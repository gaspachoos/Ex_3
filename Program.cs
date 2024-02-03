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

int[] ArrayReversal(int[] array)
{
    int x = 0;
    if (array.Length == 0)
    {
        Console.WriteLine("Развернутый массив ");
        return array;
    }
    ArrayReversal(array[1..]);
    Console.Write($" {array[x]} ");
    return array;
}