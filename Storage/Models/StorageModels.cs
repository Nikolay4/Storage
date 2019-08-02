using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
    }

    public class Incomes
    {
        public int Id { get; set; }
        public string DocNumber { get; set; }
        public DateTime Date { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }
        public Item ItemId { get; set; }
    }

    public class Expends
    {
        public int Id { get; set; }
        public string DocNumber { get; set; }
        public DateTime Date { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }
        public Item ItemId { get; set; }
    }
}
