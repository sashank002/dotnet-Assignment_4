using System;
using EmployeeDetails;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EmployeeDetails.PermanentEmployee obj1 = new EmployeeDetails.PermanentEmployee("satvan" , "parmar" , 1000.00,"2015-12-31","2028-12-31");

            // Console.WriteLine($"{obj1.firstName}");
            // Console.WriteLine($"{obj1.lastName}");
            // Console.WriteLine($"{obj1.monthlySalary}");

            Console.WriteLine(obj1);

            obj1.getRaise(10);

            Console.WriteLine("After raise in sallery");
            Console.WriteLine(obj1);

            
            
        }
    }
}