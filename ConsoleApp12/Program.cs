using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {

        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Print();
            Student student = new Student();
            student.Print();
            student.Calculate();
            Person person = new Person();
            person.Print();
            

            Console.ReadLine();
        }
    }
}
