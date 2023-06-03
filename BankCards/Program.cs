// A base class for bank cards
public abstract class BankCard
{
    // Properties that are common for all bank cards
    public int CardNumber { get; private set; }
    public string OwnerName { get; set; }
    public decimal Balance { get; protected set; }

    // A constructor that takes a card number and an owner name
    public BankCard(int cardNumber, string ownerName)
    {
        CardNumber = cardNumber;
        OwnerName = ownerName;
        Balance = 0;
    }

    // An abstract method for depositing money
    public abstract void Deposit(decimal amount);

    // An abstract method for withdrawing money
    public abstract void Withdraw(decimal amount);
}

// A derived class for bank A cards
public class BankACard : BankCard
{
    // A constant for the commission rate
    private const decimal CommissionRate = 0.014m;

    // A constructor that calls the base constructor
    public BankACard(int cardNumber, string ownerName) : base(cardNumber, ownerName)
    {
    }

    // An override method for depositing money
    public override void Deposit(decimal amount)
    {
        // Add the amount to the balance
        Balance += amount;
    }

    // An override method for withdrawing money
    public override void Withdraw(decimal amount)
    {
        // Calculate the commission fee
        decimal commission = amount * CommissionRate;

        // Subtract the amount and the commission from the balance
        Balance -= (amount + commission);
    }
}

// A derived class for bank B cards
public class BankBCard : BankCard
{
    // A constructor that calls the base constructor
    public BankBCard(int cardNumber, string ownerName) : base(cardNumber, ownerName)
    {
    }

    // An override method for depositing money
    public override void Deposit(decimal amount)
    {
        // Add the amount to the balance
        Balance += amount;
    }

    // An override method for withdrawing money
    public override void Withdraw(decimal amount)
    {
        // Subtract the amount from the balance
        Balance -= amount;
    }
}
