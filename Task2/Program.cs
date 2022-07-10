// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

string Function(double a1, double b1, double a2, double b2) // Функция нахождения координат функциий.
{
    double x = (b1 + (-b2)) / -(a1 + (-a2));
    double y = a1 * x + b1;

    string f = Convert.ToString(x);                         // Перевод координат в string чтобы вывести из метода обе 
    string g = Convert.ToString(y);                         // координаты в одной переменной.
    string j = f + ";" + g;
    return j;
}

void ShowCoor(string j)
{
    Console.WriteLine("Координаты точка равны " + j);
}

Console.WriteLine("Введите числа для первого уравнения");
int a1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числа для второго уравнения");
int a2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());

ShowCoor(Function(a1, b1, a2, b2));