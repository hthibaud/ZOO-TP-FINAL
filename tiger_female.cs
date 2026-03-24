using System.Security.Cryptography;

public class Tiger_Female : Animal
{
   public Tiger_Female(string name, int age, bool ill, bool firstMonth) 
        : base("Tiger (Female)", name, age, "meat", 2, 10, true, 48, 168, 300, ill, firstMonth, 0, 43800, 5, 30, false, 0, 0)
    {
    }

    public void ShowDetailedInfos()
    {
        Console.WriteLine($"####### Taking care of your females: #######\n\nDiet : Meat\nHow much I eat per day: 10Kg\nDays before starvation: 2\nSexual maturity: 4 years\nAge of the end of reproduction: 14 years\nLife time: 25 years\n");
    }
    }
