using System;

namespace Hard_Drive_Info
{
    class Partition
    {
        private UInt16 additionalAvailability = 0;
        private UInt16 availability = 0;
        private UInt16[] powerManagementCapabilities = null;
        private string[] identifyingDescriptions = null;
        private UInt64 maxQuiesceTime = 0;
        private UInt64 otherIdentifyingInfo = 0;
        private UInt16 statusInfo = 0;
        private UInt64 powerOnHours = 0;
        private UInt64 totalPowerOnHours = 0;
        private UInt16 access = 0;
        private UInt64 blockSize = 0;
        private bool bootable = false;
        private bool bootPartition = false;
        private string caption = "";
        private UInt32 configManagerErrorCode = 0;
        private bool configManagerUserConfig = false;
        private string creationClassName = "";
        private string description = "";
        private string deviceID = "";
        private UInt32 diskIndex = 0;
        private bool errorCleared = false;
        private string errorDescription = "";
        private string errorMethodology = "";
        private UInt32 hiddenSectors = 0;
        private UInt32 index = 0;
        private DateTime installDate = new DateTime();
        private UInt32 lastErrorCode = 0;
        private string name = "";
        private UInt64 numberOfBlocks = 0;
        private string pNPDeviceID = "";
        private bool powerManagementSupported = false;
        private bool primaryPartition = false;
        private string purpose = "";
        private bool rewritePartition = false;
        private UInt64 size = 0;
        private UInt64 startingOffset = 0;
        private string status = "";
        private string systemCreationClassName = "";
        private string systemName = "";
        private string type = "";

        public ushort AdditionalAvailability { get => additionalAvailability; set => additionalAvailability = value; }
        public ushort Availability { get => availability; set => availability = value; }
        public ushort[] PowerManagementCapabilities { get => powerManagementCapabilities; set => powerManagementCapabilities = value; }
        public string[] IdentifyingDescriptions { get => identifyingDescriptions; set => identifyingDescriptions = value; }
        public ulong MaxQuiesceTime { get => maxQuiesceTime; set => maxQuiesceTime = value; }
        public ulong OtherIdentifyingInfo { get => otherIdentifyingInfo; set => otherIdentifyingInfo = value; }
        public ushort StatusInfo { get => statusInfo; set => statusInfo = value; }
        public ulong PowerOnHours { get => powerOnHours; set => powerOnHours = value; }
        public ulong TotalPowerOnHours { get => totalPowerOnHours; set => totalPowerOnHours = value; }
        public ushort Access { get => access; set => access = value; }
        public ulong BlockSize { get => blockSize; set => blockSize = value; }
        public bool Bootable { get => bootable; set => bootable = value; }
        public bool BootPartition { get => bootPartition; set => bootPartition = value; }
        public string Caption { get => caption; set => caption = value; }
        public uint ConfigManagerErrorCode { get => configManagerErrorCode; set => configManagerErrorCode = value; }
        public bool ConfigManagerUserConfig { get => configManagerUserConfig; set => configManagerUserConfig = value; }
        public string CreationClassName { get => creationClassName; set => creationClassName = value; }
        public string Description { get => description; set => description = value; }
        public string DeviceID { get => deviceID; set => deviceID = value; }
        public uint DiskIndex { get => diskIndex; set => diskIndex = value; }
        public bool ErrorCleared { get => errorCleared; set => errorCleared = value; }
        public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
        public string ErrorMethodology { get => errorMethodology; set => errorMethodology = value; }
        public uint HiddenSectors { get => hiddenSectors; set => hiddenSectors = value; }
        public uint Index { get => index; set => index = value; }
        public DateTime InstallDate { get => installDate; set => installDate = value; }
        public uint LastErrorCode { get => lastErrorCode; set => lastErrorCode = value; }
        public string Name { get => name; set => name = value; }
        public ulong NumberOfBlocks { get => numberOfBlocks; set => numberOfBlocks = value; }
        public string PNPDeviceID { get => pNPDeviceID; set => pNPDeviceID = value; }
        public bool PowerManagementSupported { get => powerManagementSupported; set => powerManagementSupported = value; }
        public bool PrimaryPartition { get => primaryPartition; set => primaryPartition = value; }
        public string Purpose { get => purpose; set => purpose = value; }
        public bool RewritePartition { get => rewritePartition; set => rewritePartition = value; }
        public ulong Size { get => size; set => size = value; }
        public ulong StartingOffset { get => startingOffset; set => startingOffset = value; }
        public string Status { get => status; set => status = value; }
        public string SystemCreationClassName { get => systemCreationClassName; set => systemCreationClassName = value; }
        public string SystemName { get => systemName; set => systemName = value; }
        public string Type { get => type; set => type = value; }
    }
}
