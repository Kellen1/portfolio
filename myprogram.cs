using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empayment
{
    class Program
    {
        class employee                               // class employee is created
        {
            private string empname;
            public int empid;
            public employee(string name, int id)    // two parameter constructor is created
            {
                name = empname;
                id = empid;
            }
            public employee()                       // default constructor
            {

                Console.WriteLine("1.monthly ");
                Console.WriteLine("2.temporary ");
                Console.WriteLine("3.evening");

            }
            public employee(int choose)             // overloading constructor
            {
                Console.WriteLine("please choose emp type ");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        double salary;
                        Console.WriteLine("enter your salary");
                        salary = Convert.ToInt32(Console.ReadLine());
                        double netsalary;
                        netsalary = salary - 0.18 * salary - 0.03 * salary;
                        Console.WriteLine("netsalary: {0}", netsalary);
                        break;

                    case 2:
                         double balance;
                        Console.WriteLine("enter your balance");
                        balance = Convert.ToInt32(Console.ReadLine());
                        double netbalance;
                        netbalance = balance - 0.18 * balance;
                        Console.WriteLine("netbalance: {0}", netbalance);
                        break;

                    case 3:
                         double ebalance;
                        Console.WriteLine("enter your balance");
                        ebalance = Convert.ToInt32(Console.ReadLine());
                        double netebalance;
                        netebalance = ebalance - 0.18 * ebalance + 0.0015 * ebalance;
                        Console.WriteLine("netebalance: {0}", netebalance);
                        break;

                    default:
                        Console.WriteLine("invalid choice");
                        break;


                }

            }

         
        }
        static void Main(string[] args)
        {
            string employeename;
            int employeeid;
            Console.WriteLine("enter employee nane");
            employeename = Console.ReadLine();
            Console.WriteLine("enter employee id");
            employeeid = Convert.ToInt32(Console.ReadLine());
            employee employee1 = new employee(employeename, employeeid);        //calling a two parameter constructor
           
            employee employee2= new employee();                              //calling a default constructor

            employee employee3 = new employee(1);                            // calling a one parameter constractor

            
            Console.ReadLine();
        }
    }
}
