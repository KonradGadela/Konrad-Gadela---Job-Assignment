using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Konrad_Gadela___Job_Assignment
{
    class Server 
    {
        private bool shouldUpperLetters;
        private bool shouldAtTimeStamp;
        
        public Server(params string[] modifiers)
        {
            if (modifiers.Contains("TIME"))
            {
                shouldAtTimeStamp = true;
            }

            if (modifiers.Contains("TOUPPER"))
            {
                shouldUpperLetters = true;
            }
        }
        
        public string Process(string request)
        {
            var prefix = new StringBuilder();
            var output = new StringBuilder();
            Dictionary<string, ICommandHandler> handlers = new Dictionary<string, ICommandHandler>();
            handlers.Add("ECHO", new EchoCommandHandler());
            handlers.Add("PING", new PingCommandHandler());
            var command = CommandSelection.SelectCommand(request);

            if (shouldAtTimeStamp)
            {
                prefix.Append(DateTime.Now.ToLongTimeString());
                prefix.Append(" ");
            }


            try
            {
                output = prefix.Append(handlers[command].Handle(request));
            }
            catch
            {
                Console.WriteLine("Bad request");
            }
            

            if (shouldUpperLetters)
            {
                Console.WriteLine(output.ToString().ToUpper());
            }
            else
            {
                Console.WriteLine(output);
            }

            return "";
        }

    }
}