using System;

namespace MediatorExample.Structure
{
    public class Service2 : Service
    {
        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"Service2 received message {message}");
        }
    }
}
