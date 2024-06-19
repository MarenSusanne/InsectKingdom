namespace InsectKingdom;

public class Spider : Bug
{
    private string _goodStuff;

    public Spider() : base(false, false, 8, "can bite humans")
    {
        _goodStuff = "eats flies and mite";
    }
}