namespace ChooseAdventure;

class CharacterCreation : Menu
{
    public CharacterCreation()
    {
        string characterName;
        PreText = "Enter a name for your character:";
        DisplayPreText();
        characterName = InputInformation();
        if (Program.currentUser != null)
        {
            Program.currentUser.Characters[0] = new Character(characterName);
            Console.WriteLine("Character created: " + characterName);
        }
        else
        {
            Program.currentUser = new User();
            Program.currentUser.Characters[0] = new Character(characterName);
        }
    }
}