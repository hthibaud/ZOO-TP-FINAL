public class Eagle_Habitat : Habitat
{
    public int numberOfEagles {get; private set;}
    private int _maxEagles = 4;

    private int _price = 2000;
    public Eagle_Habitat(int numberOfEagles, int maxEagles, int price) : base (0, 4, 2000)
    {
        _maxEagles = maxEagles;
        _price = price;
    }
}