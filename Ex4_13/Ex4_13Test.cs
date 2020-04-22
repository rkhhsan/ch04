using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_13
{
    class Ex4_13Test
    {
        // Main method begins execution of C# application
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee("Roberto", "Hoo", 3500.00m); // create Employee object
            Employee employee2 = new Employee("Atmo","Namateet", 5000.00m); // create Employee object

            employee1.DisplayMessage();
            employee2.DisplayMessage();
            decimal salarioAnual;
            salarioAnual = 12*employee1.Monthly_salary;
            Console.WriteLine("\nO salário anual do empregado {1} é {0:C}", salarioAnual, employee1.LastName);
            salarioAnual = 12 * employee2.Monthly_salary;
            Console.WriteLine("O salário anual do empregado {1} é {0:C}", salarioAnual, employee2.LastName);
                        
            employee1.Monthly_salary = employee1.Monthly_salary * (1.1m);
            employee2.Monthly_salary = employee2.Monthly_salary * (1.1m);

            Console.WriteLine("\nO salário foi reajustado em 10%");

            salarioAnual = 12 * employee1.Monthly_salary;
            Console.WriteLine("\nO novo salário anual do empregado {1} é {0:C}", salarioAnual, employee1.LastName);
            salarioAnual = 12 * employee2.Monthly_salary;
            Console.WriteLine("O novo salário anual do empregado {1} é {0:C}", salarioAnual, employee2.LastName);
            Console.WriteLine("\nTecle Enter para finalizar...");
            Console.Read();

        }
    }
}
