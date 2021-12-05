using System;

namespace Hard_Drive_Info
{
    class HardDrive
    {
        private UInt16 availability = 0;
        private UInt32 bytesPerSector = 0;
        private UInt16[] capabilities = null;
        private string[] capabilityDescriptions = null;
        private string caption = "";
        private string compressionMethod = "";
        private UInt32 configManagerErrorCode = 0;
        private bool configManagerUserConfig = false;
        private string creationClassName = "";
        private UInt64 defaultBlockSize = 0;
        private string description = "";
        private string deviceID = "";
        private bool errorCleared = false;
        private string errorDescription = "";
        private string errorMethodology = "";
        private string firmwareRevision = "";
        private UInt32 index = 0;
        private DateTime installDate = new DateTime();
        private string interfaceType = "";
        private UInt32 lastErrorCode = 0;
        private string manufacturer = "";
        private UInt64 maxBlockSize = 0;
        private UInt64 maxMediaSize = 0;
        private bool mediaLoaded = false;
        private string mediaType = "";
        private UInt64 minBlockSize = 0;
        private string model = "";
        private string name = "";
        private bool needsCleaning = false;
        private UInt32 numberOfMediaSupported = 0;
        private UInt32 partitions = 0;
        private string pNPDeviceID = "";
        private UInt16[] powerManagementCapabilities = null;
        private bool powerManagementSupported = false;
        private UInt32 sCSIBus = 0;
        private UInt16 sCSILogicalUnit = 0;
        private UInt16 sCSIPort = 0;
        private UInt16 sCSITargetId = 0;
        private UInt32 sectorsPerTrack = 0;
        private string serialNumber = "";
        private UInt32 signature = 0;
        private UInt64 size = 0;
        private string status = "";
        private UInt16 statusInfo = 0;
        private string systemCreationClassName = "";
        private string systemName = "";
        private UInt64 totalCylinders = 0;
        private UInt32 totalHeads = 0;
        private UInt64 totalSectors = 0;
        private UInt64 totalTracks = 0;
        private UInt32 tracksPerCylinder = 0;

        public ushort Availability { get => availability; set => availability = value; }
        public uint BytesPerSector { get => bytesPerSector; set => bytesPerSector = value; }
        public ushort[] Capabilities { get => capabilities; set => capabilities = value; }
        public string[] CapabilityDescriptions { get => capabilityDescriptions; set => capabilityDescriptions = value; }
        public string Caption { get => caption; set => caption = value; }
        public string CompressionMethod { get => compressionMethod; set => compressionMethod = value; }
        public uint ConfigManagerErrorCode { get => configManagerErrorCode; set => configManagerErrorCode = value; }
        public bool ConfigManagerUserConfig { get => configManagerUserConfig; set => configManagerUserConfig = value; }
        public string CreationClassName { get => creationClassName; set => creationClassName = value; }
        public ulong DefaultBlockSize { get => defaultBlockSize; set => defaultBlockSize = value; }
        public string Description { get => description; set => description = value; }
        public string DeviceID { get => deviceID; set => deviceID = value; }
        public bool ErrorCleared { get => errorCleared; set => errorCleared = value; }
        public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
        public string ErrorMethodology { get => errorMethodology; set => errorMethodology = value; }
        public string FirmwareRevision { get => firmwareRevision; set => firmwareRevision = value; }
        public uint Index { get => index; set => index = value; }
        public DateTime InstallDate { get => installDate; set => installDate = value; }
        public string InterfaceType { get => interfaceType; set => interfaceType = value; }
        public uint LastErrorCode { get => lastErrorCode; set => lastErrorCode = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public ulong MaxBlockSize { get => maxBlockSize; set => maxBlockSize = value; }
        public ulong MaxMediaSize { get => maxMediaSize; set => maxMediaSize = value; }
        public bool MediaLoaded { get => mediaLoaded; set => mediaLoaded = value; }
        public string MediaType { get => mediaType; set => mediaType = value; }
        public ulong MinBlockSize { get => minBlockSize; set => minBlockSize = value; }
        public string Model { get => model; set => model = value; }
        public string Name { get => name; set => name = value; }
        public bool NeedsCleaning { get => needsCleaning; set => needsCleaning = value; }
        public uint NumberOfMediaSupported { get => numberOfMediaSupported; set => numberOfMediaSupported = value; }
        public uint Partitions { get => partitions; set => partitions = value; }
        public string PNPDeviceID { get => pNPDeviceID; set => pNPDeviceID = value; }
        public ushort[] PowerManagementCapabilities { get => powerManagementCapabilities; set => powerManagementCapabilities = value; }
        public bool PowerManagementSupported { get => powerManagementSupported; set => powerManagementSupported = value; }
        public uint SCSIBus { get => sCSIBus; set => sCSIBus = value; }
        public ushort SCSILogicalUnit { get => sCSILogicalUnit; set => sCSILogicalUnit = value; }
        public ushort SCSIPort { get => sCSIPort; set => sCSIPort = value; }
        public ushort SCSITargetId { get => sCSITargetId; set => sCSITargetId = value; }
        public uint SectorsPerTrack { get => sectorsPerTrack; set => sectorsPerTrack = value; }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public uint Signature { get => signature; set => signature = value; }
        public ulong Size { get => size; set => size = value; }
        public string Status { get => status; set => status = value; }
        public ushort StatusInfo { get => statusInfo; set => statusInfo = value; }
        public string SystemCreationClassName { get => systemCreationClassName; set => systemCreationClassName = value; }
        public string SystemName { get => systemName; set => systemName = value; }
        public ulong TotalCylinders { get => totalCylinders; set => totalCylinders = value; }
        public uint TotalHeads { get => totalHeads; set => totalHeads = value; }
        public ulong TotalSectors { get => totalSectors; set => totalSectors = value; }
        public ulong TotalTracks { get => totalTracks; set => totalTracks = value; }
        public uint TracksPerCylinder { get => tracksPerCylinder; set => tracksPerCylinder = value; }
    }
}
