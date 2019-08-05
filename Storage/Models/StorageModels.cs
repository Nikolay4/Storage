using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Input DocNumber")]
        public string DocNumber { get; set; }
        [Required(ErrorMessage = "Input Date")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Input Price")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Input Price")]
        public int Count { get; set; }
        [Required(ErrorMessage = "Select ItemId")]
        public Item ItemId { get; set; }
    }

    public class Expends
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Input DocNumber")]
        public string DocNumber { get; set; }
        [Required(ErrorMessage = "Input Date")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Input Price")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Input Price")]
        public int Count { get; set; }
        [Required(ErrorMessage = "Select ItemId")]
        public Item ItemId { get; set; }
    }
}
