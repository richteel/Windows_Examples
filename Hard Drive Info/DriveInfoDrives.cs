using System.Collections;
using System.IO;

namespace Hard_Drive_Info
{
    public class DriveInfoDrivesInfo : DriveInformation
    {
        public DriveInfoDrivesInfo()
        {
            Refresh();
        }

        public override void Refresh()
        {
            drives = new ArrayList();
            messages = new ArrayList();

            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                DriveInfoDrive driveInfoDrive = new DriveInfoDrive();

                driveInfoDrive.IsReady = di.IsReady;
                driveInfoDrive.RootDirectory = di.RootDirectory;
                driveInfoDrive.Name = di.Name;
                driveInfoDrive.DriveType = di.DriveType;

                if (di.IsReady)
                {
                    driveInfoDrive.AvailableFreeSpace = di.AvailableFreeSpace;
                    driveInfoDrive.DriveFormat = di.DriveFormat;
                    driveInfoDrive.TotalFreeSpace = di.TotalFreeSpace;
                    driveInfoDrive.TotalSize = di.TotalSize;
                    driveInfoDrive.VolumeLabel = di.VolumeLabel;
                }
                drives.Add(driveInfoDrive);
            }
        }
    }
}
