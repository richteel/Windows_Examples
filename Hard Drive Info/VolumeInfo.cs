using System;
using System.Management;
using System.Collections;

namespace Hard_Drive_Info
{
    public class VolumeInfo : DriveInformation
    {
        public VolumeInfo()
        {
            Refresh();
        }

        public override void Refresh()
        {
            drives = new ArrayList();
            messages = new ArrayList();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Volume");

            foreach (ManagementObject wmi_Volume in searcher.Get())
            {
                Volume volume = new Volume();

                volume.Access = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_Volume, "Access", messages));
                volume.Automount = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Volume, "Automount", messages));
                volume.Availability = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_Volume, "Availability", messages));
                volume.BlockSize = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_Volume, "BlockSize", messages));
                volume.Capacity = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_Volume, "Capacity", messages));
                volume.Caption = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "Caption", messages));
                volume.Compressed = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Volume, "Compressed", messages));
                volume.ConfigManagerErrorCode = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_Volume, "ConfigManagerErrorCode", messages));
                volume.ConfigManagerUserConfig = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Volume, "ConfigManagerUserConfig", messages));
                volume.CreationClassName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "CreationClassName", messages));
                volume.Description = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "Description", messages));
                volume.DeviceID = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "DeviceID", messages));
                volume.DirtyBitSet = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Volume, "DirtyBitSet", messages));
                volume.DriveLetter = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "DriveLetter", messages));
                volume.DriveType = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_Volume, "DriveType", messages));
                volume.ErrorCleared = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Volume, "ErrorCleared", messages));
                volume.ErrorDescription = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "ErrorDescription", messages));
                volume.ErrorMethodology = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "ErrorMethodology", messages));
                volume.FileSystem = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "FileSystem", messages));
                volume.FreeSpace = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_Volume, "FreeSpace", messages));
                volume.IndexingEnabled = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Volume, "IndexingEnabled", messages));
                volume.InstallDate = Helper.GetVal<DateTime>(Helper.GetManagementProperty(wmi_Volume, "InstallDate", messages));
                volume.Label = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "Label", messages));
                volume.LastErrorCode = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_Volume, "LastErrorCode", messages));
                volume.MaximumFileNameLength = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_Volume, "MaximumFileNameLength", messages));
                volume.Name = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "Name", messages));
                volume.NumberOfBlocks = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_Volume, "NumberOfBlocks", messages));
                volume.PNPDeviceID = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "PNPDeviceID", messages));
                volume.PowerManagementCapabilities = Helper.GetVal<ushort[]>(Helper.GetManagementProperty(wmi_Volume, "PowerManagementCapabilities", messages));
                volume.PowerManagementSupported = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Volume, "PowerManagementSupported", messages));
                volume.Purpose = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "Purpose", messages));
                volume.QuotasEnabled = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Volume, "QuotasEnabled", messages));
                volume.QuotasIncomplete = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Volume, "QuotasIncomplete", messages));
                volume.QuotasRebuilding = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Volume, "QuotasRebuilding", messages));
                volume.Status = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "Status", messages));
                volume.StatusInfo = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_Volume, "StatusInfo", messages));
                volume.SystemCreationClassName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "SystemCreationClassName", messages));
                volume.SystemName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Volume, "SystemName", messages));
                volume.SerialNumber = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_Volume, "SerialNumber", messages));
                volume.SupportsDiskQuotas = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Volume, "SupportsDiskQuotas", messages));
                volume.SupportsFileBasedCompression = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Volume, "SupportsFileBasedCompression", messages));

                drives.Add(volume);
            }
        }
    }
}
