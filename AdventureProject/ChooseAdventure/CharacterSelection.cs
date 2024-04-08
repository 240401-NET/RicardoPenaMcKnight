namespace ChooseAdventure
{
    class CharacterSelection : Menu
    {
        List<Character> characters;
        public CharacterSelection()
        {
            if(Program.currentUser != null)
            {
                characters = Program.currentUser.Characters;
            }
            else
            {
                characters = new List<Character>();
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
            for (int i = 0; i < characters.Count; i++)
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