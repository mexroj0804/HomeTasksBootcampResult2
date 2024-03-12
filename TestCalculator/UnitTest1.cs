using Calculator;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Xunit.Sdk;

namespace TestCalculator;

public class UnitTest1
{
    [Fact]
    public void TestAddMethodForCalculatorService()
    {
        //Arrange
        decimal number1 = 28;
        decimal number2 = 7;
        decimal expectedResult = 35;

        //Act

        var result = Actions.Add(number1, number2);

        //Asert
        Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void TestForSubtractMethodForCalculatorService()
    {
        //Arrage
        decimal number1 = 290;
        decimal number2 = 135;
        decimal expectedResult = 155;

        //Act
        var result = Actions.Subtract(number1, number2);

        //Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestForMultiplyMethodForCalculatorService()
    {
        //Arrage
        decimal number1 = 30;
        decimal number2 = 25;
        decimal expectedResult = 750;

        //Act
        var  result = Actions.Multiply(number1, number2);

        //Asert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestForDivideMethodForCalculatorService()
    {
        //Arrage
        decimal number1 = 125;
        decimal number2 = 5;
        var expectedResult = 25;

        //Act
        var result = Actions.Divide(number1, number2);

        //Asert
        //Assert.Throws<DivideByZeroException>(() => result);

        Assert.Equal(expectedResult, result);

    }
}