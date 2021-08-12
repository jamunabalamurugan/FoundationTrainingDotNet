using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    class ParamsEg
    {
        void GetData(string Name, int age,params int[] Mark )
        {
            foreach(int Val in Mark)
            {
                Console.WriteLine("Marks:{0}", Val);
            }
        }
        static void Main()
        {
            string MyName = "Monisha";
           // int[] SemMark = new int[] { 89, 90, 78 };
            ParamsEg pobj = new ParamsEg();
            pobj.GetData(MyName, 89,90,78);
            Console.Read();
        }
    }
}
