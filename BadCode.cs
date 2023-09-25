
class NoGuardClauses
{

    public static void BadCode(string[] args)
    {

        // This is bad code

        string EnteredUsername;

        string EnteredPassword;

        bool IsRightUsername = false;

        while (!IsRightUsername)
        {
            Console.WriteLine("Username: ");
            EnteredUsername = Console.ReadLine();
            Console.WriteLine("Password: ");
            EnteredPassword = Console.ReadLine();

            if (EnteredUsername == "JCoulter123")
            {
                if (EnteredPassword == "Password10")
                {
                    IsRightUsername = true;
                }
                else
                {
                    Console.WriteLine("Your username or password is incorrect");
                }
            }
            else
            {
                Console.WriteLine("Your username or password is incorrect");
            }
        }

        Console.WriteLine("You have logged in!");

    }

}