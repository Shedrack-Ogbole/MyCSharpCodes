

try
{
    Console.WriteLine("Enter first number ");
    string num1 = Console.ReadLine();
    Console.WriteLine("Divided by");
    string num2 = Console.ReadLine();
    Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));
}
catch (FormatException err)
{
    Console.WriteLine("SYNTAX ERROR: Enter only numbers please");
}
catch (DivideByZeroException err)
{
    Console.WriteLine("MATH ERROR: you can't divide by zero");
}
catch (Exception err)
{
    Console.WriteLine(err);
}
finally
{
    Console.WriteLine("Thank You");
}
