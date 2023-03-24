// Написать программу, которая из имеющегося
// массива строк формирует массив из строк, длина которых <=3 символа. 
// Первоначальный маcсив можно задать на старте выполнения алгоритма.

string[] array = { "hello", "2", "yes", "world", ":-)" };
Console.WriteLine();
StartArray(array);
Console.WriteLine();
Console.WriteLine();
FinishArray(array);
Console.WriteLine();

// методы
void StartArray(string[] startArray)
{
    Console.Write("Start array: [");
    for (int i = 0; i < startArray.Length; i++)
    {
        if (i < startArray.Length - 1) Console.Write($"{startArray[i],8},");
        if (i == startArray.Length - 1) Console.Write($"{startArray[i],8}]");
        
    }
}
void FinishArray(string[] startArray)
{
    Console.Write("Finish array: [");
    string[] arrayNew = new string[startArray.Length];
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= 3)
        {
            arrayNew[i] = startArray[i];
            if (i < startArray.Length - 1) Console.Write($"{array[i],8},");
            if (i == startArray.Length - 1) Console.Write($"{array[i],8}]");
        }
    }
    Console.WriteLine();
}

