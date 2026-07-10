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
        static List<string> customerEmails = new List<string>();
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
                Console.WriteLine("6. Update Customer Information");
                Console.WriteLine("7. Delete An Account");
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
                        UpdateCutomerInfo();
                        break;
                    case 7:
                        DeleteAccount();
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
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();

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
            customerEmails.Add(email);
            accountNumbers.Add(accountNum);
            balances.Add(initialDeposit);
            Console.WriteLine("Account created successfully for" + name);
            Console.WriteLine("Email: " + email);
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
            double amount;
            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount.");
                return;
            }
            if(amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }

            balances[index] += amount;
            Console.WriteLine("Deposit successful. New balance for account " + accountNum + " is: " + balances[index] + " OMR");
        }
        static void WithdrawMoney()
        {
            Console.Write("Enter account number: ");
            string accountNum = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNum);
            if (index == -1)
            {
                Console.WriteLine("Account number " + accountNum + " does not exist. Please try again.");
                return;
            }

            Console.Write("Enter withdrawal amount: ");
            double amount;
            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }
            if (amount > balances[index])
            {
                Console.WriteLine("Insufficient funds. Current balance is: " + balances[index] + " OMR");
                return;
            }

            balances[index] -= amount;
            Console.WriteLine("Withdrawal successful. New balance for account " + accountNum + " is: " + balances[index] + " OMR");

        }
        static void ShowBalance()
        {
            Console.Write("Enter account number: ");
            string accountNum = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNum);
            if(index == -1)
            {
                Console.WriteLine("Account number " + accountNum + " does not exist. Please try again.");
                return;
            }
            Console.WriteLine("===== Your Account Details =====");
            Console.WriteLine("Customer Name: " + customerNames[index]);
            Console.WriteLine("Account Number: " + accountNum);
            Console.WriteLine("Current Balance: " + balances[index] + " OMR");
        }
        static void TransferAmount()
        {
            Console.Write("Enter your account number: ");
            string fromAccountNum = Console.ReadLine();
            int fromIndex = accountNumbers.IndexOf(fromAccountNum);
            if (fromIndex == -1)
            {
                Console.WriteLine("Your account number " + fromAccountNum + " does not exist. Please try again.");
                return;
            }
            Console.Write("Enter recipient's account number: ");
            string toAccountNum = Console.ReadLine();
            int toIndex = accountNumbers.IndexOf(toAccountNum);

            if (toIndex == -1)
            {
                Console.WriteLine("Recipient's account number " + toAccountNum + " does not exist. Please try again.");
                return;
            }
            Console.Write("Enter transfer amount: ");
            double amount = double.Parse(Console.ReadLine());
            if (amount <= 0)
            {
                Console.WriteLine("Transfer amount must be greater than zero.");
                return;
            }

            if(amount <= balances[fromIndex])
            {
                balances[fromIndex] -= amount;
                balances[toIndex] += amount;
                Console.WriteLine("Transfer successful. New balance for account " + fromAccountNum + " is: " + balances[fromIndex] + " OMR");
                Console.WriteLine("New balance for account " + toAccountNum + " is: " + balances[toIndex] + " OMR");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Current balance is: " + balances[fromIndex] + " OMR");
            }
        }
        static void UpdateCutomerInfo()
        {
            Console.Write("Enter account number: ");
            string accountNum = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNum);
            if (index == -1)
            { 
                Console.WriteLine("Account number " + accountNum + " does not exist. Please try again.");
                return;
            }

            Console.WriteLine("===== Current Customer Information =====");
            Console.WriteLine("Customer Name: " + customerNames[index]);
            Console.WriteLine("Customer Email: " + customerNames[index]);

            Console.Write("===== What would you like to update? =====");
            Console.WriteLine("1. Update Customer Name");
            Console.WriteLine("2. Update Email");
            Console.Write("Choose an option: ");

            int option;
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
                return; 
            }
            switch (option)
            {
                case 1:
                    Console.Write("Enter new customer name: ");
                    string newName = Console.ReadLine();
                    customerNames[index] = newName;
                    break;
                case 2:
                    Console.Write("Enter new email: ");
                    string newEmail = Console.ReadLine();
                    customerNames[index] = newEmail;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine("===== Updated Customer Information  =====");
            Console.WriteLine("Customer Name: " + customerNames[index]);
            Console.WriteLine("Account Number: " + accountNum);
            Console.WriteLine("Customer Email: " + customerEmails[index]);
            
        }
        static void DeleteAccount()
        {
            Console.WriteLine("Enter account number you want to delete:");
            string accNum = Console.ReadLine();
            int index = accountNumbers.IndexOf(accNum);
            if(index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }
            if(balances[index] != 0)
            {
                Console.WriteLine("Please withdraw or transer the funds before deleting.");
                return;
            }
            string deleteAccount = customerNames[index];

            customerNames.RemoveAt(index);
            accountNumbers.RemoveAt(index);
            customerEmails.RemoveAt(index);
            balances.RemoveAt(index);

            Console.WriteLine("Account Deleted successfully."); 
        }
    }
}

