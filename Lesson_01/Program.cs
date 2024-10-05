using Lesson_01.Models;

Console.WriteLine("Bank App");

List<Account> accounts = new();

Account account1 = new(300, "john@gmail.com", "123456", "John", "Doe", "123456789");
accounts.Add(account1);

Account account2 = new(1000, "jane@gmail.com", "4321", "Jane", "Doe", "987654321");
accounts.Add(account2);

string loggedInEmail = "";
bool isLoggedIn = false;

while(true)
{
    if (!isLoggedIn)
    {
        WriteLoginMenu();
        string choise = Console.ReadLine();

        if (choise == "1")
        {
            Console.WriteLine("Enter your Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your Password:");
            string password = Console.ReadLine();

            LoginAccount(email, password);
        }

        else if (choise == "2")
        {
            Console.WriteLine("Enter your Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your Password:");
            string password = Console.ReadLine();

            Console.WriteLine("Enter your First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your Phone Number:");
            string phoneNumber = Console.ReadLine();

            Account accountToAdd = new(300, email, password, firstName, lastName, phoneNumber);
            
            accounts.Add(accountToAdd);
        }
    }
    else
    {
        WriteMainMenu();
        string choise = Console.ReadLine();

    }
}




void WriteLoginMenu()
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1 - Login");
    Console.WriteLine("2 - Sign Up");
}

void WriteMainMenu()
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1 - Deposit");
    Console.WriteLine("2 - Withdraw");
    Console.WriteLine("3 - Transfer");
    Console.WriteLine("4 - Log Out");
}

void TransferMoney(Account sender, Account receiver, decimal amount)
{
    decimal sendAmount = sender.Withdraw(amount);
    receiver.Deposit(sendAmount);
}

void LoginAccount(string email, string password)
{
    bool isAccountExist = false;
    bool isPasswordCorrect = false;

    for (int i = 0; i < accounts.Count; i++)
    {
        if (accounts[i].Email == email)
        {
            isAccountExist = true;
            if (accounts[i].Password == password)
            {
                isPasswordCorrect = true;
                isLoggedIn = true;
                loggedInEmail = email;
                break;
            }
            else
            {
                isPasswordCorrect = false;
            }
            break;
        }
        else
        {
            isAccountExist = false;
        }
    }

    if (!isAccountExist)
    {
        Console.WriteLine("Account does not exist");
    }
    else if (!isPasswordCorrect)
    {
        Console.WriteLine("Password is incorrect");
    }
    else 
    {
        Console.WriteLine("Login successful");
    }
    
}