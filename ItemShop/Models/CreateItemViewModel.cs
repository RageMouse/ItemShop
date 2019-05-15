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
        public string Description { get; set; }
        public string Type { get; set; }
        public bool IsUnique { get; set; }
    }
}
