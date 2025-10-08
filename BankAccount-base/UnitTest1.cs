namespace BankAccountTests;
using BankAccount;

public class BankAccountTests
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }

    [Fact]
    public void DebitWithValidAmount()
    {
        // Arrange
        BankAccount account = new("Hieke", 100);
        decimal amount = 25;

        // Act
        account.Debit(amount);

        // Assert
        Assert.Equal(75, account.Balance);
    }

    [Fact]
    public void DebitTriggerDebitException()
    {
        // Arrange
        BankAccount account = new("Hieke", 100);
        decimal amount = 125;

        // Act
        Action action = () => account.Debit(amount);

        // Assert
        Assert.Throws<ArgumentOutOfRangeException>(action);
        

    }
}


