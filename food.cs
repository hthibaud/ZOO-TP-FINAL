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

    public void IncreaseMeat(double nbKg)
    {
        _meatKg += nbKg;
    }

        public void IncreaseSeeds(double nbKg)
    {
        _seedsKg += nbKg;
    }

        public double DecreaseMeat(double nbKg)
    {
        _meatKg -= nbKg;
        double surplus = _meatKg;

        if (_meatKg < 0)
        {
            Console.WriteLine($"Not enough meat : {_meatKg}Kg");
            _meatKg = 0;
        }
        return surplus;
    }

        public double DecreaseSeeds(double nbKg)
    {
        _seedsKg -= nbKg;
        double surplus = _seedsKg;

        if (_seedsKg < 0)
        {
            Console.WriteLine($"Not enough seeds : {_seedsKg}Kg");
            _seedsKg = 0;
        }
        return surplus;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Seeds in your stock: {_seedsKg}Kg");
        Console.WriteLine($"Meat in your stock: {_meatKg}Kg\n");
    }
}