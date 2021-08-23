using System;
using System.IO;
namespace prjFilesExceptions
{
    class Program
    {

        static void Main1()
        {
            try
            {
                StreamReader s = null;
                float f = 23.56f;
                int i = Convert.ToInt32(f);
                int j = 0;
                Console.WriteLine(i / j);//This will result in runtime error

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
        static void Main(string[] args)
        {
            StreamReader s = null;
            //Exception Handling
            try
            {
                float f = 23.56f;
                int i = Convert.ToInt32(f);
                int j = 0;
                Console.WriteLine( i / j);//This will result in runtime error

                s = new StreamReader(@"e:\MyFile.txt");
                Console.WriteLine(s.ReadToEnd());

            }
            catch(DivideByZeroException d)
            {
                Console.WriteLine("Pls check if your number is zero....");
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
                Console.WriteLine("The file could not be found");
            }
            catch (DirectoryNotFoundException obj)
            {
                Console.WriteLine("Pls check if directory  exists");
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
    }
}
