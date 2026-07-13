using static OOP_Part1.Student;

namespace OOP_Part1
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public BankAccount() { }

        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }
        public void withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            SendEmail();
        }
        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }
        private void PrintInformation()
        {
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }
        private void SendEmail()
        {
            Console.WriteLine("Email notification sent to account holder.");
        }
    }
    public class Student
    {
        public int Grade;
        public string Name;
        public string Address;
        private string email;

        int age;
        public void Reister(string Email)
        {
            email = Email;
            SendEmail();
        }
        private void SendEmail()
        {
            Console.WriteLine("Registation email sent to student");
        }
        public class Product
        {
            public string ProductName;
            public double Price;
            public int StockQuantity;

            public void Sell(int quantity)
            {
                if (StockQuantity >= quantity)
                {
                    StockQuantity -= quantity;
                }
                else
                {
                    Console.WriteLine("Not enough stock available to complete this sale");
                }
                LogTransaction();
            }

            public void Restock(int quantity)
            {
                StockQuantity += quantity;
                LogTransaction();
            }

            public double GetInventoryValue()
            {
                PrintDetails();
                return Price * StockQuantity;
            }
            private void PrintDetails()
            {
                Console.WriteLine("Product Name:" + ProductName);
                Console.WriteLine("Price:" + Price);
                Console.WriteLine("Stock Quantity:" + StockQuantity);
            }

            private void LogTransaction()
            {
                Console.WriteLine("Transaction logged successfully");
            }

        }
    }
    public class Program
    {
        static BankAccount account1 = new BankAccount() { AccountNumber = 1163, HolderName = "karim", Balance = 120 };
        static BankAccount account2= new BankAccount() { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };

        static Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
        static Student student2 = new Student { Name = "Ahmed", Address = "Muscat", Grade = 70 };

        static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (exitApp)
            {
                Console.WriteLine(" 1.  View Account Details");
                Console.WriteLine(" 2.  Update Student Address");
                Console.WriteLine(" 3.  Make a Deposit");
                Console.WriteLine(" 4.  Make a Withdrawal");
                Console.WriteLine(" 5.  View Product Details");
                Console.WriteLine(" 6.  Register a Student");
                Console.WriteLine(" 7.  Compare Two Account Balances");
                Console.WriteLine(" 8.  Restock Product & Stock Level Check");
                Console.WriteLine(" 9.  Transfer Between Accounts");
                Console.WriteLine(" 10. Update Student Grade (Validated)");
                Console.WriteLine(" 11. Student Report Card");
                Console.WriteLine(" 12. Account Health Status");
                Console.WriteLine(" 13. Bulk Sale With Revenue Calculation");
                Console.WriteLine(" 14. Scholarship Eligibility Check");
                Console.WriteLine(" 15. Full Balance Top-Up Flow");
                Console.WriteLine(" 16. Quick Account Opening [Parameterized Constructor]");
                Console.WriteLine(" 17. Total Students Counter [Static Field/Method]");
                Console.WriteLine(" 18. Overdrawn Account Check [Read-Only Property]");
                Console.WriteLine(" 19. Set Student Security PIN [Write-Only Property]");
                Console.WriteLine(" 20. Exit");
                Console.WriteLine("Choose an option");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Enter Number between 1 to 20.");
                    continue;
                }
                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposit(); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetail(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareBalances(); break;
                    case 8: RestockAndCheckLevel(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateGradeValidated(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibility(); break;
                    case 15: FullBalanceTopUp(); break;
                    case 16: QuickAccountOpening(); break;
                    case 17: TotalStudentsCounter(); break;
                    case 18: OverdrawnCheck(); break;
                    case 19: SetStudentPin(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Choose between 1 and 20.");
                        break;
                }

                Console.WriteLine("Press any key");
                Console.ReadKey();
                Console.Clear();
            }

        }
        static  BankAccount ChooseAccount()
        {
            Console.WriteLine("Choose account (1 or 2):");
            string input = Console.ReadLine();
            if(input == "2")
            {
                return account2;
            }
            return account1;
        }
        static Student ChooseStudent()
        {
            Console.WriteLine("Choose student (1 or 2)");
            string input = Console.ReadLine();
            if (input == "2")
            {
                return student2;
            }
            return student1;
        }
        static Product ChooseProduct()
        {
            Console.WriteLine("Choose Product (1 or 2)");
            string input = Console.ReadLine();
            if (input == "2")
            {
                return product2;
            }
            return product1;
        }

        //Case 1 - View Account Details
        static void ViewAccountDetails()
        {
            BankAccount choosen = ChooseAccount();
            choosen.CheckBalance();
        }

        //Case 2 - Update Student Address
        static void UpdateStudentAddress()
        {
            Student student = ChooseStudent();

            Console.WriteLine("Enter your new address");
            string newAddress = Console.ReadLine();
            student.Address = newAddress;
            Console.WriteLine("Address updated to: " + newAddress); 
        }

        //Case 3 - Make a Deposit
        static void MakeDeposit()
        {
            BankAccount account = ChooseAccount();
            Console.WriteLine("Enter deposite amount:");
            try
            {
                double amount = double.Parse(Console.ReadLine());
                account.Deposit(amount);
                Console.WriteLine(account.HolderName + "'s current balance: " + account.Balance);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalied amount entered.");
            }
        }

        //Case 4 - Make a Withdrawal
        static void MakeWithdrawal()
        {
            BankAccount account = ChooseAccount();
            Console.WriteLine("Enter withdrawal amount:");
            try
            {
                double amount = double.Parse(Console.ReadLine());
                account.withdraw(amount);
                Console.WriteLine(account.HolderName + "'s current balance: " + account.Balance);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalied amount entered.");
            }
        }

        //Case 5 - View Product Details
        static void ViewProductDetail()
        {
            Product product = ChooseProduct();
            double value = product.GetInventoryValue();
            Console.WriteLine("Total inventory value: " + value);
        }

        //Case 6 - Register a Student
        static void RegisterStudent()
        {
            Student student = ChooseStudent();
            Console.WriteLine("Enter email:");
            string emailInput = Console.ReadLine();
            student.Reister(emailInput);
            Console.WriteLine(student.Name + " has been registered successfully.");
        }

        //Case 7 - Compare Two Account Balances
        static void CompareBalances()
        {
            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine(account1.HolderName + "'s account has more money.");
            }
            else if (account2.Balance > account1.Balance)
            {
                Console.WriteLine(account2.HolderName + "'s account has more money.");
            }
            else
            {
                Console.WriteLine("Both accounts have equal balances.");
            }
        }

        //Case 8 - Restock Product & Stock Level Check
        static void RestockAndCheckLevel()
        {

        }

        //Case 9 - Transfer Between Accounts
        static void TransferBetweenAccounts()
        {

        }

        //Case 10 - Update Student Grade (Validated)
        static void UpdateGradeValidated()
        {

        }

        //Case 11 - Student Report Card
        static void StudentReportCard()
        {

        }

        //Case 12 - Account Health Status
        static void AccountHealthStatus()
        {

        }

        //Case 13 - Bulk Sale With Revenue Calculation
        static void BulkSaleWithRevenue()
        {

        }

        //Case 14 - Scholarship Eligibility Check
        static void ScholarshipEligibility()
        {

        }

        //Case 15 - Full Balance Top-Up Flow
        static void FullBalanceTopUp()
        {

        }

        //Case 16 - Quick Account Opening [Parameterized Constructor]
        static void QuickAccountOpening()
        {

        }

        //Case 17 - Total Students Counter [Static Fields & Methods]
        static void TotalStudentsCounter()
        {

        }

        //Case 18 - Overdrawn Account Check [Read-Only Property]
        static void OverdrawnCheck()
        {

        }

        //Case 19 - Set Student Security PIN [Write-Only Property]
        static void SetStudentPin()
        {

        }
    }
}




