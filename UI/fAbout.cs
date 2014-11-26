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
    public partial class fAbout : Form
    {
        public fAbout()
        {
            InitializeComponent();

            GeneratorsManager manager = GeneratorsManager.Instance;

            foreach (GeneratorPlugin pl in manager.Plugins)
            {
                TabPage pluginPage = new TabPage();

                pluginPage.Name = "tab" + pl.Name;
                pluginPage.Text = pl.Name;

                this.tabPlugins.Controls.Add(pluginPage);
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/Reimashi/WifiReveal");
        }
    }
}
