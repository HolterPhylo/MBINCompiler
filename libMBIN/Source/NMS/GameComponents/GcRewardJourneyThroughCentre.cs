namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6CE7618FE079C1D, NameHash = 0x40464A60)]
    public class GcRewardJourneyThroughCentre : NMSTemplate
    {
        // size: 0x5
        public enum CentreJourneyDestinationEnum : uint {
            Next,
            Abandoned,
            Vicious,
            Lush,
            Balanced,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CentreJourneyDestinationEnum CentreJourneyDestination;
    }
}
