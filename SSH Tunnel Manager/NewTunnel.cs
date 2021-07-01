using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SSH_Tunnel_Manager
{
    public partial class NewTunnel : Form
    {
        public NewTunnel()
        {
            InitializeComponent();
        }

        private void NewTunnel_Load(object sender, EventArgs e)
        {
            if (rbtnLocal.Checked)
            {
                tBoxLocalPort.Visible = true;
                tBoxLocalServer.Visible = false;
                tBoxForwardLocal.Visible = false;
            }
            string path = @"./config";
            DirectoryInfo root = new DirectoryInfo(path);
            FileInfo[] fs = root.GetFiles();
            if (fs.Length > 0)
            {
                foreach (FileInfo f in fs)
                {
                    cBoxconfig.Items.Add(f.Name);
                }

            }

            



        }

        private void rbtnLocal_CheckedChanged(object sender, EventArgs e)
        {
            
            tBoxLocalPort.Visible = true;
            tBoxRemotePort.Visible = true;
            tBoxRemoteServer.Visible = true;

            tBoxLocalServer.Visible = false;
            tBoxForwardLocal.Visible = false;            
            tBoxForwardRemote.Visible = false;
            
        }

        private void rbtnRemote_CheckedChanged(object sender, EventArgs e)
        {
            

            tBoxLocalServer.Visible = true;
            tBoxLocalPort.Visible = true;
            tBoxForwardRemote.Visible = true;

            tBoxForwardLocal.Visible = false;
            tBoxRemotePort.Visible = false;
            tBoxRemoteServer.Visible = false;

        }

        private void rbtnDynamic_CheckedChanged(object sender, EventArgs e)
        {
            tBoxForwardLocal.Visible = true;

            tBoxLocalServer.Visible = false;
            tBoxLocalPort.Visible = false;
            tBoxForwardRemote.Visible = false;
            tBoxRemotePort.Visible = false;
            tBoxRemoteServer.Visible = false;
        }


        private void addsave(object noprames)
        {
            string filenametBox = tBoxTunnelName.Text.Trim();

            if (filenametBox == "Tunnel Name" || filenametBox == "" || File.Exists(@"./Tunnels/"+ filenametBox))
            {
                MessageBox.Show("Please Input Tunnel Name!!!");
                return;

            }

            string filename = "./Tunnels/" + tBoxTunnelName.Text;

            if (File.Exists( filename))
            {
                MessageBox.Show("Tunnel was be Created.");
                return;
            }

            string username = tBoxlogin.Text;
            string sshserver = tBoxSSHServer.Text;
            string sshport = tBoxSSHPort.Text;
            string pass = tBoxPass.Text;
            string passbs4 = Convert.ToBase64String(Encoding.Default.GetBytes(pass));
            string authstring = username + "@" + sshserver + ":" + sshport + "-" + passbs4;


            if (rbtnLocal.Checked)
            {

                string forwardport = tBoxLocalPort.Text;
                string dserver = tBoxRemoteServer.Text + ":" + tBoxRemotePort.Text;
                //string remoteport = tBoxRemotePort.Text;

                string tunnelstr = "Local" + "_" + forwardport + "_" + dserver + "_" +authstring;
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.Write(tunnelstr);
                }
            }

            if (rbtnRemote.Checked)
            {

                string forwardport = tBoxForwardRemote.Text;
                string dserver = tBoxLocalServer.Text + ":" + tBoxLocalPort.Text;
                string tunnelstr = "Remote" + "_" + forwardport + "_" + dserver + "_" + authstring;
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.Write(tunnelstr);
                }

            }

            if (rbtnDynamic.Checked)
            {
                string forwardport = tBoxForwardLocal.Text;
                string dserver = "-0:-0";
                string tunnelstr = "Dynamic"+ "_" + forwardport + "_" + dserver + "_" + authstring;
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.Write(tunnelstr);

                }
            }
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            //new Thread(() => this.addsave("none")) { IsBackground = true }.Start();
            addsave("none");
            //Thread.Sleep(2000);
            this.Close();
        }





        private void btnadd_Click(object sender, EventArgs e)
        {
            new Thread(() => this.addsave("none")) { IsBackground = true }.Start();

            Thread.Sleep(500);
            btnadd.Text = "added";
            btnadd.Enabled = false;           
            
            Thread.Sleep(2000);
            btnadd.Text = "add";
            btnadd.Enabled = true;
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveSSHinfo_Click(object sender, EventArgs e)
        {
            string filename = @"./config/"+ cBoxconfig.Text.Trim();
            if (File.Exists(filename))
            {
                MessageBox.Show("Svae faild. \r\nThe Name was exists.");
                return;
            }


            string username = tBoxlogin.Text;
            string sshserver = tBoxSSHServer.Text;
            string sshport = tBoxSSHPort.Text;
            string pass = tBoxPass.Text;
            string passbs4 = Convert.ToBase64String(Encoding.Default.GetBytes(pass));
            string authstring = username + "@" + sshserver + ":" + sshport + "-" + passbs4;
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write(authstring);
            }
            MessageBox.Show("Save successfully!");
        }

        private void btnLoader_Click(object sender, EventArgs e)
        {
            string filename = @"./config/" + cBoxconfig.Text.Trim();
            if (!File.Exists( filename))
            {
                MessageBox.Show("The Name has been delete.");
                return;
            }

            using (StreamReader sr = new StreamReader(filename))
            {
                string[] tmp = sr.ReadToEnd().Split(':');
                string username = tmp[0].Split('@')[0];
                string server = tmp[0].Split('@')[1];
                string port = tmp[1].Split('-')[0];
                string pass = Encoding.Default.GetString(Convert.FromBase64String(tmp[1].Split('-')[1]));

                tBoxlogin.Text = username;
                tBoxSSHServer.Text = server;
                tBoxSSHPort.Text = port;
                tBoxPass.Text = pass;
            }

        }
    }
}
