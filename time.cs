class Time
{
    private int _nbMonths = 0;

    //private int _nbYears = 0;

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
            int remainingMonths =  _nbMonths %12;
            Console.WriteLine($"\nTime: {GetNbYears()} year(s) and {remainingMonths} month(s)\n");
        }
    }

    public int GetNbYears()
    {
        return _nbMonths/12;
    }
}
