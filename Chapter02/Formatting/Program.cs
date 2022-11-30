// numbered positional arguments

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple
);

// five or more paramater values cannot use named arguments

Console.WriteLine(
    format: "{0} {1} lived in {2}, {3} and worked in the {4}, team at {5}.",
    "Roger", "Cevung", "Stockholm", "Sweden", "Education", "Optimizely"
);