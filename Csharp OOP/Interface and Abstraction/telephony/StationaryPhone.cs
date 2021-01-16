using System;

namespace telephony
{
    public class StationaryPhone : ICall
    {
       public StationaryPhone()
       {

       }

       public void Call(string phone)
       {
           Console.WriteLine($"Dialing... {phone}");
       }

    }
}