using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.Media;
using System.Security.Cryptography;
using System.Globalization;
using System.Diagnostics;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BtcE;
using BtcE.Utils;

namespace BTC_e_Monitor
{
    public partial class fIndex : Form
    {
        public fIndex()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fIndex_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " v" + Application.ProductVersion;
            this.Icon = Properties.Resources.myicon;

            notifyIcon1.Icon = Properties.Resources.myicon;
            notifyIcon1.Text = Application.ProductName + " v" + Application.ProductVersion;
        }
    }
}
