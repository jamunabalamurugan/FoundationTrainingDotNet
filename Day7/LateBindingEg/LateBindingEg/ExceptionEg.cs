using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateBindingEg
{
    class ExceptionEg
    {
        public static void Main()
        {
            int age;
            //1.try block must be followed by a set of  catch statement or finally
            try
            {
           
                Console.WriteLine("Enter the age");
                age = int.Parse(Console.ReadLine());
                if(age>100 || age<1)
                {
                    throw new ArgumentOutOfRangeException();
                   
                }
                Console.WriteLine("Enter the dob");
                string dob = Console.ReadLine();
                Console.WriteLine("Enter City");
                string city = Console.ReadLine();
            }
            catch (OverflowException o)
            {
                Console.WriteLine("Overflow Exception...." + o.Message);
            }
            catch (ArgumentOutOfRangeException a)
            {
                Console.WriteLine("Age shsould be 1-100 only...." + a.Message);
            }
            catch (FormatException f)
            {
                Console.WriteLine("Format Exception...." + f.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine("Error in Age....." + e.Message);
            }
            finally
            {
                age = 0;
                Console.WriteLine("The finally block is called");
            }
            Console.WriteLine("Enter you Name");
            string name = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
