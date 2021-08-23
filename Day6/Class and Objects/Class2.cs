using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Objects
{
    class Company
    {
        public int cid;
        public string cname;
        public Company(int cid, string cname)
        {
            this.cid = cid;
            this.cname = cname;
            Console.WriteLine("Base class Constructor");
        }

        public void DisplayCompanyInfo()
        {
            Console.WriteLine("CId is {0} && Cname{1}", cid, cname);
        }

    }

    class Dept : Company
    {
        int Did;
        string Dname;

        public Dept(int cid, String cname, int Did
            , string Dname) : base(cid, cname)
        {
            this.cid = cid;
            this.cname = cname;
            this.Did = Did;
            this.Dname = Dname;
            Console.WriteLine("Derived class Constructor");
        }

        public void DisplayDeptInfo()
        {
            Console.WriteLine("Cname {0},Did {1} , DName{2}", cname,
                Did, Dname);
        }
        class Room : Dept
        {
            int rid;
            public Room(int cid, string cname, int Did, string Dname,
            int rid) : base(cid, cname, Did, Dname)
            {
                this.cid = cid;
                this.cname = cname;
                this.Did = Did;
                this.Dname = Dname;
                this.rid = rid;

                Console.WriteLine("Derived class constructor!!!!!!!");

            }

            public void DisplayRoomInfo()
            {
                Console.WriteLine("Cname {0},Did {1} , DName{2}, rid{3}", cname,
                    Did, Dname, rid);
            }

        }


        class Program
        {
            static void Main(string[] args)
            {
                Dept dobj = new Dept(1, "LTI",
                    100, "Development");
                Room roomj = new Room(2, "lt", 200, "Sadlke", 45);

                dobj.DisplayCompanyInfo();
                dobj.DisplayDeptInfo();
                roomj.DisplayRoomInfo();
                Console.Read();
            }
        }
    }
}
