namespace ChooseAdventure;

public class Tavern : Menu
{
    public Tavern()
    {
        NumOptions = 3;
        options = new Option[NumOptions];
        options[0] = new Option("Buy a Drink");
        options[1] = new Option("Talk to the Bartender");
        options[2] = new Option("Exit");
        DisplayOptions();
        SelectOption();
    }
}