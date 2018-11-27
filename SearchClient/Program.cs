using RandomNumberService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service1();

            Console.WriteLine(service.RandomGen());
        }
    }
}
