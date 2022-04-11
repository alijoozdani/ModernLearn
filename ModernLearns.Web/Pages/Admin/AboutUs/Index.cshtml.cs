using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernLearns.Core.Security;
using ModernLearns.Core.Services.Interfaces;

namespace ModernLearns.Web.Pages.Admin.AboutUs
{
    [PermissionChecker(23)]
    public class IndexModel : PageModel
    {
        private IAboutUsService _aboutUs;
        public IndexModel(IAboutUsService aboutUs)
        {
            _aboutUs = aboutUs;
        }

        public ModernLearns.DataLayer.Entities.AboutUs.AboutUs AboutUs { get; set; }
        public void OnGet()
        {
            AboutUs = _aboutUs.GetLast();
        }
    }
}
