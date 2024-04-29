using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x312BCF5EE606BCA, NameHash = 0xAE95337199B47CD)]
    public class GcBaseBuildingPartNavNodeData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Vector3f AtDir;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector3f LocalPos;
        [NMS(Index = 5)]
        /* 0x20 */ public List<uint> ConnectedNodeIndices;
        [NMS(Index = 4)]
        /* 0x30 */ public NMSString0x10 InteractionID;
        [NMS(Index = 2)]
        /* 0x40 */ public float ArriveDist;
        [NMS(Index = 0)]
        /* 0x44 */ public GcNPCNavSubgraphNodeType Type;
    }
}
