using System;

public class CreditCard : EventArgs
{
    private float _spendAmount;
    public static event EventHandler<CreditCard> SpendMoney;

    public float SpendAmount
    {
        get
        {
            return _spendAmount;
        }
        set
        {
            _spendAmount = value;
            Notify();
        }
    }

    private void Notify()
    {
        if (SpendMoney != null)
        {
            SpendMoney(this, this);
        }
    }
}