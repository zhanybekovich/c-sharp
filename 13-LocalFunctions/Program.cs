/*
 * Local functions represent functions defined within other methods. 
 * A local function typically contains actions that apply only within its method.
 */

void Compare(int[] numbers1, int[] numbers2)
{
    int numbers1Sum = Sum(numbers1);
    int numbers2Sum = Sum(numbers2);

    if (numbers1Sum > numbers2Sum)
        Console.WriteLine("сумма чисел из массива numbers1 больше");
    else if (numbers1Sum < numbers2Sum)
        Console.WriteLine("сумма чисел из массива numbers2 больше");
    else
        Console.WriteLine("суммы чисел обоих массивов равны");

    int Sum(int[] numbers)
    {
        int result = 0;
        foreach (int number in numbers)
            result += number;
        return result;
    }
}

/*
 * Local functions represent functions defined within other methods. 
 * A local function typically contains actions that apply only within its method.
 */
int Sum(int[] numbers)
{
    int result = 0;
    int limit = 0;
    foreach (int number in numbers)
    {
        if (IsPassed(number, limit)) result += number;
    }
    return result;

    static bool IsPassed(int number, int lim)
    {
        //return number > limit; // Error: Method IsPassed does not have access to variable limit
        return number > lim;
    }
}