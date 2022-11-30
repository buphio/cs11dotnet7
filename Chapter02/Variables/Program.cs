using System.Xml;


object height = 1.88; // storing a double in an object
object name = "Amir"; // storing a string in an object
Console.WriteLine($"{name} is {height} meters tall.");

// int length1 = name.Length; // compiler error!
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");

// dynamic can invoke members of value without explicit cast!
dynamic something = "Ahmed";
Console.WriteLine($"Lenght is {something.Length}");

// TYPE INFERENCE
/*
var population = 67_000_000;    // inferred to int
var weight = 1.88;              // inferred to double
var price = 4.99M;              // inferred to decimal
var fruit = "Apples";           // inferred to string - double quotes
var letter = 'Z';               // inferred to character - single quotes
var happy = true;               // inferred to boolean
*/


var xml1 = new XmlDocument();           // C#3 and later
XmlDocument xml2 = new XmlDocument();   // all C# versions

// target-typed new (C#9 and above)
XmlDocument xml3 = new();

Person kim = new();
kim.BirthDate = new(1967, 12, 26);

List<Person> people = new()
{
    new() { FirstName = "Alice" },
    new() { FirstName = "Bob" },
    new() { FirstName = "Charlie" }
};

Console.WriteLine($"\ndefault(int): {default(int)}");
Console.WriteLine($"default(bool): {default(bool)}");
Console.WriteLine($"default(DateTime): {default(DateTime)}");
Console.WriteLine($"default(string): {default(string)}\n");

int number = 42;
Console.WriteLine(number);
number = default;
Console.WriteLine(number);
