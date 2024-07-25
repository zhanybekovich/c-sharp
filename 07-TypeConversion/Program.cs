// Types that can be savely automatically converted
/*
 * byte => short, ushort, int, uint, long, ulong, float, double, decimal
 * sbyte => short, int, long, float, double, decimal
 * short => int, long, float, double, decimal
 * ushort => int, uint, long, ulong, float, double, decimal
 * int => long, float, double, decimal
 * uint => long, ulong, float, double, decimal
 * long => float, double, decimal
 * ulong => float, double, decimal
 * float => double
 * char => ushort, int, uint, long, ulong, float, double, decimal
 * In other situations use EXPLICIT conversion
 */

// Explicit conversion
double a = 4.0;
decimal b = (decimal)a;
Console.WriteLine(b);
