using System.ComponentModel.Design;
using System.Globalization;
using System.Net;
using System.Security.Cryptography.X509Certificates;

public class Zoo
{

    //Initializes all I need for the Zoo Class
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



    //Shows the basic info of the Zoo
    public void ShowInfo()
    {
        Console.Clear();
        Console.WriteLine("\n ########### STATS OF YOUR ZOO! ########### \n");
        Console.WriteLine($"\nTotal of habitats : {numberOfHabitats}\nTotal of chicken habitats : {numberOfChickenHabitats}\nTotal of eagle habitats : {numberOfEagleHabitats}\nTotal of tiger habitats : {numberOfTigerHabitats}\nTotal of animals : {numberOfAnimals}\nTotal of chickens : {numberOfChickens}\nTotal of eagles : {numberOfEagles}\nTotal of tigers : {numberOfTigers}\n");
    }


    //Shows the detailed info of each chicken in habitats info + how to take care of each sex
    public void ShowChickensDetailedInfo()
    {
        Chicken_Female chickenFemale = new Chicken_Female("reference", 6, false, false);
        Chicken_Male chickenMale = new Chicken_Male("reference", 6, false, false);

        Console.WriteLine($"\nTotal of chickens habitats : {_chickenHabitats.Count}\n");

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
        chickenFemale.ShowDetailedInfos();
        chickenMale.ShowDetailedInfos();

    }


    //Shows the detailed info of each eagle in habitats info + how to take care of each sex
    public void ShowEaglesDetailedInfo()
    {
        Eagle_Female eagleFemale = new Eagle_Female("reference", 6, false, false);
        Eagle_Male eagleMale = new Eagle_Male("reference", 6, false, false);

        Console.WriteLine($"\nTotal of eagles habitats : {_eagleHabitats.Count}\n");

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
        eagleFemale.ShowDetailedInfos();
        eagleMale.ShowDetailedInfos();
    }


    //Shows the detailed info of each tiger in habitats info + how to take care of each sex
    public void ShowTigersDetailedInfo()
    {
        Tiger_Female tigerFemale = new Tiger_Female("reference", 6, false, false);
        Tiger_Male tigerMale = new Tiger_Male("reference", 6, false, false);


        Console.WriteLine($"\nTotal of tigers habitats : {_tigerHabitats.Count}\n");

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
        tigerFemale.ShowDetailedInfos();
        tigerMale.ShowDetailedInfos();
    }


    //adds a chicken habitat in the list
    public void addChickenHabitat()
    {

        Chicken_Habitat newChickenHabitat = new Chicken_Habitat();

        _chickenHabitats.Add(newChickenHabitat);

        Console.Clear();

        Console.WriteLine("\n\n\nNew habitat for chickens has been built!\n");
        numberOfChickenHabitats += 1;
        numberOfHabitats += 1;
    }


    //adds a eagle habitat in the list
    public void addEagleHabitat()
    {
        Eagle_Habitat newEagleHabitat = new Eagle_Habitat();

        _eagleHabitats.Add(newEagleHabitat);

        Console.Clear();


        Console.WriteLine("\n\n\nNew habitat for eagles has been built!\n");
        numberOfEagleHabitats += 1;
        numberOfHabitats += 1;
    }


    //adds a tiger habitat in the list
    public void addTigerHabitat()
    {
        Tiger_Habitat newTigerHabitat = new Tiger_Habitat();

        _tigerHabitats.Add(newTigerHabitat);

        Console.Clear();


        Console.WriteLine("\n\n\nNew habitat for tigers has been built!\n");
        numberOfTigerHabitats += 1;
        numberOfHabitats += 1;
    }


    //adds a chicken female in the list of the animals (with name input)
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


