﻿/*int intNumber = 25;
double doubleNumber = 12.12;
string text = "some text";
bool logicVar = true;
комментирование Ctrl+/ или /* */

/*int num1 = 5;
int num2 = 10;
Console.WriteLine("My numbers are " + num1 + " and " + num2 + " and its good");
Console.WriteLine($"My numbers are {num1} and {num2} and its good");
*/


/*Console.Write("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);*/

/*//Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

Console.Write("Input a first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

/*//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
*/

Console.Write("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}