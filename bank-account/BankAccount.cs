using System;

public class BankAccount
{
    private bool open;
    private float balance;
    private readonly object Lock;

    public BankAccount()
    {
        open = false;
        balance = 0;
        Lock = new object();
    }

    public void Open() => Sync( () => open = true);

    public void Close() => Sync( () => open = false);

    public float Balance
    {
        get => Sync( () => { Check(); return balance; });
        private set => Sync( () => balance = value);
    }

    public void UpdateBalance(float change)
    {
        Sync( () => { Check(); balance += change; });
    }

    private T Sync<T>(Func<T> f)
    {
        lock (Lock) { return f.Invoke(); }
    }

    private void Sync(Action a)
    {
        lock (Lock) { a.Invoke(); }
    }

    private void Check()
    {
        if (!open) throw new InvalidOperationException();
    }
}