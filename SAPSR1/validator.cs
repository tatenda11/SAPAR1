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

        public static string errorMsg;
        public static Regex alphaNum = new Regex("^[a-zA-Z0-9\\s]*$");
        public static Regex alpha = new Regex("^[a-zA-Z\\s]*$");
       

        public static Boolean isValidateName(string name)
        {
            if(name == "")
            {
                errorMsg  = "name cannot be empty";
                return false;
            }
            else if(name.Length <= 2)
            {
                errorMsg = "name cannot be less than two characters";
                return false;
            }
            else if (!alpha.IsMatch(name))
            {
                errorMsg = "name can only contain alphabetical characters";
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Boolean isValidMoney(string amount)
        {
            double mamount;
            if (Double.TryParse(amount, out mamount) == false)
            {
                errorMsg = "amount is not a valid currency amount";
                return false;
            }
            return true;
        }


        public static Boolean isValidDateOfBirth(string dateStr ,int maxAge, int minAge)
        {
            DateTime myDate = Convert.ToDateTime(dateStr);
            int age = DateTime.Now.Year - myDate.Year;
            if(age > maxAge)
            {
                errorMsg = "age of "+ age +" exceeds maximum";
                return false;
            }
            else if(age < minAge)
            {
                errorMsg = "age of " + age + " is below mininum";
                return false;
            }
            return true;
        }

        public static Boolean isValidEmail(string email)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (!Regex.IsMatch(email, pattern))
            {
                errorMsg = "email address is not valid";
                return false;
            }
            return true;
        }

        public static Boolean isValidPhoneNumber(string phone)
        {
            if (!Regex.Match(phone, @"^(\+[0-9]{9})$").Success)
            {
                errorMsg = "Invalid Phone Number";
                return false;
            }
            return true;
        }

        public static Boolean isValidAlphaNumeric(string str)
        {
            if (!alphaNum.IsMatch(str))
            {
                errorMsg = "only alphanumeric character allowed fo this field";
                return false;
            }
            return true;
        }
    }
}
