namespace ChooseAdventure;

class MainMenu : Menu
{
    public MainMenu()
    {
        NumOptions = 3;
        options = new Option[NumOptions];
        options[0] = new Option("Create New Character");
        options[1] = new Option("Select Character");
        options[2] = new Option("Exit");
        DisplayOptions();
    }
}