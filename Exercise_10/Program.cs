Console.WriteLine("Введите трехзначное число: ");
int SecondDigit (int a) 
{
    a = Math.Abs(a);
    return a / 10 % 10;
}
Console.WriteLine(SecondDigit(Convert.ToInt32(Console.ReadLine())));