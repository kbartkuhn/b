using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program : Construction
    {
        static void Main(string[] args)
        {

            userinput users = new userinput();
            while (true)
            {
            users.getUserInput();
            users.Compareittothelist();
            }

            shapes shape = new shapes();
            shape.normalTriangle();
            shape.printnormaltriangle();
            Console.ReadKey();

            shape.makeupsidetriangle();
            shape.printupsidetriangle();

            shape.makebackwardtriangle();
            shape.printbackwardtriangle();

            fibonaccisequence fib = new fibonaccisequence();
            fib.fibonaccifinderdisplayer();

            Construction hello = new Construction()


            



            

        }
    }
}
