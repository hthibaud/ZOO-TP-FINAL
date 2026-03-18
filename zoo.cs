using System.ComponentModel.Design;
using System.Globalization;
using System.Net;

public class Zoo
{
    public int numberOfHabitats { get; private set; }
    public int numberOfChickenHabitats { get; private set; }
    public int numberOfEagleHabitats { get; private set; }
    public int numberOfTigerHabitats { get; private set; }

    public int numberOfAnimals;

    public int numberOfChickens;

    public int numberOfEagles;

    public int numberOfTigers;
    private List<Chicken_Habitat> _chickenHabitats = new List<Chicken_Habitat>();

    private List<Eagle_Habitat> _eagleHabitats = new List<Eagle_Habitat>();

    private List<Tiger_Habitat> _tigerHabitats = new List<Tiger_Habitat>();

    private List<Chicken_Female> _chickensFemales = new List<Chicken_Female>();

    private List<Chicken_Male> _chickensMales = new List<Chicken_Male>();

    private List<Eagle_Female> _eaglesFemales = new List<Eagle_Female>();

    private List<Eagle_Male> _eaglesMales = new List<Eagle_Male>();

    private List<Tiger_Female> _tigersFemales = new List<Tiger_Female>();

    private List<Tiger_Male> _tigersMales = new List<Tiger_Male>();


    public void ShowInfo()
    {
        Console.WriteLine($"\nTotal of habitats : {numberOfHabitats}\nTotal of chicken habitats : {numberOfChickenHabitats}\nTotal of eagle habitats : {numberOfEagleHabitats}\nTotal of tiger habitats : {numberOfTigerHabitats}\nTotal of animals : {numberOfAnimals}\nTotal of chickens : {numberOfChickens}\nTotal of eagles : {numberOfEagles}\nTotal of tigers : {numberOfTigers}\n");
    }

    public Zoo(int numberOfHabitats, int numberOfChickenHabitats, int numberOfEagleHabitats, int numberOfTigerHabitats)
    {
    }

    public void addChickenHabitat()
    {

        Chicken_Habitat newChickenHabitat = new Chicken_Habitat(0, 10, 300);

        _chickenHabitats.Add(newChickenHabitat);

        Console.WriteLine("New habitat for chickens has been built!");
        numberOfChickenHabitats += 1;
        numberOfHabitats += 1;
    }

    public void addEagleHabitat()
    {
        Eagle_Habitat newEagleHabitat = new Eagle_Habitat(0, 4, 2000);

        _eagleHabitats.Add(newEagleHabitat);

        Console.WriteLine("New habitat for eagles has been built!");
        numberOfEagleHabitats += 1;
        numberOfHabitats += 1;
    }

    public void addTigerHabitat()
    {
        Tiger_Habitat newTigerHabitat = new Tiger_Habitat(0, 2, 2000);

        _tigerHabitats.Add(newTigerHabitat);

        Console.WriteLine("New habitat for tigers has been built!");
        numberOfTigerHabitats += 1;
        numberOfHabitats += 1;
    }

    public void addChickenFemale()
    {
        Console.Write("Enter a name for your new chicken: ");
        string? chosenChickenFemaleName = Console.ReadLine();

        if (chosenChickenFemaleName == null || chosenChickenFemaleName == " ")
        {
            chosenChickenFemaleName = "Unnamed chicken";
        }

        Chicken_Female ChickenFemale = new Chicken_Female("chicken", chosenChickenFemaleName, 6, "seeds", 1, 0.15, true, 6, 8, 15, false, true);
        
        _chickensFemales.Add(ChickenFemale);

        Console.WriteLine($"Your new chicken {chosenChickenFemaleName} of 6 months has been added to your chicken habitat!");
        numberOfChickens += 1;
        numberOfAnimals += 1;
    }

