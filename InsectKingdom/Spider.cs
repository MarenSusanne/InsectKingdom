namespace InsectKingdom;

public class Spider : Bug
{
    private string _goodStuff;

    public Spider(string species) : base(species, false, false, 8, "can bite humans")
    {
        _goodStuff = "eats flies and mite";
        
    }

		public override void PrintInfo()
		{
				base.PrintInfo();
				Console.WriteLine($"Good stuff: {_goodStuff}");
		}
}
