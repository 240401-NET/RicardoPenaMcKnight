namespace ChooseAdventure;

public class Tavern : Menu
{
    public Tavern()
    {
        NumOptions = 3;
        options = new Option[NumOptions];
        PreText = "You enter the tavern. You see a bartender cleaning a glass and a few patrons sitting at the bar. What do you do?";
        options[0] = new Option("Buy a Drink");
        options[1] = new Option("Talk to the Bartender");
        options[2] = new Option("Exit");
        DisplayOptions();
        Console.WriteLine("No story beyond this point. Exiting...");
        Console.ReadLine();
        Program.Exit();
    }
}