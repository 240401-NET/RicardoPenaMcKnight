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
    public Option(string text, Func<Menu> menu)
    {
        optionText = text;
        this.menu = menu();
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
            else if(menu.Type == "Input")
            {
                menu.DisplayPreText();
                menu.Input = Menu.InputInformation();
                menu.RunMenuFunctions();
            }
            else if (menu.Type == "Not Implemented")
            {
                Console.WriteLine("This option is not yet implemented.");
                Console.ReadLine();
                Program.Exit();
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
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
                Program.Exit();
            }
            else
            {
                Console.WriteLine("This option is not yet implemented.");
            }
        }
    }
}