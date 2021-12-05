using System;

namespace Hard_Drive_Info
{
    class Volume
    {
        private UInt16 access = 0;
        private bool automount = false;
        private UInt16 availability = 0;
        private UInt64 blockSize = 0;
        private UInt64 capacity = 0;
        private string caption = "";
        private bool compressed = false;
        private UInt32 configManagerErrorCode = 0;
        private bool configManagerUserConfig = false;
        private string creationClassName = "";
        private string description = "";
        private string deviceID = "";
        private bool dirtyBitSet = false;
        private string driveLetter = "";
        private UInt32 driveType = 0;
        private bool errorCleared = false;
        private string errorDescription = "";
        private string errorMethodology = "";
        private string fileSystem = "";
        private UInt64 freeSpace = 0;
        private bool indexingEnabled = false;
        private DateTime installDate = new DateTime();
        private string label = "";
        private UInt32 lastErrorCode = 0;
        private UInt32 maximumFileNameLength = 0;
        private string name = "";
        private UInt64 numberOfBlocks = 0;
        private string pNPDeviceID = "";
        private UInt16[] powerManagementCapabilities = null;
        private bool powerManagementSupported = false;
        private string purpose = "";
        private bool quotasEnabled = false;
        private bool quotasIncomplete = false;
        private bool quotasRebuilding = false;
        private string status = "";
        private UInt16 statusInfo = 0;
        private string systemCreationClassName = "";
        private string systemName = "";
        private UInt32 serialNumber = 0;
        private bool supportsDiskQuotas = false;
        private bool supportsFileBasedCompression = false;

        public ushort Access { get => access; set => access = value; }
        public bool Automount { get => automount; set => automount = value; }
        public ushort Availability { get => availability; set => availability = value; }
        public ulong BlockSize { get => blockSize; set => blockSize = value; }
        public ulong Capacity { get => capacity; set => capacity = value; }
        public string Caption { get => caption; set => caption = value; }
        public bool Compressed { get => compressed; set => compressed = value; }
        public uint ConfigManagerErrorCode { get => configManagerErrorCode; set => configManagerErrorCode = value; }
        public bool ConfigManagerUserConfig { get => configManagerUserConfig; set => configManagerUserConfig = value; }
        public string CreationClassName { get => creationClassName; set => creationClassName = value; }
        public string Description { get => description; set => description = value; }
        public string DeviceID { get => deviceID; set => deviceID = value; }
        public bool DirtyBitSet { get => dirtyBitSet; set => dirtyBitSet = value; }
        public string DriveLetter { get => driveLetter; set => driveLetter = value; }
        public uint DriveType { get => driveType; set => driveType = value; }
        public bool ErrorCleared { get => errorCleared; set => errorCleared = value; }
        public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
        public string ErrorMethodology { get => errorMethodology; set => errorMethodology = value; }
        public string FileSystem { get => fileSystem; set => fileSystem = value; }
        public ulong FreeSpace { get => freeSpace; set => freeSpace = value; }
        public bool IndexingEnabled { get => indexingEnabled; set => indexingEnabled = value; }
        public DateTime InstallDate { get => installDate; set => installDate = value; }
        public string Label { get => label; set => label = value; }
        public uint LastErrorCode { get => lastErrorCode; set => lastErrorCode = value; }
        public uint MaximumFileNameLength { get => maximumFileNameLength; set => maximumFileNameLength = value; }
        public string Name { get => name; set => name = value; }
        public ulong NumberOfBlocks { get => numberOfBlocks; set => numberOfBlocks = value; }
        public string PNPDeviceID { get => pNPDeviceID; set => pNPDeviceID = value; }
        public ushort[] PowerManagementCapabilities { get => powerManagementCapabilities; set => powerManagementCapabilities = value; }
        public bool PowerManagementSupported { get => powerManagementSupported; set => powerManagementSupported = value; }
        public string Purpose { get => purpose; set => purpose = value; }
        public bool QuotasEnabled { get => quotasEnabled; set => quotasEnabled = value; }
        public bool QuotasIncomplete { get => quotasIncomplete; set => quotasIncomplete = value; }
        public bool QuotasRebuilding { get => quotasRebuilding; set => quotasRebuilding = value; }
        public string Status { get => status; set => status = value; }
        public ushort StatusInfo { get => statusInfo; set => statusInfo = value; }
        public string SystemCreationClassName { get => systemCreationClassName; set => systemCreationClassName = value; }
        public string SystemName { get => systemName; set => systemName = value; }
        public uint SerialNumber { get => serialNumber; set => serialNumber = value; }
        public bool SupportsDiskQuotas { get => supportsDiskQuotas; set => supportsDiskQuotas = value; }
        public bool SupportsFileBasedCompression { get => supportsFileBasedCompression; set => supportsFileBasedCompression = value; }
    }
}