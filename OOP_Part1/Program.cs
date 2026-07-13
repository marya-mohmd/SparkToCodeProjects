using System.Security.Cryptography.X509Certificates;

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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
