using System;
using System.Management;
using System.Collections;

namespace Hard_Drive_Info
{
    static class Helper
    {
        public static T GetVal<T>(object val)
        {
            if (val == null) {
                if (typeof(T) == typeof(string))
                {
                    return (T)Convert.ChangeType("", typeof(T));
                }
                else if (typeof(T) == typeof(UInt16) || typeof(T) == typeof(UInt32) || typeof(T) == typeof(UInt64) ||
                    typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
                {
                    return (T)Convert.ChangeType(0, typeof(T));
                }
                else if (typeof(T) == typeof(bool))
                {
                    return (T)Convert.ChangeType(false, typeof(T));
                }
                else if (typeof(T) == typeof(DateTime))
                {
                    return (T)Convert.ChangeType(new DateTime(), typeof(T));
                }
                else
                {
                    return (T)Convert.ChangeType(null, typeof(T));
                }
            }
            else
            {
                return (T)Convert.ChangeType(val, typeof(T));
            }
        }

        public static object GetManagementProperty(ManagementObject ManagementRow, string PropertyName, ArrayList errors)
        {
            object retVal = null;

            try
            {
                retVal = ManagementRow[PropertyName];
            }
            catch (Exception e)
            {
                string errMsg = "ERROR: GetManagementProperty(obj, \"" + PropertyName + "\") " + e.Message;
                errors.Add(errMsg);
                Console.WriteLine(errMsg);
            }

            return retVal;
        }
    }
}
