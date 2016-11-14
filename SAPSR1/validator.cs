using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SAPSR1
{
    class validator
    {
        public static string AlphaNumericString(string s)
        {
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (r.IsMatch(s))
            {
                return s;
            }
            else
            {
                throw new ArgumentException("Only alphanumeric characters may be used");
            }
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
