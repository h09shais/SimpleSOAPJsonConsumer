using System;
using SimpleSOAPJsonConsumer.SimpleService;

namespace SimpleSOAPJsonConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new SimpleServiceClient();
            var response = client.Authenticate(new AuthenticationRequest
            {
                Username = "test",
                Password = "test"
            });

            Console.WriteLine(response.Valid ? response.Message : "Error!");
            Console.ReadLine();
        }
    }
}
