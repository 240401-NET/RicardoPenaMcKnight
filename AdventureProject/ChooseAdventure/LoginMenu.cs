namespace ChooseAdventure;

class LoginMenu : Menu
{
    public LoginMenu()
    {
        NumOptions = 3;
        options = new Option[NumOptions];
        options[0] = new Option("Login", new Username(true));
        options[1] = new Option("Create New User", new Username(false));
        options[2] = new Option("Exit");
    }
    public LoginMenu(string preText)
    {
        NumOptions = 3;
        options = new Option[NumOptions];
        this.PreText = preText;
        options[0] = new Option("Login", new Username(true));
        options[1] = new Option("Create New User", new Username(false));
        options[2] = new Option("Exit");
        DisplayOptions();
        SelectOption();
    }
}