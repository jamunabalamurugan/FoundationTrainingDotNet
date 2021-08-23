using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEg
{
    interface Calc
    {
         int Eno { get; set; }
        void add(int x,int y);
        void sub(int a, int b);
        int mul(int s,int h);
        int div(int k,int l);

    }

    interface scicalc
    {
        void add(int x, int y);
        void msg(string m);
    }
}
