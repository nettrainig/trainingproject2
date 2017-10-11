using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.logic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2Context tc = new Test2Context();
            tc.Clients.ToList<Client>().ForEach(o => Console.WriteLine(o.Name));
        }
    }
}
