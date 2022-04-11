using ModernLearns.Core.Services.Interfaces;
using ModernLearns.DataLayer.Context;
using ModernLearns.DataLayer.Entities.AboutUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernLearns.Core.Services
{
    public class AboutUsService:IAboutUsService
    {
        private ModernLearnsDBContext _context;
        public AboutUsService(ModernLearnsDBContext context)
        {
            _context = context;
        }

        public AboutUs GetAboutUsById(int id)
        {
            return _context.AboutUs.Find(id);
        }

        public AboutUs GetLast()
        {
            return _context.AboutUs.FirstOrDefault();
        }

        public void Insert(AboutUs aboutUs)
        {
            if (_context.AboutUs.Any()) return;
            _context.AboutUs.Add(aboutUs);
            _context.SaveChanges();
        }

        public void Update(AboutUs aboutUs)
        {
            _context.AboutUs.Update(aboutUs);
            _context.SaveChanges();
        }
    }
}
