using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expensetracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch ;
            List<expense> expenses = new List<expense>();

            do
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("*******EXPENSE TRACKER MODULE*********");
                Console.WriteLine("**************************************");
                Console.WriteLine("1. ADD EXPENSE");
                Console.WriteLine("2. VIEW ALL EXPENSES");
                Console.WriteLine("3. VIEW TOTAL EXPENSES");
                Console.WriteLine("4. Exit\n");
                Console.Write("Enter Your Choice : ");
                ch = Convert.ToInt32(Console.ReadLine());
                try
                {
                    
                    switch (ch)
                    {
                        case 1:
                            {
                                try
                                {
                                    expense e = new expense();
                                    e.accdet();
                                    expenses.Add(e);

                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error: Please Enter a VALID Numeric Number");
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine("Error: " + ex.Message);
                                }
                                finally
                                {
                                    Console.WriteLine("Expense Processing Completed");
                                }
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("ALL EXPENSES");
                                if (expenses.Count == 0)
                                    Console.WriteLine("No EXPENSE FOUND");
                                else
                                {
                                    foreach(expense expense in expenses)
                                    {
                                        expense.dispdet();
                                    }
                                }
                                break;
                            }
                            
                        case 3:
                            {
                                double t = 0;
                                foreach (expense expense in expenses)
                                {
                                    t = t + expense.amt;
                                }
                                Console.WriteLine("Total Expense = " + t);
                                break;
                            }
                            
                        case 4:
                            {
                                Console.WriteLine("THANK YOU FOR USING THE PROGRAM");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Error: Please enter a valid choice ");
                                break;
                            }
                            
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("ENTER A VALID CHOICE ... PLEASE TRY AGAIN...");
                }
            } while (ch != 4);

        }
        class expense
        {
            public int expId;
            public string category;
            public double amt;
            public string paymentMode;
            public DateTime expdate;

            //method-1 to accept the expense details 

            public void accdet()
            {
                Console.Write("Enter Expense Id = ");
                expId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Expense Category = ");
                category = Console.ReadLine();
                Console.Write("Enter the Amount : ");
                amt = Convert.ToDouble(Console.ReadLine());

                if (amt <= 0)
                    throw new Exception("Expense Amount must be more than ZERO ");
                Console.Write("Enter Payment Mode(Cash/UPI/Card) : ");
                paymentMode = Console.ReadLine();
                expdate = DateTime.Now;
            }

            //method -2 to display expense details 

            public void dispdet()
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Expense ID: " + expId);
                Console.WriteLine("Expense Category : " + category);
                Console.WriteLine("Expense Amount: " + amt);
                Console.WriteLine("Enpense Mode :" + paymentMode);
                Console.WriteLine("Expense Date : " + expdate);
                Console.WriteLine("-----------------------------------------------------");

            }

        }

    }
}
