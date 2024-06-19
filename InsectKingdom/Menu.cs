namespace InsectKingdom;

public class Menu
{

    public void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. See all bugs");
            Console.WriteLine("2. Add more insects");
            Console.WriteLine("3. Log out");

            int input = GetInput();
            Console.WriteLine();
            Console.WriteLine();

            switch (input)
            {
                case 1:
                    ShowInsects(BugManager.GetBugs());
                    break;
                case 2:
                    AddBug();
                    break;
                case 3:

                    break;
            }
        }
    }

    private void AddBug()
    {
				string species = PromptUser("Species?");
				bool canFly = StringToBool(PromptUser("Can it fly?"));
				bool suckBlood = StringToBool(PromptUser("Does it suck blood?"));
				int hasLegs = Convert.ToInt32(PromptUser("Leg count?"));
				string isAnnoying = PromptUser("Annoying traits?");

				BugManager.AddBug(species, canFly, suckBlood, hasLegs, isAnnoying);
    }

    private void ShowInsects(List<Bug> bugs)
    {
        for (int i = 0; i < bugs.Count(); i++)
        {
            Console.WriteLine($"{i}. {bugs[i].GetSpecies()}");
        }

        int input = GetInput();
        Console.WriteLine();
        Console.WriteLine();
        if (input < 0 || input >= bugs.Count())
        {
            Console.WriteLine("Invalid input");
            return;
        }

        bugs[input].PrintInfo();
    }

    private int GetInput()
    {
        return Console.ReadKey().KeyChar - '0';
    }

		private string PromptUser(string text)
		{
				Console.WriteLine(text);
				return Console.ReadLine();
		}

		private bool StringToBool(string input)
		{
				switch (input.ToLower())
				{
						case "yes":
						case "true":
								return true;
						default:
								return false;
				}
		}
}
