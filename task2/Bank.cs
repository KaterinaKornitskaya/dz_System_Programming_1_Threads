using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task2
{
    internal class Bank  // класс Банк
    {
        int money;       // баланс
        string name;     // имя пользователя
        int percent;     // процентная ставка
        DateTime dt;     //текущая дата и время

        // метод для записи
        public void WriteData(object obj)  // передаем объект для того, чтобы метод
                                           // подходил для делегата ParameterizedThreadStart
        {
            string str = (string)obj;  // преобразуем объект к строке
            // открываем файл на дозапись
            using (StreamWriter wr = new StreamWriter("Data.txt", true))
            {
                wr.WriteLine(str);  // записываем переданную строку
            }
        }

        public int Money  // свойство Баланс
        {
            get { return money; }
            set
            {
                if (money != value)  // если баланс не равен значению
                {
                    money = value;
                    // создаем новый поток, передаем объект делегата ParameterizedThreadStart
                    // делегат инициализируем методом WriteData
                    Thread th = new Thread(new ParameterizedThreadStart(WriteData));
                    th.IsBackground = true;  // делаем поток фоновым
                    dt = DateTime.Now;       // текущее дата/время
                    // запускаем поток, передаем строку для записи в файл
                    th.Start($"{dt.ToString()} Баланс изменен. Текущий баланс = {value} грн.");
                }

            }
        }
        public string Name  // свойство Имя
        {
            get { return name; }
            set  // сеттер аналогично свойствам других полей
            {
                if (name != value)
                {
                    name = value;
                    Thread th = new Thread(new ParameterizedThreadStart(WriteData));
                    th.IsBackground = true;
                    dt = DateTime.Now;
                    th.Start($"{dt.ToString()} Имя изменено. Текущее имя - {value}.");
                }

            }
        }
        public int Percent  // свойтсво Процентная ставка
        {
            get { return percent; }
            set  // сеттер аналогично свойствам других полей
            {
                if (percent != value)
                {
                    percent = value;
                    Thread th = new Thread(new ParameterizedThreadStart(WriteData));
                    th.IsBackground = true;
                    dt = DateTime.Now;
                    th.Start($"{dt.ToString()} Процентная ставка изменена. Текущая ставка = {value} %.");
                }
            }
        }

        // конструктор с параметрами
        public Bank(int mon, string name, int percent)
        {
            Money=mon;
            Name=name;
            Percent=percent;
        }

        // переопределенный метол ToString()
        public override string ToString()
        {
            return $"My account: \nMoney: {Money} grn," +
                $"\nName: {Name} \nPercent : {Percent} %";
        }
    }
}
