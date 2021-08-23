using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug13
{
    class MainClass
    {
        public static void Main()
        {
            IUserInterface desc = new ScreenDescription();
            while (true)
            {
                desc.showFirstScreen();
                
            }
             
        }
    }
}
