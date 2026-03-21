using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

class Program
{
    Zoo thisZoo = new Zoo(0, 0, 0, 0);
    BankAccount myAccount = new BankAccount(80000);

    Chicken_Habitat chicken_habitat = new Chicken_Habitat();

    Eagle_Habitat eagle_habitat = new Eagle_Habitat();

    Tiger_Habitat tiger_habitat = new Tiger_Habitat();

    Time time = new Time();

    Food food = new Food();

    Visitors visitors = new Visitors();
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

                case "7":
                    SellStuffMenu();
                    break;

                case "i":
                    InitScenario1();
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
        food.ShowInfos();
        Console.WriteLine(" 1. Buy Animals");
        Console.WriteLine(" 2. Buy Habitats");
        Console.WriteLine(" 3. Buy food");
        Console.WriteLine(" 4. View Stats");
        Console.WriteLine(" 5. Pass the month");
        Console.WriteLine(" 6. Pass the year");
        Console.WriteLine(" 7. Sell your stuff to merchant");
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
                                    eagle_habitat.AddAnimal();
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                                else
                                {
                                    thisZoo.addEagleMale(6);
                                    eagle_habitat.AddAnimal();
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
                                    eagle_habitat.AddAnimal();
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");
                                }
                                else
                                {
                                    thisZoo.addEagleMale(48);
                                    eagle_habitat.AddAnimal();
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
                                    eagle_habitat.AddAnimal();
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");
                                }
                                else
                                {
                                    thisZoo.addEagleMale(168);
                                    eagle_habitat.AddAnimal();
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
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                                else
                                {
                                    thisZoo.addTigerMale(48);
                                    Console.WriteLine($"Balance : {myAccount.currentMoney}");

                                }
                                tiger_habitat.AddAnimal();
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
                                tiger_habitat.AddAnimal();
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
                food.ShowInfos();
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
        time.GetCurrentMonthName();
        time.ShowInfos();
        thisZoo.GrowUpAnimalsMonths();
        thisZoo.DeathByAge();
        FeedAnimals();
        thisZoo.CheckStarvation();
        EarnSubvention();
        HaveVisitors();
        PressKeyToContinue2();

    }

    private void PassTheYear()
    {
        for (var i = 1; i <= 12; i++)
        {
            PassTheMonth();
        }
    }

    public void BuyFoodMenu()
    {
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
                    Console.WriteLine($"{thisAnimal.GetName()} didn't eat for {nbDaysWithoutFeeding} days");

                }

                Console.WriteLine($"[FEED] {thisAnimal.GetName()} ate {kgPerDay * 30:F2}Kg of seeds.");
            }
            else
            {
                double nbRemainingKg = food.DecreaseMeat(kgPerDay * 30);
                if (nbRemainingKg < 0)
                {
                    nbDaysWithoutFeeding = -1 * nbRemainingKg / kgPerDay;
                    Console.WriteLine($"{thisAnimal.GetName()} didn't eat for {nbDaysWithoutFeeding} days");

                }

                Console.WriteLine($"[FEED] {thisAnimal.GetName()} ate {kgPerDay * 30:F2}Kg of meat.");

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
            Console.WriteLine($"\n[SUBVENTION] You've got an annual subvention of {subvention}€!");

        }
    }

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
    public void HaveVisitors()
    {
        if (time.GetCurrentMonth() < 7)
        {
            HaveVisitors_low();
        }
        else
        {
            HaveVisitors_high();
        }
        myAccount.ShowInfos();
    }
    public void PressKeyToContinue()
    {
        Console.WriteLine("\n[Press key to return to main menu]");
        Console.ReadLine();
    }

    public void PressKeyToContinue2()
    {
        Console.WriteLine("\n[Press key to continue]");
        Console.ReadLine();
    }

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
                //SellHabitatsMenu();
                break;

            case "3":
                SellFoodMenu();
                break;
        }
    }
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

                    Console.WriteLine("\n 1. Female chicken (6 months) : +10€\n 2. Male chicken (6 months) : +20€\n 3. Back");

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

        Console.WriteLine("\n1. Seeds\n2. Meat \n");
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


        myAccount.Buy(25000);
        food.IncreaseMeat(5000);

        myAccount.Buy(2500);
        food.IncreaseSeeds(1000);
    }
}

