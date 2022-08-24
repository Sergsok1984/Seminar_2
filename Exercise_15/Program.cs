Console.WriteLine("Введите день недели от 1 до 7: ");
string Holiday(int dayNumber) 
{
    if (dayNumber == 6 || dayNumber == 7) 
    {
        return "Выходной день.";       
    }
    else if (dayNumber >= 1 && dayNumber <= 5)
    {
        return "Рабочий день.";        
    }
    else 
    { 
        return "Введено некорректное число.";        
    }
}
Console.WriteLine(Holiday(Convert.ToInt32(Console.ReadLine())));