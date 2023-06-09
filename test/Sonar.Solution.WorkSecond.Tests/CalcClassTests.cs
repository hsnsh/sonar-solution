using Xunit.Sdk;

namespace Sonar.Solution.WorkSecond.Tests;

public class CalcClassTests
{
    [Fact]
    public void Balance_ShouldResetBalanceValue()
    {
        // Arrange
        var sut = new CalcClass();

        // Act
        sut.Reset();

        // Assert
        sut.Balance.Should().Be(0);
    }

    [Fact]
    public void Add_ShouldAddToBalanceValue()
    {
        // Arrange
        var sut = new CalcClass();
        var expectedValue = sut.Balance;

        // Act
        sut.Add(7);

        // Assert
        sut.Balance.Should().Be(expectedValue + 7);
    }

    [Fact]
    public void Subtract_ShouldSubToBalanceValue()
    {
        // Arrange
        var sut = new CalcClass();
        var expectedValue = sut.Balance;

        // Act
        sut.Subtract(7);

        // Assert
        sut.Balance.Should().Be(expectedValue - 7);
    }

    [Fact]
    public void Pow_ShouldPowToBalanceValue()
    {
        // Arrange
        var sut = new CalcClass();
        var expectedValue = sut.Balance;

        // Act
        sut.Pow(7);

        // Assert
        sut.Balance.Should().Be(expectedValue * 7);
    }

    [Fact]
    public void Div_ShouldDivToBalanceValue()
    {
        // Arrange
        var sut = new CalcClass();
        var expectedValue = sut.Balance;

        // Act
        sut.Div(7);

        // Assert
        sut.Balance.Should().Be(expectedValue / 7);
    }
}