using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModernLearns.DataLayer.Entities.ContactUs
{
   public class ContactUs
    {
        [Key]
        public int ContactId { get; set; }

        [Display(Name = "عنوان تماس با ما")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(800)]
        public string Title { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(400)]
        public string Address { get; set; }

        [Display(Name = "شماره های تماس")]
        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [MaxLength(30)]
        public string PhoneNumber { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "ساعات پاسخگویی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(400)]
        public string ResponseTime { get; set; }

        public bool IsDelete { get; set; }
    }
}
