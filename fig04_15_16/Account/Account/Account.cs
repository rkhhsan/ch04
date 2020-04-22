// Fig. 4.15: Account.cs
// Account class with a constructor to 
// initialize instance variable balance.
using System;

public class Account
{
    private decimal balance; // instance variable that stores the balance

    // constructor  
    public Account(decimal initialBalance)
    {
        Balance = initialBalance; // set balance using property
    } // end Account constructor

    // credit (add) an amount to the account
    public void Credit(decimal amount)
    {
        if (amount > 0)
            Balance = Balance + amount; // add amount to balance
        else
            Console.WriteLine("Valor invalido(nao positivo) para credito\n",
                amount);
    } // end method Credit

    // debit (subtract) an amount to the account
    public void Debit(decimal amount)
    {
        if (amount > 0)
        {
            if (amount <= Balance)
                Balance = Balance - amount; // add amount to balance 
            else

                Console.WriteLine("Valor do Saque maior que o Saldo(valor inválido)!");
        }
        else
            Console.WriteLine("Valor invalido(nao positivo) para debito\n",
                amount);
    } // end method Credit

    // a property to get and set the account balance
    public decimal Balance
    {
        get
        {
            return balance;
        } // end get
        set
        {
            // validate that value is greater than or equal to 0; 
            // if it is not, balance is left unchanged
            if (value >= 0)
                balance = value;
            //else
            //    Console.WriteLine("Valor do Saque maior que o Saldo(valor inválido)!");
        } // end set
    } // end property Balance
} // end class Account


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