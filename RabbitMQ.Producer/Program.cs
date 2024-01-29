using EasyNetQ;
using RabbitMQ.Model;

using (var bus = RabbitHutch.CreateBus("host=localhost"))
{
    var input = String.Empty;
    Console.WriteLine("Enter a message. 'Quit' to quit.");
    while ((input = Console.ReadLine()) != "Quit")
    {
        var response = bus.Rpc.Request<TesteRequest, TextResponse>(new TesteRequest { Mensagem = input });
        Console.WriteLine("Response received: {0}", response.ResponseMessage);
    }
}

