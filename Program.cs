using System.Configuration.Assemblies;
using System.Linq.Expressions;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

class Program
{
    //initializing all I need in my program to work correctly
    Zoo thisZoo = new Zoo(0, 0, 0, 0);
    BankAccount myAccount = new BankAccount(80000);

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


        string title = "\u001b[1m";
        string green = "\u001b[32m";
        string reset = "\u001b[0m";

        //Start menu
        sfx.StartSFXMusic("startZooSFX.wav");
        myProg.StartMenu();
        Console.WriteLine($"\n\n\n{title}{green}         START? {reset}(press enter)");
        Console.ReadLine();
        sfx.PlaySound("clickSFX.wav");
        myProg.Run();

    }

    //Run starts the game/simulation
    bool isPlaying = true;
    public void Run()
    {
        //Starts loop music of the game
        sfx.StartMusic("zoomusic.wav");

        while (isPlaying)
        {


            //all the choices we can make in the main menu
            ShowMainMenu();

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "0":

                    Console.WriteLine("Goodbye!");
                    sfx.StopMusic();
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
        thisZoo.ShowInfoStart();
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

        string yellow = "\u001b[33m";
        string reset = "\u001b[0m";
        string title = "\u001b[1m";

        sfx.PlaySound("clickSFX.wav");
        Console.Clear();
        Console.WriteLine($"\n{title}########### Buy an animal for your Zoo! ###########{reset}\n");
        Console.WriteLine("\n 1. Chickens \n 2. Eagles \n 3. Tigers \n\n 4. Back");
        myAccount.ShowInfos();
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

                    Console.WriteLine($"\n 1. Female chicken (6 months) : {title}{yellow}20€{reset}\n 2. Male chicken (6 months) : {title}{yellow}100€{reset}\n 3. Back");

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
                if (thisZoo.EnoughEagleHabitats() == false)
                {
                    Console.Clear();
                    Console.WriteLine("You don't have enough habitats, buy a new one.");
                    break;
                }
                if (thisZoo.EnoughEagleHabitats() == true)
                {
                    Console.WriteLine($"\n 1. Eagle (6 months) : {title}{yellow}1000€{reset} \n 2. Eagle (4 years) : {title}{yellow}4 000€{reset} \n 3. Eagle (14 years) : {title}{yellow}2 000€{reset} \n 4. Back\n");

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
                                    myAccount.ShowInfos();

                                }
                                else
                                {
                                    thisZoo.addEagleMale(6);
                                    sfx.PlaySound("eagleSFX.wav");
                                    myAccount.ShowInfos();

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
                                    myAccount.ShowInfos();
                                }
                                else
                                {
                                    thisZoo.addEagleMale(48);
                                    sfx.PlaySound("eagleSFX.wav");
                                    myAccount.ShowInfos();
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
                                    myAccount.ShowInfos();
                                }
                                else
                                {
                                    thisZoo.addEagleMale(168);
                                    sfx.PlaySound("eagleSFX.wav");
                                    myAccount.ShowInfos();
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
                    Console.WriteLine($"\n 1. Tiger (6 months) : {title}{yellow}3 000€{reset} \n 2. Tiger (4 years) : {title}{yellow}120 000€{reset} \n 3. Tiger (14 years) : {title}{yellow}60 000€{reset} \n 4. Back\n");

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
                                    myAccount.ShowInfos();
                                }
                                else
                                {
                                    thisZoo.addTigerMale(6);
                                    sfx.PlaySound("tigerSFX.wav");
                                    myAccount.ShowInfos();

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
                                    sfx.PlaySound("tigerSFX.wav");
                                    myAccount.ShowInfos();

                                }
                                else
                                {
                                    thisZoo.addTigerMale(48);
                                    sfx.PlaySound("tigerSFX.wav");
                                    myAccount.ShowInfos();

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
                                    myAccount.ShowInfos();

                                }
                                else
                                {
                                    thisZoo.addTigerMale(168);
                                    sfx.PlaySound("tigerSFX.wav");
                                    myAccount.ShowInfos();
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
        PressKeyToContinue();
    }


    //menu + code where you can buy your habitats, and how many of them
    private void BuyHabitatsMenu()
    {

        string green = "\u001b[32m";
        string yellow = "\u001b[33m";
        string reset = "\u001b[0m";
        string title = "\u001b[1m";

        sfx.PlaySound("clickSFX.wav");
        Console.Clear();
        Console.WriteLine($"\n{title}########### Buy an habitat for your Zoo! ###########{reset}\n");
        Console.WriteLine($"\n1. Chicken habitat (10 chickens): {title}{yellow}300€{reset}");
        Console.WriteLine($"2. Eagle habitat (4 eagles): {title}{yellow}2 000€{reset}");
        Console.WriteLine($"3. Tiger habitat (2 tigers): {title}{yellow}2 000€{reset}");
        Console.WriteLine("\n4. Back\n");
        myAccount.ShowInfos();
        Console.Write("\nChoice: ");

        var choice = Console.ReadLine();
        if (choice == "4") return;

        Console.WriteLine("\nHow many habitats do you want to build?");
        if (!int.TryParse(Console.ReadLine(), out int amount) || amount <= 0 || amount > 10)
        {
            Console.WriteLine("Invalid amount! (you can't buy more than 10 habitats at once)");
            PressKeyToContinue();
            return;
        }

        switch (choice)
        {
            case "1":
                int totalCostChicken = amount * 300;

                myAccount.Buy(totalCostChicken);

                if (!myAccount.hasError)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        thisZoo.addChickenHabitat();
                    }
                    sfx.PlaySound("building.wav");
                    Console.WriteLine($"{green}Successfully built {title}{amount}{reset} {green}chicken habitats!{reset}");
                }
                break;

            case "2":
                int totalCostEagle = amount * 2000;

                myAccount.Buy(totalCostEagle);

                if (!myAccount.hasError)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        thisZoo.addEagleHabitat();
                    }
                    sfx.PlaySound("building.wav");
                    Console.WriteLine($"{green}Successfully built {title}{amount}{reset} {green}eagle habitats!{reset}");
                }
                break;

            case "3":
                int totalCostTiger = amount * 2000;

                myAccount.Buy(totalCostTiger);

                if (!myAccount.hasError)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        thisZoo.addTigerHabitat();
                    }
                    sfx.PlaySound("building.wav");
                    Console.WriteLine($"{green}Successfully built {title}{amount}{reset} {green}tiger habitats!{reset}");
                }
                break;
        }

        if (myAccount.hasError) Console.WriteLine($"{myAccount.errorString}");
        PressKeyToContinue();
    }


    //     var habitat_choice = Console.ReadLine();

    //     switch (habitat_choice)
    //     {
    //         case "1":

    //             Console.WriteLine($"\nBuy a chicken habitat (max.10 chickens) for {title}{yellow}300€{reset}? (type yes or no)\n");

    //             var confirm_chicken_habitat_choice = Console.ReadLine();

    //             switch (confirm_chicken_habitat_choice)
    //             {
    //                 case "yes":
    //                     myAccount.Buy(300);
    //                     myAccount.ShowInfos();
    //                     sfx.PlaySound("moneySFX.wav");
    //                     sfx.PlaySound("building.wav");
    //                     thisZoo.addChickenHabitat();
    //                     break;

    //                 case "no":
    //                     break;
    //                 default:
    //                     Console.WriteLine("invalid choice");
    //                     break;
    //             }
    //             break;

    //         case "2":

    //             Console.WriteLine($"\nBuy an eagle habitat (max.4 eagles) for {title}{yellow}2 000€{reset}? (type yes or no)\n");

    //             var confirm_eagle_habitat_choice = Console.ReadLine();
    //             switch (confirm_eagle_habitat_choice)
    //             {
    //                 case "yes":
    //                     myAccount.Buy(2000);
    //                     sfx.PlaySound("moneySFX.wav");
    //                     sfx.PlaySound("building.wav");
    //                     myAccount.ShowInfos();
    //                     thisZoo.addEagleHabitat();
    //                     break;

    //                 case "no":
    //                     break;

    //                 default:
    //                     Console.WriteLine("invalid choice");
    //                     break;
    //             }
    //             break;

    //         case "3":

    //             Console.WriteLine($"\nBuy a tiger habitat (max.2 tigers) for {title}{yellow}2 000€{reset}? (type yes or no)\n");

    //             var confirm_tiger_habitat_choice = Console.ReadLine();
    //             switch (confirm_tiger_habitat_choice)
    //             {
    //                 case "yes":
    //                     myAccount.Buy(2000);
    //                     sfx.PlaySound("moneySFX.wav");
    //                     sfx.PlaySound("building.wav");
    //                     thisZoo.addTigerHabitat();
    //                     myAccount.ShowInfos();
    //                     break;

    //                 case "no":
    //                     break;

    //                 default:
    //                     Console.WriteLine("invalid choice");
    //                     break;

    //             }
    //             break;

    //         case "4":
    //             return;

    //         default:
    //             Console.WriteLine("invalid choice");
    //             break;

    //     }
    //     PressKeyToContinue();
    // }


    //menu where you can choose to see which one of your stats
    private void StatsMenu()
    {
        string title = "\u001b[1m";
        string reset = "\u001b[0m";

        sfx.PlaySound("clickSFX.wav");
        Console.Clear();
        Console.WriteLine($"{title}\n########### ALL STATS! ###########{reset}\n");
        Console.WriteLine("\n 1. See details of chickens\n 2. See details of eagles\n 3. See details of tigers\n 4. See Zoo stats \n 5. Back");
        Console.Write("\nChoice: ");


        var detailchoice = Console.ReadLine();

        switch (detailchoice)
        {
            case "1":
                thisZoo.ShowChickensDetailedInfo();
                sfx.PlaySound("chickenSFX.wav");
                break;

            case "2":
                thisZoo.ShowEaglesDetailedInfo();
                sfx.PlaySound("eagleSFX.wav");
                break;

            case "3":
                thisZoo.ShowTigersDetailedInfo();
                sfx.PlaySound("tigerSFX.wav");
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
        PressKeyToContinue();
    }


    // one of the most important one -> it will be the turn by turn function: 
    //to pass a month every time you want to in the main menu
    private void PassTheMonth()
    {
        time.IncrMonths();
        time.GetCurrentMonthName();
        time.ShowInfos();
        thisZoo.DeathByAge();
        thisZoo.CheckIllnesses();
        FeedAnimals();
        thisZoo.CheckStarvation();
        HaveVisitors();
        EarnSubvention();
        thisZoo.CheckAllReproductions(time);
        thisZoo.CheckGestationTime();
        thisZoo.GrowUpAnimalsMonths();
        CheckEvents();
        PressKeyToContinue2();
        CheckLoseCondition();
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
        string yellow = "\u001b[33m";
        string reset = "\u001b[0m";
        string title = "\u001b[1m";

        sfx.PlaySound("clickSFX.wav");

        Console.Clear();
        Console.WriteLine($"\n{title}########### Buy food for your animals! ###########{reset}\n");

        myAccount.ShowInfos();

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
                    sfx.PlaySound("moneySFX.wav");
                    sfx.PlaySound("seeds.wav");
                    Console.WriteLine($"\nYou bought {kgSeeds}kg of seeds for {title}{yellow}{food.seedsPricePerKg * kgSeeds}€{reset}\n");
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
                    sfx.PlaySound("moneySFX.wav");
                    sfx.PlaySound("meat.wav");
                    Console.WriteLine($"\nYou bought {kgMeat}kg of meat for {title}{yellow}{food.meatPricePerKg * kgMeat}€{reset}\n");
                    myAccount.ShowInfos();
                }
                break;
        }
        PressKeyToContinue();
    }


    //function that will let you know what is going on during the month (how much seeds and meat your aimals consumed this month)
    public void FeedAnimals()
    {
        double totalSeedsEaten = 0;
        double totalMeatEaten = 0;
        int animalsHungry = 0;

        for (int i = 0; i < thisZoo._animals.Count; i++)
        {
            Animal thisAnimal = thisZoo._animals[i];

            double kgNeeded = thisAnimal.GetKgPerDay() * 30;
            double nbDaysWithoutFeeding = 0;

            if (thisAnimal.GetSpecies().Contains("Chicken"))
            {
                double nbRemainingKg = food.DecreaseSeeds(kgNeeded);

                if (nbRemainingKg < 0)
                {
                    nbDaysWithoutFeeding = -1 * nbRemainingKg / thisAnimal.GetKgPerDay();

                    totalSeedsEaten = totalSeedsEaten + (kgNeeded + nbRemainingKg);

                    animalsHungry += 1;
                }
                else
                {
                    totalSeedsEaten = totalSeedsEaten + kgNeeded;
                }
            }
            else
            {
                double nbRemainingKg = food.DecreaseMeat(kgNeeded);

                if (nbRemainingKg < 0)
                {
                    nbDaysWithoutFeeding = -1 * nbRemainingKg / thisAnimal.GetKgPerDay();

                    totalMeatEaten = totalMeatEaten + (kgNeeded + nbRemainingKg);
                    animalsHungry = animalsHungry + 1;
                }
                else
                {
                    totalMeatEaten = totalMeatEaten + kgNeeded;
                }
            }

            thisAnimal.SetHunger(nbDaysWithoutFeeding);
        }

        string red = "\u001b[31m";
        string reset = "\u001b[0m";
        string green = "\u001b[32m";
        string title = "\u001b[1m";

        Console.WriteLine($"\n{green}[FEEDING REPORT]{reset}");

        Console.WriteLine($"[SEEDS] Your chickens ate: {title}{green}{totalSeedsEaten:F2}Kg{reset} of seeds this month.");
        Console.WriteLine($"[MEAT] Your eagles and tigers ate: {title}{green}{totalMeatEaten:F2}Kg{reset} of meat this month.");

        if (animalsHungry > 0)
        {
            Console.WriteLine($"{red}[WARNING] {title}{animalsHungry}{reset}{red} animals didn't have enough food this month!{reset}");
        }
    }

    //to calculate when you deserve a subvention on the 12th month of the year
    public void EarnSubvention()
    {
        string green = "\u001b[32m";
        string yellow = "\u001b[33m";
        string title = "\u001b[1m";
        string reset = "\u001b[0m";

        int subvention = 0;
        if (myAccount.GetNbSubvention() != time.GetNbYears())
        {
            for (var i = 0; i < thisZoo._animals.Count; i++)
            {
                subvention += thisZoo._animals[i].GetSubvention();
            }

            myAccount.IncrSubventions();
            myAccount.Sell(subvention);

            Console.WriteLine($"\n{title}{green}[SUBVENTION] You've got an annual subvention of {yellow}{subvention}€{reset}{green}!{reset}");
            sfx.PlaySound("moneySFX.wav");
        }
    }


    //calculates how many visitors you'll have during the low season (from to October to April)
    public void HaveVisitors_low()
    {

        string title = "\u001b[1m";
        string yellow = "\u001b[33m";
        string reset = "\u001b[0m";
        string cyan = "\u001b[36m";

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

        Console.WriteLine($"\n{cyan}[VISITORS]{reset} The {nbVisitors} visitors payed {yellow}{title}{priceVisitors}€{reset} in total during the low season.\n");
    }


    //calculates how many visitors you'll have during the high season (from to May to September)
    public void HaveVisitors_high()
    {

        string title = "\u001b[1m";
        string yellow = "\u001b[33m";
        string reset = "\u001b[0m";
        string cyan = "\u001b[36m";

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

        Console.WriteLine($"\n{cyan}[VISITORS]{reset} The {nbVisitors} visitors payed {yellow}{title}{priceVisitors}€{reset} in total during the high season.\n");
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
        Console.WriteLine("\n[Press any key to return to main menu]");
        Console.ReadLine();
        sfx.PlaySound("clickSFX.wav");
    }


    //just a menu function that says Press key to continue and waits for that key to continue
    public void PressKeyToContinue2()
    {
        Console.WriteLine("\n[Press any key to continue]");
        Console.ReadLine();
        sfx.PlaySound("clickSFX.wav");
    }


    //display menu where you can choose what to sell from your zoo
    public void SellStuffMenu()
    {
        string title = "\u001b[1m";
        string reset = "\u001b[0m";

        Console.Clear();
        Console.WriteLine($"\n{title}########### Sell stuff to customers! ###########{reset}\n");
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

        string title = "\u001b[1m";
        string reset = "\u001b[0m";
        string yellow = "\u001b[33m";

        Console.Clear();
        if (thisZoo.TotalAnimals <= 0)
        {
            Console.WriteLine("You don't have any animal to sell.");
            PressKeyToContinue();
            return;
        }

        Console.WriteLine($"\n{title}########### Sell animals from your Zoo! ###########{reset}\n");
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

                    Console.WriteLine($"\n 1. Female chicken (6 months): {title}{yellow}+10€{reset}\n 2. Male chicken (6 months): {title}{yellow}+20€{reset}\n 3. Back");

                    var chicken_choice = Console.ReadLine();
                    switch (chicken_choice)
                    {
                        case "1":
                            myAccount.Sell(10);

                            sfx.PlaySound("moneySFX.wav");
                            thisZoo.RemoveChickenFemale();
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
                                sfx.PlaySound("moneySFX.wav");
                                thisZoo.RemoveChickenMale();
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
                    Console.WriteLine($"\n 1. Eagle (6 months): {title}{yellow}+500€{reset} \n 2. Eagle (4 years): {title}{yellow}+2 000€{reset} \n 3. Eagle (14 years): {title}{yellow}+400€{reset} \n 4. Back\n");

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
                                sfx.PlaySound("moneySFX.wav");
                                thisZoo.RemoveEagleOf6Months();
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
                                sfx.PlaySound("moneySFX.wav");
                                thisZoo.RemoveEagleOf4Years();
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
                                sfx.PlaySound("moneySFX.wav");
                                thisZoo.RemoveEagleOf14Years();
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
                    Console.WriteLine($"\n 1. Tiger (6 months): {title}{yellow}+1500€{reset} \n 2. Tiger (4 years): {title}{yellow}+60 000€{reset} \n 3. Tiger (14 years): {title}{yellow}+10 000€{reset} \n 4. Back\n");

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
                                sfx.PlaySound("moneySFX.wav");
                                thisZoo.RemoveTigerOf6Months();
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
                                sfx.PlaySound("moneySFX.wav");
                                thisZoo.RemoveTigerOf4Years();
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
                                sfx.PlaySound("moneySFX.wav");
                                thisZoo.RemoveTigerOf14Years();
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
        PressKeyToContinue();
    }


    //display menu + code to sell food from the zoo to "customers"
    public void SellFoodMenu()
    {

        string yellow = "\u001b[33m";
        string title = "\u001b[1m";
        string reset = "\u001b[0m";

        Console.Clear();
        Console.WriteLine($"\n{title}########### Sell food to customers! ###########{reset}\n");
        myAccount.ShowInfos();
        food.ShowInfos();

        if (food.GetMeatKg() <= 0 && food.GetSeedsKg() <= 0)
        {
            Console.WriteLine("You don't have any food to sell.");
            PressKeyToContinue();
            return;
        }

        Console.WriteLine($"\n1. Seeds: {title}{yellow}+2.5€{reset}/Kg\n2. Meat: {yellow}{title}+5€{reset}/Kg\n");
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
                sfx.PlaySound("moneySFX.wav");
                sfx.PlaySound("seeds.wav");
                Console.Clear();
                Console.WriteLine($"\nYou sold {kgSeeds}kg of seeds for {title}{yellow}{food.seedsPricePerKg * kgSeeds}€{reset} to a customer!\n");
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
                sfx.PlaySound("meat.wav");
                sfx.PlaySound("moneySFX.wav");
                Console.Clear();
                Console.WriteLine($"\nYou sold {kgMeat}kg of meat for {title}{yellow}{food.meatPricePerKg * kgMeat}€{reset} to a customer!\n");
                myAccount.ShowInfos();
                break;
        }
        PressKeyToContinue();
    }


    //display menu + code to sell habitats from the zoo to "customers"
    public void SellHabitatsMenu()
    {
        string yellow = "\u001b[33m";
        string title = "\u001b[1m";
        string reset = "\u001b[0m";

        Console.Clear();
        if (thisZoo.TotalHabitats <= 0)
        {
            Console.WriteLine("You don't have any habitat to sell.");
            PressKeyToContinue();
            return;
        }
        Console.WriteLine($"\n{title}########### Sell habitats from your Zoo! ###########{reset}\n");
        myAccount.ShowInfos();
        Console.WriteLine($"\n 1. Chickens habitat: {yellow}{title}+50€{reset}\n 2. Eagles habitat: {yellow}{title}+500€{reset}\n 3. Tigers habitat: {yellow}{title}+500€{reset}\n\n 4. Back");
        Console.Write("\nChoice: ");

        var sellHabitatsChoice = Console.ReadLine();
        switch (sellHabitatsChoice)
        {
            case "1":
                if (thisZoo.RemoveChickenHabitatOk() == false)
                {
                    Console.Clear();
                    Console.WriteLine("\nAll your chickens habitats are occupied, can't sell.\n");
                    break;
                }

                if (thisZoo.RemoveChickenHabitatOk() == true)
                {

                    Console.WriteLine($"\nSell chickens habitat for {yellow}{title}50€{reset}? (type yes or no)\n");

                    var chicken_choice = Console.ReadLine();
                    switch (chicken_choice)
                    {
                        case "yes":
                            myAccount.Sell(50);
                            thisZoo.SellChickenHabitat();
                            sfx.PlaySound("moneySFX.wav");
                            Console.Clear();
                            Console.WriteLine($"\nYour chickens habitat has been sold for {yellow}{title}50€{reset}!\n");
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
                    Console.WriteLine($"\nSell eagles habitat for {yellow}{title}+500€{reset}? (type yes or no)\n");

                    var eagle_choice = Console.ReadLine();

                    switch (eagle_choice)
                    {

                        case "yes":
                            myAccount.Sell(500);
                            thisZoo.SellEagleHabitat();
                            sfx.PlaySound("moneySFX.wav");
                            Console.Clear();
                            Console.WriteLine($"\nYour eagles habitat has been sold for {yellow}{title}500€{reset}!\n");
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
                    Console.WriteLine($"\n Sell tigers habitat for {yellow}{title}500€{reset}? (type yes or no)\n");

                    var tiger_choice = Console.ReadLine();

                    switch (tiger_choice)
                    {

                        case "yes":
                            myAccount.Sell(500);
                            thisZoo.SellTigerHabitat();
                            sfx.PlaySound("moneySFX.wav");
                            Console.Clear();
                            Console.WriteLine($"\nYour tigers habitat has been sold for {yellow}{title}500€{reset}!\n");
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
        PressKeyToContinue();
    }


    //Checks for rotten meat or bad seeds
    public void CheckFood()
    {

        string red = "\u001b[31m";
        string title = "\u001b[1m";
        string reset = "\u001b[0m";

        Random rand = new Random();
        var random20 = rand.Next(5); //number between 0 & 4 so 1/5chance so 20%
        var random10 = rand.Next(10); //number bewteen 0 & 10 so 1/10chance so 10%

        if (random20 == 0)
        {
            food.BadSeeds();
            Console.WriteLine($"\n{red}[SILO] You lost {title}10%{reset}{red} of your seeds this month because of insects.{reset}");
        }

        if (random10 == 0)
        {
            food.BeRotten();
            Console.WriteLine($"\n{red}[COLD-CHAMBER] {title}20%{reset}{red} of your meat has rotten this month.{reset}");
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
            sfx.PlaySound("thief.wav");
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
            sfx.PlaySound("fire.wav");
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

    public void CheckLoseCondition()
    {
        if (thisZoo.TotalAnimals == 0 && myAccount.GetCurrentMoney() < 42.5 && thisZoo.TotalChickenHabitats == 1)
        {
            YouLose();
        }
        else if (thisZoo.TotalAnimals == 0 && myAccount.GetCurrentMoney() < 342.5 && thisZoo.TotalHabitats == 0)
        {

            YouLose();
        }
    }

    public void YouLose()
    {
        string red = "\u001b[31m";
        string title = "\u001b[1m";
        string reset = "\u001b[0m";

        Console.Clear();
        Console.WriteLine($"\n\n\n\n\n{red}{title}YOU LOSE! you don't have enough habitats, money and animals{reset}");
        Console.WriteLine("[press any key to quit the game]");
        Console.ReadLine();
        sfx.StopMusic();
        isPlaying = false;
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

        myAccount.Buy(20);
        thisZoo.addChickenFemale2("Poulette2");

        myAccount.Buy(20);
        thisZoo.addChickenFemale2("Poulette3");

        myAccount.Buy(100);
        thisZoo.addChickenMale2("Pouletto");

        myAccount.Buy(100);
        thisZoo.addChickenMale2("Pouletto2");

        myAccount.Buy(100);
        thisZoo.addChickenMale2("Pouletto3");


        myAccount.Buy(3000);
        thisZoo.addTigerFemale2("Tigrette", 6);


        myAccount.Buy(1000);
        thisZoo.addEagleMale2("Aiglou", 6);

        myAccount.Buy(1000);
        thisZoo.addEagleFemale2("Aiglette", 6);

        myAccount.Buy(1000);
        thisZoo.addEagleFemale2("Aiglette2", 6);


        myAccount.Buy(35000);
        food.IncreaseMeat(7000);

        myAccount.Buy(2500);
        food.IncreaseSeeds(1000);

        sfx.PlaySound("clickSFX.wav");

    }
}
