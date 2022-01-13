using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
namespace video12
{
    public static class Extension
    {
        public static bool IsEmail(this string mail)
        {
            try
            {
                MailAddress mailAdress = new MailAddress(mail);
                return true;
            }
            catch (Exception)
            {

                throw;
                return false;
            }
        }
    }
}
