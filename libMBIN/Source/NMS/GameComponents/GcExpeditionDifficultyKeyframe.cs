namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCDA43052420EA671, NameHash = 0xEC5C654507FD5E75)]
    public class GcExpeditionDifficultyKeyframe : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Difficulty;
        [NMS(Index = 0)]
        /* 0x4 */ public int EventNumber;
    }
}
