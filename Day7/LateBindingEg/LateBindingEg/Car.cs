using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace LateBindingEg
//{
//    public abstract class car
//    {​​​
//        public car()
//        {​​​
//            Console.WriteLine("car is called");
//        }​​​

//         public virtual void gear()
//        {​​​
//            Console.WriteLine("car gear is called");
//        }​​​

//        public abstract void drive();
      

//}​​​
// public class ford : car
//    {​​​
//public ford()
//        {​​​
//Console.WriteLine("ford is called");
//        }​​​
// public override void gear()
//        {​​​
//Console.WriteLine("ford gear is called");
//        }​​​
//        public override void drive()
//        {
//            Console.WriteLine("You can drive in wide roads at the speed of 120km/hr");
//        }
//    }​​​
//public class maruti : car
//    {​​​
//public maruti()
//        {​​​
//Console.WriteLine("maruti is called");
//        }​​​
//// public override void gear()
////        {​​​
////Console.WriteLine("maruti gear is called");
////        }​​​
//         public override void drive()
//        {
//            Console.WriteLine("You can drive in wide roads at the speed of 110km/hr");
//        }
//    }

//    sealed class swift:maruti
//    {

//    }
//    class mariti800 :  maruti
//    {

//    }
// class Late_Binding
//    {​​​
//        public static void Main()
//        {​​​
////car c1 = new maruti();
////            c1.gear();
////            car c2 = new ford();
////            c2.gear();
////            maruti c3 = new maruti();
////            c3.gear();
////            ford c4 = new ford();
////            c4.gear();

//            car obj;
//            Console.WriteLine("Welcome Buyer....please choose a car of your preference");
//            Console.WriteLine("1. Basic Car \t2. Ford Car \t3. Maruthi Car\t 0.Exit");
//            int choice = int.Parse(Console.ReadLine());

//            switch (choice)
//            {
//                case 1: //obj = new car();
//                  // obj.gear();
//                    break;
//                case 2: obj = new ford();
//                    obj.gear();
//                    obj.drive();
//                    break;
//                case 3: obj = new maruti();
//                    obj.gear();//it will call the base class gear method if it is not overriden in derived class
//                    obj.drive();
//                    break;
//                case 0:
//                    break;
//                default:
//                    break;
//            }


//            Console.ReadKey();
//        }
//    }
//}