    //adds a chicken female in the list of the animals (name is chosen in parameter here)
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
                return;
            }
        }
        Console.WriteLine("You don't have enough habitats, buy a new one.");
    }


    //adds a baby chicken female in the list of the animals (name is chosen in parameter here)
    public void addBabyChickenFemale2(string chosenChickenFemaleName)
    {
        foreach (var habitat in _chickenHabitats)
        {
            if (habitat.NumberOfAnimals < 10)
            {
                Chicken_Female ChickenFemale = new Chicken_Female(chosenChickenFemaleName, 0, false, true);

                habitat.AddAnimal();

                numberOfChickens += 1;

                _animals.Add(ChickenFemale);
                numberOfAnimals += 1;

                Console.Clear();

                Console.WriteLine($"\n\n\nYour new (female) baby chicken {chosenChickenFemaleName} has been added to your chicken habitat!\n");
                return;
            }
        }
        Console.WriteLine("You don't have enough habitats to have babies, buy a new one!");
    }


    //removes a chicken female in the list of the animals (when it dies)
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
        Console.Clear();

        Console.WriteLine($"\n\n\nYour chicken {chosenChickenFemaleName} of 6 months has been sold for 10€!\n");
    }


    //adds a chicken female in the list of the animals (with name input)
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


    //adds a chicken male in the list of the animals (name is chosen in parameter here)
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

                Console.WriteLine($"\n\n\nYour new (male) chicken {chosenChickenMaleName} of 6 months has been added to your chicken habitat!\n");
                return;
            }
        }
        Console.WriteLine("You don't have enough habitats, buy a new one.");
    }


    //adds a baby chicken male in the list of the animals (name is chosen in parameter here)
    public void addBabyChickenMale2(string chosenChickenMaleName)
    {

        foreach (var habitat in _chickenHabitats)
        {
            if (habitat.NumberOfAnimals < 10)
            {
                Chicken_Male ChickenMale = new Chicken_Male(chosenChickenMaleName, 0, false, true);

                habitat.AddAnimal();

                numberOfChickens += 1;

                _animals.Add(ChickenMale);
                numberOfAnimals += 1;

                Console.Clear();

                Console.WriteLine($"\n\n\nYour new baby chicken {chosenChickenMaleName} has been added to your chicken habitat!\n");
                return;
            }
        }
        Console.WriteLine("You don't have enough habitats to have babies, buy a new one!");
    }


    //removes a chicken male in the list of the animals (when it dies or it's sold)
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


    //adds an eagle female in the list of the animals (with age in parameter and name input)
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


    //adds an eagle female in the list of the animals (name and age are chosen in parameter here)
    public void addEagleFemale2(string chosenEagleFemaleName, int age)
    {
        foreach (var habitat in _eagleHabitats)
        {
            if (habitat.NumberOfAnimals < 4)
            {

                Eagle_Female EagleFemale = new Eagle_Female(chosenEagleFemaleName, age, false, true);

                numberOfEagles += 1;

                _animals.Add(EagleFemale);
                habitat.AddAnimal();

                numberOfAnimals += 1;

                Console.Clear();

                Console.WriteLine($"\n\n\nYour new (female) eagle {chosenEagleFemaleName} of {age} months has been added to your eagles habitat!\n");
                return;
            }
        }
        Console.WriteLine("You don't have enough habitats, buy a new one.");
    }


    //adds an eagle male in the list of the animals (with age in parameter and name input)
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


    //adds an eagle male in the list of the animals (name and age are chosen in parameter here)
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

                Console.WriteLine($"\n\n\nYour new (male) eagle {chosenEagleMaleName} of {age} months has been added to your eagles habitat!\n");
                return;
            }

            Console.WriteLine("You don't have enough habitat, buy a new one.");

        }
    }


    //removes an eagle of 6 months in the list of the animals (with name search, for when it's sold)
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


    //removes an eagle of 4 years in the list of the animals (with name search, for when it's sold)
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


    //function that removes an eagle of 14 years in the list of the animals (with name search, for when it's sold)
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


    //adds an eagle female in the list of the animals (with age in parameter and name input)
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


    //adds an eagle female in the list of the animals (name and age are chosen in parameter here)
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

                Console.WriteLine($"\n\n\nYour new (female) tiger {chosenTigerFemaleName} of {age} months has been added to your tigers habitat!\n");
                return;
            }
        }
        Console.WriteLine("You don't have enough habitats, buy a new one.");
    }


    //adds an eagle male in the list of the animals (with age in parameter and name input)
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


    //adds an eagle male in the list of the animals (name and age are chosen in parameter here)
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

                Console.WriteLine($"\n\n\nYour new (male) tiger {chosenTigerMaleName} of {age} months has been added to your tigers habitat!\n");
                return;
            }
        }
        Console.WriteLine("You don't have enough habitats, buy a new one.");
    }


    //removes an tiger of 6 months in the list of the animals (with name search, for when it's sold)
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


    //removes an tiger of 4 years in the list of the animals (with name search, for when it's sold)
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


    //removes an tiger of 14 years in the list of the animals (with name search, for when it's sold)
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


    //checks if there's enough habitat when you buy an animal or if the animals of this species reproduct
    public bool EnoughChickenHabitats()
    {
        return numberOfChickens < numberOfChickenHabitats * 10;
    }


    //checks if there's enough habitat when you buy an animal or if the animals of this species reproduct
    public bool EnoughEagleHabitats()
    {
        return numberOfEagles < numberOfEagleHabitats * 4;

    }


    //checks if there's enough habitat when you buy an animal or if the animals of this species reproduct
    public bool EnoughTigerHabitats()
    {
        return numberOfTigers < numberOfTigerHabitats * 2;
    }


    //increases the age of the animals to +1 and sets the "firstMonth" attribute to false
    public void GrowUpAnimalsMonths()
    {
        for (var i = 0; i < _animals.Count; i++)
        {
            _animals[i].GrowUpMonths();
            _animals[i].SetFirstMonthToFalse();
        }
    }


    //checks if the females are pregnant and for how long for the births info etc + adds the new babies in the habitats
    public void CheckGestationTime()
    {
        Random rand = new Random();

        for (var i = _animals.Count - 1; i >= 0; i--)
        {
            if (_animals[i].IsPregnant() == true)
            {
                _animals[i].AddTimeToGestation();

                if (_animals[i].GetGestationTime() == 2 && _animals[i] is Chicken_Female)
                {
                    int randomChoice = rand.Next(2);

                    if (randomChoice == 0)
                    {
                        Console.WriteLine($"[DEATH] A baby chicken of {_animals[i].GetName()} has saddly passed away during birth.");
                    }
                    else
                    {
                        int otherrandomChoice = rand.Next(2);

                        if (otherrandomChoice == 0)
                        {
                            _animals[i].IncrNumberOfKids();

                            addBabyChickenFemale2($"Baby{_animals[i].GetNumberOfKids()} of {_animals[i].GetName()}");
                            Console.WriteLine($"[BIRTH] A baby (female) chicken of {_animals[i].GetName()} is born!");
                        }
                        else
                        {
                            _animals[i].IncrNumberOfKids();

                            addBabyChickenMale2($"Baby{_animals[i].GetNumberOfKids()} of {_animals[i].GetName()}");
                            Console.WriteLine($"[BIRTH] A baby (male) chicken of {_animals[i].GetName()} is born!");
                        }
                    }
                    _animals[i].ResetGestation();
                }
                else if (_animals[i].GetGestationTime() == 2 && _animals[i] is Eagle_Female)
                {
                    int randomChoice = rand.Next(2);

                    if (randomChoice == 0)
                    {
                        Console.WriteLine($"[DEATH] A baby eagle of {_animals[i].GetName()} has saddly passed away during birth.");
                    }
                    else
                    {

                        int otherrandomChoice = rand.Next(2);

                        if (otherrandomChoice == 0)
                        {
                            _animals[i].IncrNumberOfKids();

                            addEagleFemale2($"Baby{_animals[i].GetNumberOfKids()} of {_animals[i].GetName()}", 0);
                            Console.WriteLine($"[BIRTH] A baby (female) eagle of {_animals[i].GetName()} is born!");
                        }
                        else
                        {
                            _animals[i].IncrNumberOfKids();

                            addEagleMale2($"Baby{_animals[i].GetNumberOfKids()} of {_animals[i].GetName()}", 0);
                            Console.WriteLine($"[BIRTH] A baby (male) eagle of {_animals[i].GetName()} is born!");
                        }
                    }
                    _animals[i].ResetGestation();
                }
                else if (_animals[i].GetGestationTime() == 23 && _animals[i] is Tiger_Female) //23 because 1x 3births every 20months + 3months gestation
                {

                    int randomChoice = rand.Next(3);

                    if (randomChoice == 0 || randomChoice == 1)
                    {
                        Console.WriteLine($"[DEATH] A baby tiger of {_animals[i].GetName()} has saddly passed away during birth.");
                    }
                    else
                    {

                        int otherrandomChoice = rand.Next(2);

                        if (otherrandomChoice == 0)
                        {
                            _animals[i].IncrNumberOfKids();

                            addTigerFemale2($"Baby{_animals[i].GetNumberOfKids()} of {_animals[i].GetName()}", 0);
                            Console.WriteLine($"[BIRTH] A baby (female) tiger of {_animals[i].GetName()} is born!");
                        }
                        else
                        {
                            _animals[i].IncrNumberOfKids();

                            addTigerMale2($"Baby{_animals[i].GetNumberOfKids()} of {_animals[i].GetName()}", 0);
                            Console.WriteLine($"[BIRTH] A baby (male) tiger of {_animals[i].GetName()} is born!");
                        }
                    }
                    _animals[i].ResetGestation();
                }
            }
        }
    }


    //verifies if the animals are to aged to still be alive and then make them die if it is the case
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


    //checks if the animals are fed and make them die from starvation if it's not the case
    public void CheckStarvation()

    {

        for (int i = _animals.Count - 1; i >= 0; i--)
        {
            Animal thisAnimal = _animals[i];

            if (thisAnimal.GetHunger() > (thisAnimal.GetDaysBeforeStarvation() * 2))
            {
                Console.WriteLine($"[DEATH] : You didn't feed {thisAnimal.GetName()} for {thisAnimal.GetHunger():F2} days");

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

    //checks if there are enough chickens for one to be sold
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


    //checks if there are enough eagles for one to be sold
    public bool EnoughEagles()
    {
        if (numberOfEagles <= 0)
        {
            return false;
        }
        return true;
    }


    //checks if there are enough tigers for one to be sold
    public bool EnoughTigers()
    {
        if (numberOfTigers <= 0)
        {
            return false;
        }
        return true;
    }


    //checks if there are empty habitats so we can sell them
    public bool RemoveChickenHabitatOk()
    {
        foreach (var habitat in _chickenHabitats)
        {
            if (habitat.NumberOfAnimals == 0)
            {
                return true;
            }
        }
        return false;

    }


    //checks if there are empty habitats so we can sell them
    public bool RemoveEagleHabitatOk()
    {
        foreach (var habitat in _eagleHabitats)
        {
            if (habitat.NumberOfAnimals == 0)
            {
                return true;
            }
        }
        return false;

    }


    //checks if there are empty habitats so we can sell them
    public bool RemoveTigerHabitatOk()
    {
        foreach (var habitat in _tigerHabitats)
        {
            if (habitat.NumberOfAnimals == 0)
            {
                return true;
            }
        }
        return false;
    }


    //makes it possible to sell the habitat and sets all the habitats counts to -1
    public void SellChickenHabitat()
    {
        foreach (var habitat in _chickenHabitats)
        {
            if (RemoveChickenHabitatOk() == true)
            {
                _chickenHabitats.Remove(habitat);
                numberOfChickenHabitats--;
                numberOfHabitats--;
                return;
            }
        }
    }


    //makes it possible to sell the habitat and sets all the habitats counts to -1
    public void SellEagleHabitat()
    {
        foreach (var habitat in _eagleHabitats)
        {
            if (RemoveEagleHabitatOk() == true)
            {
                numberOfEagleHabitats--;
                numberOfHabitats--;
                _eagleHabitats.Remove(habitat);
                return;
            }
        }
    }


    //makes it possible to sell the habitat and sets all the habitats counts to -1
    public void SellTigerHabitat()
    {
        foreach (var habitat in _tigerHabitats)
        {
            if (RemoveTigerHabitatOk() == true)
            {
                numberOfTigerHabitats--;
                numberOfHabitats--;
                _tigerHabitats.Remove(habitat);
                return;
            }
        }
    }

    //Checks if there's a chicken male in the Zoo 
    //(because of architecture problem, I can't verify in each habitat) to do little chickens with the females
    public bool HasAdultChickenMale()
    {
        foreach (var animal in _animals)
        {
            if (animal is Chicken_Male && animal.GetAge() >= 6 && animal.GetAge() < 96) // 96 months = 8 years
            {
                return true;
            }
        }
        return false;
    }


    //checks if there's at least one adult eagle to have baby eagles with a female eagle
    //(because of architecture problem, I can't verify in each habitat)
    public bool HasAdultEagleMale()
    {
        foreach (var animal in _animals)
        {
            if (animal is Eagle_Male && animal.GetAge() >= 48 && animal.GetAge() < 168) // 168 months = 14 years
            {
                return true;
            }
        }
        return false;
    }


    //checks if there's at least one adult tiger to have baby tigers with a female tigers
    //(because of architecture problem, I can't verify in each habitat)
    public bool HasAdultTigerMale()
    {
        foreach (var animal in _animals)
        {
            if (animal is Tiger_Male && animal.GetAge() >= 72 && animal.GetAge() < 168) // 96 months = 8 years
            {
                return true;
            }
        }
        return false;
    }


    //checks if the reproduction is possible for this species
    public void CheckChickensReproduction()
    {
        bool malePresent = HasAdultChickenMale();

        if (malePresent == true)
        {
            foreach (var thisfemale in _animals)
            {
                if (thisfemale is Chicken_Female && !thisfemale.IsPregnant() && !thisfemale.FirstMonth() && EnoughChickenHabitats() == true && !thisfemale.GetIllness())
                {
                    if (thisfemale.GetAge() >= 6 && thisfemale.GetAge() <= 96) // 96 months = 8 years
                    {
                        thisfemale.SetPregnantTrue();
                    }
                }
            }
        }
    }


    //checks if the reproduction is possible for this species
    public void CheckEaglesReproduction(Time time)
    {
        bool malePresent = HasAdultEagleMale();

        if (malePresent == true)
        {
            foreach (var thisfemale in _animals)
            {
                if (thisfemale is Eagle_Female && !thisfemale.IsPregnant() && !thisfemale.FirstMonth() && EnoughEagleHabitats() == true && time.GetCurrentMonth() == 3 && !thisfemale.GetIllness())
                {
                    if (thisfemale.GetAge() >= 48 && thisfemale.GetAge() <= 148) // 148 months = 14 years
                    {
                        thisfemale.SetPregnantTrue();
                    }
                }
            }
        }
    }


    //checks if the reproduction is possible for this species
    public void CheckTigersReproduction()
    {

        bool malePresent = HasAdultTigerMale();

        if (malePresent == true)
        {
            foreach (var thisfemale in _animals)
            {
                if (thisfemale is Tiger_Female && !thisfemale.IsPregnant() && !thisfemale.FirstMonth() && EnoughTigerHabitats() == true && !thisfemale.GetIllness())
                {
                    if (thisfemale.GetAge() >= 48 && thisfemale.GetAge() <= 148) // 148 months = 14 years
                    {
                        thisfemale.SetPregnantTrue();
                    }
                }
            }
        }

    }


    //makes a thief steal an random animal
    public void StolenAnimal()
    {
        if (_animals.Count == 0)
        {
            return;
        }
        Random rand = new Random();

        int randomAnimal = rand.Next(_animals.Count);

        Animal stolenAnimal = _animals[randomAnimal];

        _animals.RemoveAt(randomAnimal);

        numberOfAnimals--;

        Console.WriteLine($"\n[THEFT] Oh no! A thief stole {stolenAnimal.GetName()}...");

        if (stolenAnimal.GetSpecies().Contains("Chicken"))
        {
            numberOfChickens--;
            numberOfAnimals--;
        }
        else if (stolenAnimal.GetSpecies().Contains("Eagle"))
        {
            numberOfEagles--;
            numberOfAnimals--;
        }
        else
        {
            numberOfTigers--;
            numberOfAnimals--;
        }
    }


    //Checks if some animals are going to be sick (so they can't reproduce for example)
    public void CheckIllnesses()
    {
        if (_animals.Count == 0)
        {
            return;
        }

        Random rand = new Random();

        for (int i = _animals.Count - 1; i >= 0; i--)
        {

            var thisAnimal = _animals[i];

            thisAnimal.SetIllnessToFalse();

            if (thisAnimal.GetSpecies().Contains("Chicken"))
            {

                if (rand.Next(100) <= 4) //4% chance per month
                {
                    thisAnimal.SetIllnessToTrue();
                    Console.WriteLine($"[ILLNESS] Oh no! Your chicken {thisAnimal.GetName()} is ill during this month... ");


                    if (rand.Next(10) == 0) //then 10% chance of death caused by illness
                    {

                        Console.WriteLine($"[DEATH] Oh no! Your chicken {thisAnimal.GetName()} passed away from illness... ");

                        _animals.RemoveAt(i);
                        numberOfChickens--;
                        numberOfAnimals--;
                    }
                }
            }
            else if (thisAnimal.GetSpecies().Contains("Eagle"))
            {


                if (rand.Next(100) <= 5) //5%chance per month
                {
                    thisAnimal.SetIllnessToTrue();
                    Console.WriteLine($"[ILLNESS] Oh no! Your eagle {thisAnimal.GetName()} is ill during this month... ");


                    if (rand.Next(10) == 0) //then 10% chance of death caused by illness
                    {

                        Console.WriteLine($"[DEATH] Oh no! Your eagle {thisAnimal.GetName()} passed away from illness... ");

                        _animals.RemoveAt(i);
                        numberOfEagles--;
                        numberOfAnimals--;
                    }
                }
            }
            else if (thisAnimal.GetSpecies().Contains("Tiger"))
            {

                if (rand.Next(100) <= 3) //3% chance per month
                {
                    thisAnimal.SetIllnessToTrue();
                    Console.WriteLine($"[ILLNESS] Oh no! Your tiger {thisAnimal.GetName()} is ill during this month... ");

                    if (rand.Next(10) == 0) //then 10% chance of death caused by illness
                    {

                        Console.WriteLine($"[DEATH] Oh no! Your tiger {thisAnimal.GetName()} passed away from illness... ");

                        _animals.RemoveAt(i);
                        numberOfTigers--;
                        numberOfAnimals--;
                    }
                }
            }
        }
    }


    //Burns a random habitat
    public void BurnRandomHabitat()
    {

        if (numberOfHabitats == 0)
        {
            return;
        }

        List<object> allHabitats = new List<object>();

        foreach (var h in _chickenHabitats) allHabitats.Add(h);
        foreach (var h in _eagleHabitats) allHabitats.Add(h);
        foreach (var h in _tigerHabitats) allHabitats.Add(h);


        Random rand = new Random();

        int index = rand.Next(allHabitats.Count);
        object habitatToBurn = allHabitats[index];

        if (habitatToBurn is Chicken_Habitat ch)
        {
            _chickenHabitats.Remove(ch);
            numberOfChickenHabitats--;

            Console.WriteLine("[EVENT] A fire destroyed a Chicken Habitat! Hurry up, buy anew one.");
        }
        else if (habitatToBurn is Eagle_Habitat eh)
        {
            _eagleHabitats.Remove(eh);
            numberOfEagleHabitats--;
            Console.WriteLine("[EVENT] A fire destroyed an Eagle Habitat! Hurry up, buy anew one.");
        }
        else if (habitatToBurn is Tiger_Habitat th)
        {
            _tigerHabitats.Remove(th);
            numberOfTigerHabitats--;
            Console.WriteLine("[EVENT] A fire destroyed a Tiger Habitat! Hurry up, buy anew one.");
        }

        numberOfHabitats--;
    }


    //checks all the reproduction possibility to make it easier to use in the "PassTheMonth" method
    public void CheckAllReproductions(Time time)
    {
        CheckChickensReproduction();
        CheckEaglesReproduction(time);
        CheckTigersReproduction();
    }


    //Prints an ASCII Zoo art
    public void AsciiZoo()
    {
        Console.WriteLine("\n");
        Console.WriteLine("                           ███████████    ███████       ███████   \n                          ▒█▒▒▒▒▒▒███   ███▒▒▒▒▒███   ███▒▒▒▒▒███ \n █████████████   █████ ████▒     ███▒   ███     ▒▒███ ███     ▒▒███\n▒▒███▒▒███▒▒███ ▒▒███ ▒███      ███    ▒███      ▒███▒███      ▒███\n ▒███ ▒███ ▒███  ▒███ ▒███     ███     ▒███      ▒███▒███      ▒███\n ▒███ ▒███ ▒███  ▒███ ▒███   ████     █▒▒███     ███ ▒▒███     ███ \n █████▒███ █████ ▒▒███████  ███████████ ▒▒▒███████▒   ▒▒▒███████▒  \n▒▒▒▒▒ ▒▒▒ ▒▒▒▒▒   ▒▒▒▒▒███ ▒▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒▒▒▒       ▒▒▒▒▒▒▒    \n                  ███ ▒███                                         \n                 ▒▒██████                                          \n                  ▒▒▒▒▒▒                                           \n");
    }
}
