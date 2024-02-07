using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E6911CBD4B3E06C, NameHash = 0xFA6C3AD3E80DE203)]
    public class GcCustomisationUIData : NMSTemplate
    {
        [NMS(Size = 0x18, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x0 */ public GcCustomisationUI[] CustomisationUIData;
    }
}
