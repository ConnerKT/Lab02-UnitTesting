class Numbersgame
{
    public static decimal Balance;
    public static string Error = "Error you enter an Invalid Amount";
    
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
                Console.WriteLine("How much would you like to Withdraw");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                decimal result = Withdraw(amount);
                if (result == Error)
                {

                }
                Console.WriteLine("$" + result);
            }
            if (input == "3")
            {
                decimal result = Deposit();
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
            return Error
        }
        Balance - amount;
        return Balance;
    }
    public static decimal Deposit()
    {
        return Balance;
    }
}