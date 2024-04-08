namespace ChooseAdventure;

class Username : Menu
{
    public string? username;
    bool userExists = false;

    public Username()
    {
        NumOptions = 1;
        options = new Option[NumOptions];
        options[0] = new Option("Submit");
    }
    public Username (bool userExists)
    {
        this.userExists = userExists;
        NumOptions = 1;
        options = new Option[NumOptions];
        options[0] = new Option("Submit");
    }

    public void EnterUsername()
    {
        Console.WriteLine("Please enter a username.");
        string input = Console.ReadLine() ?? "";
        
        if(userExists)
        {
            if (Program.FindUser(input) != null)
            {
                username = input;
                Program.currentUser = Program.FindUser(username);
                Console.WriteLine("Welcome, " + username);
                Password password = new(true);
            }
        
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid username.");
                EnterUsername();
            }
        }
        else
        {
            if (input.Length > 0)
            {
                username = input;
                Console.WriteLine("Username set to: " + username);
                if (Program.currentUser != null)
                {
                    Program.currentUser.UserName = username;
                    Password password = new(false);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid username.");
                EnterUsername();
            }
        }

    }

}