namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x72924EE5C621D51A, NameHash = 0x13819499)]
    public class GcSolarSystemTraderSpawnData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector2f SequenceTakeoffDelay;
        [NMS(Index = 3)]
        /* 0x08 */ public int ChanceToDelayLaunch;
        [NMS(Index = 1)]
        /* 0x0C */ public float InitialTakeoffDelay;
        [NMS(Index = 0)]
        /* 0x10 */ public int MaxToSpawn;
    }
}
