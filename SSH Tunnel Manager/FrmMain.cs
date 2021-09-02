using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Renci.SshNet;

namespace SSH_Tunnel_Manager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnNewOne_Click(object sender, EventArgs e)
        {
            NewTunnel f = new NewTunnel();

            f.ShowDialog();
        }

        private bool stopFlag = false;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            string path = @"./Tunnels";
            DirectoryInfo root = new DirectoryInfo(path);
            foreach (FileInfo f in root.GetFiles())
            {
                string Name = f.Name;
                string fullName = f.FullName;
                using (StreamReader swr = new StreamReader(fullName))
                {
                    string text = swr.ReadToEnd();
                    string[] textarray = text.Split('_');
                    string type = textarray[0];
                    string forwardport = textarray[1];
                    string dserver = textarray[2];
                    string[] sshserverauth = textarray[3].Split('-');
                    string sshserver = sshserverauth[0];
                    string sshserverpass = sshserverauth[1];
                    

                    int index = this.dataGridView2.Rows.Add();
                    this.dataGridView2.Rows[index].Cells[0].Value = Name;
                    this.dataGridView2.Rows[index].Cells[1].Value = type;
                    this.dataGridView2.Rows[index].Cells[2].Value = forwardport;
                    this.dataGridView2.Rows[index].Cells[3].Value = dserver;
                    this.dataGridView2.Rows[index].Cells[4].Value = sshserver;
                    this.dataGridView2.Rows[index].Cells[6].Value = sshserverpass;

                }
            }
        }

        private void btnStartall_Click(object sender, EventArgs e)
        {
            //string privateKeyPath = tBoxkeyprivate.Text.Trim();

            //if (privateKeyPath == "")
            //{
            //    MessageBox.Show("Please Input your Private key");
            //    return;
            //}

            //if (!File.Exists(privateKeyPath))
            //{
            //    MessageBox.Show("Please Check your Private Key path.");
            //    return;
            //}


            for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
            {


                string type = this.dataGridView2.Rows[i].Cells[1].Value.ToString();
                
                
                string forwardport = this.dataGridView2.Rows[i].Cells[2].Value.ToString();
                string dserver = this.dataGridView2.Rows[i].Cells[3].Value.ToString();
                string sship = this.dataGridView2.Rows[i].Cells[4].Value.ToString().Split(':')[0].Split('@')[1];
                string sshusername = this.dataGridView2.Rows[i].Cells[4].Value.ToString().Split(':')[0].Split('@')[0];
                string sshport = this.dataGridView2.Rows[i].Cells[4].Value.ToString().Split(':')[1];
                string password = this.dataGridView2.Rows[i].Cells[6].Value.ToString();
                //string[] conn = new string[] { forwardport, dserver, sship , sshusername, sshport };
                Dictionary<string, string> conn = new Dictionary<string, string>();
                conn.Add("forwardport", forwardport);
                conn.Add("sship", sship);
                conn.Add("sshusername", sshusername);
                conn.Add("sshport", sshport);
                conn.Add("password", password);
                conn.Add("dserver", dserver);
                conn.Add("row", i.ToString());

                switch (type)
                {
                    case "Local":
                        new Thread(() => this.addLocalForwarding(conn)) { IsBackground = true }.Start();

                        break;
                    case "Remote":
                        //string command = string.Format($" -i {privateKeyPath} -C -N -R 0.0.0.0:{forwardport}:{dserver} -p {sshport} {sshserver}");
                        //MessageBox.Show(command);

                        new Thread(() => this.addRemoteForwarding(conn)) { IsBackground = true }.Start();
                        //this.addLocalForwarding(conn);
                        //addLocalForwarding();
                        break;
                    case "Dynamic":
                        break;
                }
            }

        }



        private void addLocalForwarding(object prames)
        {
            Dictionary<string, string> d = prames as Dictionary<string, string>;
            string sship = d["sship"];
            int sshport = Int32.Parse(d["sshport"]);
            string sshusername = d["sshusername"];
            string password = Encoding.Default.GetString(Convert.FromBase64String(d["password"]));
            uint forwardport = uint.Parse(d["forwardport"]);
            string dip = d["dserver"].Split(':')[0];
            uint dport = uint.Parse(d["dserver"].Split(':')[1]);

            ConnectionInfo ConnNfo = new ConnectionInfo(sship, sshport, sshusername,new AuthenticationMethod[] { new PasswordAuthenticationMethod(sshusername, password), });
            using (var client = new SshClient(ConnNfo))
            {
                client.Connect();
                
                //if (client.IsConnected)
                //{
                //    MessageBox.Show("SSH is Connected.");
                //}
                //else { MessageBox.Show("SSH is not Connected."); }

                //var portFwld = new ForwardedPortLocal("0.0.0.0", 80, "39.108.88.207", 22);
                var portLocalFwld = new ForwardedPortLocal("127.0.0.1", forwardport,  dip, dport);
                client.AddForwardedPort(portLocalFwld);
                portLocalFwld.Start();
                

                if (portLocalFwld.IsStarted)
                {
                    //MessageBox.Show("Forwarding Success.");
                    dataGridView2.Rows[int.Parse(d["row"])].Cells[5].Value = "Success";
                }
                else { dataGridView2.Rows[int.Parse(d["row"])].Cells[5].Value = "Failed"; }


                while (!stopFlag)
                {
                    Thread.Sleep(1000);
                }
                dataGridView2.Rows[int.Parse(d["row"])].Cells[5].Value = "stoped.";
            }
        }






        
        private void addRemoteForwarding(object prames)
        {
            Dictionary<string, string> d = prames as Dictionary<string, string>;
            string sship = d["sship"];
            int sshport = Int32.Parse(d["sshport"]);
            string sshusername = d["sshusername"];
            string password = Encoding.Default.GetString(Convert.FromBase64String(d["password"]));
            uint forwardport = uint.Parse(d["forwardport"]);
            string dip = d["dserver"].Split(':')[0];
            uint dport = uint.Parse(d["dserver"].Split(':')[1]);

            try
            {
                //PasswordConnectionInfo connectionInfo = new PasswordConnectionInfo("39.108.88.207", 22, "root", "password");
                ConnectionInfo ConnNfo = new ConnectionInfo(sship, sshport, sshusername,
                new AuthenticationMethod[]{
                // Pasword based Authentication
                new PasswordAuthenticationMethod(sshusername,password),

                    // Key Based Authentication (using keys in OpenSSH Format)
                    //new PrivateKeyAuthenticationMethod("root",new PrivateKeyFile[]{
                    //  new PrivateKeyFile(@"C:\Users\h4ck\Desktop\id_rsa")
                    //} ),
                });

                using (var client = new SshClient(ConnNfo))
                {
                    client.Connect();
                    //if (client.IsConnected)
                    //{
                    //    MessageBox.Show("SSH is Connected.");
                    //}
                    //else { MessageBox.Show("SSH is not Connected."); }

                    //var portFwld = new ForwardedPortLocal("0.0.0.0", 80, "39.108.88.207", 22);
                    var portremoteFwld = new ForwardedPortRemote("127.0.0.1", forwardport, dip, dport);

                    

                    client.AddForwardedPort(portremoteFwld);
                    portremoteFwld.Start();

                    if (portremoteFwld.IsStarted)
                    {
                        //MessageBox.Show("Forwarding Success.");
                        dataGridView2.Rows[int.Parse(d["row"])].Cells[5].Value = "Success";
                    }
                    else { dataGridView2.Rows[int.Parse(d["row"])].Cells[5].Value = "Failed"; }
                    
                    while (!stopFlag)
                    {
                        Thread.Sleep(1000);
                        if (!client.IsConnected)
                        {
                            dataGridView2.Rows[int.Parse(d["row"])].Cells[5].Value = "disconnected.";
                            addRemoteForwarding(d);
                        }
                            
                    }
                    dataGridView2.Rows[int.Parse(d["row"])].Cells[5].Value = "stoped.";
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                dataGridView2.Rows[int.Parse(d["row"])].Cells[5].Value = ex.Message;
            }
            
        }

        private void addDynamicforwarding(object prames)
        {
            Dictionary<string, string> d = prames as Dictionary<string, string>;
            string sship = d["sship"];
            int sshport = Int32.Parse(d["sshport"]);
            string sshusername = d["sshusername"];
            string password = Encoding.Default.GetString(Convert.FromBase64String(d["password"]));
            uint forwardport = uint.Parse(d["forwardport"]);
            //string dip = d["dserver"].Split(':')[0];
            //uint dport = uint.Parse(d["dserver"].Split(':')[1]);


            try
            {
                //PasswordConnectionInfo connectionInfo = new PasswordConnectionInfo("39.108.88.207", 22, "root", "password");
                ConnectionInfo ConnNfo = new ConnectionInfo(sship, sshport, sshusername,
                new AuthenticationMethod[]{
                // Pasword based Authentication
                new PasswordAuthenticationMethod(sshusername,password),

                    // Key Based Authentication (using keys in OpenSSH Format)
                    //new PrivateKeyAuthenticationMethod("root",new PrivateKeyFile[]{
                    //  new PrivateKeyFile(@"C:\Users\h4ck\Desktop\id_rsa")
                    //} ),
                });

                using (var client = new SshClient(ConnNfo))
                {
                    client.Connect();
                    //if (client.IsConnected)
                    //{
                    //    MessageBox.Show("SSH is Connected.");
                    //}
                    //else { MessageBox.Show("SSH is not Connected."); }

                    //var portFwld = new ForwardedPortLocal("0.0.0.0", 80, "39.108.88.207", 22);
                    var portremoteFwld = new ForwardedPortDynamic( forwardport);
                    client.AddForwardedPort(portremoteFwld);
                    portremoteFwld.Start();

                    if (portremoteFwld.IsStarted)
                    {
                        //MessageBox.Show("Forwarding Success.");
                        dataGridView2.Rows[int.Parse(d["row"])].Cells[5].Value = "Success";
                    }
                    else { dataGridView2.Rows[int.Parse(d["row"])].Cells[5].Value = "Failed"; }
                    while (!stopFlag)
                    {
                        Thread.Sleep(1000);
                    }
                    dataGridView2.Rows[int.Parse(d["row"])].Cells[5].Value = "stoped.";
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                dataGridView2.Rows[int.Parse(d["row"])].Cells[5].Value = ex.Message;
            }

        }

        private void btnStopall_Click(object sender, EventArgs e)
        {
            stopFlag = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void deleteThisItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.SelectedRows[0]);
        }

    }
}
