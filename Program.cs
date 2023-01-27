// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void ShowArray(string[] array, int size)
{
    Console.Write("[");
    for(int i =0; i < size; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.Write("]");
}

string[] myArray = {"Russia", "Denmark", "Kazan", "123"};
string[] newArray = new string[myArray.Length];
int j = 0;
int size = 0;
int maxSize = 3;
for(int i = 0;  i < myArray.Length; i++)
{
    if(myArray[i].Length <= maxSize)
    {
        size++;
        newArray[j] = myArray[i];
        j++;
    }
}

ShowArray(newArray, size);



/*
string[] Array;
Console.WriteLine("Введите массив строк, через пробел");
string stroka = Console.ReadLine();
Array = stroka.Split(' ');
var result = new string[Array.Length];
var realSize = 0;
foreach(var value in Array)
{
    if(value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}

Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);
*/