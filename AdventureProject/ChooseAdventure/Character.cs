namespace ChooseAdventure;

public class Character
{
    User user;
    public string Name {get; set;}
    public int MaxHealth {get; set;}
    public int CurrentHealth {get; set;}

    public Character()
    {
        this.user = Program.currentUser;
        Name = "Default";
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
    }
    public Character(string name)
    {
        this.user = Program.currentUser;
        this.Name = name;
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
    }
    public Character(User user, string name)
    {
        this.user = user;
        this.Name = name;
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
    }

}