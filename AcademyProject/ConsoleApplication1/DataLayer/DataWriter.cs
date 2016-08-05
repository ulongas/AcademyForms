using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EntityDB;
using System.Timers;

namespace DataLayer
{
    public class DataWriter
    { 
        private System.Timers.Timer _aTimer;
        DataManager dataManager = new FullDataManager();
        MetricsContext context = new MetricsContext();
        ComputerDetail detail = new ComputerDetail();

        public void StartWriting()
        {
            WriteStaticDataToDb();
            _aTimer = new System.Timers.Timer(2000);

            _aTimer.Elapsed += OnTimedEvent;

            _aTimer.AutoReset = true;

            _aTimer.Enabled = true;
        }

        void WriteStaticDataToDb()
        {
            context.Database.EnsureCreated();
            detail.Name = dataManager.GetComputerName();
            detail.User = dataManager.GetUserName();
            detail.Cpu = dataManager.GetCpuName();
            detail.Ram = dataManager.GetTotalRam();
            detail.VideoCard = dataManager.GetVideoCardName();
            detail.Ip = dataManager.GetIpAddress().ToString();
            ComputerDetail detailInDb = context.ComputerDetails.FirstOrDefault(w => w.Name == detail.Name);
            if(detailInDb == null)
            {
                context.ComputerDetails.Add(detail);
                context.SaveChanges();
            }
            else
            {
                detail = detailInDb;
            }
        }

        void WriteDynamicDataToDb()
        {
            UsageData usageData = new UsageData();
            usageData.CpuUsage = dataManager.GetCpuUsage();
            usageData.RamUsage = dataManager.GetRamUsage();
            usageData.AvailableDiskSpaceGb = dataManager.GetAvailableDiskSpaceGb();
            usageData.AverageDiskQueueLength = dataManager.GetAverageDiskQueueLength();
            usageData.Time = DateTime.Now;
            detail.UsageDataCollection = new List<UsageData>();
            detail.UsageDataCollection.Add(usageData);
            context.UsageDatas.Add(usageData);
            context.SaveChanges();
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            WriteDynamicDataToDb();
        }
    }
}
