public class Time
{
    private int _nbMonths = 0;


//Increments the number of months for whe you pass the turn
    public void IncrMonths()
    {
        _nbMonths++;
    }
    
    
    //Shows the time info (elapsed time)
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
    
    
    //returns the nb of years
    public int GetNbYears()
    {
        return _nbMonths / 12;
    }
    
    
    //returns the nb total of months
    public int GetNbMonths()
    {
        return _nbMonths;
    }

    //returns the current month between 1 & 12
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
    
    
    //returns the name of the month of the year we are in a this time
    public void GetCurrentMonthName()
    {
        if (GetCurrentMonth() == 1)
        {
            Console.WriteLine("\n########## JANUARY ##########\n");
        }
        if (GetCurrentMonth() == 2)
        {
            Console.WriteLine("\n########## FEBRUARY ##########\n");
        }
        else if (GetCurrentMonth() == 3)
        {
            Console.WriteLine("\n########## MARCH ##########\n");
        }
        else if (GetCurrentMonth() == 4)
        {
            Console.WriteLine("\n########## APRIL ##########\n");
        }
        else if (GetCurrentMonth() == 5)
        {
            Console.WriteLine("\n########## MAY ##########\n");
        }
        else if (GetCurrentMonth() == 6)
        {
            Console.WriteLine("\n########## JUNE ##########\n");
        }
        else if (GetCurrentMonth() == 7)
        {
            Console.WriteLine("\n########## JULY ##########\n");
        }
        else if (GetCurrentMonth() == 8)
        {
            Console.WriteLine("\n########## AUGUST ##########\n");
        }
        else if (GetCurrentMonth() == 9)
        {
            Console.WriteLine("\n########## SEPTEMBER ##########\n");
        }
        else if (GetCurrentMonth() == 10)
        {
            Console.WriteLine("\n########## OCTOBER ##########\n");
        }
        else if (GetCurrentMonth() == 11)
        {
            Console.WriteLine("\n########## NOVEMBER ##########\n");
        }
        else if (GetCurrentMonth() == 12)
        {
            Console.WriteLine("\n########## DECEMBER ##########\n");
        }
    }
}
