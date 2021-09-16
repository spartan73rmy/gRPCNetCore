using Existence.grpc.Protos;
using Grpc.Net.Client;
using System;

namespace grpcConsumer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnecriptedSupport", true);
            var client = new HelloWorld.HelloWorldClient(GrpcChannel.ForAddress("http://localhost:5000"));

            var response = client.SayHello(new HelloRequest { Name = "Alberto ", Year = 2000 }).Message;

            Console.WriteLine(response);
        }
    }
}
