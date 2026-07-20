using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            int n;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------");

                Console.WriteLine("------STUDENT ADMISSION SYSTEM---------");
                Console.WriteLine("------------------------------");

                Console.WriteLine("");
                Console.WriteLine("Enter 1 for entering of the student details ");
                Console.WriteLine("Enter 2 for displaying the details of the student");
                Console.WriteLine("ENter 3 to check the eligibility for scholarship");
                Console.WriteLine("ENter 0 to Exit the program");
                Console.WriteLine("");
                n = Convert.ToInt32(Console.ReadLine());
                
                


                if (n == 0)
                {
                    Console.WriteLine("Thank you for using program");
                    break;
                }
                switch (n)
                {
                    case 0:
                        break;
                    case 1:
                        student.RegisterStudent();
                        break;
                    case 2:
                        student.displayDetails();
                        break;
                    case 3:
                        student.CheckEligibility();
                        break;
                }
            } while (n != 0);


        }
    }
    class Student
    {
        public int age, admissionNumber, fees;
        protected int percentage;
        private string sName, sNumber, address;
        public string status, course;

        public void displayDetails()
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------");

            Console.WriteLine("------STUDENT DETAILS---------");

            Console.WriteLine("------------------------------");

            Console.WriteLine("Name: " + sName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("status:" + status);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("address: " + address);
            Console.WriteLine("percentage : " + percentage);
            Console.WriteLine("Contact Number: " + sNumber);
        }

        public void RegisterStudent()
        {
            Console.WriteLine("Enter the name of the student");
            sName = Console.ReadLine();
            Console.WriteLine("Enter the age of the Student");
            age = Console.ReadLine().Length;
            Console.WriteLine("Enter the course of the student");
            course = Console.ReadLine();
            Console.WriteLine("enter the percentage of the student");
            percentage = Console.ReadLine().Length;
            Console.WriteLine("Enter the address of the student");
            address = Console.ReadLine();
            Console.WriteLine("Enter the contact number of the student");
            sNumber = Console.ReadLine();
            Console.WriteLine("Enter status of the student");
            status = Console.ReadLine();
            Console.WriteLine("Enter the fees of the student");
            fees = Console.ReadLine().Length;
        }

        public void CheckEligibility()
        {
            if (percentage >= 90)
            {
                Console.WriteLine("Your scholarship is 50000");

            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Your schalship is 25000");
            }
            else
            {
                Console.WriteLine("you are not eligible for the scholarship");
            }
        }


    }
}
