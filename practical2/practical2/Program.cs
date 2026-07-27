using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Employee_Payroll_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Employee Type");
            Console.WriteLine("1. FULL - TIME");
            Console.WriteLine("2. PART - TIME");
            Console.WriteLine("Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());

            employee e = null;
            Ipayrol p = null;

            if (ch == 1)
            {
                e = new FullTimeemp();
                p = (Ipayrol)e;
            }
            else if (ch == 2)
            {
                e = new PartTimeemp();
                p = (Ipayrol)e;
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
                return;
            }
            e.accdet();
            e.disdet();
            p.calSal();

        }
        interface Ipayrol
        {
            void calSal();
        }
        class employee // parent class
        {
            public int empid;
            public string ename;
            public double bsal;
            public employee() // constructor
            {
                Console.WriteLine("************************");
                Console.WriteLine("EMPLOYEE PAYROLL SYSTEM");
                Console.WriteLine("************************");

            }
            // METHOD 1 - TO Accept details

            public void accdet()
            {
                Console.WriteLine("Enter Emp Id =");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Emp Name =");
                ename = Console.ReadLine();
                Console.WriteLine("Enter Emp Basic Salary =");
                bsal = Convert.ToInt32(Console.ReadLine());
            }
            // method 2 - to display emp details

            public void disdet()
            {
                Console.WriteLine("Emp Id =" + empid);
                Console.WriteLine("Emp Name =" + ename);
                Console.WriteLine("Emp Basic Salary =" + bsal);

            }
        }
        class FullTimeemp : employee, Ipayrol // derived class 1
        {
            public void calSal()
            {
                double da = bsal * 0.20;
                double hra = bsal * 0.65;
                double ma = bsal * 0.10;
                double pf = bsal * 0.70;

                double netSal = (bsal + ma + da + hra) - pf;

                Console.WriteLine("Emp Type = FULL - TIME");
                Console.WriteLine("Net Salary =" + netSal);
            }
        }
        class PartTimeemp : employee, Ipayrol // derived class 2
        {
            public void calSal()
            {
                double netSal = bsal;
                Console.WriteLine("Emp Type = PART - TIME");
                Console.WriteLine("Net Salary =" + netSal);
            }
        }
        interface Ipayroll
        {
            void calSal();
        }
    }
}