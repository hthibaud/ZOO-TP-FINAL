public class Food
{
    private double _meatKg = 0;
    private double _seedsKg = 0;

    public float meatPricePerKg = 5f;
    public float seedsPricePerKg = 2.5f;

    public Food()
    {
        _meatKg = 0;
        _seedsKg = 0;

    }


    //increases the amount of meat
    public void IncreaseMeat(double nbKg)
    {
        _meatKg += nbKg;
    }


    //increases the amount of seeds
    public void IncreaseSeeds(double nbKg)
    {
        _seedsKg += nbKg;
    }


    //decreases the amount of meat
    public double DecreaseMeat(double nbKg)
    {
        _meatKg -= nbKg;
        double surplus = _meatKg;

        if (_meatKg < 0)
        {
            //Console.WriteLine($"Not enough meat : {_meatKg:F2}Kg");
            _meatKg = 0;
        }
        return surplus;
    }


    //decreases the amount of seeds
    public double DecreaseSeeds(double nbKg)
    {
        _seedsKg -= nbKg;
        double surplus = _seedsKg;

        if (_seedsKg < 0)
        {
            //Console.WriteLine($"Not enough seeds : {_seedsKg:F2}Kg");
            _seedsKg = 0;
        }
        return surplus;
    }

    //returns the meat value
    public double GetMeatKg()
    {
        return _meatKg;
    }


    //returns the seeds value
    public double GetSeedsKg()
    {
        return _seedsKg;
    }


    //Decreases the amount of meat of 20%
    public void BeRotten()
    {
        if (_meatKg < 0)
        {
            return;
        } else
        {
            DecreaseMeat(_meatKg/100 * 20);
        }
    }


    //Decreases the amount of seeds of 10%
    public void BadSeeds()
    {
        if (_seedsKg < 0)
        {
            return;
        } else
        {
            DecreaseSeeds(_seedsKg/100 * 10);
        }
    }


    //shows the info of the stocks
    public void ShowInfos()
    {
        string title = "\u001b[1m";
        string green = "\u001b[32m";
        string reset = "\u001b[0m";

        Console.WriteLine($"Seeds in your silo: {title}{green}{_seedsKg:F2}Kg{reset}");
        Console.WriteLine($"Meat in your cold chamber: {title}{green}{_meatKg:F2}Kg{reset}\n");
    }
}