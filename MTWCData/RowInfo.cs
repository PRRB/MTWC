using System.Collections.Generic;
using System.Linq;

namespace MTWC
{
    public class RowInfo
    {
        public bool _compare { get; set; }
        public int RowNum { get; set; }
        public string UnitId { get; set; }
        public string UnitType { get; set; }
        public int? ProductionCost { get; set; }
        public int? SupportCost { get; set; }
        public int? ProductionTime { get; set; }
        public int? HonourHandicap { get; set; }
        public int? UnitBaseStrength { get; set; }
        public int? UnitSize { get; set; }
        public int? HonourStepValue { get; set; }
        public string GeneralCandidate { get; set; }
        public string RebellingTroopMixes { get; set; }
        public string RulerIDTroopAdvantage { get; set; }
        public string RegionIDtroopAdvantage { get; set; }
        public string DojoAdvantageModifier { get; set; }
        public string UnitchoicesAI { get; set; }
        public string UnitSpecialityExtraBuildinginfluences { get; set; }
        public string BuildingsNeeded { get; set; }
        public string UnitClass { get; set; }
        public int? MoralBonus { get; set; }
        public string AplicablePeriods { get; set; }
        public string IsBaseUnitSizeScaleable { get; set; }

        private string _generalStats;
        private Dictionary<string, string> _stats;
        private void SetGeneralStats(string stats)
        {
            _generalStats = stats;
            if (stats?.Length > 0)
            {
                _stats = stats.Split(',').ToDictionary(
                    k => k.Split('(')[0].Trim(),
                    v => v.Split('(')[1].Split(')')[0].Trim());
            }
        }
        public string GeneralStats
        {
            get => _generalStats;
            set { SetGeneralStats(value); }
        }
        public string IsStealth { get; set; }
        public string UnitSpecialities { get; set; }
        public string TooltipLabels { get; set; }
        public string Mounttype { get; set; }
        public string ModelType { get; set; }
        public string FactionLeaderDetails { get; set; }
        public string FactionAssociation { get; set; }
        public string Region { get; set; }
        public string UnitFormationSuitability { get; set; }
        public string UnitTaskSuitability { get; set; }
        public string CulturesBelongingTo { get; set; }
        public string ShipStats { get; set; }
        public int? MeleeSupportingRanks { get; set; }
        public string Impetuousness { get; set; }
        public string FormationSpacing { get; set; }
        public string ShieldType { get; set; }
        public string MeleesWithShield { get; set; }
        public string ShieldModifier { get; set; }
        public string IsArmourPiercing { get; set; }
        public int? CavAttackBonus { get; set; }
        public int? CavDefenceBonus { get; set; }
        public string FearedUnits { get; set; }
        public string ZealImpact { get; set; }
        public string FaithImpact { get; set; }
        public string DismountInfo { get; set; }
        public string DismountsInBattle { get; set; }
        public string Weapontype { get; set; }
        public string MercenaryUnit { get; set; }
        public string Periodassociationfornoncampaigngames { get; set; }
        public string Factionassociationfornoncampaigngames { get; set; }
        public string Unknown { get; set; }


        //HEIGHT( 110 ),
        //RADIUS( 45 ),
        //SCALE( 125 ), 
        //PROJECTILE_TYPE( NONE ),
        //SAMURAI( NO ),
        //MARCH_SPEED( 9 ),
        //RUN_SPEED( 24 ),
        //CHARGE_SPEED( 26 ),
        //MIN_TURNSPEED( 2 ),
        //MAX_TURNSPEED( 8 ),
        //TURN_TO_MOTION_SPEED( 8 ),
        //MAX_INMOTION_TURN( 96 ),
        //FORMATION_WIDTH_SPACING( 115 ),
        //FORMATION_LENGTH_SPACING( 125 ),
        //ENGAGEMENT_THRESHOLD( 5000 ),
        //CHARGE_BONUS( 6 ),
        //MELEE_BONUS( 3 ),
        //DEFENCE_BONUS( 2 ),
        //ARMOUR_LEVEL( 2 ),
        //HONOUR_LEVEL( 5 ),
        //AMMO( 0 ),
        //FORMATIONS_PREFERRED_NUM_ROWS( 3 )
        public int? HEIGHT => _stats?[nameof(HEIGHT)].ToInt();
        public int? RADIUS => _stats?[nameof(RADIUS)].ToInt();
        public int? SCALE => _stats?[nameof(SCALE)].ToInt();
        public string PROJECTILE_TYPE => _stats?[nameof(PROJECTILE_TYPE)];
        public string SAMURAI => _stats?[nameof(SAMURAI)];
        public int? MARCH_SPEED => _stats?[nameof(MARCH_SPEED)].ToInt();
        public int? RUN_SPEED => _stats?[nameof(RUN_SPEED)].ToInt();
        public int? CHARGE_SPEED => _stats?[nameof(CHARGE_SPEED)].ToInt();
        public int? MIN_TURNSPEED => _stats?[nameof(MIN_TURNSPEED)].ToInt();
        public int? MAX_TURNSPEED => _stats?[nameof(MAX_TURNSPEED)].ToInt();
        public int? TURN_TO_MOTION_SPEED => _stats?[nameof(TURN_TO_MOTION_SPEED)].ToInt();
        public int? MAX_INMOTION_TURN => _stats?[nameof(MAX_INMOTION_TURN)].ToInt();
        public int? FORMATION_WIDTH_SPACING => _stats?[nameof(FORMATION_WIDTH_SPACING)].ToInt();
        public int? FORMATION_LENGTH_SPACING => _stats?[nameof(FORMATION_LENGTH_SPACING)].ToInt();
        public int? ENGAGEMENT_THRESHOLD => _stats?[nameof(ENGAGEMENT_THRESHOLD)].ToInt();
        public int? CHARGE_BONUS => _stats?[nameof(CHARGE_BONUS)].ToInt();
        public int? MELEE_BONUS => _stats?[nameof(MELEE_BONUS)].ToInt();
        public int? DEFENCE_BONUS => _stats?[nameof(DEFENCE_BONUS)].ToInt();
        public int? ARMOUR_LEVEL => _stats?[nameof(ARMOUR_LEVEL)].ToInt();
        public int? HONOUR_LEVEL => _stats?[nameof(HONOUR_LEVEL)].ToInt();
        public int? AMMO => _stats?[nameof(AMMO)].ToInt();
        public int? FORMATIONS_PREFERRED_NUM_ROWS => _stats?[nameof(FORMATIONS_PREFERRED_NUM_ROWS)].ToInt();
    }
}