    public void addChickenMale()
    {
        Console.Write("Enter a name for your new chicken: ");
        string? chosenChickenMaleName = Console.ReadLine();

        if (chosenChickenMaleName == null || chosenChickenMaleName == " ")
        {
            chosenChickenMaleName = "Unnamed chicken";
        }

        Chicken_Male ChickenMale = new Chicken_Male("Chicken (male)", chosenChickenMaleName, 6, "seeds", 2, 0.18, false, 6, 96, 180, false, true);

        _chickensMales.Add(ChickenMale);

        Console.WriteLine($"Your new chicken {chosenChickenMaleName} of 6 months has been added to your chicken habitat!");
        numberOfChickens += 1;
        numberOfAnimals += 1;
    }

    public void addEagleFemale(int age)
    {
        Console.Write("Enter a name for your new eagle: ");
        string? chosenEagleFemaleName = Console.ReadLine();

        if (chosenEagleFemaleName == null || chosenEagleFemaleName == " ")
        {
            chosenEagleFemaleName = "Unnamed eagle";
        }

        Eagle_Female EagleFemale = new Eagle_Female("Eagle (female)", chosenEagleFemaleName, age, "meat", 10, 0.3, true, 48, 168, 300, false, true);

        _eaglesFemales.Add(EagleFemale);

        Console.WriteLine($"Your new eagle {chosenEagleFemaleName} of {age} months has been added to your eagles habitat!");
        numberOfEagles += 1;
        numberOfAnimals += 1;
    }

    public void addEagleMale(int age)
    {
        Console.Write("Enter a name for your new eagle: ");
        string? chosenEagleMaleName = Console.ReadLine();

        if (chosenEagleMaleName == null || chosenEagleMaleName == " ")
        {
            chosenEagleMaleName = "Unnamed eagle";
        }

        Eagle_Male EagleMale = new Eagle_Male("Eagle (male)", chosenEagleMaleName, age, "meat", 10, 0.25, false, 48, 168, 300, false, true);

        _eaglesMales.Add(EagleMale);

        Console.WriteLine($"Your new eagle {chosenEagleMaleName} of {age} months has been added to your eagles habitat!");
        numberOfEagles += 1;
        numberOfAnimals += 1;
    }

    public void addTigerFemale(int age)
    {
        Console.Write("Enter a name for your new tiger: ");
        string? chosenTigerFemaleName = Console.ReadLine();

        if (chosenTigerFemaleName == null || chosenTigerFemaleName == " ")
        {
            chosenTigerFemaleName = "Unnamed tiger";
        }

        Tiger_Female TigerFemale = new Tiger_Female("Tiger (female)", chosenTigerFemaleName, age, "meat", 2, 10, true, 48, 168, 300, false, true);

        _tigersFemales.Add(TigerFemale);

        Console.WriteLine($"Your new tiger {chosenTigerFemaleName} of {age} months has been added to your tigers habitat!");
        numberOfTigers += 1;
        numberOfAnimals += 1;
    }

    public void addTigerMale(int age)
    {
        Console.Write("Enter a name for your new tiger: ");
        string? chosenTigerMaleName = Console.ReadLine();

        if (chosenTigerMaleName == null || chosenTigerMaleName == " ")
        {
            chosenTigerMaleName = "Unnamed tiger";
        }

        Tiger_Male TigerMale = new Tiger_Male("Tiger (male)", chosenTigerMaleName, age, "meat", 2, 12, false, 36, 168, 300, false, true);

        _tigersMales.Add(TigerMale);

        Console.WriteLine($"Your new eagle {chosenTigerMaleName} of {age} months has been added to your eagles habitat!");
        numberOfTigers += 1;
        numberOfAnimals += 1;
    }

    public bool EnoughChickenHabitats()
    {
        if (numberOfChickens < numberOfChickenHabitats * 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool EnoughEagleHabitats()
    {
        if (numberOfEagles < numberOfEagleHabitats * 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool EnoughTigerHabitats()
    {
        if (numberOfTigers < numberOfTigerHabitats * 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
