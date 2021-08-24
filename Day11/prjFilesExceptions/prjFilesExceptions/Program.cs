using System;
using System.IO;

namespace prjFilesExceptions
{
    partial class Program
    {

    }
    partial class Program
    {
        #region OldMain
        static void Main1()
        {
            try
            {
                StreamReader s = null;
                float f = 23.56f;
                int i = Convert.ToInt32(f);
                int j = 0;
                //Console.WriteLine(i / j);//This will result in runtime error

                s = new StreamReader(@"e:\MyFile.txt");
                Console.WriteLine(s.ReadToEnd());
                s.Close();
            }

            finally
            {
                Console.WriteLine("Pls close your files"); //Gets executed whether there is an exception or not
            }
            Console.WriteLine("End of Program");//This line is called after try block whether an exception occured or not
            Console.ReadKey();
        }
        #endregion
        #region WriteFile
        /// <summary>
        /// You can use this method to create a file
        /// </summary>
        /// <returns> This will return a string datatype </returns>
        /// 

        public string WriteContent()
        {
            Console.WriteLine("Pls enter the contents");
            string str = Console.ReadLine();
            foreach (var item in str)
            {
                if(item=='A')
                Console.WriteLine(item);
            }
            return str;
        }
        public void WriteChar()
        {
            Console.WriteLine('A');
        }
        public void WriteAllChar()
        {
            Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        }
        #endregion

        #region Main
        static void Main(string[] args)
        {
            StreamReader s = null;
            //Exception Handling
            string name = "Jamuna";
            Console.WriteLine(@"Hello!!! {0} \t Welcome to Files",name);//To supress the special  meaning and return the absolute value typed within double quotes
            Console.ReadKey();
            
            Program p = new Program();
            p.WriteContent();
            
            try
            {
                s = new StreamReader(@"E:\AT\Day11\Bookstore.xml");
             
                Console.WriteLine("Reading and Displaying the contents of OtherOddThings in  CSharp ");

                Console.WriteLine(s.ReadToEnd());
                s.Close();
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("Pls check if your \t number is zero....\n");
            }

            catch (OverflowException obj)
            {
                Console.WriteLine("Please enter a smaller no");
            }
            catch (FormatException obj)
            {
                Console.WriteLine("The entered No {0} is incorrect", obj.HResult);
            }
            catch (FileNotFoundException obj)
            {
                Console.WriteLine("The file could not be found "+obj.Message);
            }
            catch (DirectoryNotFoundException obj)
            {
                Console.WriteLine("Pls check if directory  exists "+obj.Message);
            }
            catch (Exception obj)
            {
                Console.WriteLine(obj.Message);
                // Console.WriteLine(e.StackTrace);

            }

            finally
            {
                if (s != null)
                    s.Close();
                Console.WriteLine("Inside Finally Block");
            }
            Console.WriteLine("After the Try Catch Finally");
            Console.ReadKey();
        }
        #endregion
    }
}
