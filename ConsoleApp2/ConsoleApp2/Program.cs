internal class Program
{
    private static void Main(string[] args)
    {
        CreditCard card = new CreditCard
        {
            OwnerName = "Saba Sulaberidze",
            CardValidationDate = new DateTime(2024, 11, 13),
            CreditLimit = 5000m,
            Amount = 1500m
        };

        card.ChangePin(1701);
        card.WithdrawMoney(230m);
        card.FinancialTransfer(350m);
    }
}

public class CreditCard
{
    private int cardNumber;
    private int pin;

    public string OwnerName { get; set; }
    public DateTime CardValidationDate { get; set; }
    public decimal CreditLimit { get; set; }
    public decimal Amount { get; set; }

    public void ChangePin(int newPin)
    {
        if (newPin.ToString().Length == 4)
        {
            pin = newPin;
            Console.WriteLine("PIN changed successfully.");
        }
        else
        {
            Console.WriteLine("Invalid PIN. It must be 4 digits.");
        }
    }

    public void WithdrawMoney(decimal amount)
    {
        if (amount > 0 && amount <= Amount)
        {
            Amount -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}. Remaining balance: {Amount:C}");
        }
        else
        {
            Console.WriteLine("Invalid amount or insufficient funds.");
        }
    }

    public void FinancialTransfer(decimal amount)
    {
        if (amount > 0 && amount <= Amount)
        {
            Amount -= amount;
            Console.WriteLine($"Transferred: {amount:C}. Remaining balance: {Amount:C}");
        }
        else
        {
            Console.WriteLine("Invalid amount or insufficient funds.");
        }
    }
}
