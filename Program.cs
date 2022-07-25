/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
 длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
 */


// 1. Создание массива
// 2. Определение количества элементов массива длиной <= 3
// 3. Выбор элементов из созданного массива
// 4. Печать

string[] SelectElements(string[] str)
{
    int length = str.Length;
    int AmountElements(string[] str)
    {
        int amountElements = 0;
        for (int i = 0; i < length; i++)
        {
            if (str[i].Length <= 3) amountElements++;
        }
        return amountElements;
    }

    string[] selectedElements = new string[AmountElements(str)];
    int j = 0;
    for (int i = 0; i < length; i++)
    {
        if (str[i].Length <= 3)
        {
            selectedElements[j] = str[i];
            j++;
        }
    }
    return selectedElements;
}

string Print(string[] prt)
{
    int length = prt.Length;
    if (length == 0) return $"Нет удовлетворяющих условию строк. \n";
    else
    {
        string result = String.Empty;
        for (int i = 0; i < length; i++)
        {
            result += $"Строка {i + 1}: {prt[i]} \n";
        }
        return result;
    }

}

