using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_ATM_Machine
{
    class ATM
    {
        //fields
        private List<Account> userAccounts;
        //properties

        //constructors

        //methods

        //#1 - Register Account. Takes a username and password and uses them to create a new account, and add to list of active accounts

        //#2 - Login. Takes username and password.
            // first, check if an account is logged in. If so, kick an error (Current user must log out). 
            // If not, search the account list for an Account with a matching username AND password 
            // once found, set that account to the Current Account


        // ONLY IF THERE IS AN ACCOUNT LOGGED IN
        //#3. Logout - Set the current account to null

        //#4. CheckBalance - Prints the current Account Balance (double)

        //#5. Deposit - Takes a double and adds it to the current AccountBalance

        //#6. Withdraw - Takes a double and subtracts from AccountBalance
            // if AccountBalance < ammountToWithdraw - throw an error.


    }
}
