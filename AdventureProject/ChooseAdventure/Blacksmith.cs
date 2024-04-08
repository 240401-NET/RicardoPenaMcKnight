namespace ChooseAdventure;

public class Blacksmith : Menu
{
    public Blacksmith()
    {
        NumOptions = 3;
        options = new Option[NumOptions];
        PreText = "You enter the blacksmith's shop. The blacksmith greets you and asks what you need.";
        options[0] = new Option("Buy Sword");
        options[1] = new Option("Buy Shield");
        options[2] = new Option("Exit");
        DisplayOptions();
        SelectOption();
    }
}