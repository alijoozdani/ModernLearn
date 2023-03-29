using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernLearns.Core.Security;
using ModernLearns.Core.Services.Interfaces;

namespace ModernLearns.Web.Pages.Admin.ContactUs
{
    [PermissionChecker(22)]
    public class IndexModel : PageModel
    {
        private IContactUsService _contactUs;
        public IndexModel(IContactUsService contactUs)
        {
            _contactUs = contactUs;
        }

        [BindProperty]
        public DataLayer.Entities.ContactUs.ContactUs ContactUs { get; set; }
        public void OnGet()
        {
            ContactUs = _contactUs.GetLast();
        }
    }
}
