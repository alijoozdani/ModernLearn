using ModernLearns.DataLayer.Entities.AboutUs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModernLearns.Core.Services.Interfaces
{
    public interface IAboutUsService
    {
        AboutUs GetLast();
        AboutUs GetAboutUsById(int id);
        void Insert(AboutUs aboutUs);
        void Update(AboutUs aboutUs);
    }
}
