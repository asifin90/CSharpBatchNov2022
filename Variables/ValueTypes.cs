Console.Write("Welcome to C# programming!");

Console.WriteLine("Hello, World!");

//Addition of two number
int num1 = 10, num2 = 20;
Console.WriteLine("Addition of {0} and {1} : {2}", num1, num2, num1 + num2);
Console.WriteLine("Addition of "+ num1 + " and "+num2+" : "+ (num1 + num2));
Console.WriteLine("Addition of num1 and num2  : (num1 + num2)");


/*
   Substraction of two number
   To declare float variable add suffix  f or F of type float
   To declare double variable add suffix  d or D of type double, but it is optional for double
*/
float num3 = 9.3F;
double num4 = 3.0;
Console.WriteLine("Substraction of {0} and {1} : {2}", num3, num4, num3 + num4);


/*
   Multiplication of two number
   To declare decimal variable add suffix  m or M of type decimal
*/
decimal num5 = 9.25m;
decimal num6 = 3.054M;
Console.WriteLine("Multiplication of {0} and {1} : {2}", num5, num6, num5 * num6);


int num7 = 9; double num8 = 3.3d;
Console.WriteLine("Division of {0} and {1} : {2}", num7, num8, num7 / num8);

int num9 = 9, num10 = 3;    
Console.WriteLine("Mode of {0} and {1} : {2}", num9, num10, num9 % num10);
