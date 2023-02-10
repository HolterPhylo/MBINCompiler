namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE4FCE7BE8C20CFF5, NameHash = 0x4CC02B5A253167FD)]
    public class TkAnimationGameData : NMSTemplate
    {
        /* 0x0 */ public bool RootMotionEnabled;
        /* 0x1 */ public bool BlockPlayerMovement;
        // size: 0x3
        public enum BlockPlayerWeaponEnum {
            Unblocked,
            Sheathed,
            OutButCannotFire,
        }
        /* 0x4 */ public BlockPlayerWeaponEnum BlockPlayerWeapon;
    }
}
