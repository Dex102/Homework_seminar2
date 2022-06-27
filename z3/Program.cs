bool days (int day)
{
    if (day > 5 && day <= 7) return true;
    else return false;
}

Console.Write("Input number: ");
int WeekDay = Convert.ToInt32(Console.ReadLine());

while (WeekDay > 7) 
{
    Console.Write("Invalid number! Input a new number: ");
    WeekDay = Convert.ToInt32(Console.ReadLine());
}

bool daycheck = days(WeekDay);

if (daycheck == true)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}
