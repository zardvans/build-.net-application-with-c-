// See https://aka.ms/new-console-template for more information

// Character escape sequences
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\console\\repos");

// Format output using character escape sequences
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");

// Verbatim string literal
// Console.WriteLine(@"    c:\source\repos
        // This is where your code goes)");

// Format output using verbatim string literals
Console.WriteLine(@"c:\invoices");

// Unicode escape characters
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// Format output using unicode escape characters
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");

// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
