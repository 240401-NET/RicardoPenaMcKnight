namespace ChooseAdventure;

public class Character
{
    public string Name {get; set;}
    public int MaxHealth {get; set;}
    public int CurrentHealth {get; set;}

    public Character()
    {
        Name = "Default";
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
    }
    public Character(string name)
    {
        this.Name = name;
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
    }

}