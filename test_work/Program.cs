int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string[] CreateArray(int l)
{
    string[] array = new string[l];
    for (int i = 0; i < l; i++)
    {
        System.Console.Write($"Введите {i + 1}-й элемент массива: ");
        array[i] = Console.ReadLine()!;

    }
    return array;
}

string[] FilterArray(string[] array)
{
    string[] newArray = new string[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = array[i];
        }
    }
    return newArray;
}

void PrintArray(string[] array, string text)
{
    System.Console.Write(text);
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int length = ReadInt("Введите размер массива: ");
string[] array = CreateArray(length);
string[] newArray = FilterArray(array);
PrintArray(array, "Заданный массив: ");
PrintArray(newArray, "Массив строк, длинной меньше либо равной 3: ");