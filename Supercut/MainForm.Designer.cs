namespace Supercut
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.AddFolder = new System.Windows.Forms.Button();
            this.AddFile = new System.Windows.Forms.Button();
            this.RemoveFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Duration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoClip = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RandomStart = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RandomOrder = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.VideoPlayer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(0, 0);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(266, 450);
            this.VideoPlayer.TabIndex = 0;
            this.VideoPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.VideoPlayer_PlayStateChange);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.PlayList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddFolder, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddFile, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RemoveFile, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PlayList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PlayList, 3);
            this.PlayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayList.FormattingEnabled = true;
            this.PlayList.Location = new System.Drawing.Point(3, 3);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(524, 354);
            this.PlayList.TabIndex = 0;
            this.PlayList.DoubleClick += new System.EventHandler(this.PlayList_DoubleClick);
            // 
            // AddFolder
            // 
            this.AddFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddFolder.Location = new System.Drawing.Point(3, 363);
            this.AddFolder.Name = "AddFolder";
            this.AddFolder.Size = new System.Drawing.Size(170, 24);
            this.AddFolder.TabIndex = 1;
            this.AddFolder.Text = "Add Folder";
            this.AddFolder.UseVisualStyleBackColor = true;
            this.AddFolder.Click += new System.EventHandler(this.AddFolder_Click);
            // 
            // AddFile
            // 
            this.AddFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddFile.Location = new System.Drawing.Point(179, 363);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(170, 24);
            this.AddFile.TabIndex = 2;
            this.AddFile.Text = "Add File";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // RemoveFile
            // 
            this.RemoveFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveFile.Location = new System.Drawing.Point(355, 363);
            this.RemoveFile.Name = "RemoveFile";
            this.RemoveFile.Size = new System.Drawing.Size(172, 24);
            this.RemoveFile.TabIndex = 3;
            this.RemoveFile.Text = "Remove File";
            this.RemoveFile.UseVisualStyleBackColor = true;
            this.RemoveFile.Click += new System.EventHandler(this.RemoveFile_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.RandomStart);
            this.panel1.Controls.Add(this.Duration);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AutoClip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 24);
            this.panel1.TabIndex = 5;
            // 
            // Duration
            // 
            this.Duration.Enabled = false;
            this.Duration.Location = new System.Drawing.Point(192, 2);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(100, 20);
            this.Duration.TabIndex = 7;
            this.Duration.TextChanged += new System.EventHandler(this.Duration_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Duration:";
            // 
            // AutoClip
            // 
            this.AutoClip.AutoSize = true;
            this.AutoClip.Location = new System.Drawing.Point(23, 4);
            this.AutoClip.Name = "AutoClip";
            this.AutoClip.Size = new System.Drawing.Size(68, 17);
            this.AutoClip.TabIndex = 4;
            this.AutoClip.Text = "Auto Clip";
            this.AutoClip.UseVisualStyleBackColor = true;
            this.AutoClip.CheckedChanged += new System.EventHandler(this.AutoClip_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RandomStart
            // 
            this.RandomStart.AutoSize = true;
            this.RandomStart.Location = new System.Drawing.Point(365, 4);
            this.RandomStart.Name = "RandomStart";
            this.RandomStart.Size = new System.Drawing.Size(131, 17);
            this.RandomStart.TabIndex = 8;
            this.RandomStart.Text = "Random Start Position";
            this.RandomStart.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RandomOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 24);
            this.panel2.TabIndex = 6;
            // 
            // RandomOrder
            // 
            this.RandomOrder.AutoSize = true;
            this.RandomOrder.Location = new System.Drawing.Point(23, 4);
            this.RandomOrder.Name = "RandomOrder";
            this.RandomOrder.Size = new System.Drawing.Size(95, 17);
            this.RandomOrder.TabIndex = 0;
            this.RandomOrder.Text = "Random Order";
            this.RandomOrder.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Supercut";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox PlayList;
        private System.Windows.Forms.Button AddFolder;
        private System.Windows.Forms.Button AddFile;
        private System.Windows.Forms.Button RemoveFile;
        private System.Windows.Forms.CheckBox AutoClip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox RandomStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox RandomOrder;
    }
}