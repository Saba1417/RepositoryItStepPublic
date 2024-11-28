class BankomatApp
{
    static void Main()
    {
        string accountFile = "myaccount.txt";
        CheckBalance(accountFile);
        Deposit(accountFile, 100);
        Withdraw(accountFile, 50);
    }

    static void CheckBalance(string filePath)
    {
        if (File.Exists(filePath))
        {
            string balance = File.ReadAllText(filePath);
            Console.WriteLine($"Current balance: {balance}");
        }
        else
        {
            Console.WriteLine("Account file not found.");
        }
    }

    static void Deposit(string filePath, decimal amount)
    {
        if (File.Exists(filePath))
        {
            decimal balance = decimal.Parse(File.ReadAllText(filePath));
            balance += amount;
            File.WriteAllText(filePath, balance.ToString());
            Console.WriteLine($"Deposited {amount}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Account file not found.");
        }
    }

    static void Withdraw(string filePath, decimal amount)
    {
        if (File.Exists(filePath))
        {
            decimal balance = decimal.Parse(File.ReadAllText(filePath));
            if (balance >= amount)
            {
                balance -= amount;
                File.WriteAllText(filePath, balance.ToString());
                Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        else
        {
            Console.WriteLine("Account file not found.");
        }
    }
}