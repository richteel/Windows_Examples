using System;
using System.Management;
using System.Collections;

namespace Hard_Drive_Info
{
    public class HardDriveInfo : DriveInformation
    {
        public HardDriveInfo()
        {
            Refresh();
        }

        public override void Refresh()
        {
            drives = new ArrayList();
            messages = new ArrayList();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HardDrive in searcher.Get())
            {
                HardDrive hardDrive = new HardDrive();

                hardDrive.Availability = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_HardDrive, "Availability", messages));
                hardDrive.BytesPerSector = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_HardDrive, "BytesPerSector", messages));
                hardDrive.Capabilities = Helper.GetVal<ushort[]>(Helper.GetManagementProperty(wmi_HardDrive, "Capabilities", messages));
                hardDrive.CapabilityDescriptions = Helper.GetVal<string[]>(Helper.GetManagementProperty(wmi_HardDrive, "CapabilityDescriptions", messages));
                hardDrive.Caption = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "Caption", messages));
                hardDrive.CompressionMethod = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "CompressionMethod", messages));
                hardDrive.ConfigManagerErrorCode = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_HardDrive, "ConfigManagerErrorCode", messages));
                hardDrive.ConfigManagerUserConfig = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_HardDrive, "ConfigManagerUserConfig", messages));
                hardDrive.CreationClassName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "CreationClassName", messages));
                hardDrive.DefaultBlockSize = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_HardDrive, "DefaultBlockSize", messages));
                hardDrive.Description = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "Description", messages));
                hardDrive.DeviceID = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "DeviceID", messages));
                hardDrive.ErrorCleared = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_HardDrive, "ErrorCleared", messages));
                hardDrive.ErrorDescription = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "ErrorDescription", messages));
                hardDrive.ErrorMethodology = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "ErrorMethodology", messages));
                hardDrive.FirmwareRevision = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "FirmwareRevision", messages));
                hardDrive.Index = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_HardDrive, "Index", messages));
                hardDrive.InstallDate = Helper.GetVal<DateTime>(Helper.GetManagementProperty(wmi_HardDrive, "InstallDate", messages));
                hardDrive.InterfaceType = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "InterfaceType", messages));
                hardDrive.LastErrorCode = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_HardDrive, "LastErrorCode", messages));
                hardDrive.Manufacturer = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "Manufacturer", messages));
                hardDrive.MaxBlockSize = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_HardDrive, "MaxBlockSize", messages));
                hardDrive.MaxMediaSize = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_HardDrive, "MaxMediaSize", messages));
                hardDrive.MediaLoaded = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_HardDrive, "MediaLoaded", messages));
                hardDrive.MediaType = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "MediaType", messages));
                hardDrive.MinBlockSize = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_HardDrive, "MinBlockSize", messages));
                hardDrive.Model = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "Model", messages));
                hardDrive.Name = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "Name", messages));
                hardDrive.NeedsCleaning = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_HardDrive, "NeedsCleaning", messages));
                hardDrive.NumberOfMediaSupported = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_HardDrive, "NumberOfMediaSupported", messages));
                hardDrive.Partitions = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_HardDrive, "Partitions", messages));
                hardDrive.PNPDeviceID = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "PNPDeviceID", messages));
                hardDrive.PowerManagementCapabilities = Helper.GetVal<ushort[]>(Helper.GetManagementProperty(wmi_HardDrive, "PowerManagementCapabilities", messages));
                hardDrive.PowerManagementSupported = Helper.GetVal<bool>(Helper.GetManagementProperty(wmi_HardDrive, "PowerManagementSupported", messages));
                hardDrive.SCSIBus = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_HardDrive, "SCSIBus", messages));
                hardDrive.SCSILogicalUnit = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_HardDrive, "SCSILogicalUnit", messages));
                hardDrive.SCSIPort = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_HardDrive, "SCSIPort", messages));
                hardDrive.SCSITargetId = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_HardDrive, "SCSITargetId", messages));
                hardDrive.SectorsPerTrack = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_HardDrive, "SectorsPerTrack", messages));
                hardDrive.SerialNumber = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "SerialNumber", messages));
                hardDrive.Signature = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_HardDrive, "Signature", messages));
                hardDrive.Size = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_HardDrive, "Size", messages));
                hardDrive.Status = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "Status", messages));
                hardDrive.StatusInfo = Helper.GetVal<ushort>(Helper.GetManagementProperty(wmi_HardDrive, "StatusInfo", messages));
                hardDrive.SystemCreationClassName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "SystemCreationClassName", messages));
                hardDrive.SystemName = Helper.GetVal<string>(Helper.GetManagementProperty(wmi_HardDrive, "SystemName", messages));
                hardDrive.TotalCylinders = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_HardDrive, "TotalCylinders", messages));
                hardDrive.TotalHeads = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_HardDrive, "TotalHeads", messages));
                hardDrive.TotalSectors = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_HardDrive, "TotalSectors", messages));
                hardDrive.TotalTracks = Helper.GetVal<ulong>(Helper.GetManagementProperty(wmi_HardDrive, "TotalTracks", messages));
                hardDrive.TracksPerCylinder = Helper.GetVal<uint>(Helper.GetManagementProperty(wmi_HardDrive, "TracksPerCylinder", messages));

                drives.Add(hardDrive);
            }
        }
    }
}
