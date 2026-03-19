public class Habitat
{
    protected int _numberOfAnimals { get; set; }
    protected int _maxAnimals = 0;
    protected int _price = 0;
    public int NumberOfAnimals => _numberOfAnimals;

    public Habitat(int numberOfAnimals, int maxAnimals, int price)
    {
        _numberOfAnimals = numberOfAnimals;
        _maxAnimals = maxAnimals;
        _price = price;
    }

    public void ShowInfo()
    {
    //    Console.WriteLine($"\nNumber of animals : {NumberOfAnimals} /{_maxAnimals}");
    }
    public void AddAnimal()
    {
        if (_numberOfAnimals < _maxAnimals)
        {
            _numberOfAnimals++;
        }
        else
        {
            Console.WriteLine("Habitat is full!");
        }
    }
}