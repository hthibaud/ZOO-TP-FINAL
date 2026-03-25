using System.Configuration.Assemblies;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

class Program
{
    //initializing all I need in my program to work correctly
    Zoo thisZoo = new Zoo(0, 0, 0, 0);
    BankAccount myAccount = new BankAccount(80000);

    Chicken_Habitat chicken_habitat = new Chicken_Habitat();

    Eagle_Habitat eagle_habitat = new Eagle_Habitat();

    Tiger_Habitat tiger_habitat = new Tiger_Habitat();

    Time time = new Time();

    Food food = new Food();

    SFX sfx = new SFX();

    Visitors visitors = new Visitors();

    //main will launch the program (myProg.Run)
    static void Main()
    {

        Program myProg = new Program();

        SFX sfx = new SFX();

        Console.Clear();


            //Start menu
            sfx.StartMusic("startZooSFX.wav");
            myProg.StartMenu();
            Console.WriteLine("\n\n\n        START? (press enter)");
            Console.ReadLine();
            sfx.PlaySound("clickSFX.wav");
            myProg.Run();

    }

    //Run starts the game/simulation
    public void Run()
    {
        //Starts loop music of the game
        sfx.StartMusic("zoomusic.wav");
        
        bool isPlaying = true;

        while (isPlaying)
        {


            //all the choices we can make in the main menu
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
                    sfx.PlaySound("timeSFX.wav");
                    Console.Clear();
                    PassTheMonth();
                    break;

                case "6":
                    sfx.PlaySound("timeSFX.wav");
                    Console.Clear();
                    PassTheYear();
                    break;

                case "7":
                    SellStuffMenu();
                    break;

                case "i":
                    InitScenario1();
                    break;

            }
        }
    }


    //display of the main menu
    private void ShowMainMenu()
    {
        Console.Clear();
        thisZoo.AsciiZoo();
        myAccount.ShowInfos();
        time.ShowInfos();
        food.ShowInfos();
        Console.WriteLine(" 1. Buy Animals");
        Console.WriteLine(" 2. Buy Habitats");
        Console.WriteLine(" 3. Buy food");
        Console.WriteLine(" 4. View Stats");
        Console.WriteLine(" 5. Pass the month");
        Console.WriteLine(" 6. Pass the year");
        Console.WriteLine(" 7. Sell your stuff to merchant\n");

        Console.WriteLine(" i. (for testing) Initializes the zoo with predefined habitats, animals, food...\n");

        Console.WriteLine(" 0. Exit Game");
        Console.Write("\nChoice: ");
    }


    //menu + code where you can buy your animals
    private void BuyAnimalsMenu()
    {
        sfx.PlaySound("clickSFX.wav");
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
                                sfx.PlaySound("chickenSFX.wav");
                                myAccount.ShowInfos();
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
                                sfx.PlaySound("chickenSFX.wav");
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
                                    sfx.PlaySound("eagleSFX.wav");
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                                else
                                {
                                    thisZoo.addEagleMale(6);
                                    sfx.PlaySound("eagleSFX.wav");
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
                                    sfx.PlaySound("eagleSFX.wav");
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");
                                }
                                else
                                {
                                    thisZoo.addEagleMale(48);
                                    sfx.PlaySound("eagleSFX.wav");
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
                                    sfx.PlaySound("eagleSFX.wav");
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");
                                }
                                else
                                {
                                    thisZoo.addEagleMale(168);
                                    sfx.PlaySound("eagleSFX.wav");
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
                                    sfx.PlaySound("tigerSFX.wav");
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                                else
                                {
                                    thisZoo.addTigerMale(6);
                                    sfx.PlaySound("tigerSFX.wav");
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                                tiger_habitat.AddAnimal();
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
                                    sfx.PlaySound("tigerSFX.wav");
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                                else
                                {
                                    thisZoo.addTigerMale(48);
                                    sfx.PlaySound("tigerSFX.wav");
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
                                    sfx.PlaySound("tigerSFX.wav");
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                                else
                                {
                                    thisZoo.addTigerMale(168);
                                    sfx.PlaySound("tigerSFX.wav");
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


    //menu + code where you can buy your habitats
    private void BuyHabitatsMenu()
    {
        sfx.PlaySound("clickSFX.wav");
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
                        sfx.PlaySound("moneySFX.wav");
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
                        sfx.PlaySound("moneySFX.wav");
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
                        sfx.PlaySound("moneySFX.wav");
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


    //menu where you can choose to see which one of your stats
    private void StatsMenu()
    {
        sfx.PlaySound("clickSFX.wav");
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
                food.ShowInfos();
                myAccount.ShowInfos();
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


    // one of the most important one -> it will be the turn by turn function: 
    //to pass a month every time you want to in the main menu
    private void PassTheMonth()
    {
        time.IncrMonths();
        time.GetCurrentMonthName();
        time.ShowInfos();
        thisZoo.DeathByAge();
        FeedAnimals();
        thisZoo.CheckStarvation();
        HaveVisitors();
        EarnSubvention();
        thisZoo.CheckAllReproductions(time);
        thisZoo.CheckGestationTime();
        thisZoo.GrowUpAnimalsMonths();
        CheckEvents();
        PressKeyToContinue2();
    }


    //just the PassTheMonth function but 12 times to make a year
    private void PassTheYear()
    {
        for (var i = 1; i <= 12; i++)
        {
            PassTheMonth();
        }
    }


    //menu where you can buy food
    public void BuyFoodMenu()
    {
        sfx.PlaySound("clickSFX.wav");
        Console.Clear();
        Console.WriteLine("\n########### Buy food for your animals! ###########\n");

        food.ShowInfos();

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

                if (myAccount.hasError)
                {
                    Console.Clear();
                    Console.WriteLine($"\n{myAccount.errorString}");
                    break;
                }
                else
                {
                    food.IncreaseSeeds(kgSeeds);
                    Console.Clear();
                    sfx.PlaySound("moneySFX");
                    Console.WriteLine($"\nYou bought {kgSeeds}kg of seeds for {food.seedsPricePerKg * kgSeeds}€\n");
                    myAccount.ShowInfos();
                }

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

                if (myAccount.hasError)
                {
                    Console.Clear();
                    Console.WriteLine($"\n{myAccount.errorString}");
                    break;
                }
                else
                {
                    food.IncreaseMeat(kgMeat);
                    Console.Clear();
                    sfx.PlaySound("moneySFX");
                    Console.WriteLine($"\nYou bought {kgMeat}kg of meat for {food.meatPricePerKg * kgMeat}€\n");
                    myAccount.ShowInfos();
                }
                break;
        }
        Console.WriteLine("\n[Press any key to return to Main Menu]");
        Console.ReadLine();
    }


    //function that will let you know what is going on during the month (what animal ate food, what animal didn't)
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
                    Console.WriteLine($"[FEED] {thisAnimal.GetName()} didn't eat for {nbDaysWithoutFeeding} days");
                    Console.WriteLine($"[FEED] {thisAnimal.GetName()} ate only {(kgPerDay * 30) + nbRemainingKg:F2}Kg of seeds.");
                }
                else
                {
                    Console.WriteLine($"[FEED] {thisAnimal.GetName()} ate {kgPerDay * 30:F2}Kg of seeds.");
                }
            }
            else
            {
                double nbRemainingKg = food.DecreaseMeat(kgPerDay * 30);
                if (nbRemainingKg < 0)
                {
                    nbDaysWithoutFeeding = -1 * nbRemainingKg / kgPerDay;
                    Console.WriteLine($"[FEED] {thisAnimal.GetName()} didn't eat for {nbDaysWithoutFeeding} days");
                    Console.WriteLine($"[FEED] {thisAnimal.GetName()} ate only {(kgPerDay * 30) + nbRemainingKg:F2}Kg of meat.");
                }
                else
                {


                    Console.WriteLine($"[FEED] {thisAnimal.GetName()} ate {kgPerDay * 30:F2}Kg of meat.");
                }
            }

            thisAnimal.SetHunger(nbDaysWithoutFeeding);
        }
    }


    //to calculate when you deserve a subvention on the 12th month of the year
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

            Console.WriteLine($"\n[SUBVENTION] You've got an annual subvention of {subvention}€!");

        }
    }


    //calculates how many visitors you'll have during the low season (from to October to April)
    public void HaveVisitors_low()
    {
        float priceVisitors = 0f;
        float nbVisitors = 0;

        for (var i = 0; i < thisZoo._animals.Count; i++)
        {
            priceVisitors += thisZoo._animals[i].GetPriceVisitors_low();
            nbVisitors += thisZoo._animals[i].GetNbVisitors_low();
        }

        visitors.IncrVisitors(nbVisitors);

        myAccount.IncrVisitorsMoney(priceVisitors);
        myAccount.Sell(priceVisitors);

        Console.WriteLine($"\n[VISITORS] The {nbVisitors} visitors payed {priceVisitors}€ in total during the low season.\n");
    }


    //calculates how many visitors you'll have during the high season (from to May to September)
    public void HaveVisitors_high()
    {
        float priceVisitors = 0f;
        float nbVisitors = 0;

        for (var i = 0; i < thisZoo._animals.Count; i++)
        {
            priceVisitors += thisZoo._animals[i].GetPriceVisitors_high();
            nbVisitors += thisZoo._animals[i].GetNbVisitors_high();
        }

        visitors.IncrVisitors(nbVisitors);

        myAccount.IncrVisitorsMoney(priceVisitors);
        myAccount.Sell(priceVisitors);

        Console.WriteLine($"\n[VISITORS] The {nbVisitors} visitors payed {priceVisitors}€ in total during the high season.\n");
    }


    //verifies if you are in a low or high season 
    public void HaveVisitors()
    {
        if (time.GetCurrentMonth() > 9 && time.GetCurrentMonth() < 6)
        {
            HaveVisitors_low();
        }
        else
        {
            HaveVisitors_high();
        }
        myAccount.ShowInfos();
    }


    //just a menu function that says Press key to return to main menu and waits for that key to continue
    public void PressKeyToContinue()
    {
        Console.WriteLine("\n[Press key to return to main menu]");
        Console.ReadLine();
        sfx.PlaySound("clickSFX");
    }


    //just a menu function that says Press key to continue and waits for that key to continue
    public void PressKeyToContinue2()
    {
        Console.WriteLine("\n[Press key to continue]");
        Console.ReadLine();
        sfx.PlaySound("clickSFX");
    }


    //display menu where you can choose what to sell from your zoo
    public void SellStuffMenu()
    {

        Console.Clear();
        Console.WriteLine("\n########### Sell stuff to customers! ###########\n");
        Console.WriteLine("\nWhat do you want to sell?\n");
        Console.WriteLine("1. Sell animals\n2. Sell Habitats\n3. Sell Food");
        Console.Write("\nChoice: ");

        var sellMenuChoice = Console.ReadLine();

        switch (sellMenuChoice)
        {
            case "1":
                SellAnimalsMenu();
                break;

            case "2":
                SellHabitatsMenu();
                break;

            case "3":
                SellFoodMenu();
                break;
        }
    }


    //display menu + code to sell animals from the zoo
    public void SellAnimalsMenu()
    {
        Console.Clear();
        if (thisZoo.numberOfAnimals <= 0)
        {
            Console.WriteLine("You don't have any animal to sell.");
            PressKeyToContinue();
            return;
        }
        Console.WriteLine("\n ########### Sell animals from your Zoo! ########### \n");
        myAccount.ShowInfos();
        Console.WriteLine("\n 1. Chickens \n 2. Eagles \n 3. Tigers \n\n 4. Back");
        Console.Write("\nChoice: ");


        var animal_choice = Console.ReadLine();
        switch (animal_choice)
        {

            case "1":

                if (thisZoo.EnoughChickens() == false)
                {
                    Console.Clear();
                    Console.WriteLine("\nYou don't have any chicken to sell.\n");
                    break;
                }

                if (thisZoo.EnoughChickens() == true)
                {

                    Console.WriteLine("\n 1. Female chicken (6 months): +10€\n 2. Male chicken (6 months): +20€\n 3. Back");

                    var chicken_choice = Console.ReadLine();
                    switch (chicken_choice)
                    {
                        case "1":
                            myAccount.Sell(10);

                            thisZoo.RemoveChickenFemale();
                            chicken_habitat.RemoveAnimal();
                            myAccount.ShowInfos();
                            break;

                        case "2":
                            myAccount.Sell(20);

                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {
                                thisZoo.RemoveChickenMale();
                                chicken_habitat.RemoveAnimal();
                                myAccount.ShowInfos();
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
                if (thisZoo.EnoughEagles() == false)
                {
                    Console.Clear();
                    Console.WriteLine("You don't have any eagle to sell.");
                    break;
                }
                if (thisZoo.EnoughEagles() == true)
                {
                    Console.WriteLine("\n 1. Eagle (6 months) : +500€ \n 2. Eagle (4 years) : +2 000€ \n 3. Eagle (14 years) : +400€ \n 4. Back\n");

                    var eagle_choice = Console.ReadLine();

                    switch (eagle_choice)
                    {

                        case "1":
                            myAccount.Sell(500);

                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {
                                thisZoo.RemoveEagleOf6Months();
                                eagle_habitat.RemoveAnimal();
                                myAccount.ShowInfos();
                            }
                            break;

                        case "2":
                            myAccount.Sell(2000);

                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {

                                thisZoo.RemoveEagleOf4Years();
                                eagle_habitat.RemoveAnimal();
                                myAccount.ShowInfos();

                            }
                            break;

                        case "3":
                            myAccount.Sell(400);

                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {
                                thisZoo.RemoveEagleOf14Years();
                                eagle_habitat.RemoveAnimal();
                                myAccount.ShowInfos();

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

                if (thisZoo.EnoughTigers() == false)
                {
                    Console.Clear();
                    Console.WriteLine("\nYou don't have any tiger to sell.\n");
                    break;
                }
                if (thisZoo.EnoughTigerHabitats() == true)
                {
                    Console.WriteLine("\n 1. Tiger (6 months) : +1500€ \n 2. Tiger (4 years) : +60 000€ \n 3. Tiger (14 years) : +10 000€ \n 4. Back\n");

                    var tiger_choice = Console.ReadLine();

                    switch (tiger_choice)
                    {

                        case "1":
                            myAccount.Sell(1500);
                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {
                                thisZoo.RemoveTigerOf6Months();
                                tiger_habitat.RemoveAnimal();
                                myAccount.ShowInfos();
                            }
                            break;

                        case "2":
                            myAccount.Sell(60000);
                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {
                                thisZoo.RemoveTigerOf4Years();
                                tiger_habitat.RemoveAnimal();
                                myAccount.ShowInfos();
                            }
                            break;

                        case "3":
                            myAccount.Sell(10000);
                            if (myAccount.hasError)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{myAccount.errorString}");
                            }
                            else
                            {
                                thisZoo.RemoveTigerOf14Years();
                                tiger_habitat.RemoveAnimal();
                                myAccount.ShowInfos();
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


    //display menu + code to sell food from the zoo to "customers"
    public void SellFoodMenu()
    {
        Console.Clear();
        Console.WriteLine("\n########### Sell food to customers! ###########\n");
        myAccount.ShowInfos();
        food.ShowInfos();

        if (food.GetMeatKg() <= 0 && food.GetSeedsKg() <= 0)
        {
            Console.WriteLine("You don't have any food to sell.");
            PressKeyToContinue();
            return;
        }

        Console.WriteLine("\n1. Seeds: +2.5€/Kg\n2. Meat: +5€/Kg\n");
        Console.Write("\nChoice: ");

        var food_choice = Console.ReadLine();
        switch (food_choice)
        {

            case "1":

                int kgSeeds;

                while (true)
                {
                    Console.WriteLine("\nHow many Kg of seeds do you want to sell?\n");

                    var StrKgSeeds = Console.ReadLine();
                    if (int.TryParse(StrKgSeeds, out kgSeeds))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input");
                }
                if (kgSeeds > food.GetSeedsKg())
                {
                    Console.WriteLine($"You don't have {kgSeeds}kg seeds to sell");
                    PressKeyToContinue();
                    return;
                }
                myAccount.Sell(kgSeeds * food.seedsPricePerKg);
                food.DecreaseSeeds(kgSeeds);
                Console.Clear();
                Console.WriteLine($"\nYou sold {kgSeeds}kg of seeds for {food.seedsPricePerKg * kgSeeds}€ to a customer!\n");
                myAccount.ShowInfos();
                break;

            case "2":

                int kgMeat;

                while (true)
                {
                    Console.WriteLine("\nHow many kg of meat do you want to sell?\n");

                    var StrKgMeat = Console.ReadLine();
                    if (int.TryParse(StrKgMeat, out kgMeat))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input");
                }
                if (kgMeat > food.GetMeatKg())
                {
                    Console.WriteLine($"You don't have {kgMeat}kg meat to sell");
                    PressKeyToContinue();
                    return;
                }
                myAccount.Sell(kgMeat * food.meatPricePerKg);
                food.DecreaseMeat(kgMeat);
                Console.Clear();
                Console.WriteLine($"\nYou sold {kgMeat}kg of meat for {food.meatPricePerKg * kgMeat}€ to a customer!\n");
                myAccount.ShowInfos();
                break;
        }
        Console.WriteLine("\n[Press any key to return to Main Menu]");
        Console.ReadLine();
    }


    //display menu + code to sell habitats from the zoo to "customers"
    public void SellHabitatsMenu()
    {

        Console.Clear();
        if (thisZoo.numberOfHabitats <= 0)
        {
            Console.WriteLine("You don't have any habitat to sell.");
            PressKeyToContinue();
            return;
        }
        Console.WriteLine("\n ########### Sell habitats from your Zoo! ########### \n");
        myAccount.ShowInfos();
        Console.WriteLine("\n 1. Chickens habitat: +50€\n 2. Eagles habitat: +500€\n 3. Tigers habitat: +500€\n\n 4. Back");
        Console.Write("\nChoice: ");

        var sellHabitatsChoice = Console.ReadLine();
        switch (sellHabitatsChoice)
        {
            case "1":
                if (thisZoo.RemoveChickenHabitatOk() == false)
                {
                    Console.Clear();
                    Console.WriteLine("\nAll your chickens habitats are occupied to sell.\n");
                    break;
                }

                if (thisZoo.RemoveChickenHabitatOk() == true)
                {

                    Console.WriteLine("\nSell chickens habitat for 50€? (type yes or no)\n");

                    var chicken_choice = Console.ReadLine();
                    switch (chicken_choice)
                    {
                        case "yes":
                            myAccount.Sell(50);
                            thisZoo.SellChickenHabitat();
                            Console.Clear();
                            Console.WriteLine("\nYour chickens habitat has been sold for 50€!\n");
                            myAccount.ShowInfos();

                            break;

                        case "no":
                            break;

                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                }
                break;

            case "2":
                if (thisZoo.RemoveEagleHabitatOk() == false)
                {
                    Console.Clear();
                    Console.WriteLine("All your eagles habitats are occupied.");
                    break;
                }
                if (thisZoo.RemoveEagleHabitatOk() == true)
                {
                    Console.WriteLine("\nSell eagles habitat for 500€? (type yes or no)\n");

                    var eagle_choice = Console.ReadLine();

                    switch (eagle_choice)
                    {

                        case "yes":
                            myAccount.Sell(500);
                            thisZoo.SellEagleHabitat();
                            Console.Clear();
                            Console.WriteLine("\nYour eagles habitat has been sold for 500€!\n");
                            myAccount.ShowInfos();
                            break;

                        case "no":
                            break;

                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                    break;
                }
                break;

            case "3":

                if (thisZoo.RemoveTigerHabitatOk() == false)
                {
                    Console.Clear();
                    Console.WriteLine("\nAll your tigers habitats are occupied.\n");
                    break;
                }
                if (thisZoo.RemoveTigerHabitatOk() == true)
                {
                    Console.WriteLine("\n Sell tigers habitat for 500€? (type yes or no)\n");

                    var tiger_choice = Console.ReadLine();

                    switch (tiger_choice)
                    {

                        case "yes":
                            myAccount.Sell(500);
                            thisZoo.SellTigerHabitat();
                            Console.Clear();
                            Console.WriteLine("\nYour tigers habitat has been sold for 500€!\n");
                            myAccount.ShowInfos();
                            break;

                        case "no":
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


    //Checks for rotten meat or bad seeds
    public void CheckFood()
    {
        Random rand = new Random();
        var random20 = rand.Next(5); //number between 0 & 4 so 1/5chance so 20%
        var random10 = rand.Next(10); //number bewteen 0 & 10 so 1/10chance so 10%

        if (random20 == 0)
        {
            food.BadSeeds();
            Console.WriteLine("\n[SILO] You lost 10% of your seeds this month because of insects.");
        }

        if (random10 == 0)
        {
            food.BeRotten();
            Console.WriteLine("\n[COLD-CHAMBER] 20% of your meat has rotten this month.");
        }
        else
        {
            return;
        }
    }


    //Checks for thiefs (1% chance to steal a random animal)
    public void CheckThiefs()
    {
        Random rand = new Random();
        var random1 = rand.Next(100); //number between 0 & 99 so 1/100chance so 1% chance

        if (random1 == 0)
        {
            thisZoo.StolenAnimal();
        }
    }


    //Checks for fires (1% chance to burn a random habitat)
    public void CheckFire()
    {
        Random rand = new Random();
        var random1 = rand.Next(100); //number between 0 & 99 so 1/100chance so 1% chance

        if (random1 == 0)
        {
            thisZoo.BurnRandomHabitat();
        }
    }


    //Checks all events 
    public void CheckEvents()
    {
        CheckFood();
        CheckThiefs();
        CheckFire();
    }

    public void StartMenu()
    {
        Console.Clear();
        thisZoo.AsciiZoo();
    }

    //Initializes the scenario 1 (for testing) that gives you directly :
    //1 habitat for each animal 
    //6 chickens, 3 eagles and 1 tiger
    //5000Kg of meat and 1000Kg of seeds
    public void InitScenario1()
    {
        myAccount.Buy(300);
        thisZoo.addChickenHabitat();
        myAccount.Buy(2000);
        thisZoo.addTigerHabitat();
        myAccount.Buy(2000);
        thisZoo.addEagleHabitat();


        myAccount.Buy(20);
        thisZoo.addChickenFemale2("Poulette");
        chicken_habitat.AddAnimal();

        myAccount.Buy(20);
        thisZoo.addChickenFemale2("Poulette2");
        chicken_habitat.AddAnimal();

        myAccount.Buy(20);
        thisZoo.addChickenFemale2("Poulette3");
        chicken_habitat.AddAnimal();

        myAccount.Buy(100);
        thisZoo.addChickenMale2("Pouletto");
        chicken_habitat.AddAnimal();

        myAccount.Buy(100);
        thisZoo.addChickenMale2("Pouletto2");
        chicken_habitat.AddAnimal();

        myAccount.Buy(100);
        thisZoo.addChickenMale2("Pouletto3");
        chicken_habitat.AddAnimal();


        myAccount.Buy(3000);
        thisZoo.addTigerFemale2("Tigrette", 6);
        tiger_habitat.AddAnimal();


        myAccount.Buy(1000);
        thisZoo.addEagleMale2("Aiglou", 6);
        eagle_habitat.AddAnimal();

        myAccount.Buy(1000);
        thisZoo.addEagleFemale2("Aiglette", 6);
        eagle_habitat.AddAnimal();

        myAccount.Buy(1000);
        thisZoo.addEagleFemale2("Aiglette2", 6);
        eagle_habitat.AddAnimal();


        myAccount.Buy(35000);
        food.IncreaseMeat(7000);

        myAccount.Buy(2500);
        food.IncreaseSeeds(1000);
    }
}
