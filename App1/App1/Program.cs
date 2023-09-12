using System;

namespace App1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int firstNumber = randomNumber.Next(-100, 100), secondNumber = randomNumber.Next(-100, 100);
            
            Console.WriteLine("(" + firstNumber + " * " + secondNumber + ")^2 = " + ToSquare(firstNumber, secondNumber));
        }

        /// <summary>
        /// Функция возведения в квадрат произведения двух целых чисел
        /// </summary>
        /// <param name="firstNumber">Первое целое число</param>
        /// <param name="secondNumber">Второе целое число</param>
        /// <returns>Возведенное в квадрат произведение двух целых чисел</returns>
        static int ToSquare(int firstNumber, int secondNumber)
        {
            return (firstNumber * secondNumber) * (firstNumber * secondNumber);
        }
    }
}