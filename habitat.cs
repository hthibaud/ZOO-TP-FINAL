public class Habitat
{
    protected int _numberOfAnimals { get; set; }
    protected int _maxAnimals = 0;
    protected int _price = 0;
    public int NumberOfAnimals => _numberOfAnimals;

    //constructor
    public Habitat(int numberOfAnimals, int maxAnimals, int price)
    {
        _numberOfAnimals = numberOfAnimals;
        _maxAnimals = maxAnimals;
        _price = price;
    }
}