namespace ChooseAdventure;

public class Menu
{
    public int NumOptions {get; set;}
    public Option[] options;
    public string PreText {get; set;}
    public int Choice {get; set;}
    public string Input {get; set;}
    public string Type {get; set;}

    public Menu()
    {
        NumOptions = 0;
        this.PreText = " ";
        options = new Option[NumOptions];
    }
    public Menu(string preText)
    {
        NumOptions = 0;
        options = new Option[NumOptions];
        this.PreText = preText;
    }
    public Menu(string preText, int numOptions)
    {
        NumOptions = numOptions;
        options = new Option[NumOptions];
        this.PreText = preText;
    }

    public void DisplayOptions()
    {

        if (this.PreText != null)
        {
            Console.WriteLine(this.PreText);
        }
        for (int i = 0; i < NumOptions; i++)
        {
            Console.WriteLine($"\n {i + 1}. " + options[i].optionText);
        }
    }

    public void DisplayPreText()
    {
        Console.WriteLine(this.PreText);
    }

    public void SelectOption()
    {
        try{
            Choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + "\nInvalid input. Please enter a number between 1 and " + NumOptions);
            SelectOption();
        }
        if (Choice >= 1 && Choice <= NumOptions)
        {
            options[Choice - 1].Choose();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and " + NumOptions);
            SelectOption();
        }
    }
    public void SelectOption(int Choice, Menu menu)
    {
        if (Choice >= 1 && Choice <= NumOptions)
        {
            options[Choice - 1].Choose();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and " + NumOptions);
            SelectOption();
        }
    }

    public static string InputInformation()
    {
        string input = "";
        try 
        {
            input = Console.ReadLine() ?? "";
            Console.Clear();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + "\nInvalid input. Please enter a valid input.");
            InputInformation();
        }
        return input;
    }

    public virtual void RunMenuFunctions()
    {
        Console.WriteLine("This menu is not yet implemented.");
    }
}