using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony
{
    public class StationaryPhone : IPhone
    {
        public string Call(string phoneNumber)
        {
            if (phoneNumber.Any(char.IsLetter))
            {
                return "Invalid number!";
            }
            return $"Dialing... {phoneNumber}";
        }
    }
}
