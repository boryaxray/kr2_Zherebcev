using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
{
    class Data
    {
        // Поле DataTime data.
        DateTime date;
        // установить аданную дату
        public Data(int year, int month, int day)
        {
            date = new DateTime(year, month, day);
        }
        // дату 1.04.2024
        public Data()
        {
            date = new DateTime(2024, 4, 1);
        }
        //вычислить дату предыдущего дня;
        public DateTime PrevDay()
        {
            return date.AddDays(-1);
        }
        //вычислить дату следующего дня;
        public DateTime NextDay()
        {
            return date.Add(TimeSpan.FromDays(1));
        }
        //определить сколько дней осталось до конца месяца
        public int DaysLeft()
        {
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        }
        //установить или получить значение поле класса (доступно для чтения и записи)
        public DateTime Date
        {
            set { date = value; }
            get { return date; }
        }
        //позволяющее определить год высокосным (доступно только для чтения)
        public bool IsLeap
        {
            get { return DateTime.IsLeapYear(date.Year); }
        }
        // Индексатор, позволяющий определить дату i-того по счету дня относительно установленной даты 
        // (при отрицательных значениях индекса отсчет ведется в обратном порядке). 
        public DateTime this[int index]
        {
            get{ return date.AddDays(index);}
        }
        //Перегрузку:операции !: возвращает значение true, если установленная дата не является последним днем месяца, иначе false;
        public static bool operator !(Data a)
        {
            return a.date.Day != DateTime.DaysInMonth(a.date.Year, a.date.Month);
        }
        // констант true и false: обращение к экземпляру класса дает значение true,
        // если установленная дата является началом года, иначе false;
        public static bool operator true(Data a)
        {
            return a.date.Day == 1 && a.date.Month == 1;
        }
        public static bool operator false(Data a)
        {
            return a.date.Day != 1 || a.date.Month != 1;
        }
        // операции &: возвращает значение true, если поля двух объектов равны, иначе false;
        public static bool operator &(Data a, Data b)
        {
            return a.date.Equals(b.date);
        }
        public static explicit operator String(Data obj)
        {
            return " Год: " + obj.date.Year + " Месяц: " + obj.date.Month + " Число: " + obj.date.Day;
        }
        public static explicit operator Data(String str)
        {
            string[] str_arr = str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Data obj = new Data(Convert.ToInt32(str_arr[0]), Convert.ToInt32(str_arr[1]), Convert.ToInt32(str_arr[2]));
            return obj;
        }

    }
}
