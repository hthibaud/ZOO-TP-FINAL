public class Habitat
{
    private int _numberOfAnimals = 0;

    public Habitat(int numberOfAnimals) {
    _numberOfAnimals = numberOfAnimals;
    }
    public void ShowInfo(){
                Console.WriteLine($"\nTotal of animals : {_numberOfAnimals}");
    }
}