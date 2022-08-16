using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEasyTasks : MonoBehaviour
{

    // Написать метод, который принимает на вход длины катетов прямоугольного треугольника, а возвращает его периметр.

    private double CalculateTrianglePerimeter(double firstCathet, double secondCathet)
    {
        return Math.Sqrt(firstCathet * firstCathet + secondCathet * secondCathet) + firstCathet + secondCathet;
    }



    // Написать метод, который возвращает true, если число x является делителем числа y?

    private bool isIntegerAdvisor(float x, float y)
    {
        return x % y == 0;
    }



    // Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, …, 7) возвращает день недели в виде члена enum(вам нужно будет самим его создать) и выводит на экран название этого дня недели (понедельник, вторник, …, воскресенье) (обязательно использовать ператор switch).
   
    private enum DayOfTheWeek
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    private DayOfTheWeek getDayOfTheWeek(int number)
    {
        switch (number)
        {
            case 1:
                showDayOfTheWeek(1);
                return DayOfTheWeek.Monday;
            case 2:
                showDayOfTheWeek(2);
                return DayOfTheWeek.Tuesday;
            case 3:
                showDayOfTheWeek(3);
                return DayOfTheWeek.Wednesday;
            case 4:
                showDayOfTheWeek(4);
                return DayOfTheWeek.Thursday;
            case 5:
                showDayOfTheWeek(5);
                return DayOfTheWeek.Friday;
            case 6:
                showDayOfTheWeek(6);
                return DayOfTheWeek.Saturday;
            case 7:
                showDayOfTheWeek(7);
                return DayOfTheWeek.Sunday;
            default:
                throw new Exception("Please, enter the correct number");
        }
    }

    void showDayOfTheWeek(int numberOfTheWeek)
    {
        Debug.Log(Enum.GetName(typeof(DayOfTheWeek), numberOfTheWeek));
    }



    // Напечатать 2 метода, которые переводят фунты в килограммы и обратно (1 фунт = 453 г).
  
    double LbToKg(double lb)
    {
        return lb * 0.453;
    }
    double KgToLb(double kg)
    {
        return kg / 0.453;
    }



    // Написать метод, который принимает на вход два различных десятичных числа. Метод должен вывести какое из них больше и какое меньше.
   
    void NumberComparison(float firstNumber, float secondNumber)
    {
        if (firstNumber > secondNumber)
            Debug.Log($"{firstNumber} > {secondNumber}");

        else if (firstNumber < secondNumber)
            Debug.Log($"{firstNumber} < {secondNumber}");

        else
            Debug.Log($"{firstNumber} = {secondNumber}");
    }




    // Сделать метод, который будет принимать текущий год, а возвращать текущий век
   
    int GetCurrentCentury(int currentYear)
    {
        if (currentYear >= 0)
            return currentYear / 100 + 1;
        else
            throw new Exception("Please, enter a positive number!");
    }
}
