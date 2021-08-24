using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFilesExceptions
{
    class InvalidNumberException : ApplicationException
    {
        ArrayList al;
        public virtual string myMsg { get; set; }
        public InvalidNumberException() //Constructor
        {
            myMsg = "The entered numbers must be greater than 10";
            //Message = "The entered numers is incorrect"; --Error as its a readonly property...Onlt get is allowed...set is not allowed
        }
        public InvalidNumberException(string str) : base(str) //Overloaded Constructor
        {
            myMsg = "The entered numbers must be greater than 10";
            //Message = "The entered numers is incorrect"; --Error as its a readonly property...Onlt get is allowed...set is not allowed
        }

        //public override string StackTrace => "Hey this is an user defined exception. The user is not a valid user";
        //public override string Message => myMsg;
    }
    class MarksException:InvalidNumberException
    {
        public MarksException()
        {
            myMsg = "Marks must be between 0-100 only";
        }
       // public override string myMsg => "Marks must be between 0-100";
    }
    class ExceptionExample
    {
        void Calculate()
        {
            int num1 = 0, num2 = 0, res = 0;
            try
            {
                Console.WriteLine("Please enter the first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 < 10 || num2 < 10)
                    throw new InvalidNumberException("Message is both numbers to be less than 10");
                else if (num1 > 100 || num2 > 100)
                    throw new MarksException();  //throws the derived Exception....This will search for a corresponding catch block...if it cant find then excutes the InvalidNumber Catch block
                res = num1 + num2;
                Console.WriteLine("The sum is " + res);
                res = num1 - num2;
                Console.WriteLine("num1 - num2 " + res);
                try //Nested try block example-If there is an exception here it will handle the exception and continue with outer try block statements
                {
                    if(num1<num2)
                    {
                        throw new DivideByZeroException(); //System Defined exceptions can also be thrown
                    }
                    res = num1 / num2;

                    Console.WriteLine("num1 / num2 " + res);
              

                }
                catch (DivideByZeroException divideByZero)
                {
                    Console.WriteLine(divideByZero.Message);
                    Console.WriteLine("The dinominator resulted in 0. We cannot divide by zero");
                }
                res = num1 * num2;
                Console.WriteLine("The product is " + res);
            }
            catch (MarksException e)  //Always handle the derived class Exceptions before the parent class catch block
            {
                Console.WriteLine("Your marks are outstanding!!!" + e.myMsg);
            }

            catch (InvalidNumberException ie)
            {
                Console.WriteLine(ie.myMsg);
                Console.WriteLine(ie.Message);
                Console.WriteLine(ie.StackTrace);

                Console.WriteLine("The Numbers must be greater than 10....it should greater than 10 for both numbers");
            }

            catch (FormatException formatException)
            {
                Console.WriteLine(formatException.Message);
                Console.WriteLine("The Marks entered should have been an number");
                Console.WriteLine(formatException.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("Some error "+ e.Message);
            }
            finally
            {
                Console.WriteLine("Always");
            }
           
            Console.WriteLine("After the catch block");


        }
        static void Main(string[] args)
        {
            ExceptionExample exceptionExample = new ExceptionExample();
            exceptionExample.Calculate();
            Console.ReadKey();
        }
    }
}
