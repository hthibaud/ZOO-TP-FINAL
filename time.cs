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

        currentMonth = _nbMonths % 12;

        if (currentMonth == 0 && _nbMonths > 0)
        {
            currentMonth = 12;
        }

        return currentMonth;
    }


    //returns the name of the month of the year we are in a this time
    public void GetCurrentMonthName()
    {

        string title = "\u001b[1m";
        string blue = "\u001b[34m";
        string reset = "\u001b[0m";

        if (GetCurrentMonth() == 1)
        {
            Console.WriteLine($"\n{title}{blue}########## JANUARY ##########{reset}\n");
        }
        if (GetCurrentMonth() == 2)
        {
            Console.WriteLine($"\n{title}{blue}########## FEBRUARY ##########{reset}\n");
        }
        else if (GetCurrentMonth() == 3)
        {
            Console.WriteLine($"\n{title}{blue}########## MARCH ##########{reset}\n");
        }
        else if (GetCurrentMonth() == 4)
        {
            Console.WriteLine($"\n{title}{blue}########## APRIL ##########{reset}\n");
        }
        else if (GetCurrentMonth() == 5)
        {
            Console.WriteLine($"\n{title}{blue}########## MAY ##########{reset}\n");
        }
        else if (GetCurrentMonth() == 6)
        {
            Console.WriteLine($"\n{title}{blue}########## JUNE ##########{reset}\n");
        }
        else if (GetCurrentMonth() == 7)
        {
            Console.WriteLine($"\n{title}{blue}########## JULY ##########{reset}\n");
        }
        else if (GetCurrentMonth() == 8)
        {
            Console.WriteLine($"\n{title}{blue}########## AUGUST ##########{reset}\n");
        }
        else if (GetCurrentMonth() == 9)
        {
            Console.WriteLine($"\n{title}{blue}########## SEPTEMBER ##########{reset}\n");
        }
        else if (GetCurrentMonth() == 10)
        {
            Console.WriteLine($"\n{title}{blue}########## OCTOBER ##########{reset}\n");
        }
        else if (GetCurrentMonth() == 11)
        {
            Console.WriteLine($"\n{title}{blue}########## NOVEMBER ##########{reset}\n");
        }
        else if (GetCurrentMonth() == 12)
        {
            Console.WriteLine($"\n{title}{blue}########## DECEMBER ##########{reset}\n");
        }
    }
}
