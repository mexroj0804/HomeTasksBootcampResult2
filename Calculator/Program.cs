

using Calculator;

decimal number1 = 12;
decimal number2 = 13;

var resultAdd = Actions.Add(number1, number2);
var resultSubtract = Actions.Subtract(number1, number2);
var resultMultiply = Actions.Multiply(number1, number2);
var resultDivide  = Actions.Divide(number1, number2);


Console.WriteLine($"Add result: {resultAdd}");
Console.WriteLine($"Subtract result: {resultSubtract}");
Console.WriteLine($"Multiply result: {resultMultiply}");
Console.WriteLine($"Divide result: {resultDivide}");