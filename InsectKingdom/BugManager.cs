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

		public static List<Bug> GetBugs() => _bugList;

		public static void AddBug(string species, bool canFly, bool suckBlood, int hasLegs, string isAnnoying)
		{
				_bugList.Add(new Bug(species, canFly, suckBlood, hasLegs, isAnnoying));
		}
}
