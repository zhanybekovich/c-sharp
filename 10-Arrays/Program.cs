// Define array
int[] numbers = new int[4];

// or
int[] nums2 = new int[4] { 1, 2, 3, 5 };
int[] nums3 = new int[] { 1, 2, 3, 5 };
int[] nums4 = new[] { 1, 2, 3, 5 };
int[] nums5 = { 1, 2, 3, 5 };

// or
string[] people = { "Tom", "Sam", "Bob" };

// since c#12
int[] nums6 = [1, 2, 3, 5];

// indexes
Console.WriteLine(nums6[0]);

// change element by index
nums6[0] = 777;
Console.WriteLine(nums6[0]);

// length
Console.WriteLine(nums6.Length);

Console.WriteLine(numbers[^1]);  // 1st from the end
Console.WriteLine(numbers[^2]);  // 2nd
Console.WriteLine(numbers[^3]);  // 3rd

// looping
int[] myNumbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i < myNumbers.Length; i++)
{
    Console.WriteLine(myNumbers[i]);
}

foreach (int number in myNumbers)
{
    Console.WriteLine(number);
}

// nested arrays
int[,] nested = { { 0, 1, 2 }, { 3, 4, 5 } };

int[,,] nested2 = new int[2, 3, 4];