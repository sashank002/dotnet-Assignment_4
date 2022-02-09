using System;
using EmployeeDetails;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EmployeeDetails.Employee obj1 = new EmployeeDetails.Employee("satvan" , "parmar" , 1000.00);

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
