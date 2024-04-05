namespace ChooseAdventure;

class User 
{
    public string UserName {get; set;}
    public string Password {get; set;}
    public Character[] Characters = new Character[10];

    public User()
    {
        UserName = "Default";
        Password = "password";
        Characters[0] = new Character();
    }
    public User(string userName)
    {
        this.UserName = userName;
        Password = "password";
        Characters[0] = new Character();
    }

}