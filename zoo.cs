public class Zoo
{
    public int numberOfHabitats { get; private set; }
    public int numberOfChickenHabitats { get; private set; }
    public int numberOfEagleHabitats { get; private set; }
    public int numberOfTigerHabitats { get; private set; }
    private List<Chicken_Habitat> _chickenHabitats = new List<Chicken_Habitat>();

    private List<Eagle_Habitat> _eagleHabitats = new List<Eagle_Habitat>();

    private List<Tiger_Habitat> _tigerHabitats = new List<Tiger_Habitat>();


    public void ShowInfo()
    {
        Console.WriteLine($"\nTotal of habitats : {numberOfHabitats}\nTotal of chicken habitats : {numberOfChickenHabitats}\nTotal of eagle habitats : {numberOfEagleHabitats}\nTotal of tiger habitats : {numberOfTigerHabitats}\n");
    }

    public Zoo(int numberOfHabitats, int numberOfChickenHabitats, int numberOfEagleHabitats, int numberOfTigerHabitats)
    {
    }

    public void addChickenHabitat()
    {

        Chicken_Habitat newChickenHabitat1 = new Chicken_Habitat(0, 10, 300);

        _chickenHabitats.Add(newChickenHabitat1);

        Console.WriteLine("New habitat for chickens has been built!");
        numberOfChickenHabitats += 1;
        numberOfHabitats += 1;
    }

    public void addEagleHabitat()
    {
        Eagle_Habitat newEagleHabitat1 = new Eagle_Habitat(0, 4, 2000);

        _eagleHabitats.Add(newEagleHabitat1);

        Console.WriteLine("New habitat for eagles has been built!");
        numberOfEagleHabitats += 1;
        numberOfHabitats += 1;
    }

    public void addTigerHabitat()
    {
        Tiger_Habitat newTigerHabitat1 = new Tiger_Habitat(0, 2, 2000);

        _tigerHabitats.Add(newTigerHabitat1);

        Console.WriteLine("New habitat for tigers has been built!");
        numberOfTigerHabitats += 1;
        numberOfHabitats += 1;
    }
}