using System;
using System.Management;
using System.Collections;

namespace Hard_Drive_Info
{
    public class LogicalDiskInfo : DriveInformation
    {
        public LogicalDiskInfo()
        {
            Refresh();
        }

        public override void Refresh()
        {
            drives = new ArrayList();
            messages = new ArrayList();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");

            foreach (ManagementObject wmi_LogicalDisk in searcher.Get())
            {
                LogicalDisk logicalDisk = new LogicalDisk();

                logicalDisk.Access = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_LogicalDisk, "Access", messages));
                logicalDisk.Availability = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_LogicalDisk, "Availability", messages));
                logicalDisk.BlockSize = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_LogicalDisk, "BlockSize", messages));
                logicalDisk.Caption = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "Caption", messages));
                logicalDisk.Compressed = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_LogicalDisk, "Compressed", messages));
                logicalDisk.ConfigManagerErrorCode = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_LogicalDisk, "ConfigManagerErrorCode", messages));
                logicalDisk.ConfigManagerUserConfig = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_LogicalDisk, "ConfigManagerUserConfig", messages));
                logicalDisk.CreationClassName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "CreationClassName", messages));
                logicalDisk.Description = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "Description", messages));
                logicalDisk.DeviceID = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "DeviceID", messages));
                logicalDisk.DriveType = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_LogicalDisk, "DriveType", messages));
                logicalDisk.ErrorCleared = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_LogicalDisk, "ErrorCleared", messages));
                logicalDisk.ErrorDescription = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "ErrorDescription", messages));
                logicalDisk.ErrorMethodology = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "ErrorMethodology", messages));
                logicalDisk.FileSystem = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "FileSystem", messages));
                logicalDisk.FreeSpace = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_LogicalDisk, "FreeSpace", messages));
                logicalDisk.InstallDate = Helper.GetVal<DateTime>(Helper.GetManagementProperty(wmi_LogicalDisk, "InstallDate", messages));
                logicalDisk.LastErrorCode = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_LogicalDisk, "LastErrorCode", messages));
                logicalDisk.MaximumComponentLength = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_LogicalDisk, "MaximumComponentLength", messages));
                logicalDisk.MediaType = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_LogicalDisk, "MediaType", messages));
                logicalDisk.Name = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "Name", messages));
                logicalDisk.NumberOfBlocks = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_LogicalDisk, "NumberOfBlocks", messages));
                logicalDisk.PNPDeviceID = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "PNPDeviceID", messages));
                logicalDisk.PowerManagementCapabilities = Helper.GetVal<ushort[]>(Helper.GetManagementProperty(wmi_LogicalDisk, "PowerManagementCapabilities", messages));
                logicalDisk.PowerManagementSupported = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_LogicalDisk, "PowerManagementSupported", messages));
                logicalDisk.ProviderName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "ProviderName", messages));
                logicalDisk.Purpose = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "Purpose", messages));
                logicalDisk.QuotasDisabled = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_LogicalDisk, "QuotasDisabled", messages));
                logicalDisk.QuotasIncomplete = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_LogicalDisk, "QuotasIncomplete", messages));
                logicalDisk.QuotasRebuilding = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_LogicalDisk, "QuotasRebuilding", messages));
                logicalDisk.Size = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "Size", messages));
                logicalDisk.Status = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "Status", messages));
                logicalDisk.StatusInfo = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_LogicalDisk, "StatusInfo", messages));
                logicalDisk.SupportsDiskQuotas = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_LogicalDisk, "SupportsDiskQuotas", messages));
                logicalDisk.SupportsFileBasedCompression = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_LogicalDisk, "SupportsFileBasedCompression", messages));
                logicalDisk.SystemCreationClassName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "SystemCreationClassName", messages));
                logicalDisk.SystemName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "SystemName", messages));
                logicalDisk.VolumeDirty = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_LogicalDisk, "VolumeDirty", messages));
                logicalDisk.VolumeName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "VolumeName", messages));
                logicalDisk.VolumeSerialNumber = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_LogicalDisk, "VolumeSerialNumber", messages));

                drives.Add(logicalDisk);
            }
        }
    }
}
