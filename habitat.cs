public class Habitat
{
    protected int _numberOfAnimals { get; set; }
    protected int _maxAnimals = 0;
    protected int _price = 0;

    public Habitat()
    {
    }
    public void ShowInfo()
    {
        Console.WriteLine($"\nNumber of animals : {_numberOfAnimals} /{_maxAnimals}");
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