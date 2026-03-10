public class Eagle_Female : Animal
{
   public Eagle_Female(string species, string name, int age, string diet, int daysBeforeStarvation, double kgPerDay, bool sex, int sexualMaturity, int endOfReproduction,int lifeTime, bool ill, bool firstMonth) 
        : base("Eagle (female)", name, age, "meat", 10, 0.3, true, 48, 168, 300, ill, firstMonth)
    {
    }
}