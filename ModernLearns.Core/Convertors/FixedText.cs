using System;
using System.Collections.Generic;
using System.Text;

namespace ModernLearns.Core.Convertors
{
    public class FixedText
    {
        public static string FixEmail(string email)
        {
            return email.Trim().ToLower();
        }
    }
}
