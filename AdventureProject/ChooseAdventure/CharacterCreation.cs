namespace ChooseAdventure;

class CharacterCreation : Menu
{
    string characterName;
    public CharacterCreation()
    {
        Type = "Input";
        PreText = "Enter a name for your character:";
        DisplayPreText();
        Input = Menu.InputInformation();
        characterName = Input;
        RunMenuFunctions();
    }

    public override void RunMenuFunctions()
    {
        if (Program.currentUser != null)
        {
            Program.currentUser.Characters.Add(new Character(characterName));
            Program.UpdateUsers();
            Console.WriteLine("Character created: " + characterName);
            Chapter1 chapter1 = new Chapter1();
        }
        else
        {
            Program.currentUser = new User();
            Program.currentUser.Characters[0] = new Character(characterName);
        }
    }

}