namespace InsectKingdom;

public class Bug
{
    private bool _canFly;
    private bool _suckBlood;
    private int _hasLegs;
    private string _isAnnoying;
    
    public Bug(bool canFly, bool suckBlood, int hasLegs, string isAnnoying)
    {
        _canFly = canFly;
        _suckBlood = suckBlood;
        _hasLegs = hasLegs;
        _isAnnoying = isAnnoying;
    }
}