using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOOPSExampleProject
{ 
    class CannotBeBaseType
    {
        public virtual void BlahMethod()
        {
            Console.WriteLine("Blah blah");
        }
    }
    class SampleOtherTopics :CannotBeBaseType
    {
        //an ooverriden method not be further overriden then use sealed
        //override keyword will also give permision for further overriding
        public override sealed void BlahMethod()
        {
            base.BlahMethod();
        }
    }
    class ChildOfChild : SampleOtherTopics
    {
        //public override void BlahMethod()
        //{
        //    base.BlahMethod();
        //}
    }
}
