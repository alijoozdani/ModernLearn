using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModernLearns.DataLayer.Entities.AboutUs
{
    public class AboutUs
    {
        [Key]
        public int AboutUsId { get; set; }

        [Display(Name = "متن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength]
        public string Text { get; set; }
        public bool IsDelete { get; set; }
    }
}
