public class Eagle_Female : Animal
{
    public Eagle_Female(string name, int age, bool ill, bool firstMonth)
         : base("Eagle (female)", name, age, "meat", 10, 0.3, true, 48, 168, 300, ill, firstMonth, 0, 2190, 7, 15, false, 0, 0)
    {
    }


    //shows the detailed info of the eagle female
    public void ShowDetailedInfos()
    {
        Console.WriteLine($"####### Taking care of your females: #######\n\nDiet : Meat\nHow much I eat per day: 0.3Kg\nDays before starvation: 10\nSexual maturity: 4 years\nAge of the end of reproduction: 14 years\nLife time: 25 years\n");
    }
}