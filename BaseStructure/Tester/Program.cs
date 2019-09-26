using System;
using Fibroin;
namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibroin.Web web = new Web();
            web.nodes.Add(new Node());
            Console.WriteLine("Hello World!");
        }
    }
}
