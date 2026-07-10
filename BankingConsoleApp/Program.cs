namespace BankingConsoleApp
{
    internal class Program
    {
        /* Shared data storage - declared at class level (static) so that
        EVERY function below can read and modify the same three lists
        without needing them passed in as parameters.*/
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Close An Account");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        ListAllAccounts();
                        break;
                    case 7:
                        CloseAccount();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter account number: ");
            string accountNum = Console.ReadLine();

            if (accountNumbers.Contains(accountNum))
            {
                Console.WriteLine("Account number " + accountNum + "already exists. Please try again.");
                return;
            }

            Console.Write("Enter initial deposit amount:");
            double initialDeposit;
            try
            {
                initialDeposit = double.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount. Please enter a valid number for the initial deposit.");
                return;
            }

            if (initialDeposit < 0)
            {
                Console.WriteLine("Initial deposit cannot be negative. Please try again.");
                return;
            }

            customerNames.Add(name);
            accountNumbers.Add(accountNum);
            balances.Add(initialDeposit);
            Console.WriteLine("Account created successfully for" + name);
            Console.WriteLine("Account Number: " + accountNum);
            Console.WriteLine("Initial Balance: " + initialDeposit + "OMR");
        }
        static void DepositMoney()
        {
            Console.Write("Enter account number: ");
            string accountNum = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNum);
            if (index == -1)
            {
                Console.WriteLine("Account number " + accountNum + " does not exist. Please try again.");
                return;
            }

            Console.Write("Enter deposit amount: ");
            double depositAmount;
            try
            {
                depositAmount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount.");
                return;
            }
            if(depositAmount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }

            balances[index] += depositAmount;
            Console.WriteLine("Deposit successful. New balance for account " + accountNum + " is: " + balances[index] + " OMR");
        }
        static void WithdrawMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
        }
        static void ShowBalance()
        {
            // TODO: implement this service (see Section 3 requirements)
        }
        static void TransferAmount()
        {
            // TODO: implement this service (see Section 3 requirements)
        }
        static void ListAllAccounts()
        {

        }
        static void CloseAccount()
        {
        }
    }
}

