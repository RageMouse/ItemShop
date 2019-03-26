using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItemShop.Models
{
    public class CreateAccounViewModel
    {
        public int AccountId { get; set; }

        [Display(Name = "Account Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name Required")]
        public string Name { get; set; }

        [Display(Name = "Account password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Required")]
        public string Password { get; set; }
        public bool IsGamemaster { get; set; }
        public bool IsActive { get; set; }
    }
}