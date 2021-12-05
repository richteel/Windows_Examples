using System;
using System.Management;
using System.Collections;

namespace Hard_Drive_Info
{
    public class PartitionInfo : DriveInformation
    {
        public PartitionInfo()
        {
            Refresh();
        }

        public override void Refresh()
        {
            drives = new ArrayList();
            messages = new ArrayList();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskPartition");

            foreach (ManagementObject wmi_Partition in searcher.Get())
            {
                Partition partition = new Partition();

                partition.AdditionalAvailability = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_Partition, "AdditionalAvailability", messages));
                partition.Availability = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_Partition, "Availability", messages));
                partition.PowerManagementCapabilities = Helper.GetVal<ushort[]>(Helper.GetManagementProperty(wmi_Partition, "PowerManagementCapabilities", messages));
                partition.IdentifyingDescriptions = Helper.GetVal<string[]>(Helper.GetManagementProperty(wmi_Partition, "IdentifyingDescriptions", messages));
                partition.MaxQuiesceTime = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_Partition, "MaxQuiesceTime", messages));
                partition.OtherIdentifyingInfo = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_Partition, "OtherIdentifyingInfo", messages));
                partition.StatusInfo = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_Partition, "StatusInfo", messages));
                partition.PowerOnHours = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_Partition, "PowerOnHours", messages));
                partition.TotalPowerOnHours = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_Partition, "TotalPowerOnHours", messages));
                partition.Access = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_Partition, "Access", messages));
                partition.BlockSize = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_Partition, "BlockSize", messages));
                partition.Bootable = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Partition, "Bootable", messages));
                partition.BootPartition = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Partition, "BootPartition", messages));
                partition.Caption = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "Caption", messages));
                partition.ConfigManagerErrorCode = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_Partition, "ConfigManagerErrorCode", messages));
                partition.ConfigManagerUserConfig = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Partition, "ConfigManagerUserConfig", messages));
                partition.CreationClassName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "CreationClassName", messages));
                partition.Description = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "Description", messages));
                partition.DeviceID = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "DeviceID", messages));
                partition.DiskIndex = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_Partition, "DiskIndex", messages));
                partition.ErrorCleared = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Partition, "ErrorCleared", messages));
                partition.ErrorDescription = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "ErrorDescription", messages));
                partition.ErrorMethodology = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "ErrorMethodology", messages));
                partition.HiddenSectors = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_Partition, "HiddenSectors", messages));
                partition.Index = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_Partition, "Index", messages));
                partition.InstallDate = Helper.GetVal<DateTime>(Helper.GetManagementProperty(wmi_Partition, "InstallDate", messages));
                partition.LastErrorCode = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_Partition, "LastErrorCode", messages));
                partition.Name = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "Name", messages));
                partition.NumberOfBlocks = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_Partition, "NumberOfBlocks", messages));
                partition.PNPDeviceID = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "PNPDeviceID", messages));
                partition.PowerManagementSupported = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Partition, "PowerManagementSupported", messages));
                partition.PrimaryPartition = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Partition, "PrimaryPartition", messages));
                partition.Purpose = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "Purpose", messages));
                partition.RewritePartition = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_Partition, "RewritePartition", messages));
                partition.Size = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_Partition, "Size", messages));
                partition.StartingOffset = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_Partition, "StartingOffset", messages));
                partition.Status = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "Status", messages));
                partition.SystemCreationClassName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "SystemCreationClassName", messages));
                partition.SystemName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "SystemName", messages));
                partition.Type = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_Partition, "Type", messages));


                drives.Add(partition);
            }
        }
    }
}
