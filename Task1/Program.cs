Console.WriteLine("Enter first number to compare");
int numA = Convert.ToInt32(Console.ReadLine());
int squareRoot = numA * numA;
Console.WriteLine("Enter Square Root to compare");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB == squareRoot)
{
    Console.WriteLine("NumB is a square root of NumA");
}
else
{
    Console.WriteLine("NumB is not a square root of NumA");
}