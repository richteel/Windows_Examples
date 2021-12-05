
namespace Hard_Drive_Info
{
    partial class frmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHardDrives = new System.Windows.Forms.TabPage();
            this.diskInfoDisplayHardDrives = new Hard_Drive_Info.DiskInfoDisplay();
            this.tabPartitions = new System.Windows.Forms.TabPage();
            this.diskInfoDisplayPartitions = new Hard_Drive_Info.DiskInfoDisplay();
            this.tabVolumes = new System.Windows.Forms.TabPage();
            this.diskInfoDisplayVolumes = new Hard_Drive_Info.DiskInfoDisplay();
            this.tabLogicalDisks = new System.Windows.Forms.TabPage();
            this.diskInfoDisplayLogicalDisks = new Hard_Drive_Info.DiskInfoDisplay();
            this.tabDriveInfo_GetDrives = new System.Windows.Forms.TabPage();
            this.diskInfoDisplayDriveInfo_GetDrives = new Hard_Drive_Info.DiskInfoDisplay();
            this.tabControl1.SuspendLayout();
            this.tabHardDrives.SuspendLayout();
            this.tabPartitions.SuspendLayout();
            this.tabVolumes.SuspendLayout();
            this.tabLogicalDisks.SuspendLayout();
            this.tabDriveInfo_GetDrives.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHardDrives);
            this.tabControl1.Controls.Add(this.tabPartitions);
            this.tabControl1.Controls.Add(this.tabVolumes);
            this.tabControl1.Controls.Add(this.tabLogicalDisks);
            this.tabControl1.Controls.Add(this.tabDriveInfo_GetDrives);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 404);
            this.tabControl1.TabIndex = 3;
            // 
            // tabHardDrives
            // 
            this.tabHardDrives.Controls.Add(this.diskInfoDisplayHardDrives);
            this.tabHardDrives.Location = new System.Drawing.Point(4, 22);
            this.tabHardDrives.Name = "tabHardDrives";
            this.tabHardDrives.Padding = new System.Windows.Forms.Padding(3);
            this.tabHardDrives.Size = new System.Drawing.Size(792, 378);
            this.tabHardDrives.TabIndex = 0;
            this.tabHardDrives.Text = "HardDrives";
            this.tabHardDrives.UseVisualStyleBackColor = true;
            // 
            // diskInfoDisplayHardDrives
            // 
            this.diskInfoDisplayHardDrives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskInfoDisplayHardDrives.DriveInfo = null;
            this.diskInfoDisplayHardDrives.Location = new System.Drawing.Point(3, 3);
            this.diskInfoDisplayHardDrives.Name = "diskInfoDisplayHardDrives";
            this.diskInfoDisplayHardDrives.Size = new System.Drawing.Size(786, 372);
            this.diskInfoDisplayHardDrives.TabIndex = 0;
            // 
            // tabPartitions
            // 
            this.tabPartitions.Controls.Add(this.diskInfoDisplayPartitions);
            this.tabPartitions.Location = new System.Drawing.Point(4, 22);
            this.tabPartitions.Name = "tabPartitions";
            this.tabPartitions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPartitions.Size = new System.Drawing.Size(792, 378);
            this.tabPartitions.TabIndex = 1;
            this.tabPartitions.Text = "Partitions";
            this.tabPartitions.UseVisualStyleBackColor = true;
            // 
            // diskInfoDisplayPartitions
            // 
            this.diskInfoDisplayPartitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskInfoDisplayPartitions.DriveInfo = null;
            this.diskInfoDisplayPartitions.Location = new System.Drawing.Point(3, 3);
            this.diskInfoDisplayPartitions.Name = "diskInfoDisplayPartitions";
            this.diskInfoDisplayPartitions.Size = new System.Drawing.Size(786, 372);
            this.diskInfoDisplayPartitions.TabIndex = 1;
            // 
            // tabVolumes
            // 
            this.tabVolumes.Controls.Add(this.diskInfoDisplayVolumes);
            this.tabVolumes.Location = new System.Drawing.Point(4, 22);
            this.tabVolumes.Name = "tabVolumes";
            this.tabVolumes.Size = new System.Drawing.Size(792, 378);
            this.tabVolumes.TabIndex = 2;
            this.tabVolumes.Text = "Volumes";
            this.tabVolumes.UseVisualStyleBackColor = true;
            // 
            // diskInfoDisplayVolumes
            // 
            this.diskInfoDisplayVolumes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskInfoDisplayVolumes.DriveInfo = null;
            this.diskInfoDisplayVolumes.Location = new System.Drawing.Point(0, 0);
            this.diskInfoDisplayVolumes.Name = "diskInfoDisplayVolumes";
            this.diskInfoDisplayVolumes.Size = new System.Drawing.Size(792, 378);
            this.diskInfoDisplayVolumes.TabIndex = 1;
            // 
            // tabLogicalDisks
            // 
            this.tabLogicalDisks.Controls.Add(this.diskInfoDisplayLogicalDisks);
            this.tabLogicalDisks.Location = new System.Drawing.Point(4, 22);
            this.tabLogicalDisks.Name = "tabLogicalDisks";
            this.tabLogicalDisks.Size = new System.Drawing.Size(792, 378);
            this.tabLogicalDisks.TabIndex = 3;
            this.tabLogicalDisks.Text = "LogicalDisks";
            this.tabLogicalDisks.UseVisualStyleBackColor = true;
            // 
            // diskInfoDisplayLogicalDisks
            // 
            this.diskInfoDisplayLogicalDisks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskInfoDisplayLogicalDisks.DriveInfo = null;
            this.diskInfoDisplayLogicalDisks.Location = new System.Drawing.Point(0, 0);
            this.diskInfoDisplayLogicalDisks.Name = "diskInfoDisplayLogicalDisks";
            this.diskInfoDisplayLogicalDisks.Size = new System.Drawing.Size(792, 378);
            this.diskInfoDisplayLogicalDisks.TabIndex = 2;
            // 
            // tabDriveInfo_GetDrives
            // 
            this.tabDriveInfo_GetDrives.Controls.Add(this.diskInfoDisplayDriveInfo_GetDrives);
            this.tabDriveInfo_GetDrives.Location = new System.Drawing.Point(4, 22);
            this.tabDriveInfo_GetDrives.Name = "tabDriveInfo_GetDrives";
            this.tabDriveInfo_GetDrives.Size = new System.Drawing.Size(792, 378);
            this.tabDriveInfo_GetDrives.TabIndex = 4;
            this.tabDriveInfo_GetDrives.Text = "DriveInfo.GetDrives";
            this.tabDriveInfo_GetDrives.UseVisualStyleBackColor = true;
            // 
            // diskInfoDisplayDriveInfo_GetDrives
            // 
            this.diskInfoDisplayDriveInfo_GetDrives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskInfoDisplayDriveInfo_GetDrives.DriveInfo = null;
            this.diskInfoDisplayDriveInfo_GetDrives.Location = new System.Drawing.Point(0, 0);
            this.diskInfoDisplayDriveInfo_GetDrives.Name = "diskInfoDisplayDriveInfo_GetDrives";
            this.diskInfoDisplayDriveInfo_GetDrives.Size = new System.Drawing.Size(792, 378);
            this.diskInfoDisplayDriveInfo_GetDrives.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Hard Drive Information";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHardDrives.ResumeLayout(false);
            this.tabPartitions.ResumeLayout(false);
            this.tabVolumes.ResumeLayout(false);
            this.tabLogicalDisks.ResumeLayout(false);
            this.tabDriveInfo_GetDrives.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHardDrives;
        private System.Windows.Forms.TabPage tabPartitions;
        private System.Windows.Forms.TabPage tabVolumes;
        private System.Windows.Forms.TabPage tabLogicalDisks;
        private DiskInfoDisplay diskInfoDisplayHardDrives;
        private DiskInfoDisplay diskInfoDisplayPartitions;
        private DiskInfoDisplay diskInfoDisplayVolumes;
        private DiskInfoDisplay diskInfoDisplayLogicalDisks;
        private System.Windows.Forms.TabPage tabDriveInfo_GetDrives;
        private DiskInfoDisplay diskInfoDisplayDriveInfo_GetDrives;
    }
}

