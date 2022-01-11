using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iftikharali081task.Models
{
    public class storemodel
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string discription { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }

    }
}
