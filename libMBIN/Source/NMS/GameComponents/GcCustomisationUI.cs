using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F390896A155387D, NameHash = 0x6418F2DE)]
    public class GcCustomisationUI : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcCustomisationGroups Common;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcCustomisationRace> Races;
        [NMS(Index = 0)]
        /* 0x20 */ public GcCustomisationCameraData RacesCameraData;
    }
}
