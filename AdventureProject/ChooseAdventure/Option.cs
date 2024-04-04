namespace ChooseAdventure;

class Option : IChoosable
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
        // Do something
        
    }
}