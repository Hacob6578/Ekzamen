using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Garden
    {
        public string Adress { get; set; } 
        public string Owner { get; set; }
        public string Flowers { get; set; }
        public List<Flower> Library = new List<Flower>();
        public Garden(string add, string own, string flw) 
        {
            Adress = add;
            Owner = own;
            Flowers = flw;
        }
        //Феткулин Вадим
        public void ShowAll()
        {
            Console.WriteLine("Сад:\n" + $"\tАдресс: {Adress}\n" + $"\tВладелец: {Owner}\n" + $"\tЦветок: {Flowers}\n"); //Прописал как будет выглядеть вывод
            Library.Sort();
            foreach (Flower flower in Library)
            {
                flower.Show();
            }
        }
    }

    //Феткулин Вадим
    public class Flower : IComparable
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Flower(string t, string des)
        {
            Title = t;
            Description = des;
        }
        public void Show()
        {
            Console.WriteLine("Цветок:\n" + $"\tНазвание: {Title}\n" + $"\tОписание: {Description}"); //Прописал как будет выглядеть вывод
        }
        public int CompareTo(object obj)
        {
            return (this.Description + this.Title).CompareTo(Description + Title);
        }
    }
}
//Феткулин В.В.