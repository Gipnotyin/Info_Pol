using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string edit, sim, parametr, ret;
            bool end = true;
            int index = -1, number, num;
            string[][] info = new string[100][];
            for (int i = 0; i < 100; i++)
            {
                info[i] = new string[5];
            }
            info[0][0] = "Human";
            Console.WriteLine(info[0][0]);
            do
            {
                Console.WriteLine("Что вы хотите сделать, добавить пользователя или вывести данные о нём на экран?(v/d)");
                sim = Console.ReadLine();
                switch (sim)
                {
                    case "v":
                        Console.WriteLine("Вы хотите изменить данные о пользователе или внести нового?(new/old)");
                        edit = Console.ReadLine();
                        if (edit == "new")
                        {
                            index++;
                            if (index == 100)
                            {
                                Console.WriteLine("Вы ввели максимально доступное количество пользователей!");
                                break;
                            }
                            Console.WriteLine("Введите имя пользователя: ");
                            info[index][0] = Console.ReadLine();
                            Console.WriteLine("Введите фамилию пользователя: ");
                            info[index][1] = Console.ReadLine();
                            Console.WriteLine("Введите Отчество пользователя: ");
                            info[index][2] = Console.ReadLine();
                            Console.WriteLine("Введите дату посещения библиотеки: ");
                            info[index][3] = Console.ReadLine();
                            Console.WriteLine("Какую книгу взял пользователь?");
                            info[index][4] = Console.ReadLine();
                        } 
                        else if (edit == "old")
                        {
                            Console.WriteLine("У какого пользователя вы хотите изменить данные?");
                            number = Convert.ToInt32(Console.ReadLine());
                            num = number - 1;
                            if (num > index || num < 0)
                            {
                                Console.WriteLine("Такого пользователя нет!");
                            } else
                            {
                                Console.WriteLine("Какой параметр вы хотите изменить?");
                                Console.WriteLine("(fname, lname, sname, date, book)");
                                parametr = Console.ReadLine();
                                switch(parametr)
                                {
                                    case "fname":
                                        Console.WriteLine("Введите новое имя пользователя");
                                        info[num][0] = Console.ReadLine();
                                        break;
                                    case "lname":
                                        Console.WriteLine("Введите новую фамилию пользователя");
                                        info[num][1] = Console.ReadLine();
                                        break;
                                    case "sname":
                                        Console.WriteLine("Введите новое отчество пользователя");
                                        info[num][2] = Console.ReadLine();
                                        break;
                                    case "date":
                                        Console.WriteLine("Введите новое время пользователя");
                                        info[num][3] = Console.ReadLine();
                                        break;
                                    case "book":
                                        Console.WriteLine("Введите новую книгу пользователя");
                                        info[num][4] = Console.ReadLine();
                                        break;
                                    default:
                                        Console.WriteLine("Вы ввели не корректные данный!");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели не корректные данные, повторите ввод...");
                        }
                        break;
                    case "d":
                        Console.WriteLine("Вы хотите вывести данные всех пользователей или данные одного пользователя?(alone\\more)");
                        parametr =Console.ReadLine();
                        switch (parametr)
                        {
                            case "more":
                                Console.WriteLine("Данные всех пользователей:");
                                for (int i = 0; i <= index; i++)
                                {
                                    Console.WriteLine("Имя " + (i+1) + " пользователя - " + info[i][0]);
                                    Console.WriteLine("Фамилия " + (i + 1) + " пользователя - " + info[i][1]);
                                    Console.WriteLine("Отчество " + (i + 1) + " пользователя - " + info[i][0]);
                                    Console.WriteLine("Время взятия книги " + (i + 1) + " пользователя - " + info[i][0]);
                                    Console.WriteLine("Взятая книга пользователя " + (i + 1) + " пользователя - " + info[i][0]);
                                    Console.WriteLine("\n");
                                }
                                break;
                            case "alone":
                                Console.WriteLine("Какого пользователя данные вы хотите вывести?");
                                number = Convert.ToInt32(Console.ReadLine());
                                num = number - 1;
                                if (number <= index || number >= 0)
                                {
                                    Console.WriteLine("Данные о " + num + " пользователе:");
                                    Console.WriteLine("Имя пользователя - " + info[num][0]);
                                    Console.WriteLine("Фамилия пользователя - " + info[num][1]);
                                    Console.WriteLine("Отчество пользователя - " + info[num][0]);
                                    Console.WriteLine("Время взятия книги пользователя - " + info[num][0]);
                                    Console.WriteLine("Взятая книга пользователя пользователя - " + info[num][0]);
                                }
                                break;
                            default:
                                Console.WriteLine("Вы ввели не корректно данные!...");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Такой команды нет, повторите попытку!");
                        break;
                }
                Console.WriteLine("Хотите продолжить ввод/вывод?(y/n)");
                ret = Console.ReadLine();
                if (ret == "y")
                {
                    end = true;
                } else
                {
                    end = false;
                }
            }
            while (end);
        }
    }
}
