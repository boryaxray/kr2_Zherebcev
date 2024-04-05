using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Data my = new Data();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Текущая дата: {(string)my}");
            my = new Data(2021, 7, 26);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Изменить дату на 26.7.2021: {(string)my}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Дата предыдущего дня: {my.PrevDay()}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Дата следующего дня: {my.NextDay()}");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Количество дней до конца месяца: { my.DaysLeft()}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Индексатор, позволяющий определить дату i-того по счету дня относительно установленной даты.Добавить к дате 10 дней: {my[10]}");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Является ли год выскокосным? {my.IsLeap}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Перегрузка операции !: true, если дата не является последним днем месяца, иначе false: {!my}");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Создается новый обьект DaateClass(2021, 7, 26)");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Data my1 = new Data(2021, 7, 26);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Перегрузка операции &: true, если поля двух объектов равны, иначе false: {my1 & my}");
            Console.ReadKey();
        }
    }
}
