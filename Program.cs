string[] array = { "1222", "58", "море", "3", "2", "456", "7", "151", "155" };

void PrintArray(string[] array)
{
       int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}" + ", ");
    }

}
Console.Write("Заданный массив: ");
PrintArray(array);

Console.WriteLine(Environment.NewLine);

//найти строки массива из трех символов.
    var result = new string[array.Length];
    var nameSize = 0;
    foreach (var name in array)
    {
        if (name.Length <= 3)
        {
            result[nameSize] = name;
            nameSize++;
        }
    }

Console.Write($"Строки заданного массива из трех символов: ");
Console.WriteLine(string.Join(", ", result));

