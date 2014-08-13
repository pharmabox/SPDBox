using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace USBCon
{
    public class COMPortInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public COMPortInfo() { }

        public static List<COMPortInfo> GetCOMPortsInfo()
        {
            List<COMPortInfo> comPortInfoList = new List<COMPortInfo>();

            ConnectionOptions options = ProcessConnection.ProcessConnectionOptions();
            ManagementScope connectionScope = ProcessConnection.ConnectionScope(Environment.MachineName, options, @"\root\CIMV2");

            ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_PnPEntity WHERE ConfigManagerErrorCode = 0");
            ManagementObjectSearcher comPortSearcher = new ManagementObjectSearcher(connectionScope, objectQuery);

            using (comPortSearcher)
            {
                string caption = null;
                foreach (ManagementObject obj in comPortSearcher.Get())
                {
                    if (obj != null)
                    {
                        object captionObj = obj["Caption"];
                        if (captionObj != null)
                        {
                            caption = captionObj.ToString();

                            COMPortInfo comPortInfo = new COMPortInfo();

                            if (caption.Contains("(COM"))
                            {

                                comPortInfo.Name = "******" + caption.Substring(caption.LastIndexOf("(COM")).Replace("(", string.Empty).Replace(")",
                                                                     string.Empty) + "******";
                            }
                            else
                            {
                                comPortInfo.Name = captionObj.ToString();
                            }

                            comPortInfo.Description = caption;
                            comPortInfoList.Add(comPortInfo);
                        }
                    }
                }
            }
            return comPortInfoList;
        }
    }
}