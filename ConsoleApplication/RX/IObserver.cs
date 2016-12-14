using System;

public interface IObserver<T>
{
    void Update(Object sender, T e);
}

public class SMSNotify : IObserver<CreditCard>
{
    public void Update(Object sender, CreditCard e)
    {
        Console.WriteLine("Sms notify.Spend {0}", e.SpendAmount);
    }
}

public class Account : IObserver<CreditCard>
{
    private float _accountAmount;

    public Account(float accountAmount)
    {
        _accountAmount = accountAmount;
    }

    public void Update(Object sender, CreditCard e)
    {
        _accountAmount -= e.SpendAmount;
        Console.WriteLine("Account amount is {0}", _accountAmount);
    }
}