void PrintString(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}

Console.Write("Введите количество строк в массиве: ");
int numberOfString = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[numberOfString];
string el = "";

for (int i = 0; i < firstArray.Length; i++)
{
    Console.Write($"Введите символы {i+1}й строки: ");
    el = Console.ReadLine();
    firstArray[i] = el;
}

PrintString(firstArray);

int numberOfString2 = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3) numberOfString2++;
}

string[] secondArray = new string[numberOfString2];