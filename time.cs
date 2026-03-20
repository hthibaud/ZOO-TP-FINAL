class Time
{
    private int _nbMonths = 0;

    private int _nbYears = 0;

    public void IncrMonths(){
        _nbMonths++;
    }
        public void IncrYears(){
        _nbMonths +=12;
    }
    public void ShowInfos()
    {
        if (_nbMonths < 12) {
            Console.WriteLine($"\nTime: {_nbMonths} months\n");
            }
        else
        {
            _nbYears = _nbMonths /12;
            int remainingMonths =  _nbMonths %12;
            Console.WriteLine($"\nTime: {_nbYears} year(s) and {remainingMonths} month(s)\n");
        }
    }
}
