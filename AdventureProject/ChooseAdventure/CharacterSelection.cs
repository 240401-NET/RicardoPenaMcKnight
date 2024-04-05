namespace ChooseAdventure
{
    class CharacterSelection : Menu
    {
        Character[] characters;
        public CharacterSelection()
        {
            if(Program.currentUser != null)
            {
                characters = Program.currentUser.Characters;
            }
            else
            {
                characters = new Character[10];
            }
            PreText = "Select a character:";
            foreach (Character? character in characters)
            {
                if (character != null)
                {
                    NumOptions++;
                }
            }
            options = new Option[NumOptions];
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] != null)
                {
                    options[i] = new Option(characters[i].Name);
                }
            }
            DisplayOptions();
            SelectOption();
        }
    }
}