namespace ChooseAdventure;

class Character
{
    private string name {get; set;}
    private int maxHealth {get; set;}
    private int currentHealth {get; set;}

    public Character()
    {
        name = "Default";
        maxHealth = 100;
        currentHealth = maxHealth;
    }
    public Character(string name)
    {
        this.name = name;
        maxHealth = 100;
        currentHealth = maxHealth;
    }

}