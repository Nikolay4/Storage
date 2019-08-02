using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class FirstInput
    {
        public static void Initialize(StorageContext context)
        {
            //if (!context.Items.Any())
            {
                context.Items.AddRange(
                    new Item
                    {
                        Name = "Doc № 1",
                        Count = 0,
                        Price = 0
                    },
                    new Item
                    {
                        Name = "Doc № 2",
                        Count = 0,
                        Price = 0
                    },
                    new Item
                    {
                        Name = "Doc № 3",
                        Count = 0,
                        Price = 0
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
