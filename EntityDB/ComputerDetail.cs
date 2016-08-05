using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace EntityDB
{
    public class ComputerDetail
    {
        public int ComputerDetailId { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Cpu { get; set; }
        public int Ram { get; set; }
        public string VideoCard { get; set; }
        public string Ip { get; set; }

        public ICollection<UsageData> UsageDataCollection { get; set; }
    }
}
