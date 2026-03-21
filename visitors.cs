public class Visitors
{
    private float _nbVisitors = 0;


    public void IncrVisitors(float nbVisitors)
    {
        _nbVisitors += nbVisitors;
    }

    public float GetNbVisitors()
    {
        return _nbVisitors;
    }
}