using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace DataLayer
{
    public class FullDataManager : DataManager
    { 
        public override ComputerSummary GetComputerSummary()
        {
            ComputerSummary summary = new ComputerSummary();
            summary.Name = GetComputerName();
            Console.WriteLine("Computer name: {0}", summary.Name);
            summary.User = GetUserName();
            Console.WriteLine("User name: {0}", summary.User);
            summary.Cpu = GetCpuName();
            Console.WriteLine("CPU name: {0}", summary.Cpu);
            summary.Ram = GetTotalRam();
            Console.WriteLine("Total RAM: {0} GB", summary.Ram);
            summary.VideoCard = GetVideoCardName();
            Console.WriteLine("Video card: {0}", summary.VideoCard);
            summary.Ip = GetIpAddress();
            Console.WriteLine("IP adress: {0}", summary.Ip);
            summary.CpuUsage = GetCpuUsage();
            Console.WriteLine("CPU usage: {0} %", summary.CpuUsage);
            summary.RamUsage = GetRamUsage();
            Console.WriteLine("Used RAM: {0} GB", summary.RamUsage);
            summary.AvailableDiskSpaceGb = GetAvailableDiskSpaceGb();
            Console.WriteLine("Free disk space: {0} GB", summary.AvailableDiskSpaceGb);
            summary.AverageDiskQueueLength = GetAverageDiskQueueLength();
            Console.WriteLine("Average disk queue length: {0}", summary.AverageDiskQueueLength);
            return summary;
        }

        public override List<string> GetApplicationList()
        {
            List<string> applicationNameList = new List<string>();
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
            foreach (ManagementObject mo in mos.Get())
            {
                if(mo["name"] != null)
                    applicationNameList.Add(mo["Name"].ToString());
            }
            return applicationNameList;
        }

        public override List<string> GetHardwareList()
        {
            List<string> hardwareList = new List<string>();
            /*ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");
            foreach (ManagementObject mo in mos.Get())
            {
                if (mo["name"] != null)
                    hardwareList.Add(mo["Name"].ToString());
            }*/

            hardwareList.Add(GetBaseBoardInfo());
            hardwareList.Add(GetDiskDrive());
            hardwareList.Add(GetCdRom());
            hardwareList.Add("Cpu : " + GetCpuName());
            hardwareList.Add("Video card : " + GetVideoCardName());
            return hardwareList;

        }
    }
}
