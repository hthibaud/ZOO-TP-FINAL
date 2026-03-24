public class Visitors
{
    private float _nbVisitors = 0;


    //Increments the number of visitors to count them 
    //and to let the user know how many of them where here during the passed month or the passed year 
    public void IncrVisitors(float nbVisitors)
    {
        _nbVisitors += nbVisitors;
    }


    //Returns the number of visitors
    public float GetNbVisitors()
    {
        return _nbVisitors;
    }
}