using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x71813D42DFD08760, NameHash = 0x89317714328CB341)]
    public class TkInteractiveSceneData : NMSTemplate
    {
        /* 0x00 */ public List<TkInteractiveControlData> Controls;
        /* 0x10 */ public NMSString0x20 Id;
    }
}
