using System;

namespace MediatorExample.Structure
{
    public class Service1 : Service
    {
        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"Service1 received message {message}");
        }
    }
}
