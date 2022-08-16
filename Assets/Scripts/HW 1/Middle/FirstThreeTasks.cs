using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstThreeTasks : MonoBehaviour
{

    //Написать метод, который будет принимать строку с числами, разделёнными пробелами и возвращать самое большое число. (известно, что строка с числами всегда в правильном формате)

    private int GetMaxNumber(string stringWithNumbers)
    {
        string[] stringNumbers = stringWithNumbers.Split(' ');
        int[] numbers = Array.ConvertAll(stringNumbers, s => int.Parse(s));
        int maxValue = numbers[0];

        foreach (int item in numbers)
        {
            if (item > maxValue)
                maxValue = item;
        }
        return maxValue;
    }


    /*Написать метод, который будет возвращать строку со всеми числами от 0 до числа n, с шагом x. Число n и x всегда положительные и больше 0. 
    Примеры: 
    CounterMethod(n: 5, x:1) -> “0 1 2 3 4 5”
    CounterMethod(n: 10, x:2) -> “0 2 4 6 8 10”
    CounterMethod(n: 10, x:3) -> “0 3 6 9”
    */

    private string CounterMethod(int n, int x)
    {
        int[] numbers = new int[n / x + 1];
        int index = 0;

        for (int i = 0; i <= n;)
        {
            numbers.SetValue(i, index);
            i += x;
            index++;
        }
        return String.Join(" ", numbers);
    }


    /*Написать метод, который будет получать массив положительных целых чисел, а возвращать сумму всех чётных цифр. 
    Если подходящих цифр в массиве нет, или массив пуст возвращать -1
    Пример:
    EvenSum(new int { 1, 3, 4, 6 }) -> 10
    EvenSum(new int { 1, 2, 3, 3 }) -> 2
    EvenSum(new int { 1, 3, 1, 7 }) -> -1
    EvenSum(new int {  }) -> -1
    */

    private int EvenSum(int[] array)
    {
        int sumOfEvenNumbers = 0;
        foreach (int item in array)
        {
            if (item % 2 == 0)
            {
                sumOfEvenNumbers += item;
            }
        }

        if (sumOfEvenNumbers == 0 || array.Length == 0)
            return -1;

        else return sumOfEvenNumbers;
    }
}
