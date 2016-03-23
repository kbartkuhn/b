using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class userinput
    {

        string userInput;
        List<string> enteredwords = new List<string>();



        public void getUserInput()
        {
            enteredwords.Add("   ");
            Console.WriteLine("Please enter a super special word");
            userInput = Console.ReadLine();
        }


        public void Compareittothelist()
        {


            for (int words = 0; words < enteredwords.Count; words++)
            {


                if (enteredwords.Contains(userInput))
                {
                    Console.WriteLine("Bark");
                    break;
                }
                else
                {
                    Console.WriteLine("Congradulations you created a special word");
                    break;
                }

            }

            enteredwords.Add(userInput);
            

        }

        
    }
}
