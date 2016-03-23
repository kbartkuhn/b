using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class fibonaccisequence
    {


        public void fibonaccifinderdisplayer()
        {
            int previous = 0;
            int number;

            Console.WriteLine("How many numbers of the sequence would you like to display?");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("What number would you like to start the sequence off with?");
            int next = int.Parse(Console.ReadLine());
            for (int ididarod = 0; ididarod < number; ididarod++)
            {
                int sum = next + previous;
                previous = next;
                next = sum;
                Console.WriteLine(next);
            }
            Console.ReadLine();
        }
    }
}
