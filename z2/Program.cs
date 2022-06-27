int ThirdNumber (int num)
{
    while (num > 999) 
    {
        num = num / 10;
    }
    
    int res = num % 10;

    return res;
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("There is no third!");
}
else 
{
    int result = ThirdNumber(number);
    Console.WriteLine("Third number - " + result);
}
