namespace ChooseAdventure;

using System.Text.RegularExpressions;

class Password
{
    public string? UserPassword {get; set;}

    public Password()
    {
        EnterPassword();
    }


    public void EnterPassword()
    {
        Console.WriteLine("Please enter a password.");
        string input = Console.ReadLine() ?? "";
        if (input.Length > 0)
        {
            UserPassword = input;
            if (UserPassword.Length < 8 || !Regex.IsMatch(UserPassword, @"[0-9]") || !Regex.IsMatch(UserPassword, @"[a-z]") || !Regex.IsMatch(UserPassword, @"[A-Z]"))
            {
                Console.WriteLine("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");
                EnterPassword();
            }
            else
            {
                Console.WriteLine("Password set.");
                MainMenu mainMenu = new();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid password.");
            EnterPassword();
        }
    }

}   
