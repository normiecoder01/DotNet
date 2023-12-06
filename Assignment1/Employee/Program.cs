using System.Runtime.CompilerServices;

namespace Employee
{
    internal class Program
    {
        class Employee
        {
            private static int empCounter=0;
            public int EmpCounter 
            { 
                get 
                { 
                    return empCounter;
                }
                private set
                { 
                    empCounter = value; 
                }
            }
            private string name;
            public string Name
            {
                get 
                { 
                    return name; 
                }
                set
                {
                    if (value==(""))
                        Console.WriteLine("Please do not leave this field blank.");
                    else
                        name = value;
                }
            }
            private  int empNo;
           
            public int EmpNo
            { 
                get 
                { 
                    return empNo; 
                }
                private set 
                { 
                    empNo = value; 
                }
            
            }
            private decimal basic;
            public decimal Basic
            {
                get 
                { 
                    return basic; 
                }
                set
                {
                    if (value < 1000 && value > 10000000000)
                        Console.WriteLine("Please enter a valid value.");
                    else
                        basic = value;
                }

            }
            private short deptNo;
            public short DeptNo
            {
                get 
                { 
                    return deptNo; 
                }

                set
                {
                    if (value <= 0)
                        Console.WriteLine("Please enter a valid department number.");
                    else
                        deptNo = value;
                }
            }
            public Employee(string name = "Default name", decimal basic = 20000,  short deptNo = 1)
            {
                empNo = ++empCounter;
                Name = name;
                Basic = basic;
                DeptNo = deptNo;
                   
            }
            public decimal GetNetSalary()
            {
                return (Basic + (Basic * 10) / 100);
            }
        }

        static void Main()
        {
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);

            Employee o4 = new Employee("Anupal", 20000, 2);
            Employee o5 = new Employee("Aman", 30000, 3);


            Console.WriteLine(o4.EmpNo);
            Console.WriteLine(o4.Name);
            Console.WriteLine(o4.Basic);

            Console.WriteLine(o5.EmpNo);
            Console.WriteLine(o5.Name);
            Console.WriteLine(o5.Basic);

        }
    }
}