// Types

// bool
bool alive = true;
bool isMarried = false;

/* 
 * byte: stores an integer from 0 to 255 and occupies 1 byte. 
 * It is represented by the System.Byte system type
 */
byte bit1 = 1;
byte bit2 = 102;

/* 
 * sbyte: stores an integer from -128 to 127 and occupies 1 byte. 
 * It is represented by the System.SByte system type
 */
sbyte bit3 = -101;
sbyte bit4 = 102;

/* 
 * short: Stores an integer from -32768 to 32767 and occupies 2 bytes. 
 * It is represented by the System.Int16 system type
 */
short n1 = 1;
short n2 = 102;

/* 
 * ushort: stores an integer from 0 to 65535 and occupies 2 bytes. 
 * It is represented by system type System.UInt16
 */
ushort n3 = 1;
ushort n4 = 102;

/* 
 * int: stores an integer from -2147483648 to 2147483647 and occupies 4 bytes. 
 * It is represented by the System.Int32 system type. 
 * All integer literals represent int type values by default:
 */
int a = 10;
int b = 0b101;
int c = 0xFF;

/* 
 * uint: stores an integer from 0 to 4294967295 and occupies 4 bytes. 
 * It is represented by the system type System.UInt32
 */
uint d = 10;
uint e = 0b101;
uint f = 0xFF;

/* 
 * long: Stores an integer from -9223372036854775808 to 9223372036854775807 
 * and occupies 8 bytes. 
 * It is represented by the System.Int64 system type
 */
long g = -10;
long h = 0b101;
long i = 0xFF;

/* 
 * ulong: Stores an integer from 0 to 18446744073709551615 and occupies 8 bytes. 
 * It is represented by the System.UInt64 system type
 */
ulong j = 10;
ulong k = 0b101;
ulong l = 0xFF;

/* 
 * float: Stores a floating point number from -3.4*1038 to 3.4*1038 and occupies 4 bytes. 
 * It is represented by the System.Single system type
 */
float radius = 5.0f;

/* 
 * double: Stores a floating point number from ±5.0*10-324 to ±1.7*10308 and occupies 8 bytes. 
 * It is represented by the System.Double system type
 */
double radius2 = 5.0;

/* 
 * decimal: stores a decimal fractional number. 
 * When used without decimal point, it has a value from ±1.0*10-28 to ±7.9228*1028, 
 * can store 28 decimal places, and occupies 16 bytes. 
 * It is represented by the System.Decimal system type
 */
decimal price = 19.95m;

/* 
 * char: stores a single character in Unicode encoding and occupies 2 bytes. 
 * It is represented by the System.Char system type
 */
char m = 'A';
char n = '\x5A';
char o = '\u0420';

/* 
 * string: stores a set of Unicode characters. 
 * It is represented by the System.String system type
 */
string hello = "Hello";
string word = "world";

/* 
 * object: can store a value of any data type and occupies 4 bytes on a 32-bit platform 
 * and 8 bytes on a 64-bit platform. 
 * It is represented by the System.Object system type, 
 * which is the base for all other .NET types and classes.
 */
object p = 22;
object q = 3.14;
object r = "hello code";

/*
 * Implicit typing
 */
var s = "Hell to World";
var t = 20;

