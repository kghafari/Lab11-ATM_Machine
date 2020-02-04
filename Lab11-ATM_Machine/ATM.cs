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
        public List<Account> UserAccounts { get; set; }

        //constructors
        public ATM()
        {

        }

        public ATM(List<Account> accounts)
        {

        }

        //methods

        //#1 - Register Account. Takes a username and password and uses them to create a new account, and add to list of active accounts
        private static void RegisterAccount()
        {
            // do stuff
        }

        //#2 - Login. Takes username and password.
        // first, check if an account is logged in. If so, kick an error (Current user must log out). 
        // If not, search the account list for an Account with a matching username AND password 
        // once found, set that account to the Current Account      
        public static void UserLogin(List<Account> accountList)
        {
            string maybeUsername = GetUserInput("Enter Username: ");
            string maybePassword = GetUserInput("Enter Password: ");

            for (int i = 0; i < accountList.Count; i++)
            {
                if (maybeUsername == accountList[i].Name && maybePassword == accountList[i].Password)
                {
                    //good stuff. Go to Login page
                    //like... DisplayLoginPage()
                    DisplayLoginPage(accountList[i]);
                    
                }
            }
            
            //Bad stuff. Return to main menu
        }

        // ONLY IF THERE IS AN ACCOUNT LOGGED IN
        //#3. Logout - Set the current account to null
        public static void UserLogout(Account currentAccount)
        {
            //do stuff
            //currentAccount = null;
        }

        public static void DisplayLoginPage(Account loggedInAccount)
        {
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");          
            Console.WriteLine("3. Withdraw");
            


            bool tryAgain = true;
            while (tryAgain)
            {
                string mainMenuInput = Console.ReadLine().ToLower();
                tryAgain = false;
                switch (mainMenuInput)
                {
                    case "1":
                    case "check balance":
                        Console.WriteLine($"Current Balance: ${CheckAccountBalance(loggedInAccount)}");
                        break;

                    case "2":
                    case "deposit":
                        DepositToAccount(loggedInAccount);
                        break;

                    case "3":
                    case "withdraw":
                        WithdrawFromAccount(loggedInAccount);
                        break;

                    default:
                        tryAgain = true;
                        Console.WriteLine("Please make a valid selection");
                        break;
                }
            }
        }

        //#4. CheckBalance - Prints the current Account Balance (double)
        public static double CheckAccountBalance(Account currentAccount)
        {
            return currentAccount.Balance;
        }

        //#5. Deposit - Takes a double and adds it to the current AccountBalance
        public static double DepositToAccount(Account currentAccount)
        {
            //get input
            double newBalance = currentAccount.Balance + GetUserNumber("How much are you depositing today? ");
            Console.WriteLine($"New Balance: {newBalance}");
            return newBalance;

        }

        //#6. Withdraw - Takes a double and subtracts from AccountBalance
        // if AccountBalance < ammountToWithdraw - throw an error.

            //this is super janky
        public static double WithdrawFromAccount(Account currentAccount)
        {
            double balance = currentAccount.Balance; //redundant
            bool tryAgain = true;
            while (tryAgain)
            {
                double withdrawAmt = GetUserNumber("How much are you withdrawing today? ");
                if (balance > withdrawAmt)
                {
                    balance -= withdrawAmt;
                    Console.WriteLine($"New Balance: {balance}"); //could send to method
                    tryAgain = false;
                }
                else
                {
                    Console.WriteLine("Balance too low, or something. Try again.");
                }
            }
            return balance;
        }


        public static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static double GetUserNumber(string message)
        {
            string input = "*";
            double number;
            while (!double.TryParse(input, out number))
            {
                input = GetUserInput(message);
            }

            return number;
        }

        public static bool AskUserToContinue(string message, string yes, string no)
        {
            string input = "";
            while (input != yes && input != no)
            {
                input = GetUserInput(message).ToLower();
            }
            if (input == yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }
}
