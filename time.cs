class Time
{
    private int _nbMonths = 0;

    //private int _nbYears = 0;

    public void IncrMonths()
    {
        _nbMonths++;
    }
    public void ShowInfos()
    {
        if (_nbMonths < 12)
        {
            Console.WriteLine($"\nTime: {_nbMonths} months\n");
        }
        else
        {
            int remainingMonths = _nbMonths % 12;
            Console.WriteLine($"\nTime: {GetNbYears()} year(s) and {remainingMonths} month(s)\n");
        }
    }
    public int GetNbYears()
    {
        return _nbMonths / 12;
    }
    public int GetNbMonths()
    {
        return _nbMonths;
    }

    public int GetCurrentMonth()
    {
        return _nbMonths%12;
    }
    public string GetCurrentMonthName()
    {
        if (GetCurrentMonth() == 1)
        {
            return "Time of the Year : January";
        }
        if (GetCurrentMonth() == 2)
        {
            return "Time of the Year : February";
        }
        else if (GetCurrentMonth() == 3)
        {
            return "Time of the Year : March";
        }
        else if (GetCurrentMonth() == 4)
        {
            return "Time of the Year : April";
        }
        else if (GetCurrentMonth() == 5)
        {
            return "Time of the Year : May";
        }
        else if (GetCurrentMonth() == 6)
        {
            return "Time of the Year : June";
        }
        else if (GetCurrentMonth() == 7)
        {
            return "Time of the Year : July";
        }
        else if (GetCurrentMonth() == 8)
        {
            return "Time of the Year : August";
        }
        else if (GetCurrentMonth() == 9)
        {
            return "Time of the Year : September";
        }
        else if (GetCurrentMonth() == 10)
        {
            return "Time of the Year : October";
        }
        else if (GetCurrentMonth() == 11)
        {
            return "Time of the Year : November";
        }
        else
        {
            return "Time of the Year : December";
        }
    }
}
