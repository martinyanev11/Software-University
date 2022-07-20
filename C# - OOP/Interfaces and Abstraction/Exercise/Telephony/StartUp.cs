using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbersInput = Console.ReadLine().Split();
            string[] URLInput = Console.ReadLine().Split();

            IPhone phone;

            foreach (string phoneNumber in phoneNumbersInput)
            {
                if (phoneNumber.Length == 10)
                {
                    phone = new Smartphone();
                }
                else
                {
                    phone = new StationaryPhone();
                }
                Console.WriteLine(phone.Call(phoneNumber));
            }

            foreach (string URL in URLInput)
            {
                Smartphone smartphone = new Smartphone();
                Console.WriteLine(smartphone.BrowseWeb(URL)); 
            }
        }
    }
}
