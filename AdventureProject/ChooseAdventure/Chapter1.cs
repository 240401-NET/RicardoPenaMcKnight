namespace ChooseAdventure;

class Chapter1 : Menu
{
    public Chapter1()
    {
        NumOptions = 3;
        options = new Option[NumOptions];
        PreText = $"Chapter 1: The Beginning." + "\nYou wake up in a small village. You have no memory of how you got here. You see a tavern and a blacksmith. What do you do?";
        options[0] = new Option("Go to the Tavern", new Tavern());
        options[1] = new Option("Go to the Blacksmith", new Blacksmith());
        options[2] = new Option("Exit");
        DisplayOptions();
        SelectOption();
    }
}