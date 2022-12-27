// See https://aka.ms/new-console-template for more information

// объявление массива
string[] array1 = new string[6] {"13", "253","56789", "hello", "world", "row"};
string[] array2 = new string[array1.Length];

SecondArrayWithIF(array1, array2);
PrintArray(array2);

// метод анализ массива
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

// метод вывод массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
