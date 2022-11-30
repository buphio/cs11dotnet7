// See https://aka.ms/new-console-template for more information

#pragma warning disable 0168 // variable declared but not used.
#pragma warning disable 0219 // variable assigned but not used.
#pragma warning disable 0414 // private field assigned but not used.


// ========== LITERAL VALUES ==========


char letter = 'A'; // assign literal characters

string firstName = "Bob"; // assign literal strings
string horizontalLine = new('-', count:74); // assign string with string class constructor
Console.WriteLine(horizontalLine);

string grinningEmoji = char.ConvertFromUtf32(0x1F600); // assign emoji by converting from Unicode
Console.WriteLine(grinningEmoji);
Console.WriteLine();

// Verbatim string (@ to disable escape characters)
string filePath = @"C:\television\sony\bravia.txt";


// Raw string literals
string xml = """
             <person age="50">
               <first_name>Mark</first_name>
             </person>
             """;
Console.WriteLine(xml);
Console.WriteLine();

// Raw interpolated string literals
var person = new { FirstName = "Alice", Age = 56 };

string json = $$"""
              {
                "first_name": "{{person.FirstName}}",
                "age": {{person.Age}},
                "calculation", "{{{ 1 + 2 }}}"
              }
              """;

Console.WriteLine(json);
