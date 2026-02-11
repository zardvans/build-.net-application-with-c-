// See https://aka.ms/new-console-template for more information
// Concatenate a literal string and a variable
string firstName = "Bob";
// string message = "Hello " + firstName;
// Console.WriteLine(message);

// Concatenate multiple variables and literal strings
// string greeting = "Hello";
// string message = greeting + ", " + firstName + "!";
// Console.WriteLine(message);

// Avoiding intermediate variables
// Console.WriteLine(greeting + " " + firstName + "!");

// Use string interpolation to combine a literal string and a variable value
string message = $"Hello {firstName}!";
Console.WriteLine(message);

// Use string interpolation with multiple variables and literal strings
int version = 11;
string updateText = "Update to Windows";
// string fullMessage = $"{updateText} {version}!";
// Console.WriteLine(fullMessage);

// Avoid intermediate variables
Console.WriteLine($"{updateText} {version}!");

// Combine verbatim literals and string interpolation
string projectName = "First-Project";
// Console.WriteLine($@"C:\Output\{projectName}\Data");
Console.WriteLine(@$"C:\Output\{projectName}\Data");