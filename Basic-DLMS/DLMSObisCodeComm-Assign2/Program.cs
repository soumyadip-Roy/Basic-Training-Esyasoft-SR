using System;
using System.Collections.Generic;

namespace DLMS_Cosem_comms
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ObisRequests obisRequests = new ObisRequests();

            List<int> obisCode_1 = new List<int> { 1, 20, 10, 10, 100, 20 }; // sample obis code 1
            List<int> obisCode_2 = new List<int> { 1, 21, 1, 1, 101, 21 }; // sample obis code 2
            List<int> obisCode_3 = new List<int> { 1, 212, 1, 12, 101, 21 }; // sample obis code 3

            obisRequests.dlmsSetOBISCodes(obisCode_1, "obisCode_1", 0);
            obisRequests.dlmsSetOBISCodes(obisCode_2, "obisCode_2", 0);
            obisRequests.dlmsSetOBISCodes(obisCode_3, "obisCode_3", 0);

            obisRequests.dlms_get(obisCode_1);
            obisRequests.dlms_set(obisCode_1, 100);
            obisRequests.dlms_get(obisCode_1);

            obisRequests.dlms_action("RESET");

        }
    }
}
