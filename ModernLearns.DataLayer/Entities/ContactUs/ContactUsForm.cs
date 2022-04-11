using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModernLearns.DataLayer.Entities.ContactUs
{
    public class ContactUsForm
    {
        [Key]
        public int ContactId { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [MaxLength(200)]
        public string FullName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(800)]
        [MinLength(10, ErrorMessage = "توضیحات باید بیشتر از 10 کاراکتر باشد")]
        public string Description { get; set; }
        [Display(Name = "پاسخ")]
        public string AgentAnswer { get; set; }

        [Display(Name = "وضعیت")]
        public bool IsPosted { get; set; }

        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime AnswerDate { get; set; }
    }
}
