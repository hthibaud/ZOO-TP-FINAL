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

    public List<Animal> _animals = new List<Animal>();


    public Zoo(int numberOfHabitats, int numberOfChickenHabitats, int numberOfEagleHabitats, int numberOfTigerHabitats)
    {
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\nTotal of habitats : {numberOfHabitats}\nTotal of chicken habitats : {numberOfChickenHabitats}\nTotal of eagle habitats : {numberOfEagleHabitats}\nTotal of tiger habitats : {numberOfTigerHabitats}\nTotal of animals : {numberOfAnimals}\nTotal of chickens : {numberOfChickens}\nTotal of eagles : {numberOfEagles}\nTotal of tigers : {numberOfTigers}\n");

    }

    public void ShowChickensDetailedInfo()
    {
        Console.WriteLine($"\nTotal of chickens habitats : {_chickenHabitats.Count}\n");

        for (var i = 0; i < _chickenHabitats.Count; i++)
        {
            Console.WriteLine($"\nchicken habitat {i + 1}:");
            _chickenHabitats[i].ShowInfo();
        }

        Console.WriteLine($"\nTotal of chickens : {_chickensFemales.Count + _chickensMales.Count}\n");

        for (var i = 0; i < _chickensFemales.Count; i++)
        {
            Console.WriteLine($"female chicken {i + 1}:");
            _chickensFemales[i].ShowInfo();
        }

        for (var i = 0; i < _chickensMales.Count; i++)
        {
            Console.WriteLine($"male chicken {i + 1}:");
            _chickensMales[i].ShowInfo();
        }
    }

    public void ShowEaglesDetailedInfo()
    {
        Console.WriteLine($"\nTotal of eagles habitats : {_eagleHabitats.Count}\n");

        for (var i = 0; i < _eagleHabitats.Count; i++)
        {
            Console.WriteLine($"\neagle habitat {i + 1}:");
            _eagleHabitats[i].ShowInfo();
        }

        Console.WriteLine($"\nTotal of eagles : {_eaglesFemales.Count + _eaglesMales.Count}\n");

        for (var i = 0; i < _eaglesFemales.Count; i++)
        {
            Console.WriteLine($"female chicken {i + 1}:");
            _eaglesFemales[i].ShowInfo();
        }

        for (var i = 0; i < _eaglesMales.Count; i++)
        {
            Console.WriteLine($"male chicken {i + 1}:");
            _eaglesMales[i].ShowInfo();
        }
    }

    public void ShowTigersDetailedInfo()
    {
        Console.WriteLine($"\nTotal of tigers habitats : {_tigerHabitats.Count}\n");

        for (var i = 0; i < _tigerHabitats.Count; i++)
        {
            Console.WriteLine($"\ntiger habitat {i + 1}:");
            _eagleHabitats[i].ShowInfo();
        }

        Console.WriteLine($"\nTotal of tigers : {_tigersFemales.Count + _tigersMales.Count}\n");

        for (var i = 0; i < _tigersFemales.Count; i++)
        {
            Console.WriteLine($"female tiger {i + 1}:");
            _tigersFemales[i].ShowInfo();
        }

        for (var i = 0; i < _tigersMales.Count; i++)
        {
            Console.WriteLine($"male tiger {i + 1}:");
            _tigersMales[i].ShowInfo();
        }
    }

    public void addChickenHabitat()
    {

        Chicken_Habitat newChickenHabitat = new Chicken_Habitat();

        _chickenHabitats.Add(newChickenHabitat);

        Console.Clear();

        Console.WriteLine("\n\n\nNew habitat for chickens has been built!\n");
        numberOfChickenHabitats += 1;
        numberOfHabitats += 1;
    }

    public void addEagleHabitat()
    {
        Eagle_Habitat newEagleHabitat = new Eagle_Habitat();

        _eagleHabitats.Add(newEagleHabitat);

        Console.Clear();


        Console.WriteLine("\n\n\nNew habitat for eagles has been built!\n");
        numberOfEagleHabitats += 1;
        numberOfHabitats += 1;
    }

    public void addTigerHabitat()
    {
        Tiger_Habitat newTigerHabitat = new Tiger_Habitat();

        _tigerHabitats.Add(newTigerHabitat);

        Console.Clear();


        Console.WriteLine("\n\n\nNew habitat for tigers has been built!\n");
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

        Chicken_Female ChickenFemale = new Chicken_Female(chosenChickenFemaleName, 6, false, true);

        _chickensFemales.Add(ChickenFemale);
        numberOfChickens += 1;

        _animals.Add(ChickenFemale);
        numberOfAnimals += 1;

        Console.Clear();

        Console.WriteLine($"\n\n\nYour new chicken {chosenChickenFemaleName} of 6 months has been added to your chicken habitat!\n");

    }

    public void addChickenMale()
    {
        Console.Write("Enter a name for your new chicken: ");
        string? chosenChickenMaleName = Console.ReadLine();

        if (chosenChickenMaleName == null || chosenChickenMaleName == " ")
        {
            chosenChickenMaleName = "Unnamed chicken";
        }

        Chicken_Male ChickenMale = new Chicken_Male(chosenChickenMaleName, 6, false, true);

        _chickensMales.Add(ChickenMale);
        numberOfChickens += 1;
        _animals.Add(ChickenMale);
        numberOfAnimals += 1;

        Console.Clear();

        Console.WriteLine($"\n\n\nYour new chicken {chosenChickenMaleName} of 6 months has been added to your chicken habitat!\n");
    }

    public void addEagleFemale(int age)
    {
        Console.Write("Enter a name for your new eagle: ");
        string? chosenEagleFemaleName = Console.ReadLine();

        if (chosenEagleFemaleName == null || chosenEagleFemaleName == " ")
        {
            chosenEagleFemaleName = "Unnamed eagle";
        }

        Eagle_Female EagleFemale = new Eagle_Female(chosenEagleFemaleName, age, false, true);

        _eaglesFemales.Add(EagleFemale);
        numberOfEagles += 1;

        _animals.Add(EagleFemale);
        numberOfAnimals += 1;

        Console.Clear();

        Console.WriteLine($"\n\n\nYour new eagle {chosenEagleFemaleName} of {age} months has been added to your eagles habitat!\n");

    }

    public void addEagleMale(int age)
    {
        Console.Write("Enter a name for your new eagle: ");
        string? chosenEagleMaleName = Console.ReadLine();

        if (chosenEagleMaleName == null || chosenEagleMaleName == " ")
        {
            chosenEagleMaleName = "Unnamed eagle";
        }

        Eagle_Male EagleMale = new Eagle_Male(chosenEagleMaleName, age, false, true);

        _eaglesMales.Add(EagleMale);
        numberOfEagles += 1;

        _animals.Add(EagleMale);
        numberOfAnimals += 1;

        Console.Clear();

        Console.WriteLine($"\n\n\nYour new eagle {chosenEagleMaleName} of {age} months has been added to your eagles habitat!\n");

    }

    public void addTigerFemale(int age)
    {
        Console.Write("Enter a name for your new tiger: ");
        string? chosenTigerFemaleName = Console.ReadLine();

        if (chosenTigerFemaleName == null || chosenTigerFemaleName == " ")
        {
            chosenTigerFemaleName = "Unnamed tiger";
        }

        Tiger_Female TigerFemale = new Tiger_Female(chosenTigerFemaleName, age, false, true);

        _tigersFemales.Add(TigerFemale);
        numberOfTigers += 1;
        _animals.Add(TigerFemale);
        numberOfAnimals += 1;


        Console.Clear();

        Console.WriteLine($"\n\n\nYour new tiger {chosenTigerFemaleName} of {age} months has been added to your tigers habitat!\n");

    }

    public void addTigerMale(int age)
    {
        Console.Write("Enter a name for your new tiger: ");
        string? chosenTigerMaleName = Console.ReadLine();

        if (chosenTigerMaleName == null || chosenTigerMaleName == " ")
        {
            chosenTigerMaleName = "Unnamed tiger";
        }

        Tiger_Male TigerMale = new Tiger_Male(chosenTigerMaleName, age, false, true);

        _tigersMales.Add(TigerMale);
        numberOfTigers += 1;

        _animals.Add(TigerMale);
        numberOfAnimals += 1;

        Console.Clear();

        Console.WriteLine($"\n\n\nYour new tiger {chosenTigerMaleName} of {age} months has been added to your tigers habitat!\n");

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
    public void GrowUpAnimalsMonths()
    {
        for (var i = 0; i < _animals.Count; i++)
        {
            _animals[i].GrowUpMonths();
        }
    }
    public void GrowUpAnimalsYears()
    {
        for (var i = 0; i < _animals.Count; i++)
        {
            _animals[i].GrowUpYears();
        }
    }
    public void DeathByAge()
    {
        for (int i = _animals.Count - 1; i >= 0; i--)
        {
            Animal thisAnimal = _animals[i];

            if (thisAnimal.GetAge() >= thisAnimal.GetLifeTime())
            {
                Console.WriteLine($"\n[DEATH] : {thisAnimal.GetName()} has passed away due to old age.");

                _animals.RemoveAt(i);

                numberOfAnimals -= 1;

                Console.WriteLine("\n[Press any key to return to Main Menu]");
                Console.ReadKey();


                if (thisAnimal.GetSpecies().Contains("Chicken"))
                {
                    numberOfChickens -= 1;
                }
                else if (thisAnimal.GetSpecies().Contains("Eagle"))
                {
                    numberOfEagles -= 1;
                }
                else
                {
                    numberOfTigers -= 1;
                }
            }
        }
    }
}
