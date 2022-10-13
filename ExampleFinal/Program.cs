using System;
using static System.Console;

Clear();//очестить экран перед запуском программы

string[] array = AskArray();//строковый массив 
string[] result = FindLessThan(array, 3);//строковый массив (созданный из массива "array", с размерностью элеиента не более 3 символов)
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");//ввыод через интерполяцию строк 
//изначально формируем массив, заданный пользователем, затем производим выборку значений из указанного массива (не более трех символов)

string[] FindLessThan(string[] input, int n) //создание метода перебора всех элементов в массиве
{
    string[] output = new string[CountLessThan(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

string[] AskArray() {
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}
