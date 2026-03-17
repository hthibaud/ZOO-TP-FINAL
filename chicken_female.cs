public class Chicken_Female : Animal
{
   public Chicken_Female(string species, string name, int age, string diet, int daysBeforeStarvation, double kgPerDay, bool sex, int sexualMaturity, int endOfReproduction,int lifeTime, bool ill, bool firstMonth) 
        : base("Chicken (female)", name, age, "seeds", 1, 0.15, true, 6, 96, 180, ill, firstMonth)
    {
    }
    public void addChickenFemale() {
    Chicken_Female chicken1 = new Chicken_Female("chicken", "TestPoule1", 3, "seeds", 1, 0.15, true, 6, 8, 15, false, true);
    }
    
}
