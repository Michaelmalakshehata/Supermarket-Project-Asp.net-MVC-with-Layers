using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ViewModel
{
    public  class OrderViewModel
    {
        public int Id { get; set; }
        [Required]
        public string date { get; set; }
        public string Description { get; set; }
        public int totalPrice { get; set; }
        public int discount { get; set; }
    }
}
