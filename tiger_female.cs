using System.Security.Cryptography;

public class Tiger_Female : Animal
{
   public Tiger_Female(string species, string name, int age, string diet, int daysBeforeStarvation, double kgPerDay, bool sex, int sexualMaturity, int endOfReproduction,int lifeTime, bool ill, bool firstMonth) 
        : base("Tiger (Female)", name, age, "meat", 2, 10, true, 48, 168, 300, ill, firstMonth)
    {
    }
    }
