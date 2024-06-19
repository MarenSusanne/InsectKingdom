namespace InsectKingdom;

public class Menu
{
    public void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. See all bugs");
            Console.WriteLine("2. Add more bugs");
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
        string text = PromptUser("Which bug do you want to add?").ToLower();
        string species = PromptUser("Species?");

        switch (text)
        {
            case "spider":
                BugManager.AddSpider(species);
                break;
            case "fly":
                BugManager.AddFly(species);
                break;
            case "butterfly":
                BugManager.AddButterfly(species);
                break;
            case "mosquito":
               BugManager.AddMosquito(species);
                break;
            case "wasp":
                BugManager.AddWasp(species);
                break;
            case "tick":
                BugManager.AddTick(species);
                break;
            default:
                Console.WriteLine("Invalid input, please try again.");
                break;
        }
    }
    
    private void ShowInsects(List<Bug> bugs)
    {
        for (int i = 0; i < bugs.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {bugs[i].GetSpecies()}");
        }

        int input = GetInput();
        Console.WriteLine();
        Console.WriteLine();
        if (input < 1 || input >= bugs.Count() + 1)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        bugs[input - 1].PrintInfo();
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