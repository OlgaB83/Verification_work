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
