using System.Xml.Serialization;

class Program {
    Zoo thisZoo = new Zoo(0,0,0,0);
    static void Main(){
        Program myZoo = new Program();
        
        myZoo.start();
    }

public void start()
{
    Console.WriteLine("\n ########### Welcome to your Zoo! ########### \n");
    Console.WriteLine("\n What do you want to do first? (Type number with your keyboard)\n");
    Console.WriteLine("\n 1.Buy an animal\n 2.Buy an habitat \n 3.Zoo stats");

    var choice = Console.ReadLine();

    switch (choice){

        case "1": 

        Console.WriteLine("\n ########### Buy an animal for your Zoo! ########### \n");
        Console.WriteLine("\n 1. Chicken\n 2. Eagle \n 3. Tiger \n");

        var animal_choice = Console.ReadLine();

        switch (animal_choice)
                {
                    case "1":
                    Console.WriteLine("\n 1. Female chicken (6 months) : 20€ \n 2.Male chicken (6 months) : 100€\n");
                    break;

                    case "2":
                    Console.WriteLine("\n 1. Tiger (6 months) : 3000€ \n 2. Tiger (4 years) : 120 000€ \n 3. Tiger (14 years) : 60 000€ \n");
                    break;
                   
                    case "3":
                    Console.WriteLine("\n 1. Eagle (6 months) : 1000€ \n 2. Eagle (4 years) : 4 000€ \n 3. Eagle (14 years) : 2 000€ \n");
                    break;

                    default:
                    
                    Console.WriteLine("invalid choice");
                    break;


                }
        break;

        case "2":

        Console.WriteLine("\n ########### Buy an habitat for your Zoo! ########### \n");
        Console.WriteLine("\n 1.Chicken habitat (10 chickens)\n 2.Eagle habitat (4 eagles) \n 3. Tiger habitat (2 tigers)\n");
               
                var habitat_choice = Console.ReadLine();

                switch (habitat_choice)
                {
                    case "1":

                    Console.WriteLine("\n 1. Buy a chicken habitat (10 chickens) for 300€?\n");
                    break;

                    case "2":

                    Console.WriteLine("\n 2. Buy an eagle habitat (4 eagles)for 2000€? \n");
                    break;
                   
                    case "3":

                    Console.WriteLine("\n 3. Buy a tiger habitat (2 tigers) for 2000€? \n");
                    break;

                    default:

                    Console.WriteLine("invalid choice");
                    break;

                }
        break;

        case "3":

        Console.WriteLine("\n ########### Stats of your Zoo! ########### \n");
        thisZoo.ShowInfo();
        break;

        default:

            Console.WriteLine("invalid choice");
            break;
    }
}

public void addChicken() {
    Chicken_Female chicken1 = new Chicken_Female("chicken", "TestPoule1", 3, "seeds", 1, 0.15, true, 6, 8, 15, false, true);
    }
}
