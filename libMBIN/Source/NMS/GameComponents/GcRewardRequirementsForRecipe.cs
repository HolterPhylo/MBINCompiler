namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1391593741FB8C93, NameHash = 0xF9DF8359)]
    public class GcRewardRequirementsForRecipe : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 RecipeID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool RewardInCreative;
    }
}
