using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Construction
    {
     
       public Construction()
        {
            Console.WriteLine("constructor");
             System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=hl_9_q_uLF8");
            

        }

        ~Construction()
        {

            Console.WriteLine("hit"); 
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=JwXohnAYyuc&feature=youtu.be&t=22s");   
            Console.ReadLine();
           
            
        }



     

        


    }


}
