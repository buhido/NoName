#**Итоговая проверочная работа.**#

*##Задача: Написать программу,которая из имеющегося массива строк формирует массив из строк,длина которых меньше или равна 3 символам.##*

*###Решение на языке С#.###*

*Задаем одномерный строковый массив строк,содержащий элементы "Errare", "humanum", "est":*
string[] arr = new string[] { "Errare", "humanum", "est" };

*Выводим в терминал:*
Console.WriteLine("Заданный массив данных:");

*Печать в консоль принятых элементов:*
Console.WriteLine($"{PrintArray(arr)}");

*Задаем параметр максимальной длины элемента массива:* 
int length = 3;  //   

*Задаем функцию определения элементов массива меньше или равной длине length,*
*включающий счетчик и вывод результатов до достижения заданной длины:*
int CheckArray(string[] arr, int length)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= length) result++;
    }
    return result;
}

*Вводим новую переменную, которой будем присваивать вычисленные элементы*
 *массива меньше либо равные 3 символам:*
int numbers = CheckArray(arr, length);

*Создаем новый массив строк с найденными элементами:*
string[] newArrayStrings = new string[numbers]; 
NewArray(arr, newArrayStrings, length);

*Задаем функцию формирования нового массива строк, с лементами меньше длины, используя метод void (принимает, но не выводит):*
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

*Функция вывода на печать в терминалнового массива:*
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