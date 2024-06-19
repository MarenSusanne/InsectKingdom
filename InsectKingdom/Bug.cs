namespace InsectKingdom;

public class Bug
{
    private string _species;
    private bool _canFly;
    private bool _suckBlood;
    private int _hasLegs;
    private string _isAnnoying;

    public Bug(string species, bool canFly, bool suckBlood, int hasLegs, string isAnnoying)
    {
        _species = species;
        _canFly = canFly;
        _suckBlood = suckBlood;
        _hasLegs = hasLegs;
        _isAnnoying = isAnnoying;
    }

		public string GetSpecies() => _species;

		public virtual void PrintInfo()
		{
				Console.WriteLine($"Species: {_species}");
				Console.WriteLine($"Can fly: {_canFly}");
				Console.WriteLine($"Sucks blood: {_suckBlood}");
				Console.WriteLine($"Legs: {_hasLegs}");
				Console.WriteLine($"Annoying trait: {_isAnnoying}");
		}

		public bool SucksBlood() => _suckBlood;
		public bool CanFly() => _canFly;
}
