using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1D5058861DCEEC9, NameHash = 0x466CC80B)]
    public class GcStatusMessageDefinitions : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public Colour MissionMarkupColour;
        [NMS(Index = 3, Size = 0x15, EnumType = typeof(GcPetChatType.PetChatTypeEnum))]
        /* 0x010 */ public GcPetVocabularyEntry[] PetChatTemplates;
        [NMS(Index = 2, Size = 0xF, EnumType = typeof(GcPetVocabularyWords.PetVocabularyWordEnum))]
        /* 0x4A8 */ public GcPetVocabularyEntry[] PetVocabulary;
        [NMS(Index = 4, Size = 0x5, EnumType = typeof(GcFriendlyDroneChatType.FriendlyDroneChatTypeEnum))]
        /* 0x7F0 */ public GcFriendlyDroneVocabularyEntry[] FriendlyDroneChatTemplates;
        [NMS(Index = 0)]
        /* 0x890 */ public List<GcStatusMessageDefinition> Messages;
    }
}
