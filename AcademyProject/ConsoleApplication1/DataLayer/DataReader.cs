using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using EntityDB;

namespace DataLayer
{
    public class DataReader
    { 
        MetricsContext contex = new MetricsContext();

        public List<UsageData> ReadUsageData()
        {
            var usageData = contex.UsageDatas.ToList();
            return usageData;
        }

        public ComputerDetail ReadComputerDetails(string computerName)
        {
            var computerDetail = contex.ComputerDetails.FirstOrDefault(w => w.Name == computerName);
            return computerDetail;
        }
    }
}
