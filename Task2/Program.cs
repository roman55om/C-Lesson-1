Console.WriteLine("Enter a number from 1 to 7");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 1)
{
    Console.WriteLine("Monday");
}
else if (dayNumber == 2)
    {
      Console.WriteLine("Tuesday");  
    }
else if (dayNumber == 3)
    {
      Console.WriteLine("Wednesday");  
    }    
else if (dayNumber == 4)
    {
      Console.WriteLine("Thursday");  
    }
else if (dayNumber == 5)
    {
      Console.WriteLine("Friday");  
    }    
else if (dayNumber == 6)
    {
      Console.WriteLine("Saturday");  
    }
else if (dayNumber == 7)
    {
      Console.WriteLine("Sunday");  
    }    
else
{
    Console.WriteLine("Enter a correct number");
}