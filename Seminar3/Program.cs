/*Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных 
координат точек в этой четверти (x и y).

void WriteRange(int qudrant)
{
    if(qudrant < 1 && qudrant > 4) Console.Writeline("Uncorrect data");
    else if(qudrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(qudrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if(qudrant == 3) Console.WriteLine("x < 0 and y < 0");
    else Console.WriteLine("x < 0 and y < 0");
}

Console.Write("Input a number of quadrant: ");
int quad = Convert.ToInt32(Console.ReadLine());

WriteRange(quad);
*/

/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int QuarterFinder(int x, int y) {
    if (x == 0 || y == 0 ) {
        Console.WriteLine("It's not possible to set zero coordinates");
    }
    if (x > 0 && y > 0) {
        return 1;
    } else if (x < 0 && y > 0) {
        return 2;
    } else if (x < 0 && y < 0) {
        return 3;
    } else {
        return 4;
    }
}

int x;
int y;

Console.Write("Please enter coordinate x: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter coordinate y: ");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The quarter is " + quarterFinder(x, y));
*/

/*Напишите программу, которая принимает на вход число (N) 
и выдаёт квадраты чисел от 1 до N.

4
1 - 1
2 - 4
3 - 9
4 - 16

Решение

void WriteQuad(int number)
{
    int current = 1;
    while (current <= number)
    {
        Console.WriteLine($"{current} - {current * current}");
        current++;
    }
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
WriteQuad (number);
*/

/*Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 2D пространстве.


double Distance(double x1, double y1, double x2, double y2)
{
     double deltaX = x2 - x1;
    double deltaY = y2 - y1;
    return Math.Sqrt(deltaX  deltaX + deltaY  deltaY);
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Distance (x1, y1, x2, y2));

*/

/* с чата задачи

//Task #1

int QuarterFinder(int x, int y) {
    if (x == 0 || y == 0 ) {
        Console.WriteLine("It's not possible to set zero coordinates");
    }
    if (x > 0 && y > 0) {
        return 1;
    } else if (x < 0 && y > 0) {
        return 2;
    } else if (x < 0 && y < 0) {
        return 3;
    } else {
        return 4;
    }
}

int x;
int y;

Console.Write("Please enter coordinate x: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter coordinate y: ");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The quarter is " + quarterFinder(x, y));


//Task #2

void PowerPrinter(int n) {
    for(int i = 1; i <= n; ++i) {
       Console.WriteLine(i + " - " + Math.Pow(i, 2));
    }
}

int n;

Console.Write("Please enter a number to powering: ");
n = Convert.ToInt32(Console.ReadLine());

PowerPrinter(n);


//Task 3

double DecartDistanceFinder(double x1, double y1, double x2, double y2) {
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}

double x1;
double y1;
double x2;
double y2;

Console.WriteLine("Please enter coordinates of two points: ");
Console.Write("Please enter x1: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter y1: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter x2: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter y2: ");
y2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("The distance between points is {0:f2}", DecartDistanceFinder(x1, y1, x2, y2));
*/

