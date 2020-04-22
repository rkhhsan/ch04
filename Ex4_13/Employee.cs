using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_13
{
    class Employee
    {
        // auto-implemented property FirstName implicitly creates an 
        // instance variable for this Employee
        public string FirstName { get; set; }

        // auto-implemented property LastName implicitly creates an 
        // instance variable for this Employee
        public string LastName { get; set; }

        // instance variable that stores the monthly_salary
        private decimal monthly_salary;

        // constructor initializes auto-implemented property 
        // CourseName with string supplied as argument
        public Employee(string FirstName, string LastName, decimal MonthlySalary)
        {
            this.FirstName = FirstName; // set CourseName 
            this.LastName = LastName;
            this.Monthly_salary = MonthlySalary;

        } // end constructor


        // a property to get and set the monthly_salary
        public decimal Monthly_salary
        {
            get
            {
                return monthly_salary;
            } // end get
            set
            {
                // validate that value is greater than or equal to 0; 
                // if it is not, balance is left unchanged
                if (value >= 0)
                    monthly_salary = value;
                //else
                //    Console.WriteLine("Valor do Saque maior que o Saldo(valor inválido)!");
            } // end set
        } // end property Balance

        // display a welcome message to the GradeBook user
        public void DisplayMessage()
        {
            // use auto-implemented property CourseName to get the 
            // name of the course that this GradeBook represents
            Console.WriteLine("Nome completo: {0} {1}\nSalário mensal: {2}", FirstName, LastName, Monthly_salary ); // display property CourseName
            
        } // end method DisplayMessage

    }//end class Employee
}
