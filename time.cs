class Time
{
    private int _nbMonths = 0;

    public void IncrMonths(){
        _nbMonths++;
    }
    public void ShowInfos()
    {
        Console.WriteLine($"\nTime: {_nbMonths} months\n");
    }
}
