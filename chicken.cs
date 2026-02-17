using System.Security.Cryptography.X509Certificates;

public class Chicken : Animal
{
   public Chicken(string species, string name, int age, string diet, int daysBeforeStarvation, double kgPerDay, bool sex, int sexualMaturity, int endOfReproduction,int lifeTime, bool illOrNot) 
        : base("Chicken", name, age, "seeds", 1, kgPerDay, sex, 6, 8, 15, illOrNot)
    {
    }
}