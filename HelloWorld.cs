// echo to console
Console.WriteLine("Hello World!");

// declare strings 
string aFriend = "Bill";
Console.WriteLine(aFriend);
// one does not have to redeclare the variable if the value changes...
aFriend = "Maria";

//string with a variable
Console.WriteLine("Hello " + aFriend);

// a better way than using plus signs
// String interpolation
Console.WriteLine($"Hello {aFriend}");
