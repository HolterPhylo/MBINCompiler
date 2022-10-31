namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB88D6ACFA377B28F, NameHash = 0x42FEEB238F6504DE)]
    public class GcDifficultySettingEnum : NMSTemplate
    {
        // size: 0x1C
        public enum DifficultySettingEnum {
            SettingsLocked,
            InventoriesAlwaysInRange,
            AllSlotsUnlocked,
            WarpDriveRequirements,
            CraftingIsFree,
            TutorialEnabled,
            StartWithAllItemsKnown,
            BaseAutoPower,
            DeathConsequences,
            DamageReceived,
            DamageGiven,
            ActiveSurvivalBars,
            HazardDrain,
            EnergyDrain,
            SubstanceCollection,
            InventoryStackLimits,
            ChargingRequirements,
            FuelUse,
            LaunchFuelCost,
            CurrencyCost,
            ScannerRecharge,
            ReputationGain,
            CreatureHostility,
            SpaceCombat,
            GroundCombat,
            ItemShopAvailablity,
            SprintingCost,
            BreakTechOnDamage
        }
        /* 0x0 */ public DifficultySettingEnum DifficultySetting;
    }
}