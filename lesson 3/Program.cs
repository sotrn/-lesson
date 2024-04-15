//1st exercise
Console.WriteLine("Write number: ");
int number = 0;
int.TryParse(Console.ReadLine(), out number);

int digit1 = number % 10;          
int digit2 = (number / 10) % 10;   
int digit3 = number / 100;


int reversedNumber = digit1 * 100 + digit2 * 10 + digit3;

Console.WriteLine($"Number from right to left: {reversedNumber}" );
//2st exercise
Console.WriteLine("Write number which will be degreed:");
int numberDegree = 0;
int.TryParse(Console.ReadLine(), out numberDegree);

Console.WriteLine("Write degree of the number:");
int Degree = 0;
int.TryParse(Console.ReadLine(), out Degree);


Console.WriteLine($"Answer: {Math.Pow(numberDegree, Degree)}");

//3st exercise 

Console.WriteLine("Write number:");
int numberWtithoutTransition = 0;

int.TryParse(Console.ReadLine(), out numberWtithoutTransition);

int digits1 = numberWtithoutTransition / 100;        
int digits2 = (numberWtithoutTransition / 10) % 10;    
int digits3 = numberWtithoutTransition % 10;         

int newNumber = digit2 * 100 + digit1 * 10 + digit3;

Console.WriteLine($"Answer of transition digits: {newNumber} ");

//4st exercise
Console.WriteLine("Write number 1:");
double average1 = 0;
double.TryParse(Console.ReadLine(), out average1);

Console.WriteLine("Write number 2:");
double average2 = 0;
double.TryParse(Console.ReadLine(), out average2);

double averageCalculation = (average1 + average2) / 2;

Console.WriteLine($"Average of number 1 and number 2 are:{averageCalculation}");


//5st exercise
Console.WriteLine("Write radius of your circule");
double radius = 0;
double.TryParse(Console.ReadLine(), out radius);

double squareCalculation = 3.14 * (radius * radius);

Console.WriteLine($"Square of your circule are: {squareCalculation}");

//6st exervise


Console.Write("Write number: ");
int numberTransition = 0;
int.TryParse(Console.ReadLine(), out numberTransition);


int[] digits = new int[3];
digits[0] = numberTransition / 100; 
digits[1] = (numberTransition / 10) % 10; 
digits[2] = numberTransition % 10; 


int temp = digits[0];
digits[0] = digits[2];
digits[2] = temp;


int NewNumber = digits[0] * 100 + digits[1] * 10 + digits[2];

Console.WriteLine("Number after transition" + NewNumber);