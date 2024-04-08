namespace ChooseAdventure;
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
            this.Choice = Convert.ToInt32(Console.ReadLine());
            RunMenuFunctions();
        }
        public override void RunMenuFunctions()
        {
            Console.WriteLine("You selected: " + Choice + ". " + options[Choice - 1].optionText);
            if (Choice == 1)
            {
                Program.currentCharacter = characters[0];
                Chapter1 chapter1 = new Chapter1();
            }
            else if (Choice == 2)
            {
                Program.currentCharacter = characters[1];
                Chapter1 chapter1 = new Chapter1();
            }
            else if (Choice == 3)
            {
                Program.currentCharacter = characters[2];
                Chapter1 chapter1 = new Chapter1();
            }
            else if (Choice == 4)
            {
                Program.currentCharacter = characters[3];
                Chapter1 chapter1 = new Chapter1();
            }
            else if (Choice == 5)
            {
                Program.currentCharacter = characters[4];
                Chapter1 chapter1 = new Chapter1();
            }
            else if (Choice == 6)
            {
                Program.currentCharacter = characters[5];
                Chapter1 chapter1 = new Chapter1();
            }
            else if (Choice == 7)
            {
                Program.currentCharacter = characters[6];
                Chapter1 chapter1 = new Chapter1();
            }
            else if (Choice == 8)
            {
                Program.currentCharacter = characters[7];
                Chapter1 chapter1 = new Chapter1();
            }
            else if (Choice == 9)
            {
                Program.currentCharacter = characters[8];
                Chapter1 chapter1 = new Chapter1();
            }
            else if (Choice == 10)
            {
                Program.currentCharacter = characters[9];
                Chapter1 chapter1 = new Chapter1();
            }
            else
            {
                Console.WriteLine("No valid Option selected.");
                Console.ReadLine();
                Program.Exit();
            }
        }
    }