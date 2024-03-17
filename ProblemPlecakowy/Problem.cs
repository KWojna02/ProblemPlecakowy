using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Problem
    {
        private int n;
        private int seed;
        public List<Item> items = new List<Item>();
        public List<Item> sortedItems = new List<Item>();

        
        public Problem(int n, int seed)
        {
            this.n = n;
            this.seed = seed;
            Random random = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                Item item = new Item(i, random.Next(1,10), random.Next(1,10));
                items.Add(item);
            }

        }        

        public Result Solve(int capacity)
        {
            sortedItems = items.OrderByDescending(item => item.Ratio).ToList();

            List<int> selectedItems = new List<int>();
            int totalValue = 0;
            int totalWeight = 0;

            foreach (Item item in sortedItems)
            {
                if (totalWeight + item.Weight <= capacity)
                {
                    selectedItems.Add(item.Id);
                    totalValue += item.Value;
                    totalWeight += item.Weight;
                }
            }


            Result result = new Result(totalValue, totalWeight, selectedItems);
            return result;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Item item in items)
            {
                result += $"Id: {item.Id}, Wartość: {item.Value}, Waga: {item.Weight}, Współczynnik: {item.Ratio}\n";
            }

            return result;
        }

    }
}
