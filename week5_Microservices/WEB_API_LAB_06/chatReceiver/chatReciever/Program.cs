using System;
using Confluent.Kafka;

class Program
{
    static void Main()
    {
        var config = new ConsumerConfig
        {
            GroupId = "chat-group",
            BootstrapServers = "localhost:9092",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe("chat-topic");

        Console.WriteLine("=== Kafka Chat Consumer ===");
        Console.WriteLine("Waiting for messages...");

        while (true)
        {
            var cr = consumer.Consume();
            Console.WriteLine($"\nFriend: {cr.Message.Value}");
        }
    }
}
