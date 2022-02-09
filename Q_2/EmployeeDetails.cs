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
        return "NAME: " + firstName + " " + lastName + "\n , SALARY: " + monthlySalary;
        }

        public virtual void getRaise(double raise)
        {
           monthlySalary +=  monthlySalary*(raise/100);
        }

    


    }

    class PermanentEmployee : Employee
    {
        private double _hra;
        private double _da;
        private double _pf;

        private string _joiningDate;
        private string _retirementDate;

        public PermanentEmployee(string firstName, string lastName , double monthlySalary,string _joiningDate,string _retirementDate) : base(firstName,lastName,monthlySalary)
        {
            _da = base.MonthlySalary * 0.12;
            _hra = (_da + base.MonthlySalary) * 0.5;
            _pf = base.MonthlySalary * 0.12;
            this._joiningDate = _joiningDate;
            this._retirementDate = _retirementDate;
        }

        public double HRA
        {
            get => _hra;
        }

        public double DA
        {
            get => _da;
        }

        public double PF 
        {
            get => _pf;
        }


        public string JoiningDate
        {
            get => _joiningDate;
            set
            {
                _joiningDate = value;
            }
        }

        public string RetirementDate
        {
            get => _retirementDate;

            set
            {
                _retirementDate = value;
            }
        }

        public override void getRaise(double raise)
        {
            base.getRaise(raise);

            monthlySalary = monthlySalary+HRA+DA;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + "Joining Date: " + _joiningDate + ", Retirement Date: " + _retirementDate;
        }

    }
}