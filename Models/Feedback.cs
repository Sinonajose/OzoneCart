using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CartApi.Models
{
    public class Feedback
    {
        [Key]
        public string FId { get; set; }
        public string name { get; set; }
        public string message { get; set; }
    }
}
