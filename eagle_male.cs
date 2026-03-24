public class Eagle_Male : Animal
{
    public Eagle_Male(string name, int age, bool ill, bool firstMonth)
         : base("Eagle (male)", name, age, "meat", 10, 0.25, false, 48, 168, 300, ill, firstMonth, 0, 2190, 7, 15, false, 0, 0)
    {
    }
    public void ShowDetailedInfos()
    {
        Console.WriteLine($"####### Taking care of your Males: #######\n\nDiet : Meat\nHow much I eat per day: 0.25Kg\nDays before starvation: 10\nSexual maturity: 4 years\nAge of the end of reproduction: 14 years\nLife time: 25 years\n");
    }
}