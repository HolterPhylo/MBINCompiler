using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4BF2CF62DD956057, NameHash = 0x64E359A8)]
    public class GcRefinerRecipe : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A RecipeName;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x20A RecipeType;
        [NMS(Index = 5)]
        /* 0x60 */ public GcRefinerRecipeElement Result;
        [NMS(Index = 6)]
        /* 0x78 */ public List<GcRefinerRecipeElement> Ingredients;
        [NMS(Index = 3)]
        /* 0x88 */ public float TimeToMake;
        [NMS(Index = 4)]
        /* 0x8C */ public bool Cooking;
    }
}
