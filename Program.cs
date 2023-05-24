using System;
using System.Runtime.Versioning;
using static System.Console;

namespace Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            WriteLine("Введите целое число: ");
            int number = int.Parse(ReadLine());
            if (number % 2 == 0)
            {
                WriteLine($"Число {number} четное");
            }
            else
            {
                WriteLine($"Число {number} нечетное");
            }
            ReadKey();

            // задание 2
            WriteLine("Здравствуйте! Сколько карт у вас на руках?");
            int cardNumber = int.Parse(ReadLine());
            int sumCards = 0;
            for (int j = 0; j < cardNumber; j++)
            {
                WriteLine("Введите номинал карты: ");
                var card = ReadLine();
                switch (card)
                {
                    //case "1":
                    //    sumCards++;
                    //    break; вспомнила, что карты с номиналом 1 не существует)
                    case "2":
                        sumCards += 2;
                        break;
                    case "3":
                        sumCards += 3;
                        break;
                    case "4":
                        sumCards += 4;
                        break;
                    case "5":
                        sumCards += 5;
                        break;
                    case "6":
                        sumCards += 6;
                        break;
                    case "7":
                        sumCards += 7;
                        break;
                    case "8":
                        sumCards += 8;
                        break;
                    case "9":
                        sumCards += 9;
                        break;
                    case "10":
                        sumCards += 10;
                        break;
                    case "J":
                        sumCards += 10;
                        break;
                    case "Q":
                        sumCards += 10;
                        break;
                    case "K":
                        sumCards += 10;
                        break;
                    case "T":
                        sumCards += 10;
                        break;
                    default:
                        WriteLine("Вы ввели некорректное значение");
                        cardNumber++; // чтобы ввести cardNumber количество карт, а не меньше
                        break;
                }

            }
            WriteLine($"Сумма ваших карт: {sumCards}");
            ReadKey();

            // задание 3
            WriteLine("Введите число для проверки на простоту:");
            number = int.Parse(ReadLine());
            bool flag = false;
            int i = 2;
            while (i < number / 2)
            {
                if (number % i == 0)
                {
                    flag = true;
                    break;
                }
                i++;
            }
            if (flag)
            {
                WriteLine($"Число {number} - составное");
            }
            else if (number == 1)
            {
                WriteLine("Единица не является ни простым, ни составным числом");
            }
            else
            {
                WriteLine($"Число {number} - простое");
            }
            ReadKey();

            // задание 4
            WriteLine("Введите длину последовательности:");
            int lenght = int.Parse(ReadLine());
            int minValue = int.MaxValue;
            int temp;
            for (int j = 0; j < lenght; j++)
            {
                WriteLine($"Введите {j + 1} элемент:");
                temp = int.Parse(ReadLine());
                if (temp < minValue)
                {
                    minValue = temp;
                }
            }
            WriteLine($"Минимальное число в последовательности: {minValue}");
            ReadKey();

            // задание 5
            WriteLine("Введите максимальное число игры:");
            int maxNumber = int.Parse(ReadLine());
            Random random = new Random();
            int randomValue = random.Next(0, maxNumber + 1);
            int counter = 0;
            while (true)
            {
                counter++;
                WriteLine("Ведите число: ");
                string input = ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    WriteLine($"Было загадано число: {randomValue}");
                    break;
                }
                temp = int.Parse(input);
                if (temp < randomValue)
                {
                    WriteLine("Введенное число меньше загаданного.");
                }
                else if (temp > randomValue)
                {
                    WriteLine("Введенное число больше загаданного.");
                }
                else
                {
                    WriteLine($"Вы угадали! Количество ваших попыток: {counter}");
                    break;
                }
            }
            ReadKey();
        }
    }
}