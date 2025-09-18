using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDLMS
{
    public class GetRequestApdu
    {
        public static byte[] CreateGetRequest(ObisCode obisCode, ushort classId, byte attriId)
        {
            List<byte> apdu = new List<byte>();

            
            apdu.Add(0xC0); 
            apdu.Add(0x01); 
            
            apdu.Add(0x01);

            apdu.Add((byte)(classId >> 8)); 
            apdu.Add((byte)(classId & 0xFF)); 


            apdu.AddRange(obisCode.ToByteArray());

            apdu.Add(attriId);

            apdu.Add(0x00);

            return apdu.ToArray();
        }
    }
}
