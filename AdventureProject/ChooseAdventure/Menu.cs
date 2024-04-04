namespace ChooseAdventure;

class Menu
{
    protected int NumOptions {get; set;}
    protected Option[] options;
    protected string PreText {get; set;}
    protected int Choice {get; set;}

    public Menu()
    {
        NumOptions = 0;
        this.PreText = " ";
        options = new Option[NumOptions];
        DisplayOptions();
    }
    public Menu(string preText)
    {
        NumOptions = 0;
        options = new Option[NumOptions];
        this.PreText = preText;
        DisplayOptions();
    }

    public void DisplayOptions()
    {

        if (this.PreText != null)
        {
            Console.WriteLine(PreText);
        }
        for (int i = 0; i < NumOptions; i++)
        {
            Console.WriteLine($"\n{i + 1}. {options[i].optionText}");
        }
        SelectOption();
    }

    protected void SelectOption()
    {
        try{
            Choice = Convert.ToInt32(Console.ReadLine());
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
}