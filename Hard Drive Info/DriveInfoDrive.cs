using System;
using System.IO;

namespace Hard_Drive_Info
{
    class DriveInfoDrive
    {
        private Int64 availableFreeSpace = 0;
        private string driveFormat = "";
        private System.IO.DriveType driveType;
        private bool isReady = false;
        private string name = "";
        private System.IO.DirectoryInfo rootDirectory = null;
        private Int64 totalFreeSpace = 0;
        private Int64 totalSize = 0;
        private string volumeLabel = "";

        public long AvailableFreeSpace { get => availableFreeSpace; set => availableFreeSpace = value; }
        public string DriveFormat { get => driveFormat; set => driveFormat = value; }
        public DriveType DriveType { get => driveType; set => driveType = value; }
        public bool IsReady { get => isReady; set => isReady = value; }
        public string Name { get => name; set => name = value; }
        public DirectoryInfo RootDirectory { get => rootDirectory; set => rootDirectory = value; }
        public long TotalFreeSpace { get => totalFreeSpace; set => totalFreeSpace = value; }
        public long TotalSize { get => totalSize; set => totalSize = value; }
        public string VolumeLabel { get => volumeLabel; set => volumeLabel = value; }
    }
}
