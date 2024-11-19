using System;

namespace Converter
{
    class Programm
    {
        static void Main(string[] args)
        {
            int number;

            while (true) // Цикл для проверки ввода числа
            {
                Console.Write("Введите число которое вы хотите перевести в двоичную систему: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number)) // Проверяю получиться ли перевести введенные данные в int
                {
                    break;//Если проверка возращает true то выходу из цикла
                }
                else
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }
            }
            BinaryCalculation(number); //вызываем метод для рассчета числа 

            Console.WriteLine("");
            Console.WriteLine("Расчет выполнен, нажмите любую кнопку чтоб закрыть программу.");
            Console.ReadKey();

        }
        static void BinaryCalculation(int number) //Метод для вычисления бинарного числа
        {
            List<int> results = new List<int>(); // Лист в котором будут храниться результаты деления числа на 2
            for (int i = 1; i <= number; i = 1) // Цикл который выполняет деление пока число больше или равно 1
            {
                if (number % 2 == 0)
                {
                    results.Add(0);
                    number = number / 2; //Делим чтоб поменять состояние переменной 
                }
                else
                {
                    results.Add(1);
                    number = number / 2; //Делим чтоб поменять состояние переменной 
                }
            }
            results.Reverse(); // Переворачиваю список чтоб получить бинарное число
            foreach (int item in results) // Цикл для выводя элементов пока что либо есть в results
            {
                Console.Write(item);
            }
        }
    }
}