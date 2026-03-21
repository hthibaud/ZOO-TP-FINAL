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
            Console.WriteLine($"Elapsed time: {_nbMonths} month(s)\n");
        }
        else
        {
            int remainingMonths = _nbMonths % 12;
            Console.WriteLine($"Elapsed time: {GetNbYears()} year(s) and {remainingMonths} month(s)\n");
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
        int currentMonth;

        currentMonth = _nbMonths%12;

        if (currentMonth == 0 && _nbMonths > 0)
        {
            currentMonth = 12;
        }
    
        return currentMonth;
    }
    public void GetCurrentMonthName()
    {
        if (GetCurrentMonth() == 1)
        {
            Console.WriteLine("\nMonth of the Year : January\n");
        }
        if (GetCurrentMonth() == 2)
        {
            Console.WriteLine("\nMonth of the Year : February\n");
        }
        else if (GetCurrentMonth() == 3)
        {
            Console.WriteLine("\nMonth of the Year : March\n");
        }
        else if (GetCurrentMonth() == 4)
        {
            Console.WriteLine("\nMonth of the Year : Avril\n");
        }
        else if (GetCurrentMonth() == 5)
        {
            Console.WriteLine("\nMonth of the Year : May\n");
        }
        else if (GetCurrentMonth() == 6)
        {
            Console.WriteLine("\nMonth of the Year : June\n");
        }
        else if (GetCurrentMonth() == 7)
        {
            Console.WriteLine("\nTMonth of the Year : July\n");
        }
        else if (GetCurrentMonth() == 8)
        {
            Console.WriteLine("\nMonth of the Year : August\n");
        }
        else if (GetCurrentMonth() == 9)
        {
            Console.WriteLine("\nMonth of the Year : September\n");
        }
        else if (GetCurrentMonth() == 10)
        {
            Console.WriteLine("\nMonth of the Year : October\n");
        }
        else if (GetCurrentMonth() == 11)
        {
            Console.WriteLine("\nMonth of the Year : November\n");
        }
        else if (GetCurrentMonth() == 12)
        {
            Console.WriteLine("\nMonth of the Year : December\n");
        }
    }
}
