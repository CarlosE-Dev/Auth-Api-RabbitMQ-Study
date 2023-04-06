using Auth.UserActivity.Domain.Interfaces;
using Auth.UserActivity.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Auth.UserActivity.Domain.Services
{
    public class ConsumeService : IConsumeService
    {
        private string _queueName;
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private readonly IServiceProvider _serviceProvider;
        public ConsumeService(IServiceProvider serviceProvider)
        {
            var connectionFactory = new ConnectionFactory { HostName = "localhost" };
            _queueName = "UserActivityDataCommand-queue-v1";
            _connection = connectionFactory.CreateConnection();
            _channel = _connection.CreateModel();
            _serviceProvider = serviceProvider;
        }

        public void CheckQueue()
        {
            while (true)
            {
                Thread.Sleep(5000);
                Console.WriteLine("Checking queue...");
                var messageCount = _channel.MessageCount(_queueName);

                if (messageCount >= 1)
                {
                    ReceiveMessage();
                    Console.WriteLine("Queue has {0} messages", messageCount);
                }
            }
        }

        public void ReceiveMessage()
        {
            _channel.QueueDeclare(queue: _queueName,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                var userActivity = System.Text.Json.JsonSerializer.Deserialize<UserActivityModel>(message);
                using var scope = _serviceProvider.CreateScope();
                var service = scope.ServiceProvider.GetRequiredService<IUserActivityService>();
                service.HandleUserActivityData(userActivity);

                Console.WriteLine($" [x] Received User Activity for User {userActivity.UserCompleteName}");
            };

            _channel.BasicConsume(queue: _queueName,
                                 autoAck: true,
                                 consumer: consumer);
        }
    }
}
