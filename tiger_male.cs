public class Tiger_Male : Animal
{
   public Tiger_Male(string species, string name, int age, string diet, int daysBeforeStarvation, double kgPerDay, bool sex, int sexualMaturity, int endOfReproduction,int lifeTime, bool ill, bool firstMonth) 
        : base("Tiger (Male)", name, age, "meat", 2, 12, false, 36, 168, 300, ill, firstMonth)
    {
    }
}