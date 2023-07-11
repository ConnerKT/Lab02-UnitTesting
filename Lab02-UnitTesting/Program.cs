class Numbersgame
{
    public static decimal Balance()
    {

    }
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
                "2. Withdraw Money" +
                "3. Deposit Money" +
                "4. Exit ATM");
            string input = Console.ReadLine();
            if (input == "1")
            {
                ViewBalance();
            }
            if (input == "2")
            {
                Withdraw();
            }
            if (input == "3")
            {
                Deposit();
            }
            if (input == "4")
            {
                menuSelect = true;
            }
        }
    }
    public static decimal ViewBalance()
    {
        
    }
    public static decimal Withdraw()
    {

    }
    public static decimal Deposit()
    {

    }
}