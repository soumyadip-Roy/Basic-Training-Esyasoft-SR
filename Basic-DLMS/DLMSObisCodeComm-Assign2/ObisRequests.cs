using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DLMS_Cosem_comms
{
    public class meterObject
    {
        public List<int> obis = new List<int>();
        public string name;
        public int value;

        public meterObject(List<int> obisNumList, string Name, int Value)
        {
            foreach(int i in obisNumList)
            {
                this.obis.Add(i);
            };
            this.name = Name;
            this.value = Value;
        }
    }

    public class meterObisObjects
    {
        List<meterObject> meterObjectList = new List<meterObject>();


        public void  MeterObjectCreator(List<int> obisCode, string Name, int valueObis)
        {
            meterObject temp = new meterObject(obisCode, Name, valueObis);
            meterObjectList.Add(temp);
            Console.WriteLine("New Obis Code written-" + Name +"-"+valueObis);
        }

        public meterObject AccessObisObject(int i)
        {
            return (meterObjectList[i]);
        }
        public int meterObjectCount() { return (meterObjectList.Count); }
        
    }
    public class ObisRequests
    {    // build class for meter object

        meterObisObjects obisObjects = new meterObisObjects();
        bool obis_match(List<int> obisCode, List<int> obisCode_DLMS)
        {
            bool val = true;
            for(int i = 0; i < 6; i++)
            {
                val = val && (obisCode[i] == obisCode_DLMS[i]);
            }
            return (val);
        }
        public void dlmsSetOBISCodes(List<int> obisCode, string Name, int value)
        {
            obisObjects.MeterObjectCreator(obisCode, Name, value);
        }
        public void dlms_get(List<int> obisCode)
        {
            for(int i = 0; i < obisObjects.meterObjectCount(); i++)
            {
                meterObject obisData = obisObjects.AccessObisObject(i);
                if (obis_match(obisCode, obisData.obis))
                {
                    Console.WriteLine("[GET] " + obisData.name + " = " + obisData.value);
                    return;
                }
            }
            Console.WriteLine("[GET] OBIS not Found.");

        }

        public void dlms_set(List<int> obisCode, int setValue)
        {
            for (int i = 0; i < obisObjects.meterObjectCount(); i++)
            {
                meterObject obisData = obisObjects.AccessObisObject(i);
                if (obis_match(obisCode, obisData.obis))
                {
                    obisData.value = setValue;
                    Console.WriteLine("[SET] Value of " + obisData.name + " Updated to " + obisData.value);
                    return;
                }
            }
            Console.WriteLine("[SET] OBIS not Found.");
        }

        public void dlms_action(string actionName)
        {
            if (actionName == "RESET")
            {
                for (int i = 0; i < obisObjects.meterObjectCount(); i++)
                {
                    meterObject obisData = obisObjects.AccessObisObject(i);

                    obisData.value = 0;
                    Console.WriteLine("[ACTION] Value of " + obisData.name + " Updated to " + obisData.value);
                }
                Console.WriteLine("[ACTION] Reset Completed.");
            }

            else if (actionName == "SYNC_TIME")
            {
                Console.WriteLine("ACTION] Synchronizing meter clock to system time...");
            }

            else { Console.WriteLine("[ACTION] Unknown Method"); }
        }


    }
}
