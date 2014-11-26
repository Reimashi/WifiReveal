using NativeWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WifiReveal.UI
{
    public partial class fMain : Form
    {
        WlanClient client;

        public fMain()
        {
            InitializeComponent();

            this.Icon = global::WifiReveal.Properties.Resources.icon_app;

            this.client = new WlanClient();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            this.pbSearchProgress.Visible = true;

            this.lvNetworks.Items.Clear();

            GeneratorsManager manager = GeneratorsManager.Instance;
            List<WifiInfo> networks = new List<WifiInfo>();

            foreach (WlanClient.WlanInterface iface in client.Interfaces)
            {
                Wlan.WlanBssEntry[] wlanBssEntries = iface.GetNetworkBssList();

                foreach (Wlan.WlanBssEntry bsd in wlanBssEntries)
                {
                    WifiInfo info = new WifiInfo(bsd.dot11Bssid, bsd.dot11Ssid.SSID);
                    networks.Add(info);
                }
            }

            networks.Add(new WifiInfo(new byte[] { 0x00, 0x13, 0x49, 0x33, 0x44, 0x55 }, Encoding.ASCII.GetBytes("WLAN_1234")));

            foreach (WifiInfo wif in networks)
            {
                if (manager.CanGenerate(wif))
                {
                    String pass = manager.Generate(wif);
                    this.lvNetworks.Items.Add(new ListViewItem(new string[] { wif.Name, pass }));
                }
                else
                {
                    this.lvNetworks.Items.Add(new ListViewItem(new string[] { wif.Name, "???" }));
                }
            }

            this.pbSearchProgress.Visible = false;
        }

        static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAbout aboutw = new fAbout();
            aboutw.ShowDialog(this);
        }
    }
}
