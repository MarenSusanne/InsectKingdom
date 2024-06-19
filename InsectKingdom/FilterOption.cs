namespace InsectKingdom
{
    internal class FilterOption
    {
        private bool _toggled;
        private string _name;

        public FilterOption(bool toggled, string name)
        {
            _toggled = toggled;
            _name = name;
        }

        public string Print()
        {
            return "[" + (_toggled ? "x" : " ") + "]. " + _name;
        }

        public void Toggle()
        {
            _toggled = !_toggled;
        }

				public bool IsToggled() => _toggled;
				public string GetName() => _name;
    }
}
