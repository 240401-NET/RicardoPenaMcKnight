namespace ChooseAdventure
{
    class CharacterSelection : Menu
    {
        public CharacterSelection()
        {
            NumOptions = 1;
            options = new Option[NumOptions];
            options[0] = new Option("Select Character");
            DisplayOptions();
            SelectOption();
        }
    }
}