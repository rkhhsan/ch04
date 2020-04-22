// Fig. 4.16: AccountTest.cs
// Create and manipulate Account objects.
using System;

public class AccountTest
{
    // Main method begins execution of C# application
    public static void Main(string[] args)
    {
        Account account1 = new Account(50.00M); // create Account object
        Account account2 = new Account(-7.53M); // create Account object

        // display initial balance of each object using a property
        Console.WriteLine("account1 balance: {0:C}",
           account1.Balance); // display Balance property
        Console.WriteLine("account2 balance: {0:C}\n",
           account2.Balance); // display Balance property

        decimal amount; // deposit amount read from user

        // prompt and obtain user input
        Console.Write("Enter deposit amount for account1: ");
        amount = Convert.ToDecimal(Console.ReadLine());

        account1.Credit(amount); // add to account1 balance
        if (amount > 0)
            Console.WriteLine("adding {0:C} to account1 balance\n",
               amount);
        /* else
             Console.WriteLine("Valor invalido(nao positivo) para credito\n",
                amount);
        */
        // display balances
        Console.WriteLine("account1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}\n", account2.Balance);

        // prompt and obtain user input
        Console.Write("Enter deposit amount for account2: ");
        amount = Convert.ToDecimal(Console.ReadLine());

        account2.Credit(amount); // add to account2 balance
        if (amount > 0)
            Console.WriteLine("adding {0:C} to account2 balance\n",
               amount);

        // display balances
        Console.WriteLine("account1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}\n", account2.Balance);

        // prompt and obtain user input
        Console.Write("Digite o valor do saque para a conta1: ");
        amount = Convert.ToDecimal(Console.ReadLine());

        account1.Debit(amount); // subtract to account1 balance
        if ((amount > 0) && (amount < account1.Balance))
            Console.WriteLine("Subtracting {0:C} to account1 balance",
         amount);

        // prompt and obtain user input
        Console.Write("\nDigite o valor do saque para a conta2: ");
        amount = Convert.ToDecimal(Console.ReadLine());

        account2.Debit(amount); // subtract to account1 balance
        if ((amount > 0) && (amount < account2.Balance))
            Console.WriteLine("Subtracting {0:C} to account2 balance",
         amount);


        // display balances
        Console.WriteLine("\naccount1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}\n", account2.Balance);
    } // end Main
} // end class AccountTest


/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/