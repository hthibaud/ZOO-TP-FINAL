class BankAccount()
{
    private float _currentMoney;
    private string _errorString;

    public string errorString => _errorString;
    private bool _hasError;

    public bool hasError => _hasError;

    private void setError(string str)
    {
        _hasError = true;
        _errorString = str;
    }

    private void resetError()
    {
        _hasError = false;
        _errorString = "";
    }
    public void Sell(float amount)
    {
        resetError();
        if (amount <= 0)
        {
            setError("Bad amount");
            return;
        }
        _currentMoney += amount;
    }
    public float getMoney()
    {
        Console.WriteLine($"[Account] : {_currentMoney}€");
        return _currentMoney;
    }
    public void Buy(float amount)
    {
            resetError();
         if (amount > _currentMoney)
        {
            setError("Not enough money");
            return;
        }
          resetError();
        if (amount <= 0)
        {
        
            setError("Bad amount");
            return;
        }
        _currentMoney -= amount;
    }
}