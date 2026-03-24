public class Tiger_Male : Animal
{
   public Tiger_Male(string name, int age, bool ill, bool firstMonth) 
        : base("Tiger (Male)", name, age, "meat", 2, 12, false, 36, 168, 300, ill, firstMonth, 0, 43800, 5, 30, false, 0, 0)
    {
    }    public void ShowDetailedInfos()
    {
        Console.WriteLine($"####### Taking care of your Males: #######\n\nDiet : Meat\nHow much I eat per day: 12Kg\nDays before starvation: 2\nSexual maturity: 6 years\nAge of the end of reproduction: 14 years\nLife time: 25 years\n");
    }
}