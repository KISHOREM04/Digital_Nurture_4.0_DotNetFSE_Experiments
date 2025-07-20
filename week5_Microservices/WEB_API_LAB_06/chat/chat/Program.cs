using System;
using Confluent.Kafka;

class Program
{
    static async Task Main()
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("=== Kafka Chat Producer ===");
        Console.WriteLine("Type your message and press Enter. Type 'exit' to quit.");

        while (true)
        {
            Console.Write("You: ");
            var input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = input });
        }
    }
}
