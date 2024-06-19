using System.Collections.Generic;

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
            Console.WriteLine("3. Remove a bug");
            Console.WriteLine("4. Log out");

            int input = GetInput();
            var bugs = BugManager.GetBugs();

            switch (input)
            {
                case 1:
                    Console.WriteLine("Pick a number to get more info");
                    ShowInsects(bugs);
                    var i = GetInputForBugs(bugs);
                    if (i == -1)
                    {
                        break;
                    }
                    bugs[i - 1].PrintInfo();
                    break;
                case 2:
                    AddBug();
                    break;
                case 3:
                    Console.WriteLine("Pick the number of the bug you want to remove");
                    ShowInsects(bugs);
                    var j = GetInputForBugs(bugs);
                    if (j == -1)
                    {
                        break;
                    }
                    var removedBugs = BugManager.RemoveInsects(j - 1);
                    Console.WriteLine($"You have removed {removedBugs}");
                    break;
                case 4:
                    Environment.Exit(0);
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


        
    }

    private int GetInputForBugs(List<Bug> bugs)
    {
        int input = GetInput();
        if (input < 1 || input >= bugs.Count() + 1)
        {
            Console.WriteLine("Invalid input");
            return -1;
        }

        return input;
    }

    private int GetInput()
    {
        var input = Console.ReadKey().KeyChar - '0';
        Console.Clear();
        return input;
    }

    private string PromptUser(string text)
    {
        Console.WriteLine(text);
        return Console.ReadLine();
    }

}