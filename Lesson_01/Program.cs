Console.WriteLine("Bank App");

Account account1 = new(400);
account1.FirstName = "John";
account1.LastName = "Doe";
account1.PhoneNumber = "123456789";
account1.IBAN = "TR123456789";

account1.Withdraw(750);
account1.Withdraw(300);
// account1.Withdraw(10000);


account1.Withdraw(750);
System.Console.WriteLine();

Console.WriteLine($"Balance: {account1.GetBalance()}");

class Account
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string IBAN { get; set; }
    private decimal Balance { get; set; } //1000

    //15
    //15/1

    public Account()
    {
        Balance = 100;
    }

    public Account(decimal balance)
    {
        if (balance <= 1000)
            Balance = balance;
    }

    // public void SetBalance(decimal balance)
    // {
    //     if (balance <= 1000)
    //         Balance = balance;
    // }

    public decimal GetBalance() //Geri dönüş tipi Decimal olan bir metot ile değiştirilecek
    {
        return Balance;
    }

    public void Withdraw(decimal amount) //1500
    {
        //Balance: 1000
        //Amount: 1500
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else if (Balance != 0)
        {
            System.Console.WriteLine($"Insufficient balance but you withdraw this amount: {Balance}");
            Balance = 0;
        }
        else
        {
            System.Console.WriteLine("Insufficient balance");
        }
        //End Balance: 1000
        
    }
}
