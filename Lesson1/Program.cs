using System;

Console.WriteLine("Hello World!");
string s1 = @"
a\
b
";
int i = 5;

string s2 = $"string s1 is {s1} and my number is {i + 2}";

Console.WriteLine(s1);

string s3 = String.Format("{0,-8:c} = {1}", i, "Osher");
Console.WriteLine(s3);
Console.WriteLine("{0,10:c} = {1}", i, "Dani");

Console.WriteLine(nameof(Lesson1.Dani.ClassB) + ": B");

Console.WriteLine( i + 2 switch
{
    1 => "One",
    2 => "Two",
    > 2 => "Many",
    _ => "Non-positive"
}
);