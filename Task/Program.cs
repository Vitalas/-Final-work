void PrintString(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"\"{arr[i]}\",");
    }
    Console.WriteLine($"\"{arr[^1]}\"]");
}

Console.Write("Введите количество строк в первом массиве 1-5(включительно): ");
int numberOfString = Convert.ToInt32(Console.ReadLine());

if ((numberOfString > 5) || (numberOfString < 1))
{
    Console.WriteLine("Не корректный ввод!");
    return;
}
string[] firstArray = new string[numberOfString];

for (int i = 0; i < firstArray.Length; i++)
{
    Console.Write($"Введите символы {i + 1}й строки: ");
    firstArray[i] = Console.ReadLine();
}

int numberOfString2 = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3) numberOfString2++;
}
string[] secondArray = new string[numberOfString2];

int j = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    {
        secondArray[j] = firstArray[i];
        j++;
    }
}

if (numberOfString2 == 0)
{
    Console.WriteLine();
    Console.Write("Первый массив: ");
    PrintString(firstArray);
    Console.Write("Массив из строк первого массива, длинна которых меньше или ровна трём символам: ");
    Console.WriteLine("[]");
    Console.WriteLine();
}
else
{
    Console.WriteLine();
    Console.Write("Первый массив: ");
    PrintString(firstArray);
    Console.Write("Массив из строк первого массива, длинна которых меньше или ровна трём  символам: ");
    PrintString(secondArray);
    Console.WriteLine();
}