using System;

namespace Common
{
    // Part 1: Employee is identified by ID, Name, security level, salary, hire date, and Gender.
    public class Employee
    {
        private int _id;
        private string _name;
        private decimal _salary;


        public int Id
        {
            get { return _id; }
            set { _id = value > 0 ? value : 0; } 
        }

        public string Name
        {
            get { return _name; }
            set { _name = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; } 
        }

        public SecurityLevel SecurityLevel { get; set; } 

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value >= Constants.MinimumWage ? value : Constants.MinimumWage; } 
        }

        public HiringDate HireDate { get; set; } 

        public Gender Gender { get; set; } 

        // Constructors

        public Employee()
        {
            Name = "Unknown";
            HireDate = new HiringDate();
            SecurityLevel = SecurityLevel.Guest;
        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            HireDate = new HiringDate();
            SecurityLevel = SecurityLevel.Guest;
        }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, Gender gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate ?? new HiringDate(); // Guards against a null HiringDate being passed in
            Gender = gender;
        }

        // Part 5: represent Employee data as a string, salary formatted as currency
        public override string ToString()
        {
            return string.Format(
                "Id: {0} :: Name: {1} :: SecurityLevel: {2} :: Salary: {3:C} :: HireDate: {4} :: Gender: {5}",
                Id, Name, SecurityLevel, Salary, HireDate, Gender);
        }
    }
}
