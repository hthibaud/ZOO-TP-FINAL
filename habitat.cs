public class Habitat
{
    private int _numberOfAnimals = 0;
    private int _maxAnimals = 0;
    private int _price = 0;

    public Habitat(int numberOfAnimals, int maxAnimals, int price) {

    _numberOfAnimals = numberOfAnimals;
    _maxAnimals = maxAnimals;
    _price = price;

    }
    public void ShowInfo(){
                Console.WriteLine($"\nNumber of animals : {_numberOfAnimals} /{_maxAnimals}");
    }
}