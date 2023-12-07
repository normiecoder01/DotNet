using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Inheritence
{
    internal class Program
    {
        static void Main()
        {
            Employee mgr = new Manager();
            Console.WriteLine(mgr.CalcNetSalary());
            Employee genMgr = new GeneralManager();
            Console.WriteLine(genMgr.CalcNetSalary());
            Employee ceo = new CEO();
            Console.WriteLine(ceo.CalcNetSalary());

        }
        public interface IDbFunctions
        {

        }
        public abstract class Employee : IDbFunctions 
        {
            private static int empCounter = 0;
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
                    if (value == (""))
                        Console.WriteLine("Please do not leave this field blank.");
                    else
                        name = value;
                }
            }
            private int empNo;

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
            public Employee(string name = "Default name", decimal basic = 20000, short deptNo = 1)
            {
                empNo = ++empCounter;
                Name = name;
                Basic = basic;
                DeptNo = deptNo;

            }
            public abstract  decimal CalcNetSalary();
            
        }
       public  class Manager : Employee , IDbFunctions
        {
            private string designation;
            public string Designation
            {
                get
                {
                    return designation;
                }
                set
                {
                    if (value == (""))
                        Console.WriteLine("Please do not leave this field blank.");
                    else
                        designation = value;
                }
            }
            public Manager(string designation = "default designation") : base()
            {

            }

            public override decimal CalcNetSalary()
            {
                Console.WriteLine("In managers salary");
                return (Basic + (Basic / 10) * 100);
            }
        }
        public class GeneralManager : Manager , IDbFunctions
        {
            private string perks;
            public string Perks
            {
                get; set;
            }
            public GeneralManager() : base()
            {

            }
            public override decimal CalcNetSalary()
            {
                Console.WriteLine("In  General managers salary");
                return (Basic + (Basic / 20) * 100);
            }

        }   
        public class CEO : Employee
        {
           public sealed override decimal CalcNetSalary()
            {
                return (Basic + (Basic * 10) + (Basic * 100));
            }
        }
    }
}