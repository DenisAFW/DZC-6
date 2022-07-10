// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] Numbers(int size)
{
    int faggot = 0;
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        faggot = Convert.ToInt32(Console.ReadLine());
        array[i] = faggot;
    }
    return array;
}

int PositiveNumbers(int[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) j++;
    }
    return j;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводите числа в количестве размера массива");

int[] myarray = Numbers(size);

PositiveNumbers(myarray);
ShowArray(myarray);
Console.WriteLine("Количество положительных чисел равно " + PositiveNumbers(myarray));
