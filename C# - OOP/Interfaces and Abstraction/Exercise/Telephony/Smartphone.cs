using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony
{
    public class Smartphone : IPhone
    {
        public string Call(string phoneNumber)
        {
            if (phoneNumber.Any(char.IsLetter))
            {
                return "Invalid number!";
            }
            return $"Calling... {phoneNumber}";
        }

        public string BrowseWeb(string URL)
        {
            if (URL.Any(char.IsDigit))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {URL}!";
        }
    }
}
