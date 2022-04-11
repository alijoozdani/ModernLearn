using ModernLearns.Core.DTOs.ContactUs;
using ModernLearns.Core.Senders;
using ModernLearns.Core.Services.Interfaces;
using ModernLearns.DataLayer.Context;
using ModernLearns.DataLayer.Entities.ContactUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernLearns.Core.Services
{
    public class ContactUsService:IContactUsService
    {
        private ModernLearnsDBContext _context;
        public ContactUsService(ModernLearnsDBContext context)
        {
            _context = context;
        }

        public void AddContactUs(ContactUs contactUs)
        {
            if (_context.ContactUs.Any())
            {
                return;
            }
            _context.ContactUs.Add(contactUs);
            _context.SaveChanges();
        }

        public void EditContactUsForm(ContactUsForm contactUs)
        {
            _context.ContactUsForms.Update(contactUs);
            _context.SaveChanges();
        }

        public ContactUs GetContactUsById(int id)
        {
            return _context.ContactUs.Find(id);
        }

        public ContactUsFormViewModel GetContactUses(int pageId, int take, bool isPosted)
        {
            IQueryable<ContactUsForm> result = _context.ContactUsForms;
            if (isPosted)
            {
                result = result.Where(r => r.IsPosted);
            }
            else
            {
                result = result.Where(r => !r.IsPosted);

            }

            var skip = (pageId - 1) * take;
            var pageCount = (int)Math.Ceiling(result.Count() / (double)take);

            var model = new ContactUsFormViewModel()
            {
                ContactUses = result.OrderByDescending(c => c.CreateDate).Skip(skip).Take(take).ToList(),
                CurrentPage = pageId,
                PageCount = pageCount,
                StartPage = (pageId - 4 <= 0) ? 1 : pageId - 4,
                EndPage = (pageId + 5 > pageCount) ? pageCount : pageId + 5,
                IsPosted = isPosted
            };
            return model;
        }

        public ContactUsForm GetContactUsFormById(int contactUsFormId)
        {
            return _context.ContactUsForms.SingleOrDefault(c => c.ContactId == contactUsFormId);
        }

        public ContactUs GetLast()
        {
            return _context.ContactUs.FirstOrDefault();
        }

        public void InsertQuestion(ContactUsForm contactUsForm)
        {
            _context.ContactUsForms.Add(contactUsForm);
            _context.SaveChanges();
        }

        public void SendAnswerForContactUs(ContactUsForm contactUs, string answer)
        {
            if (string.IsNullOrEmpty(answer))
            {
                return;
            }
            try
            {
                var emailBody = $"<h3 style='text-align:center'>{contactUs.FullName} عزیز درخواست پشتیبانی شما پاسخ داده شد. </h3><h4>پاسخ پیام پشتیبانی :</h3>{answer}";
                SendEmail.Send(contactUs.Email, "پاسخ پیام پشتیبانی", emailBody.BuildView());
            }
            catch (Exception e)
            {
                return;
            }
            contactUs.IsPosted = true;
            contactUs.AgentAnswer = answer;
            contactUs.AnswerDate = DateTime.Now;
            EditContactUsForm(contactUs);
        }

        public void UpdateContactUs(ContactUs contactUs)
        {
            _context.ContactUs.Update(contactUs);
            _context.SaveChanges();
        }
    }
}
