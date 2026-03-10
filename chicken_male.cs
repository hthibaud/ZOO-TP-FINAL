public class Chicken_Male : Animal
{
   public Chicken_Male(string species, string name, int age, string diet, int daysBeforeStarvation, double kgPerDay, bool sex, int sexualMaturity, int endOfReproduction,int lifeTime, bool ill, bool firstMonth) 
        : base("Chicken (male)", name, age, "seeds", 2, 0.18, false, 6, 96, 180, ill, firstMonth)
    {
    }
}