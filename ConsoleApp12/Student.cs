using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Student : IPrint, ISred
    {
       
        int[] Mass = new int[5];
        

        public void Calculate()
        {
            int sum = 0;
            Random R = new Random();
            for (int i = 0; i < 5; i++)
            {
                Mass[i] = R.Next(2, 6);
                sum = sum += Mass[i];
            }
            Console.WriteLine("Оценки: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(Mass[i] + " ");
            }
            Console.WriteLine($"\nСреднее арифметическое: {sum / 5}");
            
        }

        public void Print()
        {
            Console.WriteLine("Student: Сейчас бы покушац");
        }
    }
}
