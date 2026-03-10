public class Zoo
{
    public int numberOfHabitats { get; private set; }
    public int numberOfChickenHabitats { get; private set; }
    public int numberOfEagleHabitats { get; private set; }
    public int numberOfTigerHabitats { get; private set; }

        public void ShowInfo(){
                Console.WriteLine($"\nTotal of habitats : {numberOfHabitats}\nTotal of chicken habitats : {numberOfChickenHabitats}\nTotal of eagle habitats : {numberOfEagleHabitats}\nTotal of tiger habitats : {numberOfTigerHabitats}\n");
        }

    public Zoo(int numberOfHabitats, int numberOfChickenHabitats, int numberOfEagleHabitats, int numberOfTigerHabitats)
    {
    }

    public void addChickenHabitat()
    {
        numberOfChickenHabitats += 1;
        numberOfHabitats += 1;
    }

        public void addEagleHabitat()
    {
        numberOfEagleHabitats += 1;
        numberOfHabitats += 1;
    }

        public void addTigerHabitat()
    {
        numberOfTigerHabitats += 1;
        numberOfHabitats += 1;
    }
}