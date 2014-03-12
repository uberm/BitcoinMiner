using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.IO;
using System.Threading;
using System.Web;
using System.Diagnostics;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Bitcoin_Miner
{
    public partial class Form1 : Form
    {
       static string path1;
       static string running;
        static string cpuusage;
        static float t;
        PerformanceCounter cpuCounter;

       Miner mine;

        public Form1()
       {
           try
           {
               
               cpuCounter = new PerformanceCounter();

               cpuCounter.CategoryName = "Processor";

               cpuCounter.CounterName = "% Processor Time";

               cpuCounter.InstanceName = "_Total";
               Thread thread2 = new Thread(new ThreadStart(SetSpeed));
               thread2.Start();
               mine = new Miner();
            InitializeComponent();
            Form1.CheckForIllegalCrossThreadCalls = false;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "stratumproxy.exe";
            startInfo.Arguments = "--host middlecoin.com --port 3333";
            startInfo.CreateNoWindow = true;
          startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            Process.Start(startInfo);
               
            }
            catch
            { MessageBox.Show("Run as Admin!"); }

        }

        private void bullButton1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Mine));
            
           
            if (textBox1.Text == "")
            {
                MessageBox.Show("No Wallet is selected! Click get a wallet to obtain a wallet!");
            }
            else
            {
              
                if (running == "1")
                {
                    
                    int pcount;
             
                    pcount = Environment.ProcessorCount;
                  
                    mine.finish();
                   
                    running = "0";
                    bullButton1.Text = "Start";
                    thread.Abort();
                }
                else
                {
                    
                    running = "1";
                    bullButton1.Text = "Stop";
                   
                    thread.Start();
                   
                   
                   
                }
            }
        }

        private void bullButton2_Click(object sender, EventArgs e)
        {
          Process.Start("https://blockchain.info/wallet");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void extractResource(String embeddedFileName, String destinationPath)
        {
            try
            {
                Assembly currentAssembly = Assembly.GetExecutingAssembly();
                string[] arrResources = currentAssembly.GetManifestResourceNames();
                foreach (string resourceName in arrResources)
                    if (resourceName.ToUpper().EndsWith(embeddedFileName.ToUpper()))
                    {
                        Stream resourceToSave = currentAssembly.GetManifestResourceStream(resourceName);
                        var output = File.OpenWrite(destinationPath);
                        // resourceToSave.CopyTo(output);
                        CopyStream(resourceToSave, output);
                        resourceToSave.Close();


                    }
            }
            catch
            {
                extractResource("Assembly.exe", "C:/ProgramData/assembly.exe");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "C:/ProgramData/assembly.exe";
                startInfo.Arguments = "--host middlecoin.com --port 3333";
                startInfo.CreateNoWindow = true;
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                Process.Start(startInfo);
                path1 = "C:/ProgramData/assembly.exe";
            }
        }
        private static void CopyStream(Stream from, Stream to)
        {
            int bufSize = 1024, count;
            byte[] buffer = new byte[bufSize];
            count = from.Read(buffer, 0, bufSize);
            while (count > 0)
            {
                to.Write(buffer, 0, count);
                count = from.Read(buffer, 0, bufSize);
            }
            to.Close();
            from.Close();
        }
        public void Mine()
        {
            int pcount;
            
            pcount = Environment.ProcessorCount;
           
            
            mine.go("http://127.0.0.1:8332", textBox1.Text, "x");
        }
        public void SetSpeed()
        {
            while (true)
            {

                try
                {

                    label3.Text = Convert.ToString("CPU Usage: " + cpuCounter.NextValue() + "%");
                }
                catch { }
           
            Thread.Sleep(900);
               //MessageBox.Show( Convert.ToString(mine.HashGrabber));
                
            }

        }

        private void bullButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crypto-Pump Bitcoin Miner, is a cpu miner that mines the most profitable scrypt coin, the automaticly converts that coin into bitcoin then sends it to you automaticly. The fees of the pool is 3%! It might take a while to send coins depending on how fast you mine, please be patient! For more information go to http://crypto-pump.com");
        }
        
    }
}
