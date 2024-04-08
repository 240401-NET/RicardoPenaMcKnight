namespace ChooseAdventure;

class MainMenu : Menu
{
    public MainMenu()
    {
        NumOptions = 3;
        options = new Option[NumOptions];
        this.PreText = "Main Menu";
        options[0] = new Option("Create New Character");
        options[1] = new Option("Select Character");
        options[2] = new Option("Exit");
        DisplayOptions();
        try
        {
            int Choice = Convert.ToInt32(Console.ReadLine());
            if (Choice < 1 || Choice > NumOptions)
            {
                throw new Exception();
            }
            if (Choice == 1)
            {
                SelectOption(1, new CharacterCreation());
            }
            else if (Choice == 2)
            {
                SelectOption(2, new CharacterSelection());
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
        catch (Exception e)
        {
            Console.WriteLine(e.Message + "\nInvalid input. Please enter a number between 1 and " + NumOptions);
        }
        
    }
}