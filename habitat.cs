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

    //adds 1 to the numberOfAnimal if the number of animal < max animals
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

    //removes 1 from the numberOfAnimal (when they die for example)
    public void RemoveAnimal()
    {
        _numberOfAnimals--;
    }

}