using System;


namespace EmployeeDetails
{
    class Employee{

        public string firstName;
        public string lastName;
        public double monthlySalary;

        public string FirstName{
            get => firstName;
            set => firstName = value;
        }

        public string LastName{
            get => lastName;
            set => lastName = value;
        }

        public double MonthlySalary
        {
            get => monthlySalary;
            set{
                if((int)value < 0)
                value = 0.0;

                monthlySalary = value;
            }
        }

        public Employee(string firstName , string lastName , double monthlySalary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.monthlySalary = monthlySalary;
        }

        public override string ToString()
        {
        return "NAME: " + firstName + " " + lastName + " , SALARY: " + monthlySalary;
        }

        public void getRaise(double raise)
        {
           monthlySalary +=  monthlySalary*(raise/100);
        }

    


    }
}