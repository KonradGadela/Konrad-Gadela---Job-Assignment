using System;

namespace Konrad_Gadela___Job_Assignment
{
    public class PingCommandHandler : ICommandHandler
    {
        public string Handle(string input)
        {
            return "Pong";
        }
    }
}