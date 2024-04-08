namespace ChooseAdventure;

using System.Text.RegularExpressions;

public class Password
{
    public string? UserPassword {get; set;}

    public Password(bool userExists)
    {
        EnterPassword(userExists);
    }


    public void EnterPassword(bool userExists)
    {
        Console.WriteLine("Please enter a password.");
        string input = Console.ReadLine() ?? "";
        if(userExists)
        {
            if (input == Program.currentUser.Password)
            {
                Console.WriteLine("Welcome, " + Program.currentUser.UserName);
                MainMenu mainMenu = new();
            }
            else
            {
                Console.WriteLine("Invalid password. Please enter the correct password.");
                EnterPassword(userExists);
            }
        }
        else
        {
            if (input.Length > 0)
        {
            UserPassword = input;
            if (UserPassword.Length < 8 || !Regex.IsMatch(UserPassword, @"[0-9]") || !Regex.IsMatch(UserPassword, @"[a-z]") || !Regex.IsMatch(UserPassword, @"[A-Z]"))
            {
                Console.WriteLine("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");
                EnterPassword(userExists);
            }
            else
            {
                Program.currentUser.Password = UserPassword;
                Program.users.Add(Program.currentUser);
                Data.SaveUsers(Program.users);
                Console.WriteLine("Password set.");
                MainMenu mainMenu = new();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid password.");
            EnterPassword(userExists);
        }
        }
    }

    public static bool ValidatePassword(string password)
    {
        if (password.Length < 8 || !Regex.IsMatch(password, @"[0-9]") || !Regex.IsMatch(password, @"[a-z]") || !Regex.IsMatch(password, @"[A-Z]"))
        {
            return false;
        }
        return true;
    }
}   
