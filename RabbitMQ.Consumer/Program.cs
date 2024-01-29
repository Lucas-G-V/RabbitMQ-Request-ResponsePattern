using EasyNetQ;
using RabbitMQ.Model;


using (var bus = RabbitHutch.CreateBus("host=localhost"))
{
    bus.Rpc.Respond<TesteRequest, TextResponse>(HandleTextRequest);

    Console.WriteLine("Listening for requests. Hit <return> to quit.");
    Console.ReadLine();
}

static TextResponse HandleTextRequest(TesteRequest textMessage)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Got request: {0}", textMessage.Mensagem);
    Console.ResetColor();
    return new TextResponse { ResponseMessage = "Response to: " + textMessage.Mensagem };
}
