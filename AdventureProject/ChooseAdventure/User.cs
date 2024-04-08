namespace ChooseAdventure;

public class User 
{
    public string UserName {get; set;}
    public string Password {get; set;}
    public List<Character> Characters = new List<Character>();

    public User()
    {
        UserName = "Default";
        Password = "password";
        Characters.Add(new Character());
    }
    public User(string userName)
    {
        this.UserName = userName;
        Password = "password";
        Characters.Add(new Character());
    }

}