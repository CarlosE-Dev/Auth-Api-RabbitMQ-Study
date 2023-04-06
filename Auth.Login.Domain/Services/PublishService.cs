using Auth.Login.Domain.Interfaces;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace Auth.Login.Domain.Services
{
    public class PublishService : IPublishService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        public PublishService()
        {
            var connectionFactory = new ConnectionFactory { HostName = "localhost" };
            _connection = connectionFactory.CreateConnection();
            _channel = _connection.CreateModel();
        }

        public void Publish(object data)
        {
            var queueName = $"{data.GetType().Name}-queue-v1";

            _channel.QueueDeclare(queue: queueName,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(data));

            _channel.BasicPublish(exchange: "",
                                 routingKey: queueName,
                                 basicProperties: null,
                                 body: body);

            Console.Write($"{data.GetType().Name} Published");
        }
    }
}

