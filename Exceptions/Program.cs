try
{
    int num = int.Parse("aaa");
}
catch (ArgumentNullException)
{
    Console.WriteLine("Catch ArgumentNullException");
}
catch (FormatException)
{
        Console.WriteLine("Catch FormatException");
}
catch (Exception)
{
    Console.WriteLine("Catch");
}
finally
{
    Console.WriteLine("Finally");
}
Console.WriteLine("Did it!");

