using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEg
{
    class Employee
    {
        int eno;//Private member variable

        public Employee()
        {
            eno = 100;
        }
        public int Eno //property definition
        {
            get { return eno; } //accessor
            //set { eno = value; } //There is no validation
            set
            {
                if (value < 100)
                {
                    eno = 0;
                }
                else
                {
                    eno = value;
                }
            }//Mutator
        }
    }
}
