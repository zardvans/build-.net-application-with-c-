// See https://aka.ms/new-console-template for more information
// Add two numeric values
// int firstNumber = 12;
// int secondNumber = 7;
// Console.WriteLine(firstNumber + secondNumber);

// Mix data types to force implicit type conversions
// string firstName = "Bob";
// int widgetsSold = 7;
// Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// Attempt a more advanced case of adding numbers and concatenating strings
// string firstName = "Bob";
// int widgetsSold = 7;
// Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

// Add parentheses to clarify your intention to the compiler
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

// Write code to perform addition, subtraction, multiplication, and division with integers
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");

// Add code to perform division using literal decimal data
decimal decimalQuotient = 7.0m / 5;
decimal decimalQuotient2 = 7 / 5.0m;
decimal decimalQuotient3 = 7.0m / 5.0m;
decimal decimalQuotient4 = 7 / 5;
Console.WriteLine($"Decimal Quotient: {decimalQuotient} {decimalQuotient2} {decimalQuotient3} {decimalQuotient4}");

// Add code to cast results of integer division
int first = 7;
int second = 5;
decimal castedQuotient = (decimal)first / (decimal)second;
Console.WriteLine($"Casted Quotient: {castedQuotient}");

// Write code to determine the remainder after integer division
Console.WriteLine($"Modulus of 200 / 5: {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5: {7 % 5}");

// Order of operations
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine($"Value 1: {value1}");
Console.WriteLine($"Value 2: {value2}");

// Increment and decrement
// int value = 0;
// value = value + 5;
// value += 5;

// int counter = 0;
// counter = counter + 1;
// counter++;

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

// Position the increment and decrement operators
int valueA = 1;
valueA++;
Console.WriteLine("First: " + valueA);
Console.WriteLine($"Second: {valueA++}");
Console.WriteLine("Third: " + valueA);
Console.WriteLine("Fourth: " + (++valueA));

// Challenge: Calculate Celsius given the current temperature in Fahrenheit
int fahrenheit = 94;
// decimal celsius = ((decimal)fahrenheit - 32) * 5 / 9;
// decimal celsius = (fahrenheit - 32m) * 5 / 9;
// decimal celsius = (fahrenheit - 32) * 5m / 9;
decimal celsius = (fahrenheit - 32) * 5 / 9m;
Console.WriteLine($"The temperature is: {celsius} Celcius.");