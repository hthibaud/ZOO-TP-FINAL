public class Zoo
{
    private int _numberOfHabitats = 0;
    private int _numberOfChickenHabitats = 0;
    private int _numberOfEagleHabitats = 0;
    private int _numberOfTigerHabitats = 0;

        public void ShowInfo(){
                Console.WriteLine($"\nTotal of habitats : {_numberOfHabitats}\nTotal of chicken habitats : {_numberOfChickenHabitats}\nTotal of eagle habitats : {_numberOfEagleHabitats}\nTotal of tiger habitats : {_numberOfTigerHabitats}\n");
        }

    public Zoo(int numberOfHabitats, int numberOfChickenHabitats, int numberOfEagleHabitats, int numberOfTigerHabitats)
    {
        _numberOfHabitats = numberOfHabitats;
        _numberOfChickenHabitats = numberOfChickenHabitats;
        _numberOfEagleHabitats = numberOfEagleHabitats;
        _numberOfTigerHabitats = numberOfTigerHabitats;
    }
}