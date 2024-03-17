using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Result
    {
        public int total_value { get; }
        public int total_weight { get; }

        public List<int> selectedItems = new List<int>();
        public Result(int total_value, int total_weight, List<int> selectedItems) 
        {   
            this.total_value = total_value;
            this.total_weight = total_weight;
            this.selectedItems = selectedItems;
        }

        public override string ToString()
        {

            return $"ids: {string.Join(" ",selectedItems)} \ntotal value: {total_value}\ntotal weight: {total_weight}";

        } 
    }
}
