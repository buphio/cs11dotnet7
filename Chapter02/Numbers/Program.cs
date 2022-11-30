#pragma warning disable 0168 // variable declared but not used.
#pragma warning disable 0219 // variable assigned but not used.
#pragma warning disable 0414 // private field assigned but not used.

// unsigned integer means positive whole number or 0
uint naturalNumber = 23;

// integer means negative or positive whole number or 0
int integerNumber = -23;

// float means single precision floating point (F makes it float literal)
float realNumber = 2.3F;

// double means double precision floating point (double is default type)
double anotherRealNumber = 2.3;

// three variables that store the number 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

// show the size of number data types
Console.WriteLine($"INT size: {sizeof(int)} // range: {int.MinValue:N0} to {int.MaxValue:N0}");
Console.WriteLine($"DOUBLE size: {sizeof(double)} // range: {double.MinValue:N0} to {double.MaxValue:N0}");
Console.WriteLine($"DECIMAL size: {sizeof(decimal)} // range: {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

// comparing double and decimal types
Console.WriteLine("\nUsing doubles:");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does not equal {0.3}");
}

Console.WriteLine("\nUsing decimals:");
decimal c = 0.1M; // M suffix means decimal literal value
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} does not equal {0.3M}");
}

