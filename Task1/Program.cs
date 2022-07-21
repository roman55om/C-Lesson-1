/*
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
} */
void Task0()
{

    // Write a program that takes an input number
    // and outputs its square root.

    Console.WriteLine("Enter a number");
    int number = Convert.ToInt32(Console.ReadLine());
    int squareRoot;
    squareRoot = number * number;
    Console.WriteLine($"{number}^2 = {squareRoot}");
}

void Task3()
{
    //3. Write a program that identifies the day
    //of the week by an input number

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
}

void Task5()
{
    //5. Напишите программу вычисления значения функции возведения числа в квадрат.
    int number = 3;
    Console.WriteLine(Power(number));
    number = 9;
    PowerProcedural(number);

    int Power(int currentNumber)
    {
        return currentNumber * currentNumber;
    }

    void PowerProcedural(int currentNumber)
    {
        Console.WriteLine(currentNumber * currentNumber);
    }
}
    //Task0();
    //Task3();
    //Task5();

void Task7()
{
    //7. Write a program that takes an input number (N)
    // and returns its sequence from -N to N.

    Console.WriteLine("Enter a number");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);
    int startNumber = -number;
    while (startNumber <= number)
    {
        Console.Write(startNumber + ",");
        startNumber+=1;
    }
    Console.Write("\b.");
    Console.WriteLine();
}

//HomeTask

void Task2()
{
    //Task2. Write a program that takes two input numbers
    // and returns max and min

    Console.WriteLine("Enter the 1st number");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the 2nd number");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int maxnumber;
    int minnumber;

    if (number1 > number2)
    {
        maxnumber = number1;
        minnumber = number2;
    }

    else 
    { 
        maxnumber = number2;
        minnumber = number1;
    }

    Console.WriteLine($"Max number is {maxnumber}, min number is {minnumber}");
}

void Task4()
{
    // Task 4. Write a program that takes 3 input numbers 
    // and returns maximum

    Console.WriteLine("Enter the 1st number");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the 2nd number");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the 3rd number");
    int number3 = Convert.ToInt32(Console.ReadLine());

    int maxnumber;

    if (number1 > number2)
    {
        maxnumber = number1;
    }

    else
    {
        maxnumber = number2;
    }

    if (number3 > maxnumber)
    {
        maxnumber = number3;
    }

    Console.WriteLine($"Max number is {maxnumber}");
}

void Task6()
{
    //Task6. Write a program that takes an input number
    // and defines if it is an even number or not.

    Console.WriteLine("Enter a number");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);

    if (number % 2 == 1)
    {
        Console.WriteLine($"The number {number} is odd");
    }

    else
    {
        Console.WriteLine($"The number {number} is even");
    }
}

void Task8()
{
    //Task 8. Write a program that takes
    // an input number (N)
    //and returns all even numbers from 1 to N.

    Console.WriteLine("Enter a number");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);
    int startNumber = 1;

    while (startNumber <= number)
    {
        if (startNumber%2 !=1)
        {
            Console.Write(startNumber + ",");
            startNumber+=1;
        }

        else 
        {
            startNumber+=1;
        } 
    }
    Console.Write("\b.");
    Console.WriteLine();
}    

//Task0();
//Task1();
//Task3();
//Task4();
//Task5();
//Task6();
//Task7();
//Task8();
