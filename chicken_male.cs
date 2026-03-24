public class Chicken_Male : Animal
{
    public Chicken_Male(string name, int age, bool ill, bool firstMonth)
         : base("Chicken (male)", name, age, "seeds", 2, 0.18, false, 6, 96, 180, ill, firstMonth, 0, 0, 0.5f, 2, false, 0, 0)
    {
    }


    //shows the detailed info of the chicken male
    public void ShowDetailedInfos()
    {
        Console.WriteLine($"####### Taking care of your Males: #######\n\nDiet : Seeds\nHow much I eat per day: 0.2Kg\nDays before starvation: 2\nSexual maturity: 6 months\nAge of the end of reproduction: 8 years\nLife time: 15 years\n");
    }
}