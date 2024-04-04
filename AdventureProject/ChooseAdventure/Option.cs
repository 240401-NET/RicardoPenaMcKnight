namespace ChooseAdventure;

public class Option : IChoosable
{
    public string optionText;
    public Menu menu;

    public Option()
    {
        optionText = "Default Option Text";
        menu = new Menu();
    }
    public Option(string text)
    {
        optionText = text;
        menu = new Menu();
    }
    public Option(string text, Menu menu)
    {
        optionText = text;
        this.menu = menu;
    }


    public void Choose()
    {
        // Load the next menu

        if (menu != null)
        {
            if (menu is Username)
            {
                Username usernameMenu = (Username)menu;
                usernameMenu.EnterUsername();
            }
            else if (menu.NumOptions == 0)
            {
                Console.WriteLine("This option is not yet implemented.");
            }
            else
            {
                menu.DisplayOptions();
                menu.SelectOption();
            }
        } else
        {
            if (optionText == "Exit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("This option is not yet implemented.");
            }
        }
    }
}