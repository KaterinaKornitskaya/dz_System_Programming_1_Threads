using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// Задание:
// Создайте поток, который принимает в себя коллекцию элементов,
// и вызывает из каждого элемента коллекции метод ToString()
// и выводит результат работы метода на экран
namespace dz_Potoki
{
    class Point  // класс Точка
    {
        public int X { get; set; }  // координата x
        public int Y { get; set; }  // координата y
        public Point(int x, int y)  // конструктор с параметрами
        {
            X = x;
            Y = y;
        }
        public Point()              // конструктор для ввода с клавиатуры
        {
            Console.WriteLine("Введите значение X:");
            int x = int.Parse( Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            int y = int.Parse(Console.ReadLine());
            X = x;
            Y = y;
        }
        // переоперделенный метод ToString()
        public override string ToString()
        {
            return $"Point: ({X}, {Y})";
        }
    }
    
    internal class Program
    {
        // метод для создания Списка точек
        public static List<Point> ListOfPoints()
        {
            List<Point> list = new List<Point>();  // создаем список
            Point p1 = new Point(1, 2);            // создаем три точки
            Point p2 = new Point(5, 9);
            Point p3 = new Point(12, 6);
            Point[] arr = { p1, p2, p3 };          // создаем массив точек
            list.AddRange(arr);                    // список инициализируем массивом
            return list;                           // возвращаем полученный список точек
        }

        // метод для вывода инфо о точке на экран, далее будет
        // использован для делегата ParameterizedThreadStart
        public static void MyFun(object obj)  // принимает параметр типа object
        {
            Point p = (Point)obj;             // object преобразовываем к типу Point
            Console.WriteLine(p.ToString());  // вывод инфо о точке в консоль
        }

        // метод для создания Потоков
        public static void ThreadParam(List<Point> list)  // метод принимает список точек
        {
            foreach (var item in list)  // цикл по точкам в списке
            {
                // создание нового потока, передаем в поток объект делегата
                // ParameterizedThreadStart, и этот делегат инициализируем
                // функцией MyFun - то есть создаем новый объект потока и 
                // указываем, какой процесс он будет выполнять (процес - это 
                // ф-ия MyFun)
                Thread t = new Thread(new ParameterizedThreadStart(MyFun));
                
                t.IsBackground = true;  // делаем поток фоновым
                Thread.Sleep(500);      // пауза 0,5 сек
                t.Start(item);          // запускаем поток
            }
        }

        static void Main(string[] args)
        {
            List<Point> list = ListOfPoints();  // создаем список, инициализируем его возвращаемым
                                                // список из метода ListOfPoints()
            ThreadParam(list);  // вызываем метод ThreadParam, метод принимает список выше
                                // в этом методе происходит запуск потоков
        }
    }
}
