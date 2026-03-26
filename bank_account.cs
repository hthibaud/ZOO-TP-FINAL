using System.Reflection.Metadata;

public class BankAccount
{
    public float currentMoney;

    private string _errorString = "";

    public string errorString => _errorString;
    private bool _hasError;

    public bool hasError => _hasError;

    private int _nbSubventions = 0;

    private float _totalVisitorsMoney = 0;

    public BankAccount(float startingMoney)
    {
        if (startingMoney < 0)
        {
            currentMoney = 0;
            setError("Initial balance cannot be negative");
        }
        else
        {
            currentMoney = startingMoney;
            resetError();
        }
    }

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
        currentMoney += amount;
    }
    public void Buy(float amount)
    {
        resetError();
        if (amount > currentMoney)
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
        currentMoney -= amount;
    }
    public void ShowInfos()
    {
        string title = "\u001b[1m";
        string yellow = "\u001b[33m";
        string reset = "\u001b[0m";

        Console.WriteLine($"{title}[BANK-ACCOUNT]{reset} Balance: {title}{yellow}{currentMoney}€{reset}\n");
    }
    public void IncrSubventions()
    {
        _nbSubventions++;
    }

    public int GetNbSubvention()
    {
        return _nbSubventions;
    }

    public void IncrVisitorsMoney(float money)
    {
        _totalVisitorsMoney += money;
    }

    public float GetCurrentMoney()
    {
        return currentMoney;
    }
}

