using System;
using System.Windows.Forms;

namespace Hard_Drive_Info
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HardDriveInfo harddriveInfo = new HardDriveInfo();
            PartitionInfo partitionInfo = new PartitionInfo();
            VolumeInfo volumeInfo = new VolumeInfo();
            LogicalDiskInfo logicalDiskInfo = new LogicalDiskInfo();
            DriveInfoDrivesInfo driveInfoDrives = new DriveInfoDrivesInfo();

            diskInfoDisplayHardDrives.DriveInfo = harddriveInfo;
            diskInfoDisplayPartitions.DriveInfo = partitionInfo;
            diskInfoDisplayVolumes.DriveInfo = volumeInfo;
            diskInfoDisplayLogicalDisks.DriveInfo = logicalDiskInfo;
            diskInfoDisplayDriveInfo_GetDrives.DriveInfo = driveInfoDrives;
        }
    }
}
