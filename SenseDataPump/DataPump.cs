using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SenseDataPump
{
    public partial class DataPump : Form
    {
        public DataPump()
        {
            InitializeComponent();
            txtLogpath.Text = System.IO.Path.GetTempPath() + @"\testdata.txt";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtStatus.Text = "";

                StandardDataTest DataTest = new StandardDataTest();
                DataTest.serverURL = txtServerURL.Text;
                DataTest.useproxy = chkProxy.Checked;
                DataTest.logpath = txtLogpath.Text;
                DataTest.connect();

                txtStatus.Text = "Process Started at " + DateTime.Now.ToString();
                this.Refresh();

                if (chkApps.Checked)
                {
                    txtStatus.Text += Environment.NewLine + DataTest.addApps(Convert.ToInt32(txtNumApps.Text), txtAppPath.Text);
                    this.Refresh();
                }
                if (chkTasks.Checked)
                {
                    txtStatus.Text += Environment.NewLine + DataTest.addTaskChainApps(Convert.ToInt32(txtnumchains.Text), Convert.ToInt32(txtchainsize.Text));
                    this.Refresh();
                }
                if (chkUsers.Checked)
                {
                    txtStatus.Text += Environment.NewLine + DataTest.addUsers(Convert.ToInt32(txtnumusers.Text), Convert.ToInt32(txtAttributes.Text));
                    this.Refresh();
                }
                if (chkStreams.Checked)
                {
                    txtStatus.Text += Environment.NewLine + DataTest.addStreams(Convert.ToInt32(txtnumstreams.Text), chkRulesForStreams.Checked);
                    this.Refresh();
                }
                if (chkTags.Checked)
                {
                    txtStatus.Text += Environment.NewLine + DataTest.addTags(Convert.ToInt32(txtnumtags.Text));
                    this.Refresh();
                }
                if (chkCustomProps.Checked)
                {
                    txtStatus.Text += Environment.NewLine + DataTest.addCustomProperties(Convert.ToInt32(txtnumcustomprops.Text));
                    this.Refresh();
                }
                if (chkDataConnections.Checked)
                {
                    txtStatus.Text += Environment.NewLine + DataTest.addDataConnections(Convert.ToInt32(txtnumdataconns.Text));
                    this.Refresh();
                }
                if (chkLicenceRules.Checked)
                {
                    txtStatus.Text += Environment.NewLine + DataTest.addLicenceConfig(Convert.ToInt32(txtnumlicencerules.Text), true);
                    this.Refresh();
                }


                txtStatus.Text += Environment.NewLine + "Process finished at " + DateTime.Now.ToString();
            }
            catch(Exception ex)
            {
                txtStatus.Text += Environment.NewLine + "Snap! Something went wrong...     " + ex.Message;
            }
        }


    }
}
