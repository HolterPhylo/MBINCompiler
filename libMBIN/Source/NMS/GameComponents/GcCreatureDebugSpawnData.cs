using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54889205D375EB2F, NameHash = 0x382C99C3)]
    public class GcCreatureDebugSpawnData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcCreatureDebugWaypoint> Waypoints;
        [NMS(Index = 0)]
        /* 0x10 */ public int CreatureIndex;
        [NMS(Index = 5)]
        /* 0x14 */ public int CurrentWaypoint;
        [NMS(Index = 1)]
        /* 0x18 */ public float InitialDelay;
        // size: 0x3
        public enum OnCompleteEnum : uint {
            Hold,
            Loop,
            Destroy,
        }
        [NMS(Index = 3)]
        /* 0x1C */ public OnCompleteEnum OnComplete;
        [NMS(Index = 4)]
        /* 0x20 */ public float SmoothTime;
        [NMS(Index = 8)]
        /* 0x24 */ public float SmoothTimer;
        [NMS(Index = 7)]
        /* 0x28 */ public float Timer;
        [NMS(Index = 6)]
        /* 0x2C */ public bool ArrivedAtCurrentWaypoint;
    }
}
