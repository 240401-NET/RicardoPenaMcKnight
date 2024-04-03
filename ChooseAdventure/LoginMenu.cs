namespace ChooseAdventure;

class LoginMenu : Menu
{
    public LoginMenu() : base()
    {
        NumOptions = 3;
        options = new Option[NumOptions];
        options[0] = new Option("Login");
        options[1] = new Option("Create New User");
        options[2] = new Option("Exit");
    }
    public LoginMenu(string preText) : base(preText)
    {
        NumOptions = 3;
        options = new Option[NumOptions];
        options[0] = new Option("Login");
        options[1] = new Option("Create New User");
        options[2] = new Option("Exit");
    }
}