using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.IO;

namespace DataLayer
{
    public abstract class DataManager
    {
        int bToGB = 1024*1024*1024;
        int kbToGB = 1024*1024;

        public abstract ComputerSummary GetComputerSummary();
        public abstract List<string> GetApplicationList();
        public abstract List<string> GetHardwareList();


        // computer metric methods ----------------------------------------
        // returns computer name
        public string GetComputerName()
        {
            string name = Environment.MachineName;
            return name;
        }

        // returns windows user logon name
        public string GetUserName()
        {
            string userName = WindowsIdentity.GetCurrent().Name;
            return userName;
        }

        // returns cpu description-
        public string GetCpuName()
        {
            string cpuName = GetWmiValueString("Win32_Processor", "Name");
            return cpuName;
        }

        // returns total RAM
        public int GetTotalRam()
        {
            int memoryInBytes = GetWmiValue("Win32_OperatingSystem", "TotalVisibleMemorySize");
            int memoryInGb = memoryInBytes/kbToGB;
            
            return memoryInGb;
        }

        // returns video cards description
        public string GetVideoCardName()
        {
            string videoCardName = GetWmiValueString("Win32_DisplayConfiguration", "Description");
            return videoCardName;
        }

        // returns local IP adress
        public IPAddress GetIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        // gets cpu usage in percentage
        public int GetCpuUsage()
        {
            int cpuUsage = GetWmiValue("Win32_PerfFormattedData_PerfOS_Processor", "PercentProcessorTime");
            return cpuUsage;
        }

        // gets total ram used 
        public int GetRamUsage()
        {
            int totalMemorySize = GetWmiValue("Win32_OperatingSystem", "TotalVisibleMemorySize");
            int freeMemory = GetWmiValue("Win32_OperatingSystem", "FreePhysicalMemory");
            int usedMemoryKB = totalMemorySize - freeMemory;
            int ramUsage = (usedMemoryKB*100)/totalMemorySize;
            return ramUsage;
        }

        // gets free disk space in GB
        public int GetAvailableDiskSpaceGb()
        {
            long tempValue = 0;
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                    tempValue += drive.TotalFreeSpace;
            }
            int diskSpace = (int)(tempValue / bToGB);
            return diskSpace;
        }

        // gets average disk read queue lenght
        public int GetAverageDiskQueueLength()
        {
            int avgDiskQueueLength =  GetWmiValue("Win32_PerfFormattedData_PerfDisk_PhysicalDisk", "AvgDiskReadQueueLength");
            return avgDiskQueueLength;
        }

        // hardware info methods-------------------------------------------------------------------

        // returns base board manufacturer, product number, serial number
        public string GetBaseBoardInfo()
        {
            string manufacturer = GetWmiValueString("Win32_BaseBoard", "Manufacturer");
            string product = GetWmiValueString("Win32_BaseBoard", "Product");
            string partNo = GetWmiValueString("Win32_BaseBoard", "SerialNumber");
            return "Base board: manufacturer -> "+ manufacturer + " product -> " + product + " serial No. - > " + partNo;
        }

        // returns disk drive info
        public string GetDiskDrive()
        {
            string info = GetWmiValueString("Win32_DiskDrive", "PNPDeviceID");
            return "Disk drive: " + info;
        }

        // returns CD Rom info
        public string GetCdRom()
        {
            string info = GetWmiValueString("Win32_CDROMDrive", "PNPDeviceID");
            return "CD Rom: " + info;
        }

        // wmi method realization -----------------------------------------------------------------

        public string GetWmiValueString(string wmiParameterName, string propertyName)
        {
            var searcher = new ManagementObjectSearcher("select * from " + wmiParameterName);
            string value = "";
            foreach (ManagementObject obj in searcher.Get().Cast<ManagementObject>())
            {
                value = obj[propertyName].ToString();
                break;
            }
            return value;
        }

        private int GetWmiValue(string wmiParameterName, string propertyName)
        {
            var searcher = new ManagementObjectSearcher("select * from " + wmiParameterName);
            int value = 0;
            foreach (ManagementObject obj in searcher.Get().Cast<ManagementObject>())
            {
                value += Convert.ToInt32(obj[propertyName]);
            }
            return value;
        }
    }
}
