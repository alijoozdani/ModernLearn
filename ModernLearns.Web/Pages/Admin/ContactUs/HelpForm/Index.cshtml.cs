using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernLearns.Core.DTOs.ContactUs;
using ModernLearns.Core.Security;
using ModernLearns.Core.Services.Interfaces;

namespace ModernLearns.Web.Pages.Admin.ContactUs.HelpForm
{
    [PermissionChecker(22)]
    public class IndexModel : PageModel
    {
        private IContactUsService _contact;

        public IndexModel(IContactUsService contact)
        {
            _contact = contact;
        }
        public ContactUsFormViewModel ContactUsModel { get; set; }
        public void OnGet(int pageId = 1, bool isPosted = false)
        {
            ContactUsModel = _contact.GetContactUses(pageId, 12, isPosted);
        }
    }
}
