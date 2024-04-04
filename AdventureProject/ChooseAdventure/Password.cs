namespace ChooseAdventure;

using System.Text.RegularExpressions;

class Password
{
    private string? password {get; set;}

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
            password = input;
            Console.WriteLine("Password set.");
            if (password.Length < 8 || !Regex.IsMatch(password, @"[0-9]") || !Regex.IsMatch(password, @"[a-z]") || !Regex.IsMatch(password, @"[A-Z]"))
            {
                Console.WriteLine("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");
                EnterPassword();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid password.");
            EnterPassword();
        }
    }

}   
