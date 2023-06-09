﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulls_and_cows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Игра на логигу: Быки и коровы";
            string choise = "";
            int[] array = new int[4] { -1, -1, -1, -1 };
            Random rand = new Random();
            string input;
            int[] answer = new int[4];
            int bulls;
            int cows;
            switch (choise)
            {
                default:
                    Console.Clear();
                    Console.WriteLine("\n\t      БЫКИ И КОРОВЫ\n");
                    Console.WriteLine("\tВведите цифру для выбора\n");
                    Console.WriteLine("\t------------------------");
                    Console.WriteLine("\t|    1. Начать игру    |");
                    Console.WriteLine("\t------------------------");
                    Console.WriteLine("\t|  2. Совместная игра  |");
                    Console.WriteLine("\t------------------------");
                    Console.WriteLine("\t|      3. Правила      |");
                    Console.WriteLine("\t------------------------");
                    Console.WriteLine("\t|     Другое. Выйти    |");
                    Console.WriteLine("\t------------------------\n");
                    Console.Write("Выбор: ");
                    choise = Console.ReadLine();
                    if (choise == "1")
                        goto case "1";
                    else if (choise == "2")
                        goto case "2";
                    else if (choise == "3")
                        goto case "3";
                    else Environment.Exit(0);
                    break;
                case "1":
                    bulls = 0;
                    cows = 0;
                    Console.Clear();
                    Console.WriteLine("* напишите 0, если хотите вернуться в меню *\n");
                    for (int i = 0; i < 4; i++)
                    {
                        array[i] = rand.Next(0, 10);
                    }
                    while ((array[0] == array[1]) || (array[0] == array[2]) || (array[0] == array[3]) || 
                        (array[1] == array[2]) || (array[1] == array[3]) || (array[2] == array[3]))
                    {
                        if (array[1] == array[0])
                        { 
                            array[1] = rand.Next(0, 10);
                            continue;
                        }
                        if (array[2] == array[0])
                        {
                            array[2] = rand.Next(0, 10);
                            continue;
                        }
                        if (array[2] == array[1])
                        {
                            array[2] = rand.Next(0, 10);
                            continue;
                        }
                        if (array[3] == array[0])
                        {
                            array[3] = rand.Next(0, 10);
                            continue;
                        }
                        if (array[3] == array[1])
                        {
                            array[3] = rand.Next(0, 10);
                            continue;
                        }
                        if (array[3] == array[2])
                        {
                            array[3] = rand.Next(0, 10);
                            continue;
                        }
                    }


                    //for (int i = 0; i < array.Length; i++)
                    //{
                    //    Console.Write(array[i]);
                    //}
                    //Console.WriteLine("\t (Число выводится для тестирования. В конечном варианте оно будет скрыто от игрока)");


                    Console.WriteLine("Компьютер загадал число");
                    while (bulls < 4)
                    {
                        Console.Write("\nВаш ответ: ");
                        input = Console.ReadLine();
                        if (input == "0")
                            goto default;
                        if (input.Length > array.Length)
                        {
                            Console.WriteLine("ОШИБКА! Слишком много цифр. Должно быть 4! Попробуйте ещё раз");
                            continue;
                        }
                        if (input.Length < array.Length)
                        {
                            Console.WriteLine("ОШИБКА! Слишком мало цифр. Должно быть 4! Попробуйте ещё раз");
                            continue;
                        }
                        switch (input[0])
                        {
                            case '0':
                                answer[0] = 0;
                                break;
                            case '1':
                                answer[0] = 1;
                                break;
                            case '2':
                                answer[0] = 2;
                                break;
                            case '3':
                                answer[0] = 3;
                                break;
                            case '4':
                                answer[0] = 4;
                                break;
                            case '5':
                                answer[0] = 5;
                                break;
                            case '6':
                                answer[0] = 6;
                                break;
                            case '7':
                                answer[0] = 7;
                                break;
                            case '8':
                                answer[0] = 8;
                                break;
                            case '9':
                                answer[0] = 9;
                                break;
                            default:
                                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
                                continue;
                        }
                        switch (input[1])
                        {
                            case '0':
                                answer[1] = 0;
                                break;
                            case '1':
                                answer[1] = 1;
                                break;
                            case '2':
                                answer[1] = 2;
                                break;
                            case '3':
                                answer[1] = 3;
                                break;
                            case '4':
                                answer[1] = 4;
                                break;
                            case '5':
                                answer[1] = 5;
                                break;
                            case '6':
                                answer[1] = 6;
                                break;
                            case '7':
                                answer[1] = 7;
                                break;
                            case '8':
                                answer[1] = 8;
                                break;
                            case '9':
                                answer[1] = 9;
                                break;
                            default:
                                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
                                continue;
                        }
                        switch (input[2])
                        {
                            case '0':
                                answer[2] = 0;
                                break;
                            case '1':
                                answer[2] = 1;
                                break;
                            case '2':
                                answer[2] = 2;
                                break;
                            case '3':
                                answer[2] = 3;
                                break;
                            case '4':
                                answer[2] = 4;
                                break;
                            case '5':
                                answer[2] = 5;
                                break;
                            case '6':
                                answer[2] = 6;
                                break;
                            case '7':
                                answer[2] = 7;
                                break;
                            case '8':
                                answer[2] = 8;
                                break;
                            case '9':
                                answer[2] = 9;
                                break;
                            default:
                                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
                                continue;
                        }
                        switch (input[3])
                        {
                            case '0':
                                answer[3] = 0;
                                break;
                            case '1':
                                answer[3] = 1;
                                break;
                            case '2':
                                answer[3] = 2;
                                break;
                            case '3':
                                answer[3] = 3;
                                break;
                            case '4':
                                answer[3] = 4;
                                break;
                            case '5':
                                answer[3] = 5;
                                break;
                            case '6':
                                answer[3] = 6;
                                break;
                            case '7':
                                answer[3] = 7;
                                break;
                            case '8':
                                answer[3] = 8;
                                break;
                            case '9':
                                answer[3] = 9;
                                break;
                            default:
                                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
                                continue;
                        }
                        if ((answer[0] == answer[1]) || (answer[0] == answer[2]) || (answer[0] == answer[3]) ||
                        (answer[1] == answer[2]) || (answer[1] == answer[3]) || (answer[2] == answer[3]))
                        {
                            Console.WriteLine("ОШИБКА! Цифры не должны повторяться. Попробуйте ещё рвз");
                            continue;
                        }
                        bulls = 0;
                        cows = 0;
                        for (int i = 0; i < answer.Length; i++)
                        {
                            if (answer[i] == array[i])
                                bulls++;
                        }
                        if (answer[0] == array[1] || answer[0] == array[2] || answer[0] == array[3])
                            cows++;
                        if (answer[1] == array[0] || answer[1] == array[2] || answer[1] == array[3])
                            cows++;
                        if (answer[2] == array[0] || answer[2] == array[1] || answer[1] == array[3])
                            cows++;
                        if (answer[3] == array[0] || answer[3] == array[1] || answer[3] == array[2])
                            cows++;
                        Console.WriteLine($"Быки: {bulls}   Коровы: {cows}");
                    }
                    Console.WriteLine("\nВы отгадали число! Поздравляем :)\n");
                    Console.WriteLine("\t------------------------");
                    Console.WriteLine("\t|    1. Сыграть ещё    |");
                    Console.WriteLine("\t------------------------");
                    Console.WriteLine("\t|  2. Вернуться в меню |");
                    Console.WriteLine("\t------------------------");
                    Console.WriteLine("\t|     Другое. Выйти    |");
                    Console.WriteLine("\t------------------------\n");
                    Console.Write("Выбор: ");
                    choise = Console.ReadLine();
                    if (choise == "1")
                        goto case "1";
                    else if (choise == "2")
                        goto default;
                    else Environment.Exit(0);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("* напишите 0, если хотите вернуться в меню *\n");
                    Console.WriteLine("\tСОВМЕСТНАЯ ИГРА");
                    array[3] = -1;
                    bulls = 0;
                    cows = 0;
                    while (array[3] == -1)
                    {
                        Console.Write("\nЗагадайте число: ");
                        input = Console.ReadLine();
                        if (input == "0")
                            goto default;
                        if (input.Length > array.Length)
                        {
                            Console.WriteLine("ОШИБКА! Слишком много цифр. Должно быть 4! Попробуйте ещё раз");
                            continue;
                        }
                        if (input.Length < array.Length)
                        {
                            Console.WriteLine("ОШИБКА! Слишком мало цифр. Должно быть 4! Попробуйте ещё раз");
                            continue;
                        }
                        switch (input[0])
                        {
                            case '0':
                                array[0] = 0;
                                break;
                            case '1':
                                array[0] = 1;
                                break;
                            case '2':
                                array[0] = 2;
                                break;
                            case '3':
                                array[0] = 3;
                                break;
                            case '4':
                                array[0] = 4;
                                break;
                            case '5':
                                array[0] = 5;
                                break;
                            case '6':
                                array[0] = 6;
                                break;
                            case '7':
                                array[0] = 7;
                                break;
                            case '8':
                                array[0] = 8;
                                break;
                            case '9':
                                array[0] = 9;
                                break;
                            default:
                                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
                                continue;
                        }
                        switch (input[1])
                        {
                            case '0':
                                array[1] = 0;
                                break;
                            case '1':
                                array[1] = 1;
                                break;
                            case '2':
                                array[1] = 2;
                                break;
                            case '3':
                                array[1] = 3;
                                break;
                            case '4':
                                array[1] = 4;
                                break;
                            case '5':
                                array[1] = 5;
                                break;
                            case '6':
                                array[1] = 6;
                                break;
                            case '7':
                                array[1] = 7;
                                break;
                            case '8':
                                array[1] = 8;
                                break;
                            case '9':
                                array[1] = 9;
                                break;
                            default:
                                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
                                continue;
                        }
                        switch (input[2])
                        {
                            case '0':
                                array[2] = 0;
                                break;
                            case '1':
                                array[2] = 1;
                                break;
                            case '2':
                                array[2] = 2;
                                break;
                            case '3':
                                array[2] = 3;
                                break;
                            case '4':
                                array[2] = 4;
                                break;
                            case '5':
                                array[2] = 5;
                                break;
                            case '6':
                                array[2] = 6;
                                break;
                            case '7':
                                array[2] = 7;
                                break;
                            case '8':
                                array[2] = 8;
                                break;
                            case '9':
                                array[2] = 9;
                                break;
                            default:
                                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
                                continue;
                        }
                        switch (input[3])
                        {
                            case '0':
                                array[3] = 0;
                                break;
                            case '1':
                                array[3] = 1;
                                break;
                            case '2':
                                array[3] = 2;
                                break;
                            case '3':
                                array[3] = 3;
                                break;
                            case '4':
                                array[3] = 4;
                                break;
                            case '5':
                                array[3] = 5;
                                break;
                            case '6':
                                array[3] = 6;
                                break;
                            case '7':
                                array[3] = 7;
                                break;
                            case '8':
                                array[3] = 8;
                                break;
                            case '9':
                                array[3] = 9;
                                break;
                            default:
                                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
                                break;
                        }
                        if ((array[0] == array[1]) || (array[0] == array[2]) || (array[0] == array[3]) ||
                            (array[1] == array[2]) || (array[1] == array[3]) || (array[2] == array[3]))
                        {
                            Console.WriteLine("ОШИБКА! Цифры не должны повторяться. Попробуйте ещё рвз");
                            array[3] = -1;
                            continue;
                        }
                    }
                    Console.Write("Нажмите любую клавишу, когда игрок будет готов отгадывать...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("* напишите 0, если хотите вернуться в меню *\n");
                    Console.WriteLine("\tСОВМЕСТНАЯ ИГРА");
                    Console.Write("\nЗагаданное число: ****");
                    while (bulls < 4)
                    {
                        Console.Write("\nВаш ответ: ");
                        input = Console.ReadLine();
                        if (input == "0")
                            goto default;
                        if (input.Length > array.Length)
                        {
                            Console.WriteLine("ОШИБКА! Слишком много цифр. Должно быть 4! Попробуйте ещё раз");
                            continue;
                        }
                        if (input.Length < array.Length)
                        {
                            Console.WriteLine("ОШИБКА! Слишком мало цифр. Должно быть 4! Попробуйте ещё раз");
                            continue;
                        }
                        switch (input[0])
                        {
                            case '0':
                                answer[0] = 0;
                                break;
                            case '1':
                                answer[0] = 1;
                                break;
                            case '2':
                                answer[0] = 2;
                                break;
                            case '3':
                                answer[0] = 3;
                                break;
                            case '4':
                                answer[0] = 4;
                                break;
                            case '5':
                                answer[0] = 5;
                                break;
                            case '6':
                                answer[0] = 6;
                                break;
                            case '7':
                                answer[0] = 7;
                                break;
                            case '8':
                                answer[0] = 8;
                                break;
                            case '9':
                                answer[0] = 9;
                                break;
                            default:
                                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
                                continue;
                        }
                        switch (input[1])
                        {
                            case '0':
                                answer[1] = 0;
                                break;
                            case '1':
                                answer[1] = 1;
                                break;
                            case '2':
                                answer[1] = 2;
                                break;
                            case '3':
                                answer[1] = 3;
                                break;
                            case '4':
                                answer[1] = 4;
                                break;
                            case '5':
                                answer[1] = 5;
                                break;
                            case '6':
                                answer[1] = 6;
                                break;
                            case '7':
                                answer[1] = 7;
                                break;
                            case '8':
                                answer[1] = 8;
                                break;
                            case '9':
                                answer[1] = 9;
                                break;
                            default:
                                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
                                continue;
                        }
                        switch (input[2])
                        {
                            case '0':
                                answer[2] = 0;
                                break;
                            case '1':
                                answer[2] = 1;
                                break;
                            case '2':
                                answer[2] = 2;
                                break;
                            case '3':
                                answer[2] = 3;
                                break;
                            case '4':
                                answer[2] = 4;
                                break;
                            case '5':
                                answer[2] = 5;
                                break;
                            case '6':
                                answer[2] = 6;
                                break;
                            case '7':
                                answer[2] = 7;
                                break;
                            case '8':
                                answer[2] = 8;
                                break;
                            case '9':
                                answer[2] = 9;
                                break;
                            default:
                                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
                                continue;
                        }
                        switch (input[3])
                        {
                            case '0':
                                answer[3] = 0;
                                break;
                            case '1':
                                answer[3] = 1;
                                break;
                            case '2':
                                answer[3] = 2;
                                break;
                            case '3':
                                answer[3] = 3;
                                break;
                            case '4':
                                answer[3] = 4;
                                break;
                            case '5':
                                answer[3] = 5;
                                break;
                            case '6':
                                answer[3] = 6;
                                break;
                            case '7':
                                answer[3] = 7;
                                break;
                            case '8':
                                answer[3] = 8;
                                break;
                            case '9':
                                answer[3] = 9;
                                break;
                            default:
                                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
                                continue;
                        }
                        if ((answer[0] == answer[1]) || (answer[0] == answer[2]) || (answer[0] == answer[3]) ||
                        (answer[1] == answer[2]) || (answer[1] == answer[3]) || (answer[2] == answer[3]))
                        {
                            Console.WriteLine("ОШИБКА! Цифры не должны повторяться. Попробуйте ещё рвз");
                            continue;
                        }
                        bulls = 0;
                        cows = 0;
                        for (int i = 0; i < answer.Length; i++)
                        {
                            if (answer[i] == array[i])
                                bulls++;
                        }
                        if (answer[0] == array[1] || answer[0] == array[2] || answer[0] == array[3])
                            cows++;
                        if (answer[1] == array[0] || answer[1] == array[2] || answer[1] == array[3])
                            cows++;
                        if (answer[2] == array[0] || answer[2] == array[1] || answer[1] == array[3])
                            cows++;
                        if (answer[3] == array[0] || answer[3] == array[1] || answer[3] == array[2])
                            cows++;
                        Console.WriteLine($"Быки: {bulls}   Коровы: {cows}");
                    }
                    Console.WriteLine("\nВы отгадали число! Поздравляем :)\n");
                    Console.WriteLine("\t------------------------");
                    Console.WriteLine("\t|    1. Сыграть ещё    |");
                    Console.WriteLine("\t------------------------");
                    Console.WriteLine("\t|  2. Вернуться в меню |");
                    Console.WriteLine("\t------------------------");
                    Console.WriteLine("\t|     Другое. Выйти    |");
                    Console.WriteLine("\t------------------------\n");
                    Console.Write("Выбор: ");
                    choise = Console.ReadLine();
                    if (choise == "1")
                        goto case "2";
                    else if (choise == "2")
                        goto default;
                    else Environment.Exit(0);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("\n\t   ПРАВИЛА ИГРЫ\n");
                    Console.WriteLine("Компьютер задумывает четыре различные");
                    Console.WriteLine("цифры от 0 до 9. Игрок делает ходы,");
                    Console.WriteLine("чтобы узнать эти цифры и их порядок.\n");
                    Console.WriteLine("Каждый ход состоит из четырёх цифр, 0");
                    Console.WriteLine("может стоять на первом месте.\n");
                    Console.WriteLine("В ответ компьютер показывает число");
                    Console.WriteLine("отгаданных цифр, стоящих на своих");
                    Console.WriteLine("местах (число быков) и число отгаданных");
                    Console.WriteLine("цифр, стоящих не на своих местах (число коров).\n");
                    Console.WriteLine("\t      ПРИМЕР\n");
                    Console.WriteLine("Компьютер задумал 0834.\n");
                    Console.WriteLine("Игрок сделал ход 8134.\n");
                    Console.WriteLine("Компьютер ответил: 2 быка (цифры 3 и 4) и");
                    Console.WriteLine("1 корова (цифра 8).");
                    Console.WriteLine("\n\n\n     ПРАВИЛА ДЛЯ СОВМЕСТНОЙ ИГРЫ\n");
                    Console.WriteLine("Правила те же, за исключением того,");
                    Console.WriteLine("что один из игроков сам загадывает");
                    Console.WriteLine("число, которое должен отгадать второй.");
                    Console.Write("\n\n\nНажмите на любую клавишу, чтобы вернуться в меню...");
                    Console.ReadKey();
                    goto default;
            }
        }
    }
}