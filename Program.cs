class Program
{
    static void Main()
    {
        BankAccount ZooBankAccount = new BankAccount();
        ZooBankAccount.Sell(80000);
        if (ZooBankAccount.hasError == true)
        {
            Console.WriteLine(ZooBankAccount.errorString);
        }
    }
}
