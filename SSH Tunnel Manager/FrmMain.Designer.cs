
namespace SSH_Tunnel_Manager
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmForwardPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDserver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsshserver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewOne = new System.Windows.Forms.Button();
            this.btnStartall = new System.Windows.Forms.Button();
            this.btnStopall = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteThisItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteSelectionItemsFromLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllItemsFromLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.Type,
            this.clmForwardPort,
            this.clmDserver,
            this.clmsshserver,
            this.clmstatus,
            this.clmPass});
            this.dataGridView2.Location = new System.Drawing.Point(12, 81);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1018, 390);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDown);
            // 
            // clmName
            // 
            this.clmName.Frozen = true;
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 130;
            // 
            // Type
            // 
            this.Type.Frozen = true;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmForwardPort
            // 
            this.clmForwardPort.Frozen = true;
            this.clmForwardPort.HeaderText = "Forward Port";
            this.clmForwardPort.Name = "clmForwardPort";
            this.clmForwardPort.ReadOnly = true;
            this.clmForwardPort.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmForwardPort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmDserver
            // 
            this.clmDserver.Frozen = true;
            this.clmDserver.HeaderText = "Destination server";
            this.clmDserver.Name = "clmDserver";
            this.clmDserver.ReadOnly = true;
            this.clmDserver.Width = 200;
            // 
            // clmsshserver
            // 
            this.clmsshserver.Frozen = true;
            this.clmsshserver.HeaderText = "SSH server";
            this.clmsshserver.Name = "clmsshserver";
            this.clmsshserver.ReadOnly = true;
            this.clmsshserver.Width = 200;
            // 
            // clmstatus
            // 
            this.clmstatus.Frozen = true;
            this.clmstatus.HeaderText = "Status";
            this.clmstatus.Name = "clmstatus";
            this.clmstatus.ReadOnly = true;
            this.clmstatus.Width = 248;
            // 
            // clmPass
            // 
            this.clmPass.Frozen = true;
            this.clmPass.HeaderText = "Passbs64";
            this.clmPass.Name = "clmPass";
            this.clmPass.Visible = false;
            // 
            // btnNewOne
            // 
            this.btnNewOne.Location = new System.Drawing.Point(12, 478);
            this.btnNewOne.Name = "btnNewOne";
            this.btnNewOne.Size = new System.Drawing.Size(224, 37);
            this.btnNewOne.TabIndex = 2;
            this.btnNewOne.Text = "New SSH Tunnel";
            this.btnNewOne.UseVisualStyleBackColor = true;
            this.btnNewOne.Click += new System.EventHandler(this.btnNewOne_Click);
            // 
            // btnStartall
            // 
            this.btnStartall.Location = new System.Drawing.Point(336, 478);
            this.btnStartall.Name = "btnStartall";
            this.btnStartall.Size = new System.Drawing.Size(224, 37);
            this.btnStartall.TabIndex = 3;
            this.btnStartall.Text = "Start all Tunnels";
            this.btnStartall.UseVisualStyleBackColor = true;
            this.btnStartall.Click += new System.EventHandler(this.btnStartall_Click);
            // 
            // btnStopall
            // 
            this.btnStopall.Location = new System.Drawing.Point(566, 478);
            this.btnStopall.Name = "btnStopall";
            this.btnStopall.Size = new System.Drawing.Size(224, 37);
            this.btnStopall.TabIndex = 4;
            this.btnStopall.Text = "Stop all Tunnels";
            this.btnStopall.UseVisualStyleBackColor = true;
            this.btnStopall.Click += new System.EventHandler(this.btnStopall_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(944, 478);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(86, 37);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteThisItemToolStripMenuItem,
            this.deleteAllItemToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteSelectionItemsFromLocalToolStripMenuItem,
            this.deleteAllItemsFromLocalToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 148);
            // 
            // deleteThisItemToolStripMenuItem
            // 
            this.deleteThisItemToolStripMenuItem.Name = "deleteThisItemToolStripMenuItem";
            this.deleteThisItemToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.deleteThisItemToolStripMenuItem.Text = "remove selection item";
            this.deleteThisItemToolStripMenuItem.Click += new System.EventHandler(this.deleteThisItemToolStripMenuItem_Click);
            // 
            // deleteAllItemToolStripMenuItem
            // 
            this.deleteAllItemToolStripMenuItem.Name = "deleteAllItemToolStripMenuItem";
            this.deleteAllItemToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.deleteAllItemToolStripMenuItem.Text = "remove all item";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // deleteSelectionItemsFromLocalToolStripMenuItem
            // 
            this.deleteSelectionItemsFromLocalToolStripMenuItem.Name = "deleteSelectionItemsFromLocalToolStripMenuItem";
            this.deleteSelectionItemsFromLocalToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.deleteSelectionItemsFromLocalToolStripMenuItem.Text = "delete selection items from local";
            // 
            // deleteAllItemsFromLocalToolStripMenuItem
            // 
            this.deleteAllItemsFromLocalToolStripMenuItem.Name = "deleteAllItemsFromLocalToolStripMenuItem";
            this.deleteAllItemsFromLocalToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.deleteAllItemsFromLocalToolStripMenuItem.Text = "delete all items from local";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(242, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(245, 22);
            this.toolStripMenuItem1.Text = "start seletion items";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(245, 22);
            this.toolStripMenuItem2.Text = "stop selection items";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 528);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnStopall);
            this.Controls.Add(this.btnStartall);
            this.Controls.Add(this.btnNewOne);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "SSH Tunnel Manager beta 1.1 - http://www.dark5.net";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnNewOne;
        private System.Windows.Forms.Button btnStartall;
        private System.Windows.Forms.Button btnStopall;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmForwardPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDserver;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsshserver;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPass;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteThisItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectionItemsFromLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllItemsFromLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

