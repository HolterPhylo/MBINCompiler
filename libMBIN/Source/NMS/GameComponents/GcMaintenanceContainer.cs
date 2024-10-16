using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B637A68ADB2B417, NameHash = 0x7FD5CA13)]
    public class GcMaintenanceContainer : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcInventoryContainer InventoryContainer;
        [NMS(Index = 5)]
        /* 0x158 */ public List<float> AmountAccumulators;
        [NMS(Index = 4)]
        /* 0x168 */ public List<float> DamageTimers;
        [NMS(Index = 3)]
        /* 0x178 */ public ulong LastBrokenTimestamp;
        [NMS(Index = 2)]
        /* 0x180 */ public ulong LastCompletedTimestamp;
        [NMS(Index = 1)]
        /* 0x188 */ public ulong LastUpdateTimestamp;
        [NMS(Index = 6)]
        /* 0x190 */ public ushort Flags;
    }
}
