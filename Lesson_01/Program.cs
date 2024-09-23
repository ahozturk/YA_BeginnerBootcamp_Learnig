Console.WriteLine("Bank App");



Account account1 = new();
account1.FirstName = "John";
account1.LastName = "Doe";
account1.PhoneNumber = "123456789";
account1.IBAN = "TR123456789";
account1.Balance = 1000;

account1.Withdraw(750);
account1.Withdraw(300);
account1.Withdraw(10000);

Console.WriteLine($"Balance: {account1.Balance}");

class Account
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string IBAN { get; set; }
    public decimal Balance { get; set; } //1000

    public void Withdraw(decimal amount) //1500
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
    }
}
