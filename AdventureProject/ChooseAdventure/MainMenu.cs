namespace ChooseAdventure;

class MainMenu : Menu
{
    public MainMenu()
    {
        NumOptions = 3;
        options = new Option[NumOptions];
        options[0] = new Option("Create New Character", new CharacterCreation());
        options[1] = new Option("Select Character", new CharacterSelection());
        options[2] = new Option("Exit");
        DisplayOptions();
        SelectOption();
    }
}