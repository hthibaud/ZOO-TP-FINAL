using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

class Program
{
    Zoo thisZoo = new Zoo(0, 0, 0, 0);
    BankAccount myAccount = new BankAccount(80000);

    Chicken_Habitat chicken_habitat = new Chicken_Habitat();

    Time time = new Time();

    Food food = new Food();
    static void Main()
    {
        Program myProg = new Program();

        Console.Clear();

        myProg.run();

    }
    public void run()
    {
        bool isPlaying = true;

        while (isPlaying)
        {

            ShowMainMenu();

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    Console.WriteLine("Goodbye!");
                    isPlaying = false;
                    break;

                case "1":
                    BuyAnimalsMenu();
                    break;

                case "2":
                    BuyHabitatsMenu();
                    break;

                case "3":
                    BuyFoodMenu();
                    break;


                case "4":
                    StatsMenu();
                    break;


                case "5":
                    PassTheMonth();
                    break;

                case "6":
                    PassTheYear();
                    break;


            }
            //Console.Clear();
        }
    }



    private void ShowMainMenu()
    {
        Console.Clear();
        Console.WriteLine("\n\n########### WELCOME TO YOUR ZOO ###########\n");
        myAccount.ShowInfos();
        time.ShowInfos();
        Console.WriteLine(" 1. Buy Animals");
        Console.WriteLine(" 2. Buy Habitats");
        Console.WriteLine(" 3. Buy food");
        Console.WriteLine(" 4. View Stats");
        Console.WriteLine(" 5. Pass the month");
        Console.WriteLine(" 6. Pass the year");
        Console.WriteLine(" 0. Exit Game");
        Console.Write("\nChoice: ");
    }

    private void BuyAnimalsMenu()
    {
        Console.Clear();
        Console.WriteLine("\n ########### Buy an animal for your Zoo! ########### \n");
        Console.WriteLine("\n 1. Chickens \n 2. Eagles \n 3. Tigers \n\n 4. Back");
        Console.Write("\nChoice: ");


        var animal_choice = Console.ReadLine();
        switch (animal_choice)
        {

            case "1":

                if (thisZoo.EnoughChickenHabitats() == false)
                {
                    Console.Clear();
                    Console.WriteLine("\nYou don't have enough habitats, buy a new one.\n");
                    break;
                }

                if (thisZoo.EnoughChickenHabitats() == true)
                {

                    Console.WriteLine("\n 1. Female chicken (6 months) : 20€\n 2. Male chicken (6 months) : 100€\n 3. Back");

                    var chicken_choice = Console.ReadLine();
                    switch (chicken_choice)
                    {
                        case "1":
                            myAccount.Buy(20);

                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {

                                thisZoo.addChickenFemale();
                                chicken_habitat.AddAnimal();
                                Console.WriteLine($"Balance : {myAccount.currentMoney}");

                            }

                            break;

                        case "2":
                            myAccount.Buy(100);

                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {
                                thisZoo.addChickenMale();
                                chicken_habitat.AddAnimal();
                                Console.WriteLine($"Balance : {myAccount.currentMoney}");
                            }
                            break;


                        case "3":
                            break;

                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                }
                break;

            case "2":
                if (thisZoo.EnoughEagleHabitats() == false)
                {
                    Console.Clear();
                    Console.WriteLine("You don't have enough habitats, buy a new one.");
                    break;
                }
                if (thisZoo.EnoughEagleHabitats() == true)
                {
                    Console.WriteLine("\n 1. Eagle (6 months) : 1000€ \n 2. Eagle (4 years) : 4 000€ \n 3. Eagle (14 years) : 2 000€ \n 4. Back\n");

                    var eagle_choice = Console.ReadLine();

                    Random rand = new Random();
                    int randomChoice = rand.Next(2);

                    switch (eagle_choice)
                    {

                        case "1":
                            myAccount.Buy(1000);

                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {
                                if (randomChoice == 0)
                                {

                                    thisZoo.addEagleFemale(6);
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                                else
                                {
                                    thisZoo.addEagleMale(6);
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                            }
                            break;

                        case "2":
                            myAccount.Buy(4000);

                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {
                                if (randomChoice == 0)
                                {
                                    thisZoo.addEagleFemale(48); //48 months = 4 years
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");
                                }
                                else
                                {
                                    thisZoo.addEagleMale(48);
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");
                                }
                            }
                            break;

                        case "3":
                            myAccount.Buy(2000);

                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {
                                if (randomChoice == 0)
                                {
                                    thisZoo.addEagleFemale(168); //168 months = 14 years
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");
                                }
                                else
                                {
                                    thisZoo.addEagleMale(168);
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");
                                }
                            }
                            break;

                        case "4":
                            break;

                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                    break;
                }
                break;

            case "3":

                if (thisZoo.EnoughTigerHabitats() == false)
                {
                    Console.Clear();
                    Console.WriteLine("\nYou don't have enough habitats, buy a new one.\n");
                    break;
                }
                if (thisZoo.EnoughTigerHabitats() == true)
                {
                    Console.WriteLine("\n 1. Tiger (6 months) : 3000€ \n 2. Tiger (4 years) : 120 000€ \n 3. Tiger (14 years) : 60 000€ \n 4. Back\n");

                    var tiger_choice = Console.ReadLine();

                    Random rand = new Random();
                    int randomChoice = rand.Next(2);

                    switch (tiger_choice)
                    {

                        case "1":
                            myAccount.Buy(3000);
                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");

                            }
                            else
                            {
                                if (randomChoice == 0)
                                {
                                    thisZoo.addTigerFemale(6);
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                                else
                                {
                                    thisZoo.addTigerMale(6);
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                            }
                            break;

                        case "2":
                            myAccount.Buy(120000);
                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {

                                if (randomChoice == 0)
                                {
                                    thisZoo.addTigerFemale(48); //48 months = 4 years
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                                else
                                {
                                    thisZoo.addTigerMale(48);
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                            }
                            break;

                        case "3":
                            myAccount.Buy(60000);
                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {

                                if (randomChoice == 0)
                                {
                                    thisZoo.addTigerFemale(168); //168 months = 14 years
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                                else
                                {
                                    thisZoo.addTigerMale(168);
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                            }
                            break;

                        case "4":
                            break;

                        default:
                            Console.WriteLine("invalid choice");
                            break;


                    }
                    break;
                }
                break;
        }
        Console.WriteLine("\n[Press any key to return to Main Menu]");
        Console.ReadLine();
    }

    private void BuyHabitatsMenu()
    {
        Console.Clear();
        Console.WriteLine("\n ########### Buy an habitat for your Zoo! ########### \n");
        Console.WriteLine("\n 1.Chicken habitat (10 chickens)\n 2.Eagle habitat (4 eagles) \n 3.Tiger habitat (2 tigers)\n");
        Console.Write("\nChoice: ");


        var habitat_choice = Console.ReadLine();

        switch (habitat_choice)
        {
            case "1":

                Console.WriteLine("\n Buy a chicken habitat (10 chickens) for 300€? (type yes or no)\n");

                var confirm_chicken_habitat_choice = Console.ReadLine();

                switch (confirm_chicken_habitat_choice)
                {
                    case "yes":
                        myAccount.Buy(300);
                        Console.WriteLine($"Balance : {myAccount.currentMoney}");
                        thisZoo.addChickenHabitat();
                        break;

                    case "no":
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                break;

            case "2":

                Console.WriteLine("\n Buy an eagle habitat (4 eagles) for 2000€? (type yes or no)\n");

                var confirm_eagle_habitat_choice = Console.ReadLine();
                switch (confirm_eagle_habitat_choice)
                {
                    case "yes":
                        myAccount.Buy(2000);
                        Console.WriteLine($"Balance : {myAccount.currentMoney}");
                        thisZoo.addEagleHabitat();
                        break;

                    case "no":
                        break;

                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                break;

            case "3":

                Console.WriteLine("\n Buy a tiger habitat (2 tigers) for 2000€? (type yes or no)\n");

                var confirm_tiger_habitat_choice = Console.ReadLine();
                switch (confirm_tiger_habitat_choice)
                {
                    case "yes":
                        myAccount.Buy(2000);
                        thisZoo.addTigerHabitat();
                        Console.WriteLine($"Balance : {myAccount.currentMoney}");
                        break;

                    case "no":
                        break;

                    default:
                        Console.WriteLine("invalid choice");
                        break;

                }
                break;

            default:
                Console.WriteLine("invalid choice");
                break;

        }
        Console.WriteLine("\n[Press any key to return to Main Menu]");
        Console.ReadLine();
    }

    private void StatsMenu()
    {
        Console.Clear();
        Console.WriteLine("\n ########### ALL STATS! ########### \n");
        Console.WriteLine("\n 1. See details of chickens\n 2. See details of eagles\n 3. See details of tigers\n 4. See Zoo stats \n 5. Back");
        Console.Write("\nChoice: ");


        var detailchoice = Console.ReadLine();

        switch (detailchoice)
        {
            case "1":
                thisZoo.ShowChickensDetailedInfo();
                break;

            case "2":
                thisZoo.ShowEaglesDetailedInfo();
                break;

            case "3":
                thisZoo.ShowTigersDetailedInfo();
                break;

            case "4":
                thisZoo.ShowInfo();
                food.ShowInfo();
                Console.WriteLine($"Balance : {myAccount.currentMoney}");
                break;

            case "5":
                break;

            default:
                Console.WriteLine("invalid choice");
                break;
        }
        Console.WriteLine("\n[Press any key to return to Main Menu]");
        Console.ReadLine();
    }

    private void PassTheMonth()
    {

        time.IncrMonths();
        thisZoo.GrowUpAnimalsMonths();
        thisZoo.DeathByAge();
        FeedAnimals();
        thisZoo.CheckStarvation();
        EarnSubvention();
        //animals update

    }

    private void PassTheYear()
    {

        time.IncrYears();
        thisZoo.GrowUpAnimalsYears();
        thisZoo.DeathByAge();
        FeedAnimals();
        thisZoo.CheckStarvation();
        EarnSubvention();
        //animals update
    }

    public void BuyFoodMenu()
    {
        Console.Clear();
        Console.WriteLine("\n########### Buy food for your animals! ###########\n");

        food.ShowInfo();

        Console.WriteLine("\n1. Seeds\n2. Meat \n");
        Console.Write("\nChoice: ");

        var animal_choice = Console.ReadLine();
        switch (animal_choice)
        {

            case "1":

                int kgSeeds;

                while (true)
                {
                    Console.WriteLine("\nHow many Kg of seeds do you want?\n");

                    var StrKgSeeds = Console.ReadLine();
                    if (int.TryParse(StrKgSeeds, out kgSeeds))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input");
                }
                myAccount.Buy(kgSeeds * food.seedsPricePerKg);
                food.IncreaseSeeds(kgSeeds);
                Console.Clear();
                Console.WriteLine($"\nYou bought {kgSeeds}kg of seeds for {food.seedsPricePerKg * kgSeeds}€\n");
                Console.WriteLine($"Balance : {myAccount.currentMoney}");
                break;

            case "2":

                int kgMeat;

                while (true)
                {
                    Console.WriteLine("\nHow many kg of meat do you want?\n");

                    var StrKgMeat = Console.ReadLine();
                    if (int.TryParse(StrKgMeat, out kgMeat))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input");
                }
                myAccount.Buy(kgMeat * food.meatPricePerKg);
                food.IncreaseMeat(kgMeat);
                Console.Clear();
                Console.WriteLine($"\nYou bought {kgMeat}kg of meat for {food.meatPricePerKg * kgMeat}€\n");
                Console.WriteLine($"Balance : {myAccount.currentMoney}€");
                break;
        }
        Console.WriteLine("\n[Press any key to return to Main Menu]");
        Console.ReadLine();
    }

    public void FeedAnimals()
    {
        for (var i = 0; i < thisZoo._animals.Count; i++)
        {
            double kgPerDay = thisZoo._animals[i].GetKgPerDay();
            double nbDaysWithoutFeeding = 0;
            Animal thisAnimal = thisZoo._animals[i];


            if (thisAnimal.GetSpecies().Contains("Chicken"))
            {
                double nbRemainingKg = food.DecreaseSeeds(kgPerDay * 30);

                if (nbRemainingKg < 0)
                {
                    nbDaysWithoutFeeding = -1 * nbRemainingKg / kgPerDay;
                }

                Console.WriteLine($"Your animal {thisAnimal} didn't eat for {nbDaysWithoutFeeding} days");

            }
            else
            {
                double nbRemainingKg = food.DecreaseMeat(kgPerDay * 30);
                if (nbRemainingKg < 0)
                {
                    nbDaysWithoutFeeding = -1 * nbRemainingKg / kgPerDay;
                }
                Console.WriteLine($"Your animal {thisAnimal} didn't eat for {nbDaysWithoutFeeding} days");
            }

            thisAnimal.SetHunger(nbDaysWithoutFeeding);
        }
    }

    public void EarnSubvention()
    {
        int subvention = 0;
        if (myAccount.GetNbSubvention() != time.GetNbYears())
        {            
            for (var i = 0; i < thisZoo._animals.Count; i++)
            {
                subvention += thisZoo._animals[i].GetSubvention();

            }

            myAccount.IncrSubventions();
            myAccount.Sell(subvention);

        }
    }
}
