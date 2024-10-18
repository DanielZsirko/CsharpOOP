using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class hajo
    {
        private string name;
        private int speed;
        private int year;
        private string id;

        public hajo(string name, int speed, int year, string id)
        {
            this.name = name;
            this.speed = speed;
            this.year = year;
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Year { get => year; set => year = value; }
        public string Id { get => id; set => id = value; }

        public override string? ToString()
        {
            return $"A hajó neve: {name}, sebessége: {speed}, évjárata: {year}, azonosítója: {id}";
        }
    }
}
