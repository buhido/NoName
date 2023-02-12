// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


string[] arr = new string[] { "Errare", "humanum", "est" };// задаем строковый массив принимающий в себя элементы "Errare", "humanum", "est"
Console.WriteLine("Заданный массив данных:");
Console.WriteLine($"{PrintArray(arr)}");//печать в консоль принятых элементов
int length = 3;  // задаем параметр максимальной длины элемента массива   

int CheckArray(string[] arr, int length)// функция определения элементов массива меньше или равной длине length
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= length) result++;
    }
    return result;
}

int numbers = CheckArray(arr, length);// вводим новую переменную которой будем присваивать вычисленные элементы
                                      // массива меньше либо равные 3 символам
string[] newArrayStrings = new string[numbers]; // создаем новый массив строк с найденными элементами
NewArray(arr, newArrayStrings, length);

// функция формирования нового массива строк используя метод void (принимает, но не выводит)
void NewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}

// функция вывода нового массива в терминал
string PrintArray(string[] arr)
{
    string result;
    result = "[ ";
    for (int i = 0; i < arr.Length; i++)
    {
        result += $"{arr[i],1}";
        if (i < arr.Length - 1) result += ", ";
    }
    result += " ]";
    return result;
}

Console.WriteLine("Показываем элементы заданного массива, длина которых не больше 3 символов:");
Console.WriteLine($"{PrintArray(arr)} => {PrintArray(newArrayStrings)}");

