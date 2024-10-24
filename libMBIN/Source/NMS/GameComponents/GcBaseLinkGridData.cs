using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7194A0DE523A00FC, NameHash = 0x24BB8E8C)]
    public class GcBaseLinkGridData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcBaseLinkGridConnectionData Connection;
        [NMS(Index = 5)]
        /* 0x38 */ public List<GcBaseLinkGridConnectionDependency> DependentConnections;
        // size: 0x3
        public enum DependsOnEnvironmentEnum : uint {
            None,
            DayNight,
            Storms,
        }
        [NMS(Index = 3)]
        /* 0x48 */ public DependsOnEnvironmentEnum DependsOnEnvironment;
        // size: 0x4
        public enum DependsOnHotspotsEnum : uint {
            None,
            Power,
            Mineral,
            Gas,
        }
        [NMS(Index = 4)]
        /* 0x4C */ public DependsOnHotspotsEnum DependsOnHotspots;
        [NMS(Index = 1)]
        /* 0x50 */ public int Rate;
        [NMS(Index = 2)]
        /* 0x54 */ public int Storage;
    }
}
