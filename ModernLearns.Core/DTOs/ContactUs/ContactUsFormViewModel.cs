using ModernLearns.DataLayer.Entities.ContactUs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModernLearns.Core.DTOs.ContactUs
{
    public class ContactUsFormViewModel
    {
        public List<ContactUsForm> ContactUses { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public bool IsPosted { get; set; }
    }
}
