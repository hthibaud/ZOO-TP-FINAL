using System.Linq.Expressions;
using System.Xml.Serialization;

class Program
{
    Zoo thisZoo = new Zoo(0, 0, 0, 0);
    BankAccount myAccount = new BankAccount(80000);
    static void Main()
    {
        Program myZoo = new Program();

        Console.Clear();

        myZoo.menu();
    }

    public void menu()
    {
        Console.WriteLine("\n ########### Welcome to your Zoo! ########### \n");
        Console.WriteLine("\n What do you want to do? (Type number with your keyboard)\n");
        Console.WriteLine("\n 1. Buy an animal\n 2. Buy an habitat \n 3. Zoo stats\n");

        var choice = Console.ReadLine();

        switch (choice)
        {

            case "1":

                Console.WriteLine("\n ########### Buy an animal for your Zoo! ########### \n");
                Console.WriteLine("\n 1. Chicken\n 2. Eagle \n 3. Tiger \n");

                var animal_choice = Console.ReadLine();
                switch (animal_choice)
                {
                    case "1":

                        if (thisZoo.EnoughChickenHabitats() == false)
                        {
                            Console.WriteLine("\nYou don't have enough habitats\n");
                            menu();
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
                                    thisZoo.addChickenFemale();
                                    menu();
                                    break;

                                case "2":
                                    myAccount.Buy(100);
                                    thisZoo.addChickenMale();
                                    menu();
                                    break;

                                case "3":
                                    menu();
                                    break;

                                default:
                                    Console.WriteLine("invalid choice");
                                    break;

                            }
                        }
                        menu();
                        break;

                    case "2":

                        if (thisZoo.EnoughEagleHabitats() == false)
                        {
                            Console.WriteLine("You don't have enough habitats");
                            menu();
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


                                    if (randomChoice == 0)
                                    {
                                        thisZoo.addEagleFemale(6);
                                    }
                                    else
                                    {
                                        thisZoo.addEagleMale(6);
                                    }
                                    menu();
                                    break;

                                case "2":
                                    myAccount.Buy(4000);

                                    if (randomChoice == 0)
                                    {
                                        thisZoo.addEagleFemale(48); //48 months = 4 years
                                    }
                                    else
                                    {
                                        thisZoo.addEagleMale(48);
                                    }
                                    menu();
                                    break;

                                case "3":
                                    myAccount.Buy(2000);

                                    if (randomChoice == 0)
                                    {
                                        thisZoo.addEagleFemale(168); //168 months = 14 years
                                    }
                                    else
                                    {
                                        thisZoo.addEagleMale(168);
                                    }
                                    menu();
                                    break;

                                case "4":
                                    menu();
                                    break;

                                default:
                                    Console.WriteLine("invalid choice");
                                    menu();
                                    break;
                            }
                            menu();
                            break;
                        }
                        menu();
                        break;

                    case "3":

                        if (thisZoo.EnoughTigerHabitats() == false)
                        {
                            Console.WriteLine("\nYou don't have enough habitats\n");
                            menu();
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


                                    if (randomChoice == 0)
                                    {
                                        thisZoo.addTigerFemale(6);
                                    }
                                    else
                                    {
                                        thisZoo.addTigerMale(6);
                                    }
                                    menu();
                                    break;

                                case "2":
                                    myAccount.Buy(120000);

                                    if (randomChoice == 0)
                                    {
                                        thisZoo.addTigerFemale(48); //48 months = 4 years
                                    }
                                    else
                                    {
                                        thisZoo.addTigerMale(48);
                                    }
                                    menu();
                                    break;

                                case "3":
                                    myAccount.Buy(60000);

                                    if (randomChoice == 0)
                                    {
                                        thisZoo.addTigerFemale(168); //168 months = 14 years
                                    }
                                    else
                                    {
                                        thisZoo.addTigerMale(168);
                                    }
                                    menu();
                                    break;

                                case "4":
                                    menu();
                                    break;

                                default:
                                    Console.WriteLine("invalid choice");
                                    menu();
                                    break;


                            }
                            menu();
                            break;
                        }
                        menu();
                        break;
                }
                menu();
                break;

            case "2":

                Console.WriteLine("\n ########### Buy an habitat for your Zoo! ########### \n");
                Console.WriteLine("\n 1.Chicken habitat (10 chickens)\n 2.Eagle habitat (4 eagles) \n 3.Tiger habitat (2 tigers)\n");

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
                                Console.WriteLine($"\nYour money : {myAccount.currentMoney}€\n");
                                thisZoo.addChickenHabitat();
                                menu();
                                break;

                            case "no":
                                menu();
                                break;
                            default:
                                Console.WriteLine("invalid choice");
                                break;
                        }
                        menu();
                        break;

                    case "2":

                        Console.WriteLine("\n Buy an eagle habitat (4 eagles) for 2000€? (type yes or no)\n");

                        var confirm_eagle_habitat_choice = Console.ReadLine();
                        switch (confirm_eagle_habitat_choice)
                        {
                            case "yes":
                                myAccount.Buy(2000);
                                Console.WriteLine($"Your money : {myAccount.currentMoney}");
                                thisZoo.addEagleHabitat();
                                menu();
                                break;

                            case "no":
                                menu();
                                break;

                            default:
                                Console.WriteLine("invalid choice");
                                menu();
                                break;
                        }

                        menu();
                        break;

                    case "3":

                        Console.WriteLine("\n Buy a tiger habitat (2 tigers) for 2000€? (type yes or no)\n");

                        var confirm_tiger_habitat_choice = Console.ReadLine();
                        switch (confirm_tiger_habitat_choice)
                        {
                            case "yes":
                                myAccount.Buy(2000);
                                thisZoo.addTigerHabitat();
                                Console.WriteLine($"Your money : {myAccount.currentMoney}");
                                menu();
                                break;

                            case "no":
                                menu();
                                break;

                            default:
                                Console.WriteLine("invalid choice");
                                break;

                        }
                        menu();
                        break;

                    default:
                        Console.WriteLine("invalid choice");
                        menu();
                        break;

                }
                menu();
                break;


            case "3":

                Console.WriteLine("\n ########### Stats of your Zoo! ########### \n");
                thisZoo.ShowInfo();
                Console.WriteLine($"Current money : {myAccount.currentMoney}\n");
                menu();
                break;

            default:
                Console.WriteLine("invalid choice");
                menu();
                break;
        }
    }
}
