using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Item
    {
        public int Id { get; }
        public int Weight { get; }
        public int Value { get; }
        public double Ratio { get; }

        public Item(int id, int weight, int value)
        {
            Id = id;
            Weight = weight;
            Value = value;
            Ratio = (double)value / weight;
        }
    }
}
