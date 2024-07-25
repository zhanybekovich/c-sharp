/*
 * For loop
 */
//for (int i = 1; i < 4; i++)
//{
//    Console.WriteLine(i);
//}

/*
 * Do...while
 */
//int i = 6;
//do
//{
//    Console.WriteLine(i);
//    i--;
//}
//while (i > 0);

/*
 * While
 */
//int i = 6;
//while (i > 0)
//{
//    Console.WriteLine(i);
//    i--;
//}

/*
 * Foreach
 */
//foreach (char c in "Tom")
//{
//    Console.WriteLine(c);
//}

/*
 * continue & break
 */
//for (int i = 0; i < 9; i++)
//{
//    if (i == 5)
//        break;
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 9; i++)
//{
//    if (i == 5)
//        continue;
//    Console.WriteLine(i);
//}

/*
 * Nested loops
 */
for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
}