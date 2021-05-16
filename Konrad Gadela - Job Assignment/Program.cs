using System;
using System.Threading.Channels;

namespace Konrad_Gadela___Job_Assignment
{
    public class Program
	{
		public static void Main()
		{
            var server1 = new Server();
            Console.WriteLine(server1.Process("ECHO Hello world!"));    // Hello world!
            Console.WriteLine(server1.Process("PING"));                 // Pong
            Console.WriteLine(server1.Process("XYZV"));                 // Bad request				


            var server2 = new Server("TOUPPER");
            Console.WriteLine(server2.Process("ECHO Hello world!"));    // HELLO WORLD!
            Console.WriteLine(server2.Process("PING"));                 // PONG


            var server3 = new Server("TIME");
            Console.WriteLine(server3.Process("ECHO Hello world!"));    // 10:20:30 Hello world!
            Console.WriteLine(server3.Process("PING"));                 // 10:20:30 Pong


            var server4 = new Server("TIME", "TOUPPER");
            Console.WriteLine(server4.Process("ECHO Hello world!"));    // 10:20:30 HELLO WORLD!
            Console.WriteLine(server4.Process("PING"));                 // 10:20:30 PONG		
		}
	}
}
