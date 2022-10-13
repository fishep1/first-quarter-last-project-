using System;
using static System.Console;

Clear();//очестить экран перед запуском программы

string[] array = AskArray();//строковый массив 
string[] result = FindLessThan(array, 3);//строковый массив (созданный из массива "array", с размерностью элеиента не более 3 символов)
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");//ввыод через интерполяцию строк 
//изначально формируем массив, заданный пользователем, затем производим выборку значений из указанного массива (не более трех символов)

string[] FindLessThan(string[] input, int n) //метод перебора всех элементов в массиве с провекрой условия (n = 3)
{
    string[] output = new string[CountLessThan(input, n)];//вызов метода с условием (n = 3)

    for(int i = 0, j = 0; i < input.Length; i++) // цикл по которому проверяем все элемменты массива
    {
        if(input[i].Length <= n) /*Условие при котором (n = 3), а значит если элемент массива меньше либо равен 3 символам 
        переносим этот элемент в финальный массив, и так пока не проверим все элементы исходного массива*/
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;//возвращаем значение 
}

int CountLessThan(string[] input, int n) // метод перебора всех элементов массива
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            count++;
        }
    }

    return count;
}

string[] AskArray() //создание исходного массива, вводим с клавиатуры через пробел
{
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}
