// See https://aka.ms/new-console-template for more information
// '//'  is used to comment a code , compiler ignore commented line 
Console.WriteLine("Hello, World!");  // Print/Write the message on console 
string name = Console.ReadLine(); // Takes the input from user/console

Console.WriteLine("Hello {0}", name);

sbyte num1 = 127; // range from -128 to 127, given an error value > 127 and value < -128,  takes 8 bit memory
//sbyte num1 = 128;  // Invalid as 128 is beyond the sbyte data type range
Console.WriteLine(num1);

byte num2 = 0; // range from 0 to 255,   
Console.WriteLine(num2); // num2 is variable name 

short num3=25;// range from -32768 to 32767
Console.WriteLine(num3); // num3, num4 variable name, word written after datatype, we called as variable name.

ushort num4 = 25; // range from 0 to 65535
Console.WriteLine(num4);

char ch = 'A';  // char data type hold only one character
Console.WriteLine(ch);

string str="A@";  // string data type can hold multiple character
Console.WriteLine(str); 

bool flag = true;   // boolean data type variable hold only true or false. Its like Switch On/Off (0/1)
Console.WriteLine(flag);

