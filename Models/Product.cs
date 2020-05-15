using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CartApi.Models
{
    public class Product
    {
        //add key
        [Key]
        public string PId { get; set; }
        public string product { get; set; }
        public string price { get; set; }
    }
}
