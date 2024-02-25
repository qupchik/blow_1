Console.Write("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[m];

void array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-ю строку массива");
        stringArray[i] = Console.ReadLine();
    }
}
string[] intrestingSymbols(string[] stringArray)
{
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            n++;
    }
    string[] resultArray = new string[n];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            resultArray[j] = stringArray[i];
            j++;
        }
    }
    return resultArray;
}
void printArray(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"\"{stringArray[i]}\", ");
    }
    Console.Write("]");
}


array(stringArray);
printArray(stringArray);
Console.Write(" -> ");
printArray(intrestingSymbols(stringArray));

