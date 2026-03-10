public class Eagle_Male : Animal
{
   public Eagle_Male(string species, string name, int age, string diet, int daysBeforeStarvation, double kgPerDay, bool sex, int sexualMaturity, int endOfReproduction,int lifeTime, bool ill, bool firstMonth) 
        : base("Eagle (male)", name, age, "meat", 10, 0.25, false, 48, 168, 300, ill, firstMonth)
    {
    }
}