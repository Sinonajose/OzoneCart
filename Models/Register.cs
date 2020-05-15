using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CartApi.Models
{
    public class Register
    {
        [Key]
        public string RId { get; set; }
        public string firstname { get; set; }
        public string secondname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
