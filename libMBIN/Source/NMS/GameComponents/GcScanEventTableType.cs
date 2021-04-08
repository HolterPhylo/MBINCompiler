using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x0000000000000000, NameHash = 0x34D109FC6FD5709)]
    public class GcScanEventTableType : NMSTemplate
    {
        // 0x8 entries
        public enum ScanTableEnum { Space, Planet, Missions, Tutorial, MissionsCreative, Vehicle, NPCPlanetSite, Seasonal }
        public ScanTableEnum ScanTable;
    }
}