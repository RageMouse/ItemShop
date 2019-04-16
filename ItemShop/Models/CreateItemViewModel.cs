using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItemShop.Models
{
    public class CreateItemViewModel
    {
        [Display(Name = "Item Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name Required")]
        public string Name { get; set; }
        [Display(Name = "Bonus value")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Bonus value Required")]
        public int Bonus { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
