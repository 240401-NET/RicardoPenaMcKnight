namespace ChooseAdventure;

class Chapter1 : Menu
{
    public Chapter1()
    {
        NumOptions = 3;
        options = new Option[NumOptions];
        PreText = $"Chapter 1: The Beginning." + "\nYou wake up in a small village. You have no memory of how you got here. You see a tavern and a blacksmith. What do you do?";
        options[0] = new Option("Go to the Tavern");
        options[1] = new Option("Go to the Blacksmith");
        options[2] = new Option("Exit");
        DisplayOptions();
        Choice = Convert.ToInt32(Console.ReadLine());
        if (Choice == 1)
        {
            SelectOption(1, new Tavern());
        }
        else if (Choice == 2)
        {
            SelectOption(2, new Blacksmith());
        }
        else if (Choice == 3)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("No valid Option selected.");
            Console.ReadLine();
            Program.Exit();
        }
    }
}