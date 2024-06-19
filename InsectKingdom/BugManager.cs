using InsectKingdom;

public static class BugManager
{
    private static List<Bug> _bugList;

    static BugManager()
    {
        _bugList = new List<Bug>()
        {
            new Spider("Black Widow"),
            new Fly("House Fly"),
            new Mosquito("Culex Mosquito"),
            new Tick("Forrest Tick"),
            new Wasp("Yellow Jacket"),
            new Butterfly("Emperor Butterfly")
        };
    }

    public static List<Bug> GetBugs() => _bugList;
    
    public static void AddSpider(string species)
    {
        _bugList.Add(new Spider(species));
    }
    
    public static void AddFly(string species)
    {
        _bugList.Add(new Fly(species));
    }
    
    public static void AddMosquito(string species)
    {
        _bugList.Add(new Mosquito(species));
    }
    
    public static void AddTick(string species)
    {
        _bugList.Add(new Tick(species));
    }
    
    public static void AddWasp(string species)
    {
        _bugList.Add(new Wasp(species));
    }
    
    public static void AddButterfly(string species)
    {
        _bugList.Add(new Butterfly(species));
    }
}