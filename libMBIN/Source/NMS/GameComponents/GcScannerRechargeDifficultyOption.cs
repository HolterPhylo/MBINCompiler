namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C77C6A1D7CCA517, NameHash = 0xE3D84E86)]
    public class GcScannerRechargeDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum ScannerRechargeDifficultyEnum : uint {
            VeryFast,
            Fast,
            Normal,
            Slow,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ScannerRechargeDifficultyEnum ScannerRechargeDifficulty;
    }
}
