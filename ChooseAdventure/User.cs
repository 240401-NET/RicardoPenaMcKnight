namespace ChooseAdventure;

class User 
{
    private string userName {get; set;}
    private string password {get; set;}
    private Character[] characters = new Character[10];

    public User()
    {
        userName = "Default";
        password = "password";
        characters[0] = new Character();
    }

}