using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class shapes
    {
        List<List<string>> triangleList = new List<List<string>>();
        List<List<string>> backwardtriangle = new List<List<string>>();
        List<List<string>> upsidetriangle = new List<List<string>>();
        public string innercontent = "*";
        public int rotation = 5;

        public int normalTriangle(int rotation = 5)
        {
            for (int outerindex = 0; outerindex < rotation; outerindex++)
            {
                triangleList.Add(new List<string>());

                for (int innerindex = 0; innerindex < outerindex + 1; innerindex++)
                {
                    triangleList[outerindex].Add(innercontent);
                }
            }
            return rotation;
        }

        public int makebackwardtriangle(int rotation = 5)
        {
            for (int outerindex = 0; outerindex < rotation; outerindex++)
            {
                backwardtriangle.Add(new List<string>());
                for (int innerindex = rotation - 1; innerindex > outerindex - 1; innerindex--)
                {
                    backwardtriangle[outerindex].Add(" ");
                }

                for (int innerindex = 0; innerindex < outerindex + 1; innerindex++)
                {
                    backwardtriangle[outerindex].Add(innercontent);
                }
            }
            return rotation;
        }


        public int makeupsidetriangle(int rotation = 5)
        {
            for (int outerindex = 0; outerindex < rotation; outerindex++)
            {
                upsidetriangle.Add(new List<string>());
                for (int innerindex = rotation - 1; innerindex > outerindex - 1; innerindex--)
                {
                    upsidetriangle[outerindex].Add(innercontent);
                }
            }
            return rotation;
        }



        public bool printnormaltriangle()
        {
            foreach (List<string> rotation in triangleList)
            {
                foreach (string innercontent in rotation)
                {
                    Console.Write(innercontent);
                }
                Console.WriteLine();
            }
            return true;
        }

        public bool printupsidetriangle()
        {
            foreach (List<string> rotation in upsidetriangle)
            {
                foreach (string innercontent in rotation)
                {
                    Console.Write(innercontent);
                }
                Console.WriteLine();
            }
            return true;
        }

        public bool printbackwardtriangle()
        {
            foreach (List<string> rotation in backwardtriangle)
            {
                foreach (string innercontent in rotation)
                {
                    Console.Write(innercontent);
                }
                Console.WriteLine();
            }
            return true;
        }




    }
}
