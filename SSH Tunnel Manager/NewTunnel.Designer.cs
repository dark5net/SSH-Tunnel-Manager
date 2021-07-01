
namespace SSH_Tunnel_Manager
{
    partial class NewTunnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnLocal = new System.Windows.Forms.RadioButton();
            this.rbtnRemote = new System.Windows.Forms.RadioButton();
            this.rbtnDynamic = new System.Windows.Forms.RadioButton();
            this.gBoxLocal = new System.Windows.Forms.GroupBox();
            this.tBoxForwardLocal = new System.Windows.Forms.TextBox();
            this.tBoxForwardRemote = new System.Windows.Forms.TextBox();
            this.tBoxLocalServer = new System.Windows.Forms.TextBox();
            this.tBoxLocalPort = new System.Windows.Forms.TextBox();
            this.tBoxRemotePort = new System.Windows.Forms.TextBox();
            this.tBoxRemoteServer = new System.Windows.Forms.TextBox();
            this.tBoxPass = new System.Windows.Forms.TextBox();
            this.tBoxlogin = new System.Windows.Forms.TextBox();
            this.tBoxSSHPort = new System.Windows.Forms.TextBox();
            this.tBoxSSHServer = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.tBoxTunnelName = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnLoader = new System.Windows.Forms.Button();
            this.cBoxconfig = new System.Windows.Forms.ComboBox();
            this.btnSaveSSHinfo = new System.Windows.Forms.Button();
            this.gBoxLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnLocal
            // 
            this.rbtnLocal.AutoSize = true;
            this.rbtnLocal.Location = new System.Drawing.Point(124, 40);
            this.rbtnLocal.Name = "rbtnLocal";
            this.rbtnLocal.Size = new System.Drawing.Size(149, 16);
            this.rbtnLocal.TabIndex = 0;
            this.rbtnLocal.Text = "Local port forwarding";
            this.rbtnLocal.UseVisualStyleBackColor = true;
            this.rbtnLocal.CheckedChanged += new System.EventHandler(this.rbtnLocal_CheckedChanged);
            // 
            // rbtnRemote
            // 
            this.rbtnRemote.AutoSize = true;
            this.rbtnRemote.Checked = true;
            this.rbtnRemote.Location = new System.Drawing.Point(399, 40);
            this.rbtnRemote.Name = "rbtnRemote";
            this.rbtnRemote.Size = new System.Drawing.Size(155, 16);
            this.rbtnRemote.TabIndex = 1;
            this.rbtnRemote.TabStop = true;
            this.rbtnRemote.Text = "Remote port forwarding";
            this.rbtnRemote.UseVisualStyleBackColor = true;
            this.rbtnRemote.CheckedChanged += new System.EventHandler(this.rbtnRemote_CheckedChanged);
            // 
            // rbtnDynamic
            // 
            this.rbtnDynamic.AutoSize = true;
            this.rbtnDynamic.Location = new System.Drawing.Point(673, 40);
            this.rbtnDynamic.Name = "rbtnDynamic";
            this.rbtnDynamic.Size = new System.Drawing.Size(245, 16);
            this.rbtnDynamic.TabIndex = 2;
            this.rbtnDynamic.Text = "Dynamic port forwarding (Socks proxy)";
            this.rbtnDynamic.UseVisualStyleBackColor = true;
            this.rbtnDynamic.CheckedChanged += new System.EventHandler(this.rbtnDynamic_CheckedChanged);
            // 
            // gBoxLocal
            // 
            this.gBoxLocal.Controls.Add(this.tBoxForwardLocal);
            this.gBoxLocal.Controls.Add(this.tBoxForwardRemote);
            this.gBoxLocal.Controls.Add(this.tBoxLocalServer);
            this.gBoxLocal.Controls.Add(this.tBoxLocalPort);
            this.gBoxLocal.Controls.Add(this.tBoxRemotePort);
            this.gBoxLocal.Controls.Add(this.tBoxRemoteServer);
            this.gBoxLocal.Controls.Add(this.tBoxPass);
            this.gBoxLocal.Controls.Add(this.tBoxlogin);
            this.gBoxLocal.Controls.Add(this.tBoxSSHPort);
            this.gBoxLocal.Controls.Add(this.tBoxSSHServer);
            this.gBoxLocal.Location = new System.Drawing.Point(12, 94);
            this.gBoxLocal.Name = "gBoxLocal";
            this.gBoxLocal.Size = new System.Drawing.Size(1017, 310);
            this.gBoxLocal.TabIndex = 3;
            this.gBoxLocal.TabStop = false;
            this.gBoxLocal.Text = "Forwarding Setting";
            // 
            // tBoxForwardLocal
            // 
            this.tBoxForwardLocal.Location = new System.Drawing.Point(31, 145);
            this.tBoxForwardLocal.Name = "tBoxForwardLocal";
            this.tBoxForwardLocal.Size = new System.Drawing.Size(156, 21);
            this.tBoxForwardLocal.TabIndex = 10;
            this.tBoxForwardLocal.Text = "Forwarded port";
            this.tBoxForwardLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxForwardLocal.Visible = false;
            // 
            // tBoxForwardRemote
            // 
            this.tBoxForwardRemote.Location = new System.Drawing.Point(739, 145);
            this.tBoxForwardRemote.Name = "tBoxForwardRemote";
            this.tBoxForwardRemote.Size = new System.Drawing.Size(156, 21);
            this.tBoxForwardRemote.TabIndex = 9;
            this.tBoxForwardRemote.Text = "Forwarded Port";
            this.tBoxForwardRemote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxLocalServer
            // 
            this.tBoxLocalServer.Location = new System.Drawing.Point(31, 66);
            this.tBoxLocalServer.Name = "tBoxLocalServer";
            this.tBoxLocalServer.Size = new System.Drawing.Size(156, 21);
            this.tBoxLocalServer.TabIndex = 8;
            this.tBoxLocalServer.Text = "Local Server";
            this.tBoxLocalServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxLocalPort
            // 
            this.tBoxLocalPort.Location = new System.Drawing.Point(31, 220);
            this.tBoxLocalPort.Name = "tBoxLocalPort";
            this.tBoxLocalPort.Size = new System.Drawing.Size(156, 21);
            this.tBoxLocalPort.TabIndex = 7;
            this.tBoxLocalPort.Text = "Local port";
            this.tBoxLocalPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxRemotePort
            // 
            this.tBoxRemotePort.Location = new System.Drawing.Point(739, 220);
            this.tBoxRemotePort.Name = "tBoxRemotePort";
            this.tBoxRemotePort.Size = new System.Drawing.Size(156, 21);
            this.tBoxRemotePort.TabIndex = 6;
            this.tBoxRemotePort.Text = "Remote Port";
            this.tBoxRemotePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxRemotePort.Visible = false;
            // 
            // tBoxRemoteServer
            // 
            this.tBoxRemoteServer.Location = new System.Drawing.Point(739, 66);
            this.tBoxRemoteServer.Name = "tBoxRemoteServer";
            this.tBoxRemoteServer.Size = new System.Drawing.Size(156, 21);
            this.tBoxRemoteServer.TabIndex = 5;
            this.tBoxRemoteServer.Text = "Remote Server";
            this.tBoxRemoteServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxRemoteServer.Visible = false;
            // 
            // tBoxPass
            // 
            this.tBoxPass.Location = new System.Drawing.Point(423, 249);
            this.tBoxPass.Name = "tBoxPass";
            this.tBoxPass.Size = new System.Drawing.Size(156, 21);
            this.tBoxPass.TabIndex = 4;
            this.tBoxPass.Text = "password";
            this.tBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxlogin
            // 
            this.tBoxlogin.Location = new System.Drawing.Point(423, 177);
            this.tBoxlogin.Name = "tBoxlogin";
            this.tBoxlogin.Size = new System.Drawing.Size(156, 21);
            this.tBoxlogin.TabIndex = 3;
            this.tBoxlogin.Text = "login";
            this.tBoxlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxSSHPort
            // 
            this.tBoxSSHPort.Location = new System.Drawing.Point(423, 113);
            this.tBoxSSHPort.Name = "tBoxSSHPort";
            this.tBoxSSHPort.Size = new System.Drawing.Size(156, 21);
            this.tBoxSSHPort.TabIndex = 2;
            this.tBoxSSHPort.Text = "SSH Port";
            this.tBoxSSHPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxSSHServer
            // 
            this.tBoxSSHServer.Location = new System.Drawing.Point(423, 54);
            this.tBoxSSHServer.Name = "tBoxSSHServer";
            this.tBoxSSHServer.Size = new System.Drawing.Size(156, 21);
            this.tBoxSSHServer.TabIndex = 1;
            this.tBoxSSHServer.Text = "SSH Server";
            this.tBoxSSHServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(399, 438);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(96, 46);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "add And exit";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(515, 438);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(96, 46);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Exit";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // tBoxTunnelName
            // 
            this.tBoxTunnelName.Location = new System.Drawing.Point(12, 452);
            this.tBoxTunnelName.Name = "tBoxTunnelName";
            this.tBoxTunnelName.Size = new System.Drawing.Size(243, 21);
            this.tBoxTunnelName.TabIndex = 6;
            this.tBoxTunnelName.Text = "Tunnel Name";
            this.tBoxTunnelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(282, 438);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(96, 46);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnLoader
            // 
            this.btnLoader.Location = new System.Drawing.Point(944, 438);
            this.btnLoader.Name = "btnLoader";
            this.btnLoader.Size = new System.Drawing.Size(85, 46);
            this.btnLoader.TabIndex = 8;
            this.btnLoader.Text = "LoadSSHinfo";
            this.btnLoader.UseVisualStyleBackColor = true;
            this.btnLoader.Click += new System.EventHandler(this.btnLoader_Click);
            // 
            // cBoxconfig
            // 
            this.cBoxconfig.FormattingEnabled = true;
            this.cBoxconfig.Location = new System.Drawing.Point(797, 453);
            this.cBoxconfig.Name = "cBoxconfig";
            this.cBoxconfig.Size = new System.Drawing.Size(121, 20);
            this.cBoxconfig.TabIndex = 9;
            // 
            // btnSaveSSHinfo
            // 
            this.btnSaveSSHinfo.Location = new System.Drawing.Point(688, 438);
            this.btnSaveSSHinfo.Name = "btnSaveSSHinfo";
            this.btnSaveSSHinfo.Size = new System.Drawing.Size(85, 46);
            this.btnSaveSSHinfo.TabIndex = 10;
            this.btnSaveSSHinfo.Text = "SaveSSHinfo";
            this.btnSaveSSHinfo.UseVisualStyleBackColor = true;
            this.btnSaveSSHinfo.Click += new System.EventHandler(this.btnSaveSSHinfo_Click);
            // 
            // NewTunnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 496);
            this.Controls.Add(this.btnSaveSSHinfo);
            this.Controls.Add(this.cBoxconfig);
            this.Controls.Add(this.btnLoader);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tBoxTunnelName);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.gBoxLocal);
            this.Controls.Add(this.rbtnDynamic);
            this.Controls.Add(this.rbtnRemote);
            this.Controls.Add(this.rbtnLocal);
            this.Name = "NewTunnel";
            this.Text = "NewTunnel";
            this.Load += new System.EventHandler(this.NewTunnel_Load);
            this.gBoxLocal.ResumeLayout(false);
            this.gBoxLocal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnLocal;
        private System.Windows.Forms.RadioButton rbtnRemote;
        private System.Windows.Forms.RadioButton rbtnDynamic;
        private System.Windows.Forms.GroupBox gBoxLocal;
        private System.Windows.Forms.TextBox tBoxPass;
        private System.Windows.Forms.TextBox tBoxlogin;
        private System.Windows.Forms.TextBox tBoxSSHPort;
        private System.Windows.Forms.TextBox tBoxSSHServer;
        private System.Windows.Forms.TextBox tBoxRemotePort;
        private System.Windows.Forms.TextBox tBoxRemoteServer;
        private System.Windows.Forms.TextBox tBoxLocalPort;
        private System.Windows.Forms.TextBox tBoxLocalServer;
        private System.Windows.Forms.TextBox tBoxForwardRemote;
        private System.Windows.Forms.TextBox tBoxForwardLocal;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox tBoxTunnelName;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnLoader;
        private System.Windows.Forms.ComboBox cBoxconfig;
        private System.Windows.Forms.Button btnSaveSSHinfo;
    }
}