public class Tiger_Habitat : Habitat
{

    public int numberOfTigers {get; private set;}
    private int _maxTigers = 2;

    private int _price = 2000;

    public Tiger_Habitat(int numberOfTigers, int maxTigers, int price) : base (0, 2, 2000)
    {
        _maxTigers = maxTigers;
        _price = price;
    }
}