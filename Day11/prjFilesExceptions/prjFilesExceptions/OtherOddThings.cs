using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFilesExceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class OtherTopics
    {
        public enum Priority
        {
            VeryHigh,
            High,
            Medium,
            Low,
            VeryLow
        }

        public void UnderstandingEnum()
        {
            Priority priority = Priority.VeryHigh;
            Console.WriteLine(priority);
            int val = (int)priority;
            Console.WriteLine(val);
            if (priority == Priority.VeryHigh)
                Console.WriteLine("Start now");
            else
                Console.WriteLine("Start");
        }

        public void UnderstandingNulls()
        {
            int? num = 10;
            int? num2 = (num ?? 0) * 10;
            Console.WriteLine(num2);
        }
    }
        class OtherOddThings
    {
        static int iNum2 = 5;
        int iNum3 = 5;
        void CSharpSurprise()
        {
            string strNum = null;
            strNum = "10";
            Console.WriteLine("String Num : " + strNum);
            int? iNum = null;//Nullable Data type

            if (iNum == null)
            {
                iNum = 10;
            }
            Console.WriteLine("Int Num : " + iNum);
            //(or)
            iNum = (iNum == null) ? 20 : iNum;//Ternary Operator


            Console.WriteLine("Int Num : " + iNum);
            iNum = null;
            //(or)
            iNum = iNum ?? 30;
            Console.WriteLine("iNum is Num : " + iNum);

            iNum =iNum2++;//Post increment...first assign the value of iNum2 and then increment
            iNum2++; //iNum2=iNum2+1;
            ++iNum2;
            Console.WriteLine("iNum after incrementis {0} and value of iNum2++ is {1}",iNum,iNum2);
            //iNum3++;
            iNum = ++iNum3;//Pre increment...first increment and then assign it to iNum
            Console.WriteLine("Int Num : " + iNum);

            string str1 = "Hello";

            string str2 = str1 ?? "Invalid";//Null Collease Operator
            Console.WriteLine("iNum2++ is :" + iNum2);
            Console.WriteLine("iNum3++ is :" + iNum3);

            Console.WriteLine("The string is " + str2);

            //Console.WriteLine("The min value for int is :" + int.MinValue);
            //int iVal = int.MaxValue;
            // iVal++;//This will assign the Minimum value which is a blunder when we are dealing with Banks
            // Console.WriteLine("The incremented iVal is"+iVal);
            try
            {
                int x = int.MaxValue;
                x++;
                Console.WriteLine("The value of x is :{0}",x);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            int iVal = int.MaxValue;


            try
            {
                checked
                {
                    iVal++;
                    Console.WriteLine("the value of Num " + iVal);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("The number has reached its maximum value");

            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error");
            }

        }
        static void Main(string[] s)
        {

            new OtherOddThings().CSharpSurprise();
            new OtherTopics().UnderstandingEnum();
            Console.ReadKey();
        }
    }
}
