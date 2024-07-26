DayTime now = DayTime.Evening;

PrintMessage(now);                  
PrintMessage(DayTime.Afternoon);    
PrintMessage(DayTime.Night);        

void PrintMessage(DayTime dayTime)
{
    switch (dayTime)
    {
        case DayTime.Morning:
            Console.WriteLine("Доброе утро");
            break;
        case DayTime.Afternoon:
            Console.WriteLine("Добрый день");
            break;
        case DayTime.Evening:
            Console.WriteLine("Добрый вечер");
            break;
        case DayTime.Night:
            Console.WriteLine("Доброй ночи");
            break;
    }
}

enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}

// enum types
/* byte, sbyte, short, ushort, int, uint, long, ulong */
enum Time : byte
{
    Morning,
    Afternoon,
    Evening,
    Night
}

// explicit values
enum DayTime2
{
    Morning = 2,
    Afternoon = 4,
    Evening = 8,
    Night = 16
}

