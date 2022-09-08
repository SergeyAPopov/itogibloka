
int primaryArrayLength = 3;
int stringLength = 3;
string[] array = GetArray(primaryArrayLength);
Console.WriteLine($"Первичный массив: [{string.Join(" : ", array)}]");
int resultArrayLength = ResultArrayLength(array, stringLength);
string[] resultArray = GetResultArray(resultArrayLength, stringLength, array);
Console.WriteLine($"Массив с длиной строк не более {stringLength}: [{string.Join(" : ", resultArray)}]");

int ResultArrayLength(string[] array, int stringLength)
{
    int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= stringLength)
    {
        result++;
    } 
}
return result;
}

string[] GetArray(int size) 
{
    string[] result = new string[size];
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент");
        result[i] = Convert.ToString(Console.ReadLine());
    }
    return result;
}

string[] GetResultArray(int size, int length, string[] array)
{
    string[] result = new string[size];
    int count = 0;
    for (int i = 0; i < primaryArrayLength; i++)
    {
        if (array[i].Length <= primaryArrayLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}




