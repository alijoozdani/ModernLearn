using ModernLearns.Core.DTOs.ContactUs;
using ModernLearns.DataLayer.Entities.ContactUs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModernLearns.Core.Services.Interfaces
{
    public interface IContactUsService
    {
        #region ContactUs
        ContactUs GetContactUsById(int id);
        ContactUs GetLast();
        void AddContactUs(ContactUs contactUs);
        void UpdateContactUs(ContactUs contactUs);
        #endregion

        #region ContactUsForm
        ContactUsFormViewModel GetContactUses(int pageId, int take, bool isPosted);
        void SendAnswerForContactUs(ContactUsForm contactUs, string answer);
        void EditContactUsForm(ContactUsForm contactUs);
        void InsertQuestion(ContactUsForm contactUsForm);
        ContactUsForm GetContactUsFormById(int contactUsFormId);
        #endregion
    }
}
