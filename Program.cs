using System.Linq.Expressions;
using System.Xml.Serialization;

class Program {
    Zoo thisZoo = new Zoo(0,0,0,0);
    BankAccount myAccount = new BankAccount(80000);
    static void Main(){
        Program myZoo = new Program();
        
        myZoo.menu();
    }

public void menu()
{
    Console.WriteLine("\n ########### Welcome to your Zoo! ########### \n");
    Console.WriteLine("\n What do you want to do? (Type number with your keyboard)\n");
    Console.WriteLine("\n 1. Buy an animal\n 2. Buy an habitat \n 3. Zoo stats\n");

    var choice = Console.ReadLine();

    switch (choice){

        case "1": 

        Console.WriteLine("\n ########### Buy an animal for your Zoo! ########### \n");
        Console.WriteLine("\n 1. Chicken\n 2. Eagle \n 3. Tiger \n");

        var animal_choice = Console.ReadLine();
        switch (animal_choice)
                {
                    case "1":

                    if (thisZoo.numberOfChickenHabitats == 0)
                    {
                        Console.WriteLine("You don't have enough habitats");
                        menu();
                        break;
                    }
                    
                    Console.WriteLine("\n 1. Female chicken (6 months) : 20€\n 2.Male chicken (6 months) : 100€\n");

                    var chicken_choice = Console.ReadLine();               
                    switch (chicken_choice)
                        {
                            case "1":
                            break;
                        }
                    break;

                    case "2":
                    Console.WriteLine("\n 1. Eagle (6 months) : 1000€ \n 2. Eagle (4 years) : 4 000€ \n 3. Eagle (14 years) : 2 000€ \n");
                    break;
                   
                    case "3":
                    Console.WriteLine("\n 1. Tiger (6 months) : 3000€ \n 2. Tiger (4 years) : 120 000€ \n 3. Tiger (14 years) : 60 000€ \n");
                    break;

                    default:
                    
                    Console.WriteLine("invalid choice");
                    break;


                }
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
                            Console.WriteLine($"Your money : {myAccount.currentMoney}€");
                            thisZoo.addChickenHabitat();
                            menu();
                            break;

                            case "no":
                            menu();
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
                            Console.WriteLine($"Your money : {myAccount.currentMoney}");
                            thisZoo.addEagleHabitat();
                            menu();
                            break;

                            case "no":
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
                        }
                    menu();
                    break;

                    default:

                    Console.WriteLine("invalid choice");
                    Console.Clear();
                    menu();
                    break;

                }
        break;

        case "3":

        Console.WriteLine("\n ########### Stats of your Zoo! ########### \n");
        thisZoo.ShowInfo();
        Console.WriteLine($"Current money : {myAccount.currentMoney}\n");
        menu();
        break;

        default:

            Console.WriteLine("invalid choice");
            Console.Clear();
            menu();
            break;
    }
}
}
