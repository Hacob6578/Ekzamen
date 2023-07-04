using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
//Феткулин Вадим
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flower flower = new Flower("Роза", "Нежный и ароматный цветок, который бывает различных цветов, идеальный подарок для девушки");
            Flower flower2 = new Flower("Тюльпан", "Тоже хороший цветов, который подойдёт для любой дамы");
            Flower flower3 = new Flower("Гипсофила", "Небольшой набор этого цветка удивит любого человека");
            Flower flower4 = new Flower("Жасмин", "Цветок");
            Garden garden = new Garden("Улица Долгорукого 3", "Иван", "Роза");
            Garden garden2 = new Garden("Менжинская 15", "Анастасия", "Тюльпан");
            Garden garden3 = new Garden("Летчика Бабушкина 3", "Вадим", "Гипсофила");
            Garden garden4 = new Garden("Изумрудная 24", "Жасмина", "Жасмин");
            flower.Show();
            flower2.Show();
            flower3.Show();
            flower4.Show();
            garden.ShowAll();
            garden2.ShowAll();
            garden3.ShowAll();
            garden4.ShowAll();
            Console.ReadKey();
            //тут в общем показан вывод всего написанного
        }
    }
}
//Феткулин Вадим