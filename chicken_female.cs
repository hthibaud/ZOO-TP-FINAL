public class Chicken_Female : Animal
{
   public Chicken_Female(string name, int age, bool ill, bool firstMonth) 
        : base("Chicken (female)", name, age, "seeds", 1, 0.15, true, 6, 96, 180, ill, firstMonth, 0, 0, 0.5f, 2, false, 0, 0)
    {
    }
        public void ShowDetailedInfos()
    {
        Console.WriteLine($"####### Taking care of your females: #######\n\nDiet : Seeds\nHow much I eat per day: 0.15Kg\nDays before starvation: 1\nSexual maturity: 6 months\nAge of the end of reproduction: 8 years\nLife time: 15 years\n");
    }
}
