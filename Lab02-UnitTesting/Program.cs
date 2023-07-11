class Numbersgame
{
    public static decimal Balance;

    static void Main(string[] args)
    {
        UserInterface();
    }
    public static void UserInterface()
    {
        bool menuSelect = false;
        Console.WriteLine("Welcome to the ATM");
        Console.WriteLine("Please Select an Option to Continue...");
        while(menuSelect == false)
        {
            Console.WriteLine("1: View Balance" +
                " 2. Withdraw Money" +
                " 3. Deposit Money" +
                " 4. Exit ATM");
            string input = Console.ReadLine();
            if (input == "1")
            {
                decimal result = ViewBalance();
                Console.WriteLine("$"+ result);

            }
            if (input == "2")
            {
                Console.WriteLine("How much would you like to Withdraw?");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                decimal result = Withdraw(amount);
                Console.WriteLine("Money has been withdrawed..");
                Console.WriteLine("$" + result);
            }
            if (input == "3")
            {
                Console.WriteLine("How much would you like to Deposit?");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                decimal result = Deposit(amount);
                Console.WriteLine("Deposited");
                Console.WriteLine("$" + result);
            }
            if (input == "4")
            {
                menuSelect = true;
            }
        }
    }
    public static decimal ViewBalance()
    {
        return Balance;
    }
    public static decimal Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new Exception("Your amount is greater than the Balance");
        } else if (amount == 0)
        {
            throw new Exception("You can't subtract 0...");
        } else if(Balance == 0)
        {
            throw new Exception("Your Balance is zero, please deposit before withdrawing...");
        }else
        {
            Balance -= amount;
        }

        return Balance;
    }
    public static decimal Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new Exception("You can't deposit a negative amount of money");
        }
        else {
            Balance += amount;
        }
    
        return Balance;
    }
}