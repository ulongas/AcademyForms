using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataLayer;
using EntityDB;

namespace Academy_Forms_Proj
{
    public partial class Form1 : Form
    {
        DataManager dataManager = new FullDataManager();
        DataReader dataReader = new DataReader();
        public Form1()
        {
            InitializeComponent();
            DataWriter dataWriter = new DataWriter();
            dataWriter.StartWriting();
        }

        private void cpuNameButton_Click(object sender, EventArgs e)
        {
            //cpuNameBox.Text = dataManager.GetCpuName();
            cpuNameBox.Text = dataReader.ReadComputerDetails(dataManager.GetComputerName()).Cpu;
        }

        private void computerName_Click(object sender, EventArgs e)
        {
            //computerNameBox.Text = dataManager.GetComputerName();
            computerNameBox.Text = dataReader.ReadComputerDetails(dataManager.GetComputerName()).Name;
        }

        private void UserNameButton_Click(object sender, EventArgs e)
        {
            //UserNameBox.Text = dataManager.GetUserName();

            UserNameBox.Text = dataReader.ReadComputerDetails(dataManager.GetComputerName()).User;
        }

        private void cpuTimer_Tick(object sender, EventArgs e)
        {
            Series cpuSeries = chart1.Series.FindByName("CpuUsage");
            Series ramSeries = chart1.Series.FindByName("RamUsage");
            //series.Points.Clear();
            //cpuSeries.Points.AddXY(DateTime.Now.ToString("HH:mm:ss"),dataManager.GetCpuUsage());
            //ramSeries.Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), dataManager.GetRamUsage());
            List<UsageData> usageDatas = new List<UsageData>();
            usageDatas = dataReader.ReadUsageData();
            if (usageDatas.Count > 10)
            {
                for (int i = usageDatas.Count - 10; i < usageDatas.Count; i++)
                {
                    cpuSeries.Points.AddXY(usageDatas[i].Time.ToString(), usageDatas[i].CpuUsage);
                    ramSeries.Points.AddXY(usageDatas[i].Time.ToString(), usageDatas[i].RamUsage);
                }
            }
        }

        private void totalRamButton_Click(object sender, EventArgs e)
        {
            //MetricsContext context = new MetricsContext();
            //totalRamBox.Text = context.ComputerDetails.Select(w => w.Ram).FirstOrDefault().ToString();
            totalRamBox.Text = dataReader.ReadComputerDetails(dataManager.GetComputerName()).Ram.ToString();
        }
    }
}
