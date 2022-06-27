int SecondNumber (int num) 
{
    return num % 100 / 10;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int Second = SecondNumber(number);
Console.WriteLine("Second number - " + Second);
