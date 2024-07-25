/*
 * & - logical multiplication
 * Multiplication is done bit by bit, 
 * and if both operands have bit values equal to 1, the operation returns 1, 
 * otherwise it returns 0
 */
//int x1 = 2; //010
//int y1 = 5;//101
//Console.WriteLine(x1 & y1); // output 0

//int x2 = 4; //100
//int y2 = 5; //101
//Console.WriteLine(x2 & y2); // output 4

/*
 * | - logical addition
 * Similar to logical multiplication, 
 * the operation is also performed on binary digits, 
 * but now returns 1 if at least one number has 1 in a given digit
 */
//int x1 = 2; //010
//int y1 = 5;//101
//Console.WriteLine(x1 | y1); // output 7 - 111
//int x2 = 4; //100
//int y2 = 5;//101
//Console.WriteLine(x2 | y2); // output 5 - 101

/*
 * ^ - XOR
 */
//int x = 45; // The value to be encrypted is in binary form 101101
//int key = 102; // Let it be a key - in binary form 1100110

//int encrypt = x ^ key; // The result will be the number 1001011 or 75
//Console.WriteLine($"Encrypted number: {encrypt}");

//int decrypt = encrypt ^ key; // The result will be the original number 45
//Console.WriteLine($"Decoded number: {decrypt}");

/*
 * ~ - logical negation or inversion
 */
int x = 12;                 // 00001100
Console.WriteLine(~x);      // 11110011   or -13