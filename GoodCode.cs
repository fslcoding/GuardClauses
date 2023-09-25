class GuardClauses
{

    public static void Main(string[] args)
    {

        // This is 'good' code

        string EnteredUsername, EnteredPassword;

        while (true)
        {

            Console.WriteLine("Username: ");
            EnteredUsername = Console.ReadLine();
            Console.WriteLine("Password: ");
            EnteredPassword = Console.ReadLine();

            if (EnteredUsername != "JCoulter123")
            {
                Console.WriteLine("Incorrect Username or password");
                continue;
            }

            if (EnteredPassword != "Password10")
            {
                Console.WriteLine("Incorrect Username or password");
                continue;
            }

            break;
        }

        Console.WriteLine("You have logged in!");

    }
}