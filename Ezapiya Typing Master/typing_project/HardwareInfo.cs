using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using typing_project;

public static class HardwareInfo
{
    /// <summary>
    /// Retrieving Processor Id.
    /// </summary>
    /// <returns></returns>
    /// 
    
    /// <summary>
    /// Retrieving HDD Serial No.
    /// </summary>
    /// <returns></returns>
    public static String GetHDDSerialNo()
    {
        ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
        ManagementObjectCollection mcol = mangnmt.GetInstances();
        string result = "";
        foreach (ManagementObject strt in mcol)
        {
            result += Convert.ToString(strt["VolumeSerialNumber"]);
        }
        return result;
    }
    /// <summary>
    /// Retrieving System MAC Address.
    /// </summary>
    /// <returns></returns>
    

}
