using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public IEnumerable<Incomes> Incomes { get; set; }
        public IEnumerable<Expends> Expends { get; set; }

        //for creating
        public Expends expend { get; set; }
        public Incomes incom { get; set; }
    }
}
