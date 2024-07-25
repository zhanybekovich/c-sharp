/* Comparison operations */
// ==
//Console.WriteLine(10 == 20);

// !=
//Console.WriteLine(10 != 20);

// <
//Console.WriteLine(10 < 20);

// >
//Console.WriteLine(10 > 20);

// <=
//Console.WriteLine(10 <= 20);

// >=
//Console.WriteLine(10 >= 20);

/* Logical operations */
// || - OR
//Console.WriteLine((5 > 6) || (4 < 6));

// && - AND
//Console.WriteLine((5 > 6) && (4 < 6));

//! - NOT
//Console.WriteLine(!true);

/*  if..else */
//int num1 = 8;
//int num2 = 6;
//if (num1 > num2)
//{
//    Console.WriteLine($"{num1} is greater than {num2}");
//}
//else
//{
//    Console.WriteLine($"{num1} is less than {num2}");
//}

// else if
//int num3 = 8;
//int num4 = 6;
//if (num3 > num4)
//{
//    Console.WriteLine($"{num3} is greater than {num4}");
//}
//else if (num3 < num4)
//{
//    Console.WriteLine($"{num3} is less than {num4}");
//} else
//{
//    Console.WriteLine($"{num3} is equal {num4}");
//}

/* Ternary operator */
//int a = 3;
//int b = 2;

//int c = a < b ? (a + b) : (a - b);
//Console.WriteLine(c);   // 1

/* Ex.1 
 * Write a console program in which the user enters two numbers from the keyboard. 
 * The program compares the two numbers and displays the result of the comparison 
 * on the console (two numbers are equal, 
 * the first number is greater than the second or the first number 
 * is less than the second).
 */
//Console.WriteLine("Enter 1st number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter 2nd number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 > num2)
//{
//    Console.WriteLine("Number1 is greater!");
//} else if (num1 < num2)
//{
//    Console.WriteLine("Number2 is greater!");
//} else
//{
//    Console.WriteLine("Equal!");
//}

/* Ex.2
 * Write a console program in which the user enters a number from the keyboard. 
 * If the number is both greater than 5 and less than 10, 
 * the program outputs "Number greater than 5 and less than 10". 
 * Otherwise, the program displays the message "Unknown number".
 */
//Console.WriteLine("Enter a number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//if(num > 5 && num < 10)
//{
//    Console.WriteLine("Number greater than 5 and less than 10");
//} else
//{
//    Console.WriteLine("Unknown number");
//}

/* Ex.3
 * Write a console program in which the user enters a number from the keyboard. 
 * If the number is either equal to 5 or equal to 10, 
 * the program outputs "The number is either equal to 5 or equal to 10". 
 * Otherwise, the program outputs the message "Unknown number".
 */
//Console.WriteLine("Enter a number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num == 5 || num == 10)
//{
//    Console.WriteLine("The number is either equal to 5 or equal to 10");
//}
//else
//{
//    Console.WriteLine("Unknown number");
//}

/* Ex.4
 * In a bank, depending on the amount of a deposit, 
 * the interest accrued on the deposit may vary. 
 * Write a console program in which the user enters the deposit amount. 
 * If the deposit amount is less than 100, 5% is charged. 
 * If the deposit amount is from 100 to 200, 7% is accrued. 
 * If the deposit amount is more than 200, 10% is accrued. 
 * At the end the program should output the deposit amount with accrued interest.
 * Use Convert.ToDouble(Console.ReadLine()) for input
 */
//Console.WriteLine("Enter your deposit sum: ");
//double deposit = Convert.ToDouble(Console.ReadLine());
//double rate = 1;

//if (deposit < 100)
//{
//    rate = 0.05;
//} else if (deposit <= 200)
//{
//    rate = 0.07;
//} else
//{
//    rate = 0.1;
//}

//double total = deposit * rate + deposit;
//Console.WriteLine(total);