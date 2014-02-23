using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
using System.IO;
using System.Net;
using System.Web;
using System.Media;
using System.Security.Cryptography;
using System.Globalization;
using System.Diagnostics;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _Hell_BTC_e_Monitor
{
    public partial class fIndex : Form
    {
        public fIndex()
        {
            InitializeComponent();

            /*bwRefresh.WorkerReportsProgress = true;
            bwRefresh.WorkerSupportsCancellation = true;

            bwBot.WorkerReportsProgress = true;
            bwBot.WorkerSupportsCancellation = true;

            bwBotSave.WorkerReportsProgress = true;
            bwBotSave.WorkerSupportsCancellation = true;*/
        }

        private void playError(string mess, string ex)
        {
            bool globalDebug = true;

            SoundPlayer sp = new SoundPlayer(Properties.Resources.alarm);
            //sp.Play();

            mess = globalDebug == true && ex != "" ? ex : mess;

            notifyIcon.ShowBalloonTip(2000, "Error", mess, ToolTipIcon.Warning);
            tssError.Text = "Error: " + mess;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " v" + Application.ProductVersion;
            this.Icon = Properties.Resources.icon;

            notifyIcon.Icon = Properties.Resources.icon;
            notifyIcon.Text = Application.ProductName + " v" + Application.ProductVersion;

            if (!File.Exists("Newtonsoft.Json.dll"))
            {
                try
                {
                    /**********************************************
                     * Отсутствует библиотека Newtonsoft.Json.dll
                     * ********************************************/
                    var client = new WebClient();
                    client.DownloadFileCompleted += (o, args) => startMonitor();
                    client.DownloadFileAsync(new Uri("http://ai-rus.com/g/Newtonsoft.Json.dll"), "Newtonsoft.Json.dll");
                }
                catch (Exception ex)
                {
                    playError("Файл 'Newtonsoft.Json.dll' не обнаружен", ex.Message);
                }
            }
            else
            {
                startMonitor();
            }
        }


        private void startMonitor()
        {
            // Initial parameters
            try
            {
                profile profile = new profile();
                cource cource = new cource();

                if (File.Exists(Application.StartupPath + "/settings.xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("settings.xml");

                    // Loading my profile parameters
                    string str = doc.GetElementsByTagName("profile")[0].InnerText;

                    foreach (XmlNode xmlNode in doc.GetElementsByTagName("show"))
                    {
                        profile.Add(xmlNode.Attributes["name"].InnerText, Convert.ToBoolean(xmlNode.Attributes["show"].InnerText));
                    }


                    foreach (XmlNode xmlNode in doc.GetElementsByTagName("pair"))
                    {
                        cource.Add(xmlNode.Attributes["name"].InnerText, Convert.ToBoolean(xmlNode.Attributes["show"].InnerText), 0);
                    }
                }
                else
                {
                    profile.Add("BTC", true);
                    profile.Add("LTC", true);
                    profile.Add("RUR", true);
                    profile.Add("USD", true);
                    profile.Add("EUR", true);
                    profile.Add("TRC", true);
                    profile.Add("WDC", true);
                    profile.Add("NMC", true);
                    profile.Add("NVC", true);
                    profile.Add("PPC", true);
                    profile.Add("FTC", true);

                    cource.Add("btc_usd", true, 0);
                    cource.Add("btc_rur", true, 0);
                    cource.Add("btc_eur", true, 0);
                    cource.Add("ltc_btc", true, 0);
                    cource.Add("ltc_usd", true, 0);
                    cource.Add("ltc_rur", true, 0);
                    cource.Add("nmc_btc", true, 0);
                    cource.Add("usd_rur", true, 0);
                    cource.Add("eur_usd", true, 0);
                    cource.Add("nvc_btc", true, 0);
                    cource.Add("trc_btc", true, 0);
                    cource.Add("ppc_btc", true, 0);
                    cource.Add("ftc_btc", true, 0);

                    int pos;

                    lvTrades.ShowGroups = true;
                    lvTrades.Groups[0].Header = "Profile";
                    lvTrades.Groups[1].Header = "Pair";

                    for (int i = 0; i < profile.Range.Count; i++)
                    {
                        pos = lvTrades.Items.Add(profile.Range[i].Name.ToString()).Index;
                        lvTrades.Items[pos].SubItems.Add(profile.Range[i].Show.ToString());
                        lvTrades.Items[pos].Group = lvTrades.Groups[0];
                    }

                    for (int i = 0; i < cource.Range.Count; i++)
                    {
                        pos = lvTrades.Items.Add(cource.Range[i].Name.ToString()).Index;
                        lvTrades.Items[pos].SubItems.Add(cource.Range[i].Show.ToString());
                        lvTrades.Items[pos].Group = lvTrades.Groups[1];
                    }

                    playError("Файл настроек не обнаружен", "");
                }
            }
            catch (Exception e)
            {
                playError("Файл 'Newtonsoft.Json.dll' не обнаружен", e.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
