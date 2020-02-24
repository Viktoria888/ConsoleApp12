using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Person : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Person: Что я тут делаю?");
        }
    }
}
