using System.ComponentModel.Design;
using System.Globalization;
using System.Net;
using System.Security.Cryptography.X509Certificates;

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

    public List<Animal> _animals = new List<Animal>();

    public Zoo(int numberOfHabitats, int numberOfChickenHabitats, int numberOfEagleHabitats, int numberOfTigerHabitats)
    {
    }

    public void ShowInfo()
    {
        Console.Clear();
        Console.WriteLine("\n ########### STATS OF YOUR ZOO! ########### \n");
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

        Console.WriteLine($"\nTotal of chickens : {numberOfChickens}\n");

        int nbChickens = 0;
        for (var i = 0; i < _animals.Count(); i++)
        {
            if (_animals[i].GetSpecies().Contains("Chicken"))
            {
                nbChickens++;
                Console.WriteLine($"Chicken {nbChickens}:");

                _animals[i].ShowInfo();
            }
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

        Console.WriteLine($"\nTotal of eagles : {numberOfEagles}\n");

        int nbEagles = 0;
        for (var i = 0; i < _animals.Count(); i++)
        {
            if (_animals[i].GetSpecies().Contains("Eagle"))
            {
                nbEagles++;
                Console.WriteLine($"Eagle {nbEagles}:");

                _animals[i].ShowInfo();
            }
        }
    }

    public void ShowTigersDetailedInfo()
    {
        Console.WriteLine($"\nTotal of tigers habitats : {_tigerHabitats.Count}\n");

        for (var i = 0; i < _chickenHabitats.Count; i++)
        {
            Console.WriteLine($"\ntiger habitat {i + 1}:");
            _tigerHabitats[i].ShowInfo();
        }

        Console.WriteLine($"\nTotal of tigers : {numberOfTigers}\n");

        int nbTigers = 0;
        for (var i = 0; i < _animals.Count(); i++)
        {

            if (_animals[i].GetSpecies().Contains("Tiger"))
            {
                nbTigers++;
                Console.WriteLine($"Tiger {nbTigers}:");

                _animals[i].ShowInfo();
            }
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

        if (chosenChickenFemaleName == null || chosenChickenFemaleName == "")
        {
            chosenChickenFemaleName = "Unnamed chicken";
        }

        addChickenFemale2(chosenChickenFemaleName);

    }

    public void addChickenFemale2(string chosenChickenFemaleName)
    {
        foreach (var habitat in _chickenHabitats)
        {
            if (habitat.NumberOfAnimals < 10)
            {
                Chicken_Female ChickenFemale = new Chicken_Female(chosenChickenFemaleName, 6, false, true);

                habitat.AddAnimal();

                numberOfChickens += 1;

                _animals.Add(ChickenFemale);
                numberOfAnimals += 1;

                Console.Clear();

                Console.WriteLine($"\n\n\nYour new chicken {chosenChickenFemaleName} of 6 months has been added to your chicken habitat!\n");
            }
            else
            {
                Console.WriteLine("You don't have enough habitat, buy a new one.");
            }
        }
    }

    public void RemoveChickenFemale()
    {

        Console.Write("Enter the name of the chicken you want to sell: ");
        string? chosenChickenFemaleName = Console.ReadLine();

        if (chosenChickenFemaleName == null || chosenChickenFemaleName == "")
        {
            chosenChickenFemaleName = "Unnamed chicken";
        }


        bool found = false;

        for (var i = _animals.Count - 1; i >= 0; i--)
        {
            if (_animals[i].GetName() == chosenChickenFemaleName && _animals[i] is Chicken_Female)
            {
                _animals.RemoveAt(i);
                numberOfChickens -= 1;
                numberOfAnimals -= 1;
                found = true;
                break;

            }
        }
        if (found == false)
        {
            Console.WriteLine($"You don't have any chicken named {chosenChickenFemaleName}");
            return;
        }
        //_chickensFemales.Add(ChickenFemale);

        Console.Clear();

        Console.WriteLine($"\n\n\nYour chicken {chosenChickenFemaleName} of 6 months has been sold for 10€!\n");
    }

    public void addChickenMale()
    {
        Console.Write("Enter a name for your new chicken: ");
        string? chosenChickenMaleName = Console.ReadLine();

        if (chosenChickenMaleName == null || chosenChickenMaleName == "")
        {
            chosenChickenMaleName = "Unnamed chicken";
        }

        addChickenMale2(chosenChickenMaleName);

    }

    public void addChickenMale2(string chosenChickenMaleName)
    {

        foreach (var habitat in _chickenHabitats)
        {
            if (habitat.NumberOfAnimals < 10)
            {
                Chicken_Male ChickenMale = new Chicken_Male(chosenChickenMaleName, 6, false, true);

                habitat.AddAnimal();

                numberOfChickens += 1;

                _animals.Add(ChickenMale);
                numberOfAnimals += 1;

                Console.Clear();

                Console.WriteLine($"\n\n\nYour new chicken {chosenChickenMaleName} of 6 months has been added to your chicken habitat!\n");
            }
            else
            {
                Console.WriteLine("You don't have enough habitat, buy a new one.");
            }
        }
    }

    public void RemoveChickenMale()
    {
        Console.Write("Enter the name of the chicken you want to sell: ");
        string? chosenChickenMaleName = Console.ReadLine();

        if (chosenChickenMaleName == null || chosenChickenMaleName == "")
        {
            chosenChickenMaleName = "Unnamed chicken";
        }


        bool found = false;

        for (var i = _animals.Count - 1; i >= 0; i--)
        {
            if (_animals[i].GetName() == chosenChickenMaleName && _animals[i] is Chicken_Male)
            {
                _animals.RemoveAt(i);
                numberOfChickens -= 1;
                numberOfAnimals -= 1;
                found = true;
                break;

            }
        }
        if (found == false)
        {
            Console.WriteLine($"You don't have any chicken named {chosenChickenMaleName}");
            return;
        }
        //_chickensFemales.Add(ChickenFemale);

        Console.Clear();

        Console.WriteLine($"\n\n\nYour chicken {chosenChickenMaleName} of 6 months has been sold for 20€!\n");
    }
    public void addEagleFemale(int age)
    {
        Console.Write("Enter a name for your new eagle: ");
        string? chosenEagleFemaleName = Console.ReadLine();

        if (chosenEagleFemaleName == null || chosenEagleFemaleName == "")
        {
            chosenEagleFemaleName = "Unnamed eagle";
        }

        addEagleFemale2(chosenEagleFemaleName, age);

    }

    public void addEagleFemale2(string chosenEagleFemaleName, int age)
    {
        foreach (var habitat in _eagleHabitats)
        {
            if (numberOfAnimals < 4)
            {

                Eagle_Female EagleFemale = new Eagle_Female(chosenEagleFemaleName, age, false, true);

                numberOfEagles += 1;

                _animals.Add(EagleFemale);
                habitat.AddAnimal();

                numberOfAnimals += 1;

                Console.Clear();

                Console.WriteLine($"\n\n\nYour new eagle {chosenEagleFemaleName} of {age} months has been added to your eagles habitat!\n");
            }
            else
            {
                Console.WriteLine("You don't have enough habitat, buy a new one.");
            }
        }

    }

    public void addEagleMale(int age)
    {
        Console.Write("Enter a name for your new eagle: ");
        string? chosenEagleMaleName = Console.ReadLine();

        if (chosenEagleMaleName == null || chosenEagleMaleName == "")
        {
            chosenEagleMaleName = "Unnamed eagle";
        }

        addEagleMale2(chosenEagleMaleName, age);

    }

    public void addEagleMale2(string chosenEagleMaleName, int age)
    {

        foreach (var habitat in _eagleHabitats)
        {

            if (habitat.NumberOfAnimals < 4)
            {
                Eagle_Male EagleMale = new Eagle_Male(chosenEagleMaleName, age, false, true);

                numberOfEagles += 1;

                _animals.Add(EagleMale);
                habitat.AddAnimal();
                numberOfAnimals += 1;

                Console.Clear();

                Console.WriteLine($"\n\n\nYour new eagle {chosenEagleMaleName} of {age} months has been added to your eagles habitat!\n");
            }
            else
            {
                Console.WriteLine("You don't have enough habitat, buy a new one.");

            }
        }
    }


    public void RemoveEagleOf6Months()
    {

        Console.Write("Enter the name of the eagle you want to sell: ");
        string? chosenEagleName = Console.ReadLine();

        if (chosenEagleName == null || chosenEagleName == "")
        {
            chosenEagleName = "Unnamed eagle";
        }


        bool found = false;

        for (var i = _animals.Count - 1; i >= 0; i--)
        {
            if (_animals[i].GetName() == chosenEagleName && _animals[i].GetAge() >= 6 && _animals[i].GetAge() < 48)
            {
                _animals.RemoveAt(i);
                numberOfEagles -= 1;
                numberOfAnimals -= 1;
                found = true;
                break;

            }
        }
        if (found == false)
        {
            Console.WriteLine($"You don't have any eagle of 6 months named {chosenEagleName}");
            return;
        }

        Console.Clear();

        Console.WriteLine($"\n\n\nYour eagle {chosenEagleName} of 6 months has been sold for 500€!\n");
    }
    public void RemoveEagleOf4Years()
    {

        Console.Write("Enter the name of the eagle you want to sell: ");
        string? chosenEagleName = Console.ReadLine();

        if (chosenEagleName == null || chosenEagleName == "")
        {
            chosenEagleName = "Unnamed eagle";
        }


        bool found = false;

        for (var i = _animals.Count - 1; i >= 0; i--)
        {
            if (_animals[i].GetName() == chosenEagleName && _animals[i].GetAge() >= 48 && _animals[i].GetAge() < 168)
            {
                _animals.RemoveAt(i);
                numberOfEagles -= 1;
                numberOfAnimals -= 1;
                found = true;
                break;

            }
        }
        if (found == false)
        {
            Console.WriteLine($"You don't have any eagle of 4 years named {chosenEagleName}");
            return;
        }

        Console.Clear();

        Console.WriteLine($"\n\n\nYour eagle {chosenEagleName} of 4 years has been sold for 2000€!\n");
    }
    public void RemoveEagleOf14Years()
    {

        Console.Write("Enter the name of the eagle you want to sell: ");
        string? chosenEagleName = Console.ReadLine();

        if (chosenEagleName == null || chosenEagleName == "")
        {
            chosenEagleName = "Unnamed eagle";
        }


        bool found = false;

        for (var i = _animals.Count - 1; i >= 0; i--)
        {
            if (_animals[i].GetName() == chosenEagleName && _animals[i].GetAge() >= 168)
            {
                _animals.RemoveAt(i);
                numberOfEagles -= 1;
                numberOfAnimals -= 1;
                found = true;
                break;

            }
        }
        if (found == false)
        {
            Console.WriteLine($"You don't have any eagle of 14 years named {chosenEagleName}");
            return;
        }

        Console.Clear();

        Console.WriteLine($"\n\n\nYour eagle {chosenEagleName} of 14 years has been sold for 400€!\n");
    }

    public void addTigerFemale(int age)
    {

        Console.Write("Enter a name for your new tiger: ");
        string? chosenTigerFemaleName = Console.ReadLine();

        if (chosenTigerFemaleName == null || chosenTigerFemaleName == "")
        {
            chosenTigerFemaleName = "Unnamed tiger";
        }

        addTigerFemale2(chosenTigerFemaleName, age);

    }

    public void addTigerFemale2(string chosenTigerFemaleName, int age)
    {


        foreach (var habitat in _tigerHabitats)
        {

            if (habitat.NumberOfAnimals < 2)
            {
                Tiger_Female TigerFemale = new Tiger_Female(chosenTigerFemaleName, age, false, true);

                numberOfTigers += 1;
                habitat.AddAnimal();
                _animals.Add(TigerFemale);
                numberOfAnimals += 1;

                Console.Clear();

                Console.WriteLine($"\n\n\nYour new tiger {chosenTigerFemaleName} of {age} months has been added to your tigers habitat!\n");

            }
            else
            {
                Console.WriteLine("You don't have enough habitat, buy a new one.");

            }
        }
    }

    public void addTigerMale(int age)
    {
        Console.Write("Enter a name for your new tiger: ");
        string? chosenTigerMaleName = Console.ReadLine();

        if (chosenTigerMaleName == null || chosenTigerMaleName == "")
        {
            chosenTigerMaleName = "Unnamed tiger";
        }

        addTigerMale2(chosenTigerMaleName, age);

    }
    public void addTigerMale2(string chosenTigerMaleName, int age)
    {

        foreach (var habitat in _tigerHabitats)
        {
            if (habitat.NumberOfAnimals < 2)
            {
                Tiger_Male TigerMale = new Tiger_Male(chosenTigerMaleName, age, false, true);

                numberOfTigers += 1;

                _animals.Add(TigerMale);
                numberOfAnimals += 1;

                Console.Clear();

                Console.WriteLine($"\n\n\nYour new tiger {chosenTigerMaleName} of {age} months has been added to your tigers habitat!\n");
            }
            else
            {
                Console.WriteLine("You don't have enough habitat, buy a new one.");

            }
        }
    }
    public void RemoveTigerOf6Months()
    {

        Console.Write("Enter the name of the tiger you want to sell: ");
        string? chosenTigerName = Console.ReadLine();

        if (chosenTigerName == null || chosenTigerName == "")
        {
            chosenTigerName = "Unnamed tiger";
        }


        bool found = false;

        for (var i = _animals.Count - 1; i >= 0; i--)
        {
            if (_animals[i].GetName() == chosenTigerName && _animals[i].GetAge() >= 6 && _animals[i].GetAge() < 48)
            {
                _animals.RemoveAt(i);
                numberOfTigers -= 1;
                numberOfAnimals -= 1;
                found = true;
                break;

            }
        }
        if (found == false)
        {
            Console.WriteLine($"You don't have any tiger of 6 months named {chosenTigerName}");
            return;
        }

        Console.Clear();

        Console.WriteLine($"\n\n\nYour tiger {chosenTigerName} of 6 months has been sold for 1500€!\n");
    }
    public void RemoveTigerOf4Years()
    {

        Console.Write("Enter the name of the tiger you want to sell: ");
        string? chosenTigerName = Console.ReadLine();

        if (chosenTigerName == null || chosenTigerName == "")
        {
            chosenTigerName = "Unnamed tiger";
        }


        bool found = false;

        for (var i = _animals.Count - 1; i >= 0; i--)
        {
            if (_animals[i].GetName() == chosenTigerName && _animals[i].GetAge() >= 48 && _animals[i].GetAge() < 168)
            {
                _animals.RemoveAt(i);
                numberOfTigers -= 1;
                numberOfAnimals -= 1;
                found = true;
                break;

            }
        }
        if (found == false)
        {
            Console.WriteLine($"You don't have any tiger of 4 years named {chosenTigerName}");
            return;
        }

        Console.Clear();

        Console.WriteLine($"\n\n\nYour tiger {chosenTigerName} of 4 years has been sold for 60 000€!\n");
    }

    public void RemoveTigerOf14Years()
    {

        Console.Write("Enter the name of the tiger you want to sell: ");
        string? chosenTigerName = Console.ReadLine();

        if (chosenTigerName == null || chosenTigerName == "")
        {
            chosenTigerName = "Unnamed tiger";
        }


        bool found = false;

        for (var i = _animals.Count - 1; i >= 0; i--)
        {
            if (_animals[i].GetName() == chosenTigerName && _animals[i].GetAge() >= 168)
            {
                _animals.RemoveAt(i);
                numberOfTigers -= 1;
                numberOfAnimals -= 1;
                found = true;
                break;

            }
        }
        if (found == false)
        {
            Console.WriteLine($"You don't have any tiger of 14 years named {chosenTigerName}");
            return;
        }

        Console.Clear();

        Console.WriteLine($"\n\n\nYour tiger {chosenTigerName} of 14 years has been sold for 10 000€!\n");
    }
    public bool EnoughChickenHabitats()
    {
        return numberOfChickens < numberOfChickenHabitats * 10;
    }
    public bool EnoughEagleHabitats()
    {
        return numberOfEagles < numberOfEagleHabitats * 4;

    }
    public bool EnoughTigerHabitats()
    {
        return numberOfTigers < numberOfTigerHabitats * 2;
    }
    public void GrowUpAnimalsMonths()
    {
        for (var i = 0; i < _animals.Count; i++)
        {
            _animals[i].GrowUpMonths();
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
    public void CheckStarvation()

    {

        for (int i = _animals.Count - 1; i >= 0; i--)
        {
            Animal thisAnimal = _animals[i];

            if (thisAnimal.GetHunger() > (thisAnimal.GetDaysBeforeStarvation() * 2))
            {
                Console.WriteLine($"[DEATH] : You didn't feed {thisAnimal.GetName()} for {thisAnimal.GetHunger()} days");

                _animals.RemoveAt(i);

                numberOfAnimals -= 1;

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

                //Console.WriteLine("\n[Press any key to continue]");
                //Console.ReadLine();
            }
        }
    }
    public bool EnoughChickens()
    {
        if (numberOfChickens <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public bool EnoughEagles()
    {
        if (numberOfEagles <= 0)
        {
            return false;
        }
        return true;
    }
    public bool EnoughTigers()
    {
        if (numberOfTigers <= 0)
        {
            return false;
        }
        return true;
    }
    public void RemoveChickenHabitat()
    {

    }
}
