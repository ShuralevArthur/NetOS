using System;
using System.Collections.Generic;
using System.Text;

namespace NetOS
{
    class Commands
    {
        public static void Help()
        {
            SystemOut.DefaultPrint("Commands: ");
            SystemOut.DefaultPrint("Help, SystemInfo, Settings, \n Shutdown, Reboot");
        }

        public static void SystemInfo()
        {
            /*
            SystemOut.DefaultPrint(Cosmos.Core.ProcessorInformation.GetVendorName().ToString());
            SystemOut.DefaultPrint(Cosmos.Core.ProcessorInformation.GetCycleCount().ToString());
            SystemOut.DefaultPrint(Cosmos.Core.ProcessorInformation.GetCycleRate().ToString());
            SystemOut.DefaultPrint(Cosmos.Core.Global.CPU.ToString());
            SystemOut.DefaultPrint(Cosmos.Core.Global.BaseIOGroups.ToString());*/
        }

        public static void Settings()
        {

        }

        public static void Shutdown()
        {
            Cosmos.HAL.Power.ACPIShutdown();
        }

        public static void Reboot()
        {
            Cosmos.HAL.Power.CPUReboot();
        }

        public static void Echo(String text)
        {
            SystemOut.DefaultPrint(text);
        }
    }
}
