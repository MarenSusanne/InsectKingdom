using System;
using InsectKingdom;

public static class BugManager
{
    private static List<Bug> _bugList;
	static BugManager()
    {
        _bugList = new List<Bug>()
        {
            new Spider(),
            new Fly(),
            new Mosquito(),
            new Tick(),
            new Wasp(),
            new Butterfly()
        };
    }
}
