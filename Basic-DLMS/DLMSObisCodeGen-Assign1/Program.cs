using System;
using System.Collections.Generic;

namespace ConsoleAppDLMS
{
    class Program
    {
        static void Main(string[] args)
        {
            var obis = new ObisCode(1, 0, 1, 8, 0, 255);

            ushort classId = 3;
            byte attributeId = 2; // e.g., value attribute

            byte[] apdu = GetRequestApdu.CreateGetRequest(obis, classId, attributeId);

            Console.WriteLine("OBIS Code: " + obis);
            Console.WriteLine("GET Request APDU: " + BitConverter.ToString(apdu));
        }
    }
}