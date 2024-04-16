// 1st exercise

using System.Net.Http.Headers;

Console.WriteLine("----Comparison of two numbers----");
Console.WriteLine("Write first number");
double firstNumber = 0;
double.TryParse(Console.ReadLine(), out firstNumber);

Console.WriteLine("Write second number to comparison with first number:");
double secondNumber = 0;
double.TryParse(Console.ReadLine(), out secondNumber);

if (firstNumber == secondNumber)
{
    Console.WriteLine("Numbers are equal");
}
else if (firstNumber > secondNumber)
{
    Console.WriteLine($"The {firstNumber} is grater than {secondNumber}");
}

else
{
    Console.WriteLine($"The {secondNumber} is grater than {firstNumber}");
}

// 2st exercise

Console.WriteLine("Write mounth:");
int mounth = 0;
int.TryParse(Console.ReadLine(),out mounth);

if (mounth == 1 && mounth == 2 && mounth == 3)
{
    Console.WriteLine("Your mounth: Spring");
}
else if (mounth == 4 && mounth == 5 && mounth == 6)
{
    Console.WriteLine("Your mounth: Summer ");
}
else if(mounth == 7 && mounth == 8 &&  mounth == 9)
{
    Console.WriteLine("Your mounth: Autumn");
}
else if(mounth == 10  && mounth == 11 &&  mounth == 12)
{
    Console.WriteLine("Your mounth: Winter");    
}
else
{
    Console.WriteLine("Mounth doesn't exist");    
}


// 3st exercise

Console.WriteLine("Write number from 1 to 100:");
if (int.TryParse(Console.ReadLine(), out int number))
{
    if (number < 1 || number > 100)
    {
        Console.WriteLine("Maximum value can be only 100!!!");
    }
    else
    {
        if (number % 15 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(number);
        }
    }
}
else
{
    Console.WriteLine("Incorect value");
}

// 4st exercise

Console.WriteLine("Write a:");
double a = 0;
double.TryParse(Console.ReadLine(), out a);

Console.WriteLine("Write b:");
double b = 0;
double.TryParse(Console.ReadLine(), out b);

Console.WriteLine("Write c:");
double c = 0;
double.TryParse(Console.ReadLine(), out c);

double discriminant = b * b - 4 * a * c;

double rootOfDiscriminant = Math.Sqrt(discriminant);

double aboveZeroX1 = -b + rootOfDiscriminant / 2 * a;
double aboveZeroX2 = -b - rootOfDiscriminant / 2 * a;

if (discriminant == 0)
{
    double x1 = -b / 2 * a;
}

else
{
    Console.WriteLine("X doesn't exist");
}
