using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using DataLayer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataManager = new FullDataManager();
            dataManager.GetComputerSummary();

            Console.WriteLine("\nHardware list: \n");
            foreach (var item in dataManager.GetHardwareList())
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("\nApplication list: \n");
            foreach (var item in dataManager.GetApplicationList())
            {
                Console.WriteLine(item);
            }
        }
    }
}
