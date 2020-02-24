using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Teacher : IPrint
    {
        
        public void Print()
        {
            Console.WriteLine("Teacher: Поставлю всем сегодня плохие оценки");
        }
    }
}
