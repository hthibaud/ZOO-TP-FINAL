public class Chicken_Habitat : Habitat
{

    public int numberOfChickens {get; private set;}
    private int _maxChickens = 10;
    public int maxChickens => maxChickens;

    private int _price = 300;

    public Chicken_Habitat(int numberOfChickens, int maxChickens, int price) : base (0, 10, 300)
    {
        _maxChickens = maxChickens;
        _price = price;
    }
}