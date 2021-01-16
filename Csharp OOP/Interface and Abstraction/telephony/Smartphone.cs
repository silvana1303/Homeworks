using System;

namespace telephony
{
    public class Smartphone : ICall, IBrowse
    {
        public Smartphone()
        {
            
        }

        public void Call(string phone)
        {
            Console.WriteLine($"Calling... {phone}");
        }

        public void Browse(string link)
        {
            Console.WriteLine($"Browsing: {link}!");
        }
    }
}