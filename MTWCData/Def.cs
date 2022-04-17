namespace MTWC
{
    public static class Def
    {
        public static string RowSelect = "^spearmen|viking|housecarle";

        public static readonly ColType[] ColSelect = new ColType[] {
            ColType.UnitId, ColType.SupportCost, ColType.ProductionCost,
            ColType.UnitSize,

            ColType.Region, ColType.RegionIDtroopAdvantage,
            ColType.RulerIDTroopAdvantage,
            ColType.FactionAssociation, ColType.BuildingsNeeded,

            ColType.MeleeSupportingRanks,
            ColType.CavAttackBonus,
            ColType.CavDefenceBonus,

            ColType.MoralBonus,
            ColType.IsArmourPiercing,
            ColType.ShieldType,
            ColType.ShieldModifier,

            ColType.RUN_SPEED, ColType.CHARGE_BONUS,
            ColType.MELEE_BONUS, ColType.DEFENCE_BONUS, ColType.ARMOUR_LEVEL
        };
    }
}