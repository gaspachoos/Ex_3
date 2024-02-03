int[] FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 50);

    }
    return array;
}
void ShowArray(int[] array)
{
    Console.WriteLine("Изначальный массив ");
    foreach (int e in array)
    {
        Console.Write($"{e} ");
    }
    Console.WriteLine();
}
