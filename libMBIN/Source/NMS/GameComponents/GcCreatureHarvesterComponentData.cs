using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21EAB7A792EEF76A, NameHash = 0x5B935AA89717BCC4)]
    public class GcCreatureHarvesterComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x420 */ public int NumSlots;
    }
}
