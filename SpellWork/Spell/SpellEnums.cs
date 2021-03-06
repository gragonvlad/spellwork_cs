using System;

namespace SpellWork
{
    public enum LocalesDBC
    {
        enUS,
        koKR,
        frFR,
        deDE,
        zhCN,
        zhTW,
        esES,
        esMX,
        ruRU
    };

    /// <summary>
    ///
    /// </summary>
    public enum SpellFamilyNames
    {
        SPELLFAMILY_GENERIC     = 0,
        SPELLFAMILY_UNK1        = 1, // events, holidays
        // unused               = 2,
        SPELLFAMILY_MAGE        = 3,
        SPELLFAMILY_WARRIOR     = 4,
        SPELLFAMILY_WARLOCK     = 5,
        SPELLFAMILY_PRIEST      = 6,
        SPELLFAMILY_DRUID       = 7,
        SPELLFAMILY_ROGUE       = 8,
        SPELLFAMILY_HUNTER      = 9,
        SPELLFAMILY_PALADIN     = 10,
        SPELLFAMILY_SHAMAN      = 11,
        SPELLFAMILY_UNK2        = 12, // 2 spells (silence resistance)
        SPELLFAMILY_POTION      = 13,
        // unused               = 14,
        SPELLFAMILY_DEATHKNIGHT = 15,
        // unused               = 16,
        SPELLFAMILY_PET         = 17
    };

    /// <summary>
    ///
    /// </summary>
    public enum SpellSpecific
    {
        SPELL_NORMAL            = 0,
        SPELL_SEAL              = 1,
        SPELL_BLESSING          = 2,
        SPELL_AURA              = 3,
        SPELL_STING             = 4,
        SPELL_CURSE             = 5,
        SPELL_ASPECT            = 6,
        SPELL_TRACKER           = 7,
        SPELL_WARLOCK_ARMOR     = 8,
        SPELL_MAGE_ARMOR        = 9,
        SPELL_ELEMENTAL_SHIELD  = 10,
        SPELL_MAGE_POLYMORPH    = 11,
        SPELL_POSITIVE_SHOUT    = 12,
        SPELL_JUDGEMENT         = 13,
        SPELL_BATTLE_ELIXIR     = 14,
        SPELL_GUARDIAN_ELIXIR   = 15,
        SPELL_FLASK_ELIXIR      = 16,
        SPELL_PRESENCE          = 17,
        SPELL_HAND              = 18,
        SPELL_WELL_FED          = 19,
        SPELL_FOOD              = 20,
        SPELL_DRINK             = 21,
        SPELL_FOOD_AND_DRINK    = 22,
    };

    /// <summary>
    ///
    /// </summary>
    public enum SpellEffects
    {
        SPELL_EFFECT_NONE                      = 0,
        SPELL_EFFECT_INSTAKILL                 = 1,
        SPELL_EFFECT_SCHOOL_DAMAGE             = 2,
        SPELL_EFFECT_DUMMY                     = 3,
        SPELL_EFFECT_PORTAL_TELEPORT           = 4,
        SPELL_EFFECT_TELEPORT_UNITS            = 5,
        SPELL_EFFECT_APPLY_AURA                = 6,
        SPELL_EFFECT_ENVIRONMENTAL_DAMAGE      = 7,
        SPELL_EFFECT_POWER_DRAIN               = 8,
        SPELL_EFFECT_HEALTH_LEECH              = 9,
        SPELL_EFFECT_HEAL                      = 10,
        SPELL_EFFECT_BIND                      = 11,
        SPELL_EFFECT_PORTAL                    = 12,
        SPELL_EFFECT_RITUAL_BASE               = 13,
        SPELL_EFFECT_RITUAL_SPECIALIZE         = 14,
        SPELL_EFFECT_RITUAL_ACTIVATE_PORTAL    = 15,
        SPELL_EFFECT_QUEST_COMPLETE            = 16,
        SPELL_EFFECT_WEAPON_DAMAGE_NOSCHOOL    = 17,
        SPELL_EFFECT_RESURRECT                 = 18,
        SPELL_EFFECT_ADD_EXTRA_ATTACKS         = 19,
        SPELL_EFFECT_DODGE                     = 20,
        SPELL_EFFECT_EVADE                     = 21,
        SPELL_EFFECT_PARRY                     = 22,
        SPELL_EFFECT_BLOCK                     = 23,
        SPELL_EFFECT_CREATE_ITEM               = 24,
        SPELL_EFFECT_WEAPON                    = 25,
        SPELL_EFFECT_DEFENSE                   = 26,
        SPELL_EFFECT_PERSISTENT_AREA_AURA      = 27,
        SPELL_EFFECT_SUMMON                    = 28,
        SPELL_EFFECT_LEAP                      = 29,
        SPELL_EFFECT_ENERGIZE                  = 30,
        SPELL_EFFECT_WEAPON_PERCENT_DAMAGE     = 31,
        SPELL_EFFECT_TRIGGER_MISSILE           = 32,
        SPELL_EFFECT_OPEN_LOCK                 = 33,
        SPELL_EFFECT_SUMMON_CHANGE_ITEM        = 34,
        SPELL_EFFECT_APPLY_AREA_AURA_PARTY     = 35,
        SPELL_EFFECT_LEARN_SPELL               = 36,
        SPELL_EFFECT_SPELL_DEFENSE             = 37,
        SPELL_EFFECT_DISPEL                    = 38,
        SPELL_EFFECT_LANGUAGE                  = 39,
        SPELL_EFFECT_DUAL_WIELD                = 40,
        SPELL_EFFECT_JUMP                      = 41,
        SPELL_EFFECT_JUMP2                     = 42,
        SPELL_EFFECT_TELEPORT_UNITS_FACE_CASTER= 43,
        SPELL_EFFECT_SKILL_STEP                = 44,
        SPELL_EFFECT_ADD_HONOR                 = 45,
        SPELL_EFFECT_SPAWN                     = 46,
        SPELL_EFFECT_TRADE_SKILL               = 47,
        SPELL_EFFECT_STEALTH                   = 48,
        SPELL_EFFECT_DETECT                    = 49,
        SPELL_EFFECT_TRANS_DOOR                = 50,
        SPELL_EFFECT_FORCE_CRITICAL_HIT        = 51,
        SPELL_EFFECT_GUARANTEE_HIT             = 52,
        SPELL_EFFECT_ENCHANT_ITEM              = 53,
        SPELL_EFFECT_ENCHANT_ITEM_TEMPORARY    = 54,
        SPELL_EFFECT_TAMECREATURE              = 55,
        SPELL_EFFECT_SUMMON_PET                = 56,
        SPELL_EFFECT_LEARN_PET_SPELL           = 57,
        SPELL_EFFECT_WEAPON_DAMAGE             = 58,
        SPELL_EFFECT_CREATE_RANDOM_ITEM        = 59,
        SPELL_EFFECT_PROFICIENCY               = 60,
        SPELL_EFFECT_SEND_EVENT                = 61,
        SPELL_EFFECT_POWER_BURN                = 62,
        SPELL_EFFECT_THREAT                    = 63,
        SPELL_EFFECT_TRIGGER_SPELL             = 64,
        SPELL_EFFECT_APPLY_AREA_AURA_RAID      = 65,
        SPELL_EFFECT_RESTORE_ITEM_CHARGES      = 66,
        SPELL_EFFECT_HEAL_MAX_HEALTH           = 67,
        SPELL_EFFECT_INTERRUPT_CAST            = 68,
        SPELL_EFFECT_DISTRACT                  = 69,
        SPELL_EFFECT_PULL                      = 70,
        SPELL_EFFECT_PICKPOCKET                = 71,
        SPELL_EFFECT_ADD_FARSIGHT              = 72,
        SPELL_EFFECT_UNTRAIN_TALENTS           = 73,
        SPELL_EFFECT_APPLY_GLYPH               = 74,
        SPELL_EFFECT_HEAL_MECHANICAL           = 75,
        SPELL_EFFECT_SUMMON_OBJECT_WILD        = 76,
        SPELL_EFFECT_SCRIPT_EFFECT             = 77,
        SPELL_EFFECT_ATTACK                    = 78,
        SPELL_EFFECT_SANCTUARY                 = 79,
        SPELL_EFFECT_ADD_COMBO_POINTS          = 80,
        SPELL_EFFECT_CREATE_HOUSE              = 81,
        SPELL_EFFECT_BIND_SIGHT                = 82,
        SPELL_EFFECT_DUEL                      = 83,
        SPELL_EFFECT_STUCK                     = 84,
        SPELL_EFFECT_SUMMON_PLAYER             = 85,
        SPELL_EFFECT_ACTIVATE_OBJECT           = 86,
        SPELL_EFFECT_WMO_DAMAGE                = 87,
        SPELL_EFFECT_WMO_REPAIR                = 88,
        SPELL_EFFECT_WMO_CHANGE                = 89,
        SPELL_EFFECT_KILL_CREDIT_PERSONAL      = 90,
        SPELL_EFFECT_THREAT_ALL                = 91,
        SPELL_EFFECT_ENCHANT_HELD_ITEM         = 92,
        SPELL_EFFECT_BREAK_PLAYER_TARGETING    = 93,
        SPELL_EFFECT_SELF_RESURRECT            = 94,
        SPELL_EFFECT_SKINNING                  = 95,
        SPELL_EFFECT_CHARGE                    = 96,
        SPELL_EFFECT_SUMMON_ALL_TOTEMS         = 97,
        SPELL_EFFECT_KNOCK_BACK                = 98,
        SPELL_EFFECT_DISENCHANT                = 99,
        SPELL_EFFECT_INEBRIATE                 = 100,
        SPELL_EFFECT_FEED_PET                  = 101,
        SPELL_EFFECT_DISMISS_PET               = 102,
        SPELL_EFFECT_REPUTATION                = 103,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT1       = 104,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT2       = 105,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT3       = 106,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT4       = 107,
        SPELL_EFFECT_DISPEL_MECHANIC           = 108,
        SPELL_EFFECT_SUMMON_DEAD_PET           = 109,
        SPELL_EFFECT_DESTROY_ALL_TOTEMS        = 110,
        SPELL_EFFECT_DURABILITY_DAMAGE         = 111,
        SPELL_EFFECT_112                       = 112,           // old SPELL_EFFECT_SUMMON_DEMON
        SPELL_EFFECT_RESURRECT_NEW             = 113,
        SPELL_EFFECT_ATTACK_ME                 = 114,
        SPELL_EFFECT_DURABILITY_DAMAGE_PCT     = 115,
        SPELL_EFFECT_SKIN_PLAYER_CORPSE        = 116,
        SPELL_EFFECT_SPIRIT_HEAL               = 117,
        SPELL_EFFECT_SKILL                     = 118,
        SPELL_EFFECT_APPLY_AREA_AURA_PET       = 119,
        SPELL_EFFECT_TELEPORT_GRAVEYARD        = 120,
        SPELL_EFFECT_NORMALIZED_WEAPON_DMG     = 121,
        SPELL_EFFECT_SERVER_SIDE               = 122,
        SPELL_EFFECT_SEND_TAXI                 = 123,
        SPELL_EFFECT_PLAYER_PULL               = 124,
        SPELL_EFFECT_MODIFY_THREAT_PERCENT     = 125,
        SPELL_EFFECT_STEAL_BENEFICIAL_BUFF     = 126,
        SPELL_EFFECT_PROSPECTING               = 127,
        SPELL_EFFECT_APPLY_AREA_AURA_FRIEND    = 128,
        SPELL_EFFECT_APPLY_AREA_AURA_ENEMY     = 129,
        SPELL_EFFECT_REDIRECT_THREAT           = 130,
        SPELL_EFFECT_PLAY_SOUND                = 131,
        SPELL_EFFECT_PLAY_MUSIC                = 132,
        SPELL_EFFECT_UNLEARN_SPECIALIZATION    = 133,
        SPELL_EFFECT_KILL_CREDIT_GROUP         = 134,
        SPELL_EFFECT_CALL_PET                  = 135,
        SPELL_EFFECT_HEAL_PCT                  = 136,
        SPELL_EFFECT_ENERGIZE_PCT              = 137,
        SPELL_EFFECT_LEAP_BACK                 = 138,
        SPELL_EFFECT_CLEAR_QUEST               = 139,
        SPELL_EFFECT_FORCE_CAST                = 140,
        SPELL_EFFECT_141                       = 141,
        SPELL_EFFECT_TRIGGER_SPELL_WITH_VALUE  = 142,
        SPELL_EFFECT_APPLY_AREA_AURA_OWNER     = 143,
        SPELL_EFFECT_KNOCKBACK_FROM_POSITION   = 144,
        SPELL_EFFECT_SUSPEND_GRAVITY           = 145,
        SPELL_EFFECT_ACTIVATE_RUNE             = 146,
        SPELL_EFFECT_QUEST_FAIL                = 147,
        SPELL_EFFECT_TRIGGER_MISSILE_2         = 148,
        SPELL_EFFECT_CHARGE2                   = 149,
        SPELL_EFFECT_QUEST_START               = 150,
        SPELL_EFFECT_TRIGGER_SPELL_2           = 151,
        SPELL_EFFECT_FRIEND_SUMMON             = 152,
        SPELL_EFFECT_CREATE_PET                = 153,
        SPELL_EFFECT_TEACH_TAXI_NODE           = 154,
        SPELL_EFFECT_TITAN_GRIP                = 155,
        SPELL_EFFECT_ENCHANT_ITEM_PRISMATIC    = 156,
        SPELL_EFFECT_CREATE_ITEM_2             = 157,
        SPELL_EFFECT_MILLING                   = 158,
        SPELL_EFFECT_ALLOW_RENAME_PET          = 159,
        SPELL_EFFECT_160                       = 160,
        SPELL_EFFECT_TALENT_SPEC_COUNT         = 161,
        SPELL_EFFECT_TALENT_SPEC_SELECT        = 162,
        SPELL_EFFECT_163                       = 163,
        SPELL_EFFECT_CANCEL_AURA               = 164,
        TOTAL_SPELL_EFFECTS                    = 165
    };

    /// <summary>
    ///
    /// </summary>
    public enum AuraType
    {
        SPELL_AURA_NONE = 0,
        SPELL_AURA_BIND_SIGHT = 1,
        SPELL_AURA_MOD_POSSESS = 2,
        SPELL_AURA_PERIODIC_DAMAGE = 3,
        SPELL_AURA_DUMMY = 4,
        SPELL_AURA_MOD_CONFUSE = 5,
        SPELL_AURA_MOD_CHARM = 6,
        SPELL_AURA_MOD_FEAR = 7,
        SPELL_AURA_PERIODIC_HEAL = 8,
        SPELL_AURA_MOD_ATTACKSPEED = 9,
        SPELL_AURA_MOD_THREAT = 10,
        SPELL_AURA_MOD_TAUNT = 11,
        SPELL_AURA_MOD_STUN = 12,
        SPELL_AURA_MOD_DAMAGE_DONE = 13,
        SPELL_AURA_MOD_DAMAGE_TAKEN = 14,
        SPELL_AURA_DAMAGE_SHIELD = 15,
        SPELL_AURA_MOD_STEALTH = 16,
        SPELL_AURA_MOD_STEALTH_DETECT = 17,
        SPELL_AURA_MOD_INVISIBILITY = 18,
        SPELL_AURA_MOD_INVISIBILITY_DETECTION = 19,
        SPELL_AURA_OBS_MOD_HEALTH = 20,                         //20,21 unofficial
        SPELL_AURA_OBS_MOD_MANA = 21,
        SPELL_AURA_MOD_RESISTANCE = 22,
        SPELL_AURA_PERIODIC_TRIGGER_SPELL = 23,
        SPELL_AURA_PERIODIC_ENERGIZE = 24,
        SPELL_AURA_MOD_PACIFY = 25,
        SPELL_AURA_MOD_ROOT = 26,
        SPELL_AURA_MOD_SILENCE = 27,
        SPELL_AURA_REFLECT_SPELLS = 28,
        SPELL_AURA_MOD_STAT = 29,
        SPELL_AURA_MOD_SKILL = 30,
        SPELL_AURA_MOD_INCREASE_SPEED = 31,
        SPELL_AURA_MOD_INCREASE_MOUNTED_SPEED = 32,
        SPELL_AURA_MOD_DECREASE_SPEED = 33,
        SPELL_AURA_MOD_INCREASE_HEALTH = 34,
        SPELL_AURA_MOD_INCREASE_ENERGY = 35,
        SPELL_AURA_MOD_SHAPESHIFT = 36,
        SPELL_AURA_EFFECT_IMMUNITY = 37,
        SPELL_AURA_STATE_IMMUNITY = 38,
        SPELL_AURA_SCHOOL_IMMUNITY = 39,
        SPELL_AURA_DAMAGE_IMMUNITY = 40,
        SPELL_AURA_DISPEL_IMMUNITY = 41,
        SPELL_AURA_PROC_TRIGGER_SPELL = 42,
        SPELL_AURA_PROC_TRIGGER_DAMAGE = 43,
        SPELL_AURA_TRACK_CREATURES = 44,
        SPELL_AURA_TRACK_RESOURCES = 45,
        SPELL_AURA_46 = 46,                                     // Ignore all Gear test spells
        SPELL_AURA_MOD_PARRY_PERCENT = 47,
        SPELL_AURA_PERIODIC_TRIGGER_BY_CLIENT = 48,             // Client periodic trigger spell by self (3 spells in 3.3.5a)
        SPELL_AURA_MOD_DODGE_PERCENT = 49,
        SPELL_AURA_MOD_CRITICAL_HEALING_AMOUNT = 50,
        SPELL_AURA_MOD_BLOCK_PERCENT = 51,
        SPELL_AURA_MOD_CRIT_PERCENT = 52,
        SPELL_AURA_PERIODIC_LEECH = 53,
        SPELL_AURA_MOD_HIT_CHANCE = 54,
        SPELL_AURA_MOD_SPELL_HIT_CHANCE = 55,
        SPELL_AURA_TRANSFORM = 56,
        SPELL_AURA_MOD_SPELL_CRIT_CHANCE = 57,
        SPELL_AURA_MOD_INCREASE_SWIM_SPEED = 58,
        SPELL_AURA_MOD_DAMAGE_DONE_CREATURE = 59,
        SPELL_AURA_MOD_PACIFY_SILENCE = 60,
        SPELL_AURA_MOD_SCALE = 61,
        SPELL_AURA_PERIODIC_HEALTH_FUNNEL = 62,
        SPELL_AURA_63 = 63,                                     // old SPELL_AURA_PERIODIC_MANA_FUNNEL
        SPELL_AURA_PERIODIC_MANA_LEECH = 64,
        SPELL_AURA_MOD_CASTING_SPEED_NOT_STACK = 65,
        SPELL_AURA_FEIGN_DEATH = 66,
        SPELL_AURA_MOD_DISARM = 67,
        SPELL_AURA_MOD_STALKED = 68,
        SPELL_AURA_SCHOOL_ABSORB = 69,
        SPELL_AURA_EXTRA_ATTACKS = 70,
        SPELL_AURA_MOD_SPELL_CRIT_CHANCE_SCHOOL = 71,
        SPELL_AURA_MOD_POWER_COST_SCHOOL_PCT = 72,
        SPELL_AURA_MOD_POWER_COST_SCHOOL = 73,
        SPELL_AURA_REFLECT_SPELLS_SCHOOL = 74,
        SPELL_AURA_MOD_LANGUAGE = 75,
        SPELL_AURA_FAR_SIGHT = 76,
        SPELL_AURA_MECHANIC_IMMUNITY = 77,
        SPELL_AURA_MOUNTED = 78,
        SPELL_AURA_MOD_DAMAGE_PERCENT_DONE = 79,
        SPELL_AURA_MOD_PERCENT_STAT = 80,
        SPELL_AURA_SPLIT_DAMAGE_PCT = 81,
        SPELL_AURA_WATER_BREATHING = 82,
        SPELL_AURA_MOD_BASE_RESISTANCE = 83,
        SPELL_AURA_MOD_REGEN = 84,
        SPELL_AURA_MOD_POWER_REGEN = 85,
        SPELL_AURA_CHANNEL_DEATH_ITEM = 86,
        SPELL_AURA_MOD_DAMAGE_PERCENT_TAKEN = 87,
        SPELL_AURA_MOD_HEALTH_REGEN_PERCENT = 88,
        SPELL_AURA_PERIODIC_DAMAGE_PERCENT = 89,
        SPELL_AURA_90 = 90,                                     // old SPELL_AURA_MOD_RESIST_CHANCE
        SPELL_AURA_MOD_DETECT_RANGE = 91,
        SPELL_AURA_PREVENTS_FLEEING = 92,
        SPELL_AURA_MOD_UNATTACKABLE = 93,
        SPELL_AURA_INTERRUPT_REGEN = 94,
        SPELL_AURA_GHOST = 95,
        SPELL_AURA_SPELL_MAGNET = 96,
        SPELL_AURA_MANA_SHIELD = 97,
        SPELL_AURA_MOD_SKILL_TALENT = 98,
        SPELL_AURA_MOD_ATTACK_POWER = 99,
        SPELL_AURA_AURAS_VISIBLE = 100,
        SPELL_AURA_MOD_RESISTANCE_PCT = 101,
        SPELL_AURA_MOD_MELEE_ATTACK_POWER_VERSUS = 102,
        SPELL_AURA_MOD_TOTAL_THREAT = 103,
        SPELL_AURA_WATER_WALK = 104,
        SPELL_AURA_FEATHER_FALL = 105,
        SPELL_AURA_HOVER = 106,
        SPELL_AURA_ADD_FLAT_MODIFIER = 107,
        SPELL_AURA_ADD_PCT_MODIFIER = 108,
        SPELL_AURA_ADD_TARGET_TRIGGER = 109,
        SPELL_AURA_MOD_POWER_REGEN_PERCENT = 110,
        SPELL_AURA_ADD_CASTER_HIT_TRIGGER = 111,
        SPELL_AURA_OVERRIDE_CLASS_SCRIPTS = 112,
        SPELL_AURA_MOD_RANGED_DAMAGE_TAKEN = 113,
        SPELL_AURA_MOD_RANGED_DAMAGE_TAKEN_PCT = 114,
        SPELL_AURA_MOD_HEALING = 115,
        SPELL_AURA_MOD_REGEN_DURING_COMBAT = 116,
        SPELL_AURA_MOD_MECHANIC_RESISTANCE = 117,
        SPELL_AURA_MOD_HEALING_PCT = 118,
        SPELL_AURA_119 = 119,                                   // old SPELL_AURA_SHARE_PET_TRACKING
        SPELL_AURA_UNTRACKABLE = 120,
        SPELL_AURA_EMPATHY = 121,
        SPELL_AURA_MOD_OFFHAND_DAMAGE_PCT = 122,
        SPELL_AURA_MOD_TARGET_RESISTANCE = 123,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER = 124,
        SPELL_AURA_MOD_MELEE_DAMAGE_TAKEN = 125,
        SPELL_AURA_MOD_MELEE_DAMAGE_TAKEN_PCT = 126,
        SPELL_AURA_RANGED_ATTACK_POWER_ATTACKER_BONUS = 127,
        SPELL_AURA_MOD_POSSESS_PET = 128,
        SPELL_AURA_MOD_SPEED_ALWAYS = 129,
        SPELL_AURA_MOD_MOUNTED_SPEED_ALWAYS = 130,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_VERSUS = 131,
        SPELL_AURA_MOD_INCREASE_ENERGY_PERCENT = 132,
        SPELL_AURA_MOD_INCREASE_HEALTH_PERCENT = 133,
        SPELL_AURA_MOD_MANA_REGEN_INTERRUPT = 134,
        SPELL_AURA_MOD_HEALING_DONE = 135,
        SPELL_AURA_MOD_HEALING_DONE_PERCENT = 136,
        SPELL_AURA_MOD_TOTAL_STAT_PERCENTAGE = 137,
        SPELL_AURA_MOD_MELEE_HASTE = 138,
        SPELL_AURA_FORCE_REACTION = 139,
        SPELL_AURA_MOD_RANGED_HASTE = 140,
        SPELL_AURA_MOD_RANGED_AMMO_HASTE = 141,
        SPELL_AURA_MOD_BASE_RESISTANCE_PCT = 142,
        SPELL_AURA_MOD_RESISTANCE_EXCLUSIVE = 143,
        SPELL_AURA_SAFE_FALL = 144,
        SPELL_AURA_MOD_PET_TALENT_POINTS = 145,
        SPELL_AURA_ALLOW_TAME_PET_TYPE = 146,
        SPELL_AURA_MECHANIC_IMMUNITY_MASK = 147,
        SPELL_AURA_RETAIN_COMBO_POINTS = 148,
        SPELL_AURA_REDUCE_PUSHBACK  = 149,                      //    Reduce Pushback
        SPELL_AURA_MOD_SHIELD_BLOCKVALUE_PCT = 150,
        SPELL_AURA_TRACK_STEALTHED  = 151,                      //    Track Stealthed
        SPELL_AURA_MOD_DETECTED_RANGE = 152,                    //    Mod Detected Range
        SPELL_AURA_SPLIT_DAMAGE_FLAT = 153,                     //    Split Damage Flat
        SPELL_AURA_MOD_STEALTH_LEVEL = 154,                     //    Stealth Level Modifier
        SPELL_AURA_MOD_WATER_BREATHING = 155,                   //    Mod Water Breathing
        SPELL_AURA_MOD_REPUTATION_GAIN = 156,                   //    Mod Reputation Gain
        SPELL_AURA_PET_DAMAGE_MULTI = 157,                      //    Mod Pet Damage
        SPELL_AURA_MOD_SHIELD_BLOCKVALUE = 158,
        SPELL_AURA_NO_PVP_CREDIT = 159,
        SPELL_AURA_MOD_AOE_AVOIDANCE = 160,
        SPELL_AURA_MOD_HEALTH_REGEN_IN_COMBAT = 161,
        SPELL_AURA_POWER_BURN_MANA = 162,
        SPELL_AURA_MOD_CRIT_DAMAGE_BONUS = 163,
        SPELL_AURA_164 = 164,
        SPELL_AURA_MELEE_ATTACK_POWER_ATTACKER_BONUS = 165,
        SPELL_AURA_MOD_ATTACK_POWER_PCT = 166,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_PCT = 167,
        SPELL_AURA_MOD_DAMAGE_DONE_VERSUS = 168,
        SPELL_AURA_MOD_CRIT_PERCENT_VERSUS = 169,
        SPELL_AURA_DETECT_AMORE = 170,
        SPELL_AURA_MOD_SPEED_NOT_STACK = 171,
        SPELL_AURA_MOD_MOUNTED_SPEED_NOT_STACK = 172,
        SPELL_AURA_173 = 173,                                   // old SPELL_AURA_ALLOW_CHAMPION_SPELLS
        SPELL_AURA_MOD_SPELL_DAMAGE_OF_STAT_PERCENT = 174,      // by defeult intelect, dependent from SPELL_AURA_MOD_SPELL_HEALING_OF_STAT_PERCENT
        SPELL_AURA_MOD_SPELL_HEALING_OF_STAT_PERCENT = 175,
        SPELL_AURA_SPIRIT_OF_REDEMPTION = 176,
        SPELL_AURA_AOE_CHARM = 177,
        SPELL_AURA_MOD_DEBUFF_RESISTANCE = 178,
        SPELL_AURA_MOD_ATTACKER_SPELL_CRIT_CHANCE = 179,
        SPELL_AURA_MOD_FLAT_SPELL_DAMAGE_VERSUS = 180,
        SPELL_AURA_181 = 181,                                   // old SPELL_AURA_MOD_FLAT_SPELL_CRIT_DAMAGE_VERSUS - possible flat spell crit damage versus
        SPELL_AURA_MOD_RESISTANCE_OF_STAT_PERCENT = 182,
        SPELL_AURA_MOD_CRITICAL_THREAT = 183,
        SPELL_AURA_MOD_ATTACKER_MELEE_HIT_CHANCE = 184,
        SPELL_AURA_MOD_ATTACKER_RANGED_HIT_CHANCE= 185,
        SPELL_AURA_MOD_ATTACKER_SPELL_HIT_CHANCE = 186,
        SPELL_AURA_MOD_ATTACKER_MELEE_CRIT_CHANCE = 187,
        SPELL_AURA_MOD_ATTACKER_RANGED_CRIT_CHANCE = 188,
        SPELL_AURA_MOD_RATING = 189,
        SPELL_AURA_MOD_FACTION_REPUTATION_GAIN = 190,
        SPELL_AURA_USE_NORMAL_MOVEMENT_SPEED = 191,
        SPELL_AURA_MOD_MELEE_RANGED_HASTE = 192,
        SPELL_AURA_HASTE_ALL = 193,
        SPELL_AURA_MOD_IGNORE_ABSORB_SCHOOL  = 194,
        SPELL_AURA_MOD_IGNORE_ABSORB_FOR_SPELL  = 195,
        SPELL_AURA_MOD_COOLDOWN = 196,                          // only 24818 Noxious Breath
        SPELL_AURA_MOD_ATTACKER_SPELL_AND_WEAPON_CRIT_CHANCE = 197,
        SPELL_AURA_198 = 198,                                   // old SPELL_AURA_MOD_ALL_WEAPON_SKILLS
        SPELL_AURA_MOD_INCREASES_SPELL_PCT_TO_HIT = 199,
        SPELL_AURA_MOD_KILL_XP_PCT = 200,
        SPELL_AURA_FLY = 201,
        SPELL_AURA_IGNORE_COMBAT_RESULT = 202,
        SPELL_AURA_MOD_ATTACKER_MELEE_CRIT_DAMAGE = 203,
        SPELL_AURA_MOD_ATTACKER_RANGED_CRIT_DAMAGE = 204,
        SPELL_AURA_MOD_ATTACKER_SPELL_CRIT_DAMAGE = 205,
        SPELL_AURA_MOD_FLIGHT_SPEED = 206,
        SPELL_AURA_MOD_FLIGHT_SPEED_MOUNTED = 207,
        SPELL_AURA_MOD_FLIGHT_SPEED_STACKING = 208,
        SPELL_AURA_MOD_FLIGHT_SPEED_MOUNTED_STACKING = 209,
        SPELL_AURA_MOD_FLIGHT_SPEED_NOT_STACKING = 210,
        SPELL_AURA_MOD_FLIGHT_SPEED_MOUNTED_NOT_STACKING = 211,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_OF_STAT_PERCENT = 212,
        SPELL_AURA_MOD_RAGE_FROM_DAMAGE_DEALT = 213,
        SPELL_AURA_214 = 214,
        SPELL_AURA_ARENA_PREPARATION = 215,
        SPELL_AURA_HASTE_SPELLS = 216,
        SPELL_AURA_217 = 217,
        SPELL_AURA_HASTE_RANGED = 218,
        SPELL_AURA_MOD_MANA_REGEN_FROM_STAT = 219,
        SPELL_AURA_MOD_RATING_FROM_STAT = 220,
        SPELL_AURA_221 = 221,
        SPELL_AURA_222 = 222,
        SPELL_AURA_223 = 223,
        SPELL_AURA_224 = 224,
        SPELL_AURA_PRAYER_OF_MENDING = 225,
        SPELL_AURA_PERIODIC_DUMMY = 226,
        SPELL_AURA_PERIODIC_TRIGGER_SPELL_WITH_VALUE = 227,
        SPELL_AURA_DETECT_STEALTH = 228,
        SPELL_AURA_MOD_AOE_DAMAGE_AVOIDANCE = 229,
        SPELL_AURA_MOD_PARTY_MAX_HEALTH = 230,
        SPELL_AURA_PROC_TRIGGER_SPELL_WITH_VALUE = 231,
        SPELL_AURA_MECHANIC_DURATION_MOD = 232,
        SPELL_AURA_233 = 233,
        SPELL_AURA_MECHANIC_DURATION_MOD_NOT_STACK = 234,
        SPELL_AURA_MOD_DISPEL_RESIST = 235,
        SPELL_AURA_CONTROL_VEHICLE = 236,
        SPELL_AURA_MOD_SPELL_DAMAGE_OF_ATTACK_POWER = 237,
        SPELL_AURA_MOD_SPELL_HEALING_OF_ATTACK_POWER = 238,
        SPELL_AURA_MOD_SCALE_2 = 239,
        SPELL_AURA_MOD_EXPERTISE = 240,
        SPELL_AURA_FORCE_MOVE_FORWARD = 241,
        SPELL_AURA_MOD_SPELL_DAMAGE_FROM_HEALING = 242,
        SPELL_AURA_FACTION_CHANGE = 243,
        SPELL_AURA_COMPREHEND_LANGUAGE = 244,
        SPELL_AURA_MOD_DURATION_OF_MAGIC_EFFECTS = 245,
        SPELL_AURA_MOD_DURATION_OF_EFFECTS_BY_DISPEL = 246,
        SPELL_AURA_MIRROR_IMAGE = 247,
        SPELL_AURA_MOD_COMBAT_RESULT_CHANCE = 248,
        SPELL_AURA_CONVERT_RUNE = 249,
        SPELL_AURA_MOD_INCREASE_HEALTH_2 = 250,
        SPELL_AURA_MOD_ENEMY_DODGE = 251,
        SPELL_AURA_SLOW_ALL = 252,
        SPELL_AURA_MOD_BLOCK_CRIT_CHANCE = 253,
        SPELL_AURA_MOD_DISARM_OFFHAND = 254,
        SPELL_AURA_MOD_MECHANIC_DAMAGE_TAKEN_PERCENT = 255,
        SPELL_AURA_NO_REAGENT_USE = 256,
        SPELL_AURA_MOD_TARGET_RESIST_BY_SPELL_CLASS = 257,
        SPELL_AURA_258 = 258,
        SPELL_AURA_MOD_PERIODIC_HEAL = 259,
        SPELL_AURA_SCREEN_EFFECT = 260,
        SPELL_AURA_PHASE = 261,
        SPELL_AURA_IGNORE_UNIT_STATE = 262,
        SPELL_AURA_ALLOW_ONLY_ABILITY = 263,
        SPELL_AURA_264 = 264,
        SPELL_AURA_265 = 265,
        SPELL_AURA_266 = 266,
        SPELL_AURA_MOD_IMMUNE_AURA_APPLY_SCHOOL = 267,
        SPELL_AURA_MOD_ATTACK_POWER_OF_STAT_PERCENT = 268,
        SPELL_AURA_MOD_IGNORE_DAMAGE_REDUCTION_SCHOOL = 269,
        SPELL_AURA_MOD_IGNORE_TARGET_RESIST = 270,              // Possibly need swap vs 195 aura used only in 1 spell Chaos Bolt Passive
        SPELL_AURA_MOD_DAMAGE_FROM_CASTER = 271,
        SPELL_AURA_MAELSTROM_WEAPON = 272,
        SPELL_AURA_X_RAY = 273,
        SPELL_AURA_274 = 274,
        SPELL_AURA_MOD_IGNORE_SHAPESHIFT = 275,
        SPELL_AURA_276 = 276,                                   // Only "Test Mod Damage % Mechanic" spell, possible mod damage done
        SPELL_AURA_MOD_MAX_AFFECTED_TARGETS = 277,
        SPELL_AURA_MOD_DISARM_RANGED = 278,
        SPELL_AURA_279 = 279,
        SPELL_AURA_MOD_TARGET_ARMOR_PCT = 280,
        SPELL_AURA_MOD_HONOR_GAIN = 281,
        SPELL_AURA_MOD_BASE_HEALTH_PCT = 282,
        SPELL_AURA_MOD_HEALING_RECEIVED = 283,                  // Possibly only for some spell family class spells
        SPELL_AURA_LINKED = 284,
        SPELL_AURA_MOD_ATTACK_POWER_OF_ARMOR = 285,
        SPELL_AURA_ABILITY_PERIODIC_CRIT = 286,
        SPELL_AURA_DEFLECT_SPELLS = 287,
        SPELL_AURA_MOD_PARRY_FROM_BEHIND_PERCENT = 288,
        SPELL_AURA_289 = 289,
        SPELL_AURA_MOD_ALL_CRIT_CHANCE = 290,
        SPELL_AURA_MOD_QUEST_XP_PCT = 291,
        SPELL_AURA_OPEN_STABLE = 292,
        SPELL_AURA_ADD_MECHANIC_ABILITIES = 293,
        SPELL_AURA_STOP_NATURAL_MANA_REGEN = 294,
        SPELL_AURA_295 = 295,
        SPELL_AURA_SET_VEHICLE_ID = 296,
        SPELL_AURA_297 = 297,
        SPELL_AURA_298 = 298,
        SPELL_AURA_299 = 299,
        SPELL_AURA_SHARE_DAMAGE_PCT = 300,
        SPELL_AURA_HEAL_ABSORB = 301,
        SPELL_AURA_302 = 302,
        SPELL_AURA_DAMAGE_DONE_VERSUS_AURA_STATE_PCT = 303,
        SPELL_AURA_FAKE_INEBRIATE = 304,
        SPELL_AURA_MOD_MINIMUM_SPEED = 305,
        SPELL_AURA_306 = 306,
        SPELL_AURA_307 = 307,
        SPELL_AURA_308 = 308,
        SPELL_AURA_309 = 309,
        SPELL_AURA_MOD_PET_AOE_DAMAGE_AVOIDANCE = 310,
        SPELL_AURA_311 = 311,
        SPELL_AURA_312 = 312,
        SPELL_AURA_313 = 313,
        SPELL_AURA_314 = 314,
        SPELL_AURA_315 = 315,
        SPELL_AURA_MOD_PERIODIC_HASTE = 316,
        TOTAL_AURAS = 317
    }

    /// <summary>
    /// Target
    /// </summary>
    public enum Targets
    {
        TARGET_NONE                             = 0,
        TARGET_SELF                             = 1,
        TARGET_RANDOM_ENEMY_CHAIN_IN_AREA       = 2,                 // only one spell has that, but regardless, it's a target type after all
        TARGET_RANDOM_FRIEND_CHAIN_IN_AREA      = 3,
        TARGET_4                                = 4,
        TARGET_PET                              = 5,
        TARGET_CHAIN_DAMAGE                     = 6,
        TARGET_AREAEFFECT_INSTANT               = 7,                 // targets around provided destination point
        TARGET_AREAEFFECT_CUSTOM                = 8,
        TARGET_INNKEEPER_COORDINATES            = 9,                 // uses in teleport to innkeeper spells
        TARGET_10                               = 10,
        TARGET_11                               = 11,
        TARGET_12                               = 12,
        TARGET_13                               = 13,
        TARGET_14                               = 14,
        TARGET_ALL_ENEMY_IN_AREA                = 15,
        TARGET_ALL_ENEMY_IN_AREA_INSTANT        = 16,
        TARGET_TABLE_X_Y_Z_COORDINATES          = 17,                // uses in teleport spells and some other
        TARGET_EFFECT_SELECT                    = 18,                // highly depends on the spell effect
        TARGET_19                               = 19,
        TARGET_ALL_PARTY_AROUND_CASTER          = 20,
        TARGET_SINGLE_FRIEND                    = 21,
        TARGET_CASTER_COORDINATES               = 22,                // used only in TargetA, target selection dependent from TargetB
        TARGET_GAMEOBJECT                       = 23,
        TARGET_IN_FRONT_OF_CASTER               = 24,
        TARGET_DUELVSPLAYER                     = 25,
        TARGET_GAMEOBJECT_ITEM                  = 26,
        TARGET_MASTER                           = 27,
        TARGET_ALL_ENEMY_IN_AREA_CHANNELED      = 28,
        TARGET_29                               = 29,
        TARGET_ALL_FRIENDLY_UNITS_AROUND_CASTER = 30,                // select friendly for caster object faction (in different original caster faction) in TargetB used only with TARGET_ALL_AROUND_CASTER and in self casting range in TargetA
        TARGET_ALL_FRIENDLY_UNITS_IN_AREA       = 31,
        TARGET_MINION                           = 32,
        TARGET_ALL_PARTY                        = 33,
        TARGET_ALL_PARTY_AROUND_CASTER_2        = 34,                // used in Tranquility
        TARGET_SINGLE_PARTY                     = 35,
        TARGET_ALL_HOSTILE_UNITS_AROUND_CASTER  = 36,
        TARGET_AREAEFFECT_PARTY                 = 37,
        TARGET_SCRIPT                           = 38,
        TARGET_SELF_FISHING                     = 39,
        TARGET_FOCUS_OR_SCRIPTED_GAMEOBJECT     = 40,
        TARGET_TOTEM_EARTH                      = 41,
        TARGET_TOTEM_WATER                      = 42,
        TARGET_TOTEM_AIR                        = 43,
        TARGET_TOTEM_FIRE                       = 44,
        TARGET_CHAIN_HEAL                       = 45,
        TARGET_SCRIPT_COORDINATES               = 46,
        TARGET_DYNAMIC_OBJECT_FRONT             = 47,
        TARGET_DYNAMIC_OBJECT_BEHIND            = 48,
        TARGET_DYNAMIC_OBJECT_LEFT_SIDE         = 49,
        TARGET_DYNAMIC_OBJECT_RIGHT_SIDE        = 50,
        TARGET_AREAEFFECT_GO_AROUND_SOURCE      = 51,
        TARGET_AREAEFFECT_GO_AROUND_DEST        = 52,                // gameobject around destination, select by spell_script_target
        TARGET_CURRENT_ENEMY_COORDINATES        = 53,                // set unit coordinates as dest, only 16 target B imlemented
        TARGET_LARGE_FRONTAL_CONE               = 54,
        TARGET_LEAP_FORWARD                     = 55,                // Target point must be calculated in target selection
        TARGET_ALL_RAID_AROUND_CASTER           = 56,
        TARGET_SINGLE_FRIEND_2                  = 57,
        TARGET_58                               = 58,
        TARGET_59                               = 59,
        TARGET_NARROW_FRONTAL_CONE              = 60,
        TARGET_AREAEFFECT_PARTY_AND_CLASS       = 61,
        TARGET_62                               = 62,
        TARGET_DUELVSPLAYER_COORDINATES         = 63,
        TARGET_INFRONT_OF_VICTIM                = 64,
        TARGET_BEHIND_VICTIM                    = 65,                // used in teleport behind spells, caster/target dependent from spell effect
        TARGET_RIGHT_FROM_VICTIM                = 66,
        TARGET_LEFT_FROM_VICTIM                 = 67,
        TARGET_68                               = 68,
        TARGET_69                               = 69,
        TARGET_70                               = 70,
        TARGET_71                               = 71,
        TARGET_RANDOM_NEARBY_LOC                = 72,                // used in teleport onto nearby locations
        TARGET_RANDOM_CIRCUMFERENCE_POINT       = 73,
        TARGET_RANDOM_POINT_NEAR_TARGET         = 74,                // Target point must be calculated in target selection
        TARGET_RANDOM_POINT_NEAR_TARGET_2       = 75,                // Target point must be calculated in target selection
        TARGET_DYNAMIC_OBJECT_COORDINATES       = 76,
        TARGET_SINGLE_ENEMY                     = 77,
        TARGET_POINT_AT_NORTH                   = 78,                // 78-85 possible _COORDINATES at radius with pi/4 step around target in unknown order, N?
        TARGET_POINT_AT_SOUTH                   = 79,                // S?
        TARGET_POINT_AT_EAST                    = 80,                // 80/81 must be symmetric from line caster->target, E (base at 82/83, 84/85 order) ?
        TARGET_POINT_AT_WEST                    = 81,                // 80/81 must be symmetric from line caster->target, W (base at 82/83, 84/85 order) ?
        TARGET_POINT_AT_NE                      = 82,                // from spell desc: "(NE)"
        TARGET_POINT_AT_NW                      = 83,                // from spell desc: "(NW)"
        TARGET_POINT_AT_SE                      = 84,                // from spell desc: "(SE)"
        TARGET_POINT_AT_SW                      = 85,                // from spell desc: "(SW)"
        TARGET_RANDOM_NEARBY_DEST               = 86,                // "Test Nearby Dest Random" - random around selected destination
        TARGET_SELF2                            = 87,
        TARGET_88                               = 88,
        TARGET_DIRECTLY_FORWARD                 = 89,
        TARGET_NONCOMBAT_PET                    = 90,
        TARGET_91                               = 91,
        TARGET_UNIT_CREATOR                     = 92,
        TARGET_93                               = 93,
        TARGET_OWNED_VEHICLE                    = 94,
        TARGET_UNIT_DRIVER                      = 95,
        TARGET_UNIT_PASSENGER_0                 = 96,
        TARGET_UNIT_PASSENGER_1                 = 97,
        TARGET_UNIT_PASSENGER_2                 = 98,
        TARGET_UNIT_PASSENGER_3                 = 99,
        TARGET_UNIT_PASSENGER_4                 = 100,
        TARGET_UNIT_PASSENGER_5                 = 101,
        TARGET_UNIT_PASSENGER_6                 = 102,
        TARGET_UNIT_PASSENGER_7                 = 103,
        TARGET_IN_FRONT_OF_CASTER_30            = 104,
        TARGET_105                              = 105,
        TARGET_106                              = 106,
        TARGET_107                              = 107,
        TARGET_GO_IN_FRONT_OF_CASTER_90         = 108,
        TARGET_109                              = 109,
        TARGET_110                              = 110,
        MAX_SPELL_TARGET
    };

    ///<summary>
    ///Spell proc event related declarations (accessed using SpellMgr functions)
    ///</summary>
    [Flags]
    public enum ProcFlags
    {
        PROC_FLAG_NONE                              = 0x00000000,

        PROC_FLAG_KILLED                            = 0x00000001,    // 00 Killed by aggressor
        PROC_FLAG_KILL                              = 0x00000002,    // 01 Kill target (in most cases need XP/Honor reward)

        PROC_FLAG_SUCCESSFUL_MELEE_HIT              = 0x00000004,    // 02 Successful melee auto attack
        PROC_FLAG_TAKEN_MELEE_HIT                   = 0x00000008,    // 03 Taken damage from melee auto attack hit

        PROC_FLAG_SUCCESSFUL_MELEE_SPELL_HIT        = 0x00000010,    // 04 Successful attack by Spell that use melee weapon
        PROC_FLAG_TAKEN_MELEE_SPELL_HIT             = 0x00000020,    // 05 Taken damage by Spell that use melee weapon

        PROC_FLAG_SUCCESSFUL_RANGED_HIT             = 0x00000040,    // 06 Successful Ranged auto attack
        PROC_FLAG_TAKEN_RANGED_HIT                  = 0x00000080,    // 07 Taken damage from ranged auto attack

        PROC_FLAG_SUCCESSFUL_RANGED_SPELL_HIT       = 0x00000100,    // 08 Successful Ranged attack by Spell that use ranged weapon
        PROC_FLAG_TAKEN_RANGED_SPELL_HIT            = 0x00000200,    // 09 Taken damage by Spell that use ranged weapon

        PROC_FLAG_SUCCESSFUL_POSITIVE_AOE_HIT       = 0x00000400,    // 10 Successful AoE (not 100% sure unused)
        PROC_FLAG_TAKEN_POSITIVE_AOE                = 0x00000800,    // 11 Taken AoE      (not 100% sure unused)

        PROC_FLAG_SUCCESSFUL_AOE_SPELL_HIT          = 0x00001000,    // 12 Successful AoE damage spell hit (not 100% sure unused)
        PROC_FLAG_TAKEN_AOE_SPELL_HIT               = 0x00002000,    // 13 Taken AoE damage spell hit      (not 100% sure unused)

        PROC_FLAG_SUCCESSFUL_POSITIVE_SPELL         = 0x00004000,    // 14 Successful cast positive spell (by default only on healing)
        PROC_FLAG_TAKEN_POSITIVE_SPELL              = 0x00008000,    // 15 Taken positive spell hit (by default only on healing)

        PROC_FLAG_SUCCESSFUL_NEGATIVE_SPELL_HIT     = 0x00010000,    // 16 Successful negative spell cast (by default only on damage)
        PROC_FLAG_TAKEN_NEGATIVE_SPELL_HIT          = 0x00020000,    // 17 Taken negative spell (by default only on damage)

        PROC_FLAG_ON_DO_PERIODIC                    = 0x00040000,    // 18 Successful do periodic (damage / healing, determined from 14-17 flags)
        PROC_FLAG_ON_TAKE_PERIODIC                  = 0x00080000,    // 19 Taken spell periodic (damage / healing, determined from 14-17 flags)

        PROC_FLAG_TAKEN_ANY_DAMAGE                  = 0x00100000,    // 20 Taken any damage
        PROC_FLAG_ON_TRAP_ACTIVATION                = 0x00200000,    // 21 On trap activation

        PROC_FLAG_TAKEN_OFFHAND_HIT                 = 0x00400000,    // 22 Taken off-hand melee attacks(not used)
        PROC_FLAG_SUCCESSFUL_OFFHAND_HIT            = 0x00800000,    // 23 Successful off-hand melee attacks
        PROC_FLAG_DEATH                             = 0x01000000,    // 24 Died in any way

        // Custom proc flag system (must be used for write proc-like effects over procsystem)
        PROC_FLAG_ON_AURA_APPLY                     = 0x04000000,    // 26 On apply aura (require SpellClassMask and custom proc ex flags)
        PROC_FLAG_ON_AURA_FADE                      = 0x08000000     // 27 On fade aura  (require SpellClassMask and custom proc ex flags)
    };

    [Flags]
    public enum ProcFlagsEx
    {
        PROC_EX_NONE                    = 0x0000000,                 // If none can trigger on Hit/Crit only (passive spells MUST defined by SpellFamily flag)

        PROC_EX_NORMAL_HIT              = 0x0000001,                 // If set only from normal hit (only damage spells)
        PROC_EX_CRITICAL_HIT            = 0x0000002,

        PROC_EX_MISS                    = 0x0000004,
        PROC_EX_RESIST                  = 0x0000008,

        PROC_EX_DODGE                   = 0x0000010,
        PROC_EX_PARRY                   = 0x0000020,

        PROC_EX_BLOCK                   = 0x0000040,
        PROC_EX_EVADE                   = 0x0000080,

        PROC_EX_IMMUNE                  = 0x0000100,
        PROC_EX_DEFLECT                 = 0x0000200,

        PROC_EX_ABSORB                  = 0x0000400,
        PROC_EX_REFLECT                 = 0x0000800,

        PROC_EX_INTERRUPT               = 0x0001000,                 // Melee hit result can be Interrupt (not used)
        PROC_EX_FULL_BLOCK              = 0x0002000,                 // block al attack damage

        PROC_EX_RESERVED2               = 0x0004000,
        PROC_EX_RESERVED3               = 0x0008000,

        PROC_EX_EX_TRIGGER_ALWAYS       = 0x0010000,                 // If set trigger always ( no matter another flags) used for drop charges
        PROC_EX_EX_ONE_TIME_TRIGGER     = 0x0020000,                 // If set trigger always but only one time (not used)
        PROC_EX_PERIODIC_POSITIVE       = 0x0040000,                 // For periodic heal
        PROC_EX_CAST_END                = 0x0080000,                 // procs on end of cast

        // Custom proc ex flag system
        PROC_EX_DIRECT_DAMAGE           = 0x0100000,                // do not proc from absorbed damage
        PROC_EX_SHIELD_BREAK            = 0x0200000,                // proc at remove aura by shield break
        PROC_EX_DISPEL                  = 0x0400000,                // proc at remove aura by dispel
        PROC_EX_EXPIRE                  = 0x0800000,                // proc at remove aura by expire
        PROC_EX_IGNORE_CC               = 0x1000000,                // proc result ignore possible CC limitations
    };

    public enum SpellSchools
    {
        PHYSICAL   = 0,
        HOLY       = 1,
        FIRE       = 2,
        NATURE     = 3,
        FROST      = 4,
        SHADOW     = 5,
        ARCANE     = 6
    };

    [Flags]
    public enum SpellSchoolMask
    {
        MASK_NONE      = 0x00,                         // not exist
        MASK_PHYSICAL  = (1 << SpellSchools.PHYSICAL), // PHYSICAL (Armor)
        MASK_HOLY      = (1 << SpellSchools.HOLY),
        MASK_FIRE      = (1 << SpellSchools.FIRE),
        MASK_NATURE    = (1 << SpellSchools.NATURE),
        MASK_FROST     = (1 << SpellSchools.FROST),
        MASK_SHADOW    = (1 << SpellSchools.SHADOW),
        MASK_ARCANE    = (1 << SpellSchools.ARCANE),

        // unions

        // 124, not include normal and holy damage
        MASK_SPELL     = (MASK_FIRE | MASK_NATURE | MASK_FROST | MASK_SHADOW | MASK_ARCANE),
        // 126
        MASK_MAGIC     = (MASK_HOLY | MASK_SPELL),
        // 127
        MASK_ALL       = (MASK_PHYSICAL | MASK_MAGIC)
    };

    public enum Mechanics
    {
        MECHANIC_NONE               = 0,
        MECHANIC_CHARM              = 1,
        MECHANIC_DISORIENTED        = 2,
        MECHANIC_DISARM             = 3,
        MECHANIC_DISTRACT           = 4,
        MECHANIC_FEAR               = 5,
        MECHANIC_GRIP               = 6,
        MECHANIC_ROOT               = 7,
        MECHANIC_SLOWATTACK         = 8,  //0 spells use this mechanic, but some SPELL_AURA_MOD_HASTE and SPELL_AURA_MOD_RANGED_HASTE use as effect mechanic
        MECHANIC_SILENCE            = 9,
        MECHANIC_SLEEP              = 10,
        MECHANIC_SNARE              = 11,
        MECHANIC_STUN               = 12,
        MECHANIC_FREEZE             = 13,
        MECHANIC_KNOCKOUT           = 14,
        MECHANIC_BLEED              = 15,
        MECHANIC_BANDAGE            = 16,
        MECHANIC_POLYMORPH          = 17,
        MECHANIC_BANISH             = 18,
        MECHANIC_SHIELD             = 19,
        MECHANIC_SHACKLE            = 20,
        MECHANIC_MOUNT              = 21,
        MECHANIC_INFECTED           = 22,
        MECHANIC_TURN               = 23,
        MECHANIC_HORROR             = 24,
        MECHANIC_INVULNERABILITY    = 25,
        MECHANIC_INTERRUPT          = 26,
        MECHANIC_DAZE               = 27,
        MECHANIC_DISCOVERY          = 28,
        MECHANIC_IMMUNE_SHIELD      = 29,  // Divine (Blessing) Shield/Protection and Ice Block
        MECHANIC_SAPPED             = 30,
        MECHANIC_ENRAGED            = 31
    };

    public enum SpellMissInfo
    {
        SPELL_MISS_NONE     = 0,
        SPELL_MISS_MISS     = 1,
        SPELL_MISS_RESIST   = 2,
        SPELL_MISS_DODGE    = 3,
        SPELL_MISS_PARRY    = 4,
        SPELL_MISS_BLOCK    = 5,
        SPELL_MISS_EVADE    = 6,
        SPELL_MISS_IMMUNE   = 7,
        SPELL_MISS_IMMUNE2  = 8,
        SPELL_MISS_DEFLECT  = 9,
        SPELL_MISS_ABSORB   = 10,
        SPELL_MISS_REFLECT  = 11
    };

    [Flags]
    public enum SpellHitType
    {
        SPELL_HIT_TYPE_UNK1 = 0x00001,
        SPELL_HIT_TYPE_CRIT = 0x00002,
        SPELL_HIT_TYPE_UNK3 = 0x00004,
        SPELL_HIT_TYPE_UNK4 = 0x00008,
        SPELL_HIT_TYPE_UNK5 = 0x00010,                          // replace caster?
        SPELL_HIT_TYPE_UNK6 = 0x00020
    };

    public enum SpellDmgClass
    {
        SPELL_DAMAGE_CLASS_NONE   = 0,
        SPELL_DAMAGE_CLASS_MAGIC  = 1,
        SPELL_DAMAGE_CLASS_MELEE  = 2,
        SPELL_DAMAGE_CLASS_RANGED = 3
    };

    public enum SpellPreventionType
    {
        SPELL_PREVENTION_TYPE_NONE    = 0,
        SPELL_PREVENTION_TYPE_SILENCE = 1,
        SPELL_PREVENTION_TYPE_PACIFY  = 2
    };

    [Flags]
    public enum ShapeshiftFormMask
    {
        FORM_ALL                = -1,
        FORM_NONE               = 0,
        FORM_CAT                = 1 << 0x00,    // 1
        FORM_TREE               = 1 << 0x01,    // 2
        FORM_TRAVEL             = 1 << 0x02,    // 3
        FORM_AQUA               = 1 << 0x03,    // 4
        FORM_BEAR               = 1 << 0x04,    // 5
        FORM_AMBIENT            = 1 << 0x05,    // 6
        FORM_GHOUL              = 1 << 0x06,    // 7
        FORM_DIREBEAR           = 1 << 0x07,    // 8
        FORM_STEVES_GHOUL       = 1 << 0x08,    // 9
        FORM_THARONJA_SKELETON  = 1 << 0x09,    // 10
        FORM_TEST_OF_STRENGTH   = 1 << 0x0A,    // 11
        FORM_BLB_PLAYER         = 1 << 0x0B,    // 12
        FORM_SHADOW_DANCE       = 1 << 0x0C,    // 13
        FORM_CREATUREBEAR       = 1 << 0x0D,    // 14
        FORM_CREATURECAT        = 1 << 0x0E,    // 15
        FORM_GHOSTWOLF          = 1 << 0x0F,    // 16
        FORM_BATTLESTANCE       = 1 << 0x10,    // 17
        FORM_DEFENSIVESTANCE    = 1 << 0x11,    // 18
        FORM_BERSERKERSTANCE    = 1 << 0x12,    // 19
        FORM_TEST               = 1 << 0x13,    // 20
        FORM_ZOMBIE             = 1 << 0x14,    // 21
        FORM_METAMORPHOSIS      = 1 << 0x15,    // 22
        FORM_UNK1               = 1 << 0x16,    // 23
        FORM_UNK2               = 1 << 0x17,    // 24
        FORM_UNDEAD             = 1 << 0x18,    // 25
        FORM_FRENZY             = 1 << 0x19,    // 26
        FORM_FLIGHT_EPIC        = 1 << 0x1A,    // 27
        FORM_SHADOW             = 1 << 0x1B,    // 28
        FORM_FLIGHT             = 1 << 0x1C,    // 29
        FORM_STEALTH            = 1 << 0x1D,    // 30
        FORM_MOONKIN            = 1 << 0x1E,    // 31
        FORM_SPIRITOFREDEMPTION = 1 << 0x1F,    // 32
    };

    public enum DispelType
    {
        DISPEL_NONE         = 0,
        DISPEL_MAGIC        = 1,
        DISPEL_CURSE        = 2,
        DISPEL_DISEASE      = 3,
        DISPEL_POISON       = 4,
        DISPEL_STEALTH      = 5,
        DISPEL_INVISIBILITY = 6,
        DISPEL_ALL          = 7,
        DISPEL_SPE_NPC_ONLY = 8,
        DISPEL_ENRAGE       = 9,
        DISPEL_ZG_TICKET    = 10,
        DESPEL_OLD_UNUSED   = 11
    };

    public enum SpellModOp
    {
        SPELLMOD_DAMAGE                 = 0,
        SPELLMOD_DURATION               = 1,
        SPELLMOD_THREAT                 = 2,
        SPELLMOD_EFFECT1                = 3,
        SPELLMOD_CHARGES                = 4,
        SPELLMOD_RANGE                  = 5,
        SPELLMOD_RADIUS                 = 6,
        SPELLMOD_CRITICAL_CHANCE        = 7,
        SPELLMOD_ALL_EFFECTS            = 8,
        SPELLMOD_NOT_LOSE_CASTING_TIME  = 9,
        SPELLMOD_CASTING_TIME           = 10,
        SPELLMOD_COOLDOWN               = 11,
        SPELLMOD_EFFECT2                = 12,
        // spellmod 13 unused
        SPELLMOD_COST                   = 14,
        SPELLMOD_CRIT_DAMAGE_BONUS      = 15,
        SPELLMOD_RESIST_MISS_CHANCE     = 16,
        SPELLMOD_JUMP_TARGETS           = 17,
        SPELLMOD_CHANCE_OF_SUCCESS      = 18,  // Only used with SPELL_AURA_ADD_FLAT_MODIFIER and affects proc spells
        SPELLMOD_ACTIVATION_TIME        = 19,
        SPELLMOD_EFFECT_PAST_FIRST      = 20,
        SPELLMOD_GLOBAL_COOLDOWN        = 21,
        SPELLMOD_DOT                    = 22,
        SPELLMOD_EFFECT3                = 23,
        SPELLMOD_SPELL_BONUS_DAMAGE     = 24,
        // spellmod 25 unused
        SPELLMOD_FREQUENCY_OF_SUCCESS   = 26,  // Only used with SPELL_AURA_ADD_PCT_MODIFIER and affects used on proc spells
        SPELLMOD_MULTIPLE_VALUE         = 27,
        SPELLMOD_RESIST_DISPEL_CHANCE   = 28,
        SPELLMOD_UNK29                  = 29,  // used by single test spell 45365
        SPELLMOD_COST_ON_HIT_FAIL       = 30,
    };

    [Flags]
    public enum SpellCastTargetFlags
    {
        TARGET_FLAG_SELF            = 0x00000000,
        TARGET_FLAG_UNUSED1         = 0x00000001,               // not used in any spells as of 3.0.3 (can be set dynamically)
        TARGET_FLAG_UNIT            = 0x00000002,               // pguid
        TARGET_FLAG_UNUSED2         = 0x00000004,               // not used in any spells as of 3.0.3 (can be set dynamically)
        TARGET_FLAG_UNUSED3         = 0x00000008,               // not used in any spells as of 3.0.3 (can be set dynamically)
        TARGET_FLAG_ITEM            = 0x00000010,               // pguid
        TARGET_FLAG_SOURCE_LOCATION = 0x00000020,               // 3 float
        TARGET_FLAG_DEST_LOCATION   = 0x00000040,               // 3 float
        TARGET_FLAG_OBJECT_UNK      = 0x00000080,               // used in 7 spells only
        TARGET_FLAG_UNIT_UNK        = 0x00000100,               // looks like self target (480 spells)
        TARGET_FLAG_PVP_CORPSE      = 0x00000200,               // pguid
        TARGET_FLAG_UNIT_CORPSE     = 0x00000400,               // 10 spells (gathering professions)
        TARGET_FLAG_OBJECT          = 0x00000800,               // pguid, 2 spells
        TARGET_FLAG_TRADE_ITEM      = 0x00001000,               // pguid, 0 spells
        TARGET_FLAG_STRING          = 0x00002000,               // string, 0 spells
        TARGET_FLAG_UNK1            = 0x00004000,               // 199 spells, opening object/lock
        TARGET_FLAG_CORPSE          = 0x00008000,               // pguid, resurrection spells
        TARGET_FLAG_UNK2            = 0x00010000,               // pguid, not used in any spells as of 3.0.3 (can be set dynamically)
        TARGET_FLAG_GLYPH           = 0x00020000,               // used in glyph spells
        TARGET_FLAG_UNK3            = 0x00040000,               // 
        TARGET_FLAG_VISUAL_CHAIN    = 0x00080000                // uint32, loop { vec3, guid -> if guid == 0 break }
    };

    public enum Powers : uint
    {
        POWER_MANA          = 0,
        POWER_RAGE          = 1,
        POWER_FOCUS         = 2,
        POWER_ENERGY        = 3,
        POWER_HAPPINESS     = 4,
        POWER_RUNE          = 5,
        POWER_RUNIC_POWER   = 6,
        POWER_HEALTH        = 0xFFFFFFFE,    // (-2 as signed value)
    };

    public enum AuraState
    {   // (C) used in caster aura state     (T) used in target aura state
        // (c) used in caster aura state-not (t) used in target aura state-not
        AURA_STATE_NONE                     = 0,
        AURA_STATE_DEFENSE                  = 1,            // C   |
        AURA_STATE_HEALTHLESS_20_PERCENT    = 2,            // CcT |
        AURA_STATE_BERSERKING               = 3,            // C T |
        AURA_STATE_FROZEN                   = 4,            //  c t| frozen target
        AURA_STATE_JUDGEMENT                = 5,            // C   |
        AURA_STATE_UNKNOWN6                 = 6,            //     | not used
        AURA_STATE_HUNTER_PARRY             = 7,            // C   |
        //AURA_STATE_ROGUE_ATTACK_FROM_STEALTH    = 7,      // C   | FIX ME: not implemented yet!
        //AURA_STATE_UNKNOWN7                     = 7,      //  c  | random/focused bursts spells (?)
        AURA_STATE_UNKNOWN8                 = 8,            //     | not used
        AURA_STATE_UNKNOWN9                 = 9,            //     | not used
        AURA_STATE_WARRIOR_VICTORY_RUSH     = 10,           // C   | warrior victory rush
        AURA_STATE_UNKNOWN11                = 11,           //    t|
        AURA_STATE_FAERIE_FIRE              = 12,           //  c t| prevent invisibility
        AURA_STATE_HEALTHLESS_35_PERCENT    = 13,           // C T |
        AURA_STATE_CONFLAGRATE              = 14,           //   T | per-caster
        AURA_STATE_SWIFTMEND                = 15,           //   T |
        AURA_STATE_DEADLY_POISON            = 16,           //   T |
        AURA_STATE_ENRAGE                   = 17,           // C   |
        AURA_STATE_BLEEDING                 = 18,           // C  t|
        AURA_STATE_DARK_TARGET              = 19,           //     |
        AURA_STATE_SUICIDE                  = 20,           //  c  | only (45317 Suicide)
        AURA_STATE_SPELLFIRE                = 21,           //     | not used
        AURA_STATE_LIGHT_TARGET             = 22,           // C  t| not implemented yet (Requires Evasive Charges to use)
        AURA_STATE_HEALTH_ABOVE_75_PERCENT  = 23            // C   |
    };

    [Flags]
    enum InventoryTypeMask
    {
        ALL             = -1,
        NON_EQUIP       = 1 << 0,
        HEAD            = 1 << 1,
        NECK            = 1 << 2,
        SHOULDERS       = 1 << 3,
        BODY            = 1 << 4,
        CHEST           = 1 << 5,
        WAIST           = 1 << 6,
        LEGS            = 1 << 7,
        FEET            = 1 << 8,
        WRISTS          = 1 << 9,
        HANDS           = 1 << 10,
        FINGER          = 1 << 11,
        TRINKET         = 1 << 12,
        WEAPON          = 1 << 13,
        SHIELD          = 1 << 14,
        RANGED          = 1 << 15,
        CLOAK           = 1 << 16,
        WEAPON_2H       = 1 << 17,
        BAG             = 1 << 18,
        TABARD          = 1 << 19,
        ROBE            = 1 << 20,
        WEAPONMAINHAND  = 1 << 21,
        WEAPONOFFHAND   = 1 << 22,
        HOLDABLE        = 1 << 23,
        AMMO            = 1 << 24,
        THROWN          = 1 << 25,
        RANGEDRIGHT     = 1 << 26,
        QUIVER          = 1 << 27,
        RELIC           = 1 << 28,
    };

    public enum ItemClass
    {
        CONSUMABLE  = 0,
        CONTAINER   = 1,
        WEAPON      = 2,
        GEM         = 3,
        ARMOR       = 4,
        REAGENT     = 5,
        PROJECTILE  = 6,
        TRADE_GOODS = 7,
        GENERIC     = 8,
        RECIPE      = 9,
        MONEY       = 10,
        QUIVER      = 11,
        QUEST       = 12,
        KEY         = 13,
        PERMANENT   = 14,
        MISC        = 15,
        GLYPH       = 16,
        MAX
    };

    [Flags]
    public enum ItemSubClassWeaponMask
    {
        ALL             = -1,
        AXE             = 1 << 0,
        AXE2            = 1 << 1,
        BOW             = 1 << 2,
        GUN             = 1 << 3,
        MACE            = 1 << 4,
        MACE2           = 1 << 5,
        POLEARM         = 1 << 6,
        SWORD           = 1 << 7,
        SWORD2          = 1 << 8,
        obsolete        = 1 << 9,
        STAFF           = 1 << 10,
        EXOTIC          = 1 << 11,
        EXOTIC2         = 1 << 12,
        FIST            = 1 << 13,
        MISC            = 1 << 14,
        DAGGER          = 1 << 15,
        THROWN          = 1 << 16,
        SPEAR           = 1 << 17,
        CROSSBOW        = 1 << 18,
        WAND            = 1 << 19,
        FISHING_POLE    = 1 << 20
    };

    [Flags]
    public enum ItemSubClassArmorMask
    {
        ALL     = -1,
        MISC    = 1 << 0,
        CLOTH   = 1 << 1,
        LEATHER = 1 << 2,
        MAIL    = 1 << 3,
        PLATE   = 1 << 4,
        BUCKLER = 1 << 5,
        SHIELD  = 1 << 6,
        LIBRAM  = 1 << 7,
        IDOL    = 1 << 8,
        TOTEM   = 1 << 9,
        SIGIL   = 1 << 10
    };

    [Flags]
    public enum ItemSubClassMiscMask
    {
        ALL     = -1,
        JUNK    = 1 << 0,
        REAGENT = 1 << 1,
        PET     = 1 << 2,
        HOLIDAY = 1 << 3,
        OTHER   = 1 << 4,
        MOUNT   = 1 << 5,
    }

    [Flags]
    public enum CreatureTypeMask
    {
        ALL             = -1,
        NONE            = 0,
        BEAST           = 1 << 0,
        DRAGONKIN       = 1 << 1,
        DEMON           = 1 << 2,
        ELEMENTAL       = 1 << 3,
        GIANT           = 1 << 4,
        UNDEAD          = 1 << 5,
        HUMANOID        = 1 << 6,
        CRITTER         = 1 << 7,
        MECHANICAL      = 1 << 8,
        NOT_SPECIFIED   = 1 << 9,
        TOTEM           = 1 << 10,
        NON_COMBAT_PET  = 1 << 11,
        GAS_CLOUD       = 1 << 12
    };
    
    [Flags]
    public enum SpellAtribute 
    {
        SPELL_ATTR_ALL                             =         -1,
        SPELL_ATTR_NONE                            =       0x00,
        SPELL_ATTR_UNK0                            = 0x00000001,            // 0
        SPELL_ATTR_RANGED                          = 0x00000002,            // 1 All ranged abilites have this flag
        SPELL_ATTR_ON_NEXT_SWING_1                 = 0x00000004,            // 2 on next swing
        SPELL_ATTR_UNK3                            = 0x00000008,            // 3 not set in 3.0.3
        SPELL_ATTR_ABILITY                         = 0x00000010,            // 4 client puts 'ability' instead of 'spell' in game strings for these spells
        SPELL_ATTR_TRADESPELL                      = 0x00000020,            // 5 trade spells, will be added by client to a sublist of profession spell
        SPELL_ATTR_PASSIVE                         = 0x00000040,            // 6 Passive spell
        SPELL_ATTR_HIDDEN_CLIENTSIDE               = 0x00000080,            // 7 Spells with this attribute are not visible in spellbook or aura bar
        SPELL_ATTR_HIDE_IN_COMBAT_LOG              = 0x00000100,            // 8 This attribite controls whether spell appears in combat logs
        SPELL_ATTR_TARGET_MAINHAND_ITEM            = 0x00000200,            // 9 Client automatically selects item from mainhand slot as a cast target
        SPELL_ATTR_ON_NEXT_SWING_2                 = 0x00000400,            // 10 on next swing 2
        SPELL_ATTR_UNK11                           = 0x00000800,            // 11
        SPELL_ATTR_DAYTIME_ONLY                    = 0x00001000,            // 12 only useable at daytime, not set in 2.4.2
        SPELL_ATTR_NIGHT_ONLY                      = 0x00002000,            // 13 only useable at night, not set in 2.4.2
        SPELL_ATTR_INDOORS_ONLY                    = 0x00004000,            // 14 only useable indoors, not set in 2.4.2
        SPELL_ATTR_OUTDOORS_ONLY                   = 0x00008000,            // 15 Only useable outdoors.
        SPELL_ATTR_NOT_SHAPESHIFT                  = 0x00010000,            // 16 Not while shapeshifted
        SPELL_ATTR_ONLY_STEALTHED                  = 0x00020000,            // 17 Must be in stealth
        SPELL_ATTR_UNK18                           = 0x00040000,            // 18
        SPELL_ATTR_LEVEL_DAMAGE_CALCULATION        = 0x00080000,            // 19 spelldamage depends on caster level
        SPELL_ATTR_STOP_ATTACK_TARGET              = 0x00100000,            // 20 Stop attack after use this spell (and not begin attack if use)
        SPELL_ATTR_IMPOSSIBLE_DODGE_PARRY_BLOCK    = 0x00200000,            // 21 Cannot be dodged/parried/blocked
        SPELL_ATTR_SET_TRACKING_TARGET             = 0x00400000,            // 22 SetTrackingTarget
        SPELL_ATTR_UNK23                           = 0x00800000,            // 23 castable while dead?
        SPELL_ATTR_CASTABLE_WHILE_MOUNTED          = 0x01000000,            // 24 castable while mounted
        SPELL_ATTR_DISABLED_WHILE_ACTIVE           = 0x02000000,            // 25 Activate and start cooldown after aura fade or remove summoned creature or go
        SPELL_ATTR_UNK26                           = 0x04000000,            // 26
        SPELL_ATTR_CASTABLE_WHILE_SITTING          = 0x08000000,            // 27 castable while sitting
        SPELL_ATTR_CANT_USED_IN_COMBAT             = 0x10000000,            // 28 Cannot be used in combat
        SPELL_ATTR_UNAFFECTED_BY_INVULNERABILITY   = 0x20000000,            // 29 unaffected by invulnerability (hmm possible not...)
        SPELL_ATTR_BREAKABLE_BY_DAMAGE             = 0x40000000,            // 30 breakable by damage?
        SPELL_ATTR_CANT_CANCEL                     = 1 << 31                // 31 positive aura can't be canceled

    };

    [Flags]
    public enum SpellAtributeEx
    {
        SPELL_ATTR_EX_ALL                          =         -1,
        SPELL_ATTR_EX_NONE                         =       0x00,
        SPELL_ATTR_EX_UNK0                         = 0x00000001,            // 0
        SPELL_ATTR_EX_DRAIN_ALL_POWER              = 0x00000002,            // 1 use all power (Only paladin Lay of Hands and Bunyanize)
        SPELL_ATTR_EX_CHANNELED_1                  = 0x00000004,            // 2 channeled 1
        SPELL_ATTR_EX_CANT_REFLECTED               = 0x00000008,            // 3 used for detect can or not spell reflected
        SPELL_ATTR_EX_UNK4                         = 0x00000010,            // 4
        SPELL_ATTR_EX_NOT_BREAK_STEALTH            = 0x00000020,            // 5 Not break stealth
        SPELL_ATTR_EX_CHANNELED_2                  = 0x00000040,            // 6 channeled 2
        SPELL_ATTR_EX_NEGATIVE                     = 0x00000080,            // 7
        SPELL_ATTR_EX_NOT_IN_COMBAT_TARGET         = 0x00000100,            // 8 Spell req target not to be in combat state
        SPELL_ATTR_EX_UNK9                         = 0x00000200,            // 9
        SPELL_ATTR_EX_NO_THREAT                    = 0x00000400,            // 10 no generates threat on cast 100%
        SPELL_ATTR_EX_UNK11                        = 0x00000800,            // 11
        SPELL_ATTR_EX_UNK12                        = 0x00001000,            // 12
        SPELL_ATTR_EX_FARSIGHT                     = 0x00002000,            // 13
        SPELL_ATTR_EX_CHANNEL_TRACKING_TARGET      = 0x00004000,            // 14
        SPELL_ATTR_EX_DISPEL_AURAS_ON_IMMUNITY     = 0x00008000,            // 15 remove auras on immunity
        SPELL_ATTR_EX_UNAFFECTED_BY_SCHOOL_IMMUNE  = 0x00010000,            // 16 unaffected by school immunity
        SPELL_ATTR_EX_UNK17                        = 0x00020000,            // 17 for auras SPELL_AURA_TRACK_CREATURES, SPELL_AURA_TRACK_RESOURCES and SPELL_AURA_TRACK_STEALTHED select non-stacking tracking spells
        SPELL_ATTR_EX_BREAKABLE_BY_ANY_DAMAGE      = 0x00040000,            // 18 auras with this attribute breaked by any damage (not CrowdControl auras)
        SPELL_ATTR_EX_UNK19                        = 0x00080000,            // 19
        SPELL_ATTR_EX_REQ_TARGET_COMBO_POINTS      = 0x00100000,            // 20 Req combo points on target
        SPELL_ATTR_EX_UNK21                        = 0x00200000,            // 21
        SPELL_ATTR_EX_REQ_COMBO_POINTS             = 0x00400000,            // 22 Use combo points (in 4.x not required combo point target selected)
        SPELL_ATTR_EX_UNK23                        = 0x00800000,            // 23
        SPELL_ATTR_EX_UNK24                        = 0x01000000,            // 24 Req fishing pole??
        SPELL_ATTR_EX_UNK25                        = 0x02000000,            // 25
        SPELL_ATTR_EX_UNK26                        = 0x04000000,            // 26
        SPELL_ATTR_EX_UNK27                        = 0x08000000,            // 27
        SPELL_ATTR_EX_HIDDEN_AURA                  = 0x10000000,            // 28 client doesn't display these spells in aura bar (special and server-side spells)
        SPELL_ATTR_EX_CHANNEL_DISPLAY_SPELL_NAME   = 0x20000000,            // 29 spell name is displayed in cast bar instead of 'channeling' text
        SPELL_ATTR_EX_UNK30                        = 0x40000000,            // 30 overpower
        SPELL_ATTR_EX_UNK31                        = 1 << 31                // 31

    };

    [Flags]
    public enum SpellAtributeEx2
    {
        SPELL_ATTR_EX2_ALL                         =         -1,
        SPELL_ATTR_EX2_NONE                        =       0x00,
        SPELL_ATTR_EX2_ALLOW_DEAD_TARGET           = 0x00000001,            // 0
        SPELL_ATTR_EX2_UNK1                        = 0x00000002,            // 1
        SPELL_ATTR_EX2_IGNORE_LOS                  = 0x00000004,            // 2 do not need LOS (e.g. 18220 since 3.3.3)
        SPELL_ATTR_EX2_UNK3                        = 0x00000008,            // 3 auto targeting? (e.g. fishing skill enhancement items since 3.3.3)
        SPELL_ATTR_EX2_UNK4                        = 0x00000010,            // 4
        SPELL_ATTR_EX2_AUTOREPEAT_FLAG             = 0x00000020,            // 5
        SPELL_ATTR_EX2_UNK6                        = 0x00000040,            // 6 only usable on tabbed by yourself
        SPELL_ATTR_EX2_UNK7                        = 0x00000080,            // 7
        SPELL_ATTR_EX2_UNK8                        = 0x00000100,            // 8 not set in 3.0.3
        SPELL_ATTR_EX2_UNK9                        = 0x00000200,            // 9
        SPELL_ATTR_EX2_UNK10                       = 0x00000400,            // 10
        SPELL_ATTR_EX2_HEALTH_FUNNEL               = 0x00000800,            // 11
        SPELL_ATTR_EX2_UNK12                       = 0x00001000,            // 12
        SPELL_ATTR_EX2_UNK13                       = 0x00002000,            // 13
        SPELL_ATTR_EX2_UNK14                       = 0x00004000,            // 14
        SPELL_ATTR_EX2_UNK15                       = 0x00008000,            // 15 not set in 3.0.3
        SPELL_ATTR_EX2_UNK16                       = 0x00010000,            // 16
        SPELL_ATTR_EX2_NOT_RESET_AUTOSHOT          = 0x00020000,            // 17 Hunters Shot and Stings only have this flag
        SPELL_ATTR_EX2_UNK18                       = 0x00040000,            // 18 Only Revive pet - possible req dead pet
        SPELL_ATTR_EX2_NOT_NEED_SHAPESHIFT         = 0x00080000,            // 19 does not necessarly need shapeshift
        SPELL_ATTR_EX2_UNK20                       = 0x00100000,            // 20
        SPELL_ATTR_EX2_DAMAGE_REDUCED_SHIELD       = 0x00200000,            // 21 for ice blocks, pala immunity buffs, priest absorb shields, but used also for other spells -> not sure!
        SPELL_ATTR_EX2_UNK22                       = 0x00400000,            // 22
        SPELL_ATTR_EX2_UNK23                       = 0x00800000,            // 23 Only mage Arcane Concentration have this flag
        SPELL_ATTR_EX2_UNK24                       = 0x01000000,            // 24
        SPELL_ATTR_EX2_UNK25                       = 0x02000000,            // 25
        SPELL_ATTR_EX2_UNK26                       = 0x04000000,            // 26 unaffected by school immunity
        SPELL_ATTR_EX2_UNK27                       = 0x08000000,            // 27
        SPELL_ATTR_EX2_UNK28                       = 0x10000000,            // 28 no breaks stealth if it fails??
        SPELL_ATTR_EX2_CANT_CRIT                   = 0x20000000,            // 29 Spell can't crit
        SPELL_ATTR_EX2_UNK30                       = 0x40000000,            // 30
        SPELL_ATTR_EX2_FOOD_BUFF                   = 1 << 31                // 31 Food or Drink Buff (like Well Fed)

    };

    [Flags]
    public enum SpellAtributeEx3
    {
        SPELL_ATTR_EX3_ALL                         =         -1,
        SPELL_ATTR_EX3_NONE                        =       0x00,
        SPELL_ATTR_EX3_UNK0                        = 0x00000001,            // 0
        SPELL_ATTR_EX3_UNK1                        = 0x00000002,            // 1
        SPELL_ATTR_EX3_UNK2                        = 0x00000004,            // 2
        SPELL_ATTR_EX3_MELEE                       = 0x00000008,            // 3
        SPELL_ATTR_EX3_IGNORE_RESURRECTION_TIMER   = 0x00000010,            // 4 you don't have to wait to be resurrected with these spells
        SPELL_ATTR_EX3_UNK5                        = 0x00000020,            // 5
        SPELL_ATTR_EX3_UNK6                        = 0x00000040,            // 6
        SPELL_ATTR_EX3_STACK_FOR_DIFF_CASTERS      = 0x00000080,            // 7 create a separate (de)buff stack for each caster
        SPELL_ATTR_EX3_TARGET_ONLY_PLAYER          = 0x00000100,            // 8 Can target only player
        SPELL_ATTR_EX3_UNK9                        = 0x00000200,            // 9
        SPELL_ATTR_EX3_MAIN_HAND                   = 0x00000400,            // 10 Main hand weapon required
        SPELL_ATTR_EX3_BATTLEGROUND                = 0x00000800,            // 11 Can casted only on battleground
        SPELL_ATTR_EX3_CAST_ON_DEAD                = 0x00001000,            // 12 target is a dead player (not every spell has this flag)
        SPELL_ATTR_EX3_UNK13                       = 0x00002000,            // 13
        SPELL_ATTR_EX3_UNK14                       = 0x00004000,            // 14 "Honorless Target" only this spells have this flag
        SPELL_ATTR_EX3_UNK15                       = 0x00008000,            // 15 Auto Shoot, Shoot, Throw,  - this is autoshot flag
        SPELL_ATTR_EX3_CANT_TRIGGER_PROC           = 0x00010000,            // 16 no triggers effects that trigger on casting a spell??
        SPELL_ATTR_EX3_NO_INITIAL_AGGRO            = 0x00020000,            // 17 Causes no aggro if not missed
        SPELL_ATTR_EX3_CANT_MISS                   = 0x00040000,            // 18 Spell should always hit its target
        SPELL_ATTR_EX3_IMPROVER                    = 0x00080000,            // 19 only spells, that improve other spells
        SPELL_ATTR_EX3_DEATH_PERSISTENT            = 0x00100000,            // 20 Death persistent spells
        SPELL_ATTR_EX3_UNK21                       = 0x00200000,            // 21
        SPELL_ATTR_EX3_REQ_WAND                    = 0x00400000,            // 22 Req wand
        SPELL_ATTR_EX3_UNK23                       = 0x00800000,            // 23
        SPELL_ATTR_EX3_REQ_OFFHAND                 = 0x01000000,            // 24 Req offhand weapon
        SPELL_ATTR_EX3_UNK25                       = 0x02000000,            // 25 no cause spell pushback ?
        SPELL_ATTR_EX3_CAN_PROC_WITH_TRIGGERED     = 0x04000000,            // 26 auras with this attribute can proc from triggered spell casts (?)
        SPELL_ATTR_EX3_UNK27                       = 0x08000000,            // 27
        SPELL_ATTR_EX3_UNK28                       = 0x10000000,            // 28
        SPELL_ATTR_EX3_DISABLE_MODS                = 0x20000000,            // 29 Client doesn't apply spellmods for those spells (mostly mounting and like this spells)
        SPELL_ATTR_EX3_DONT_DISPLAY_RANGE          = 0x40000000,            // 30 client doesn't display range in tooltip for those spells
        SPELL_ATTR_EX3_UNK31                       = 1 << 31                // 31

    };

    [Flags]
    public enum SpellAtributeEx4
    {
        SPELL_ATTR_EX4_ALL                         =         -1,
        SPELL_ATTR_EX4_NONE                        =       0x00,
        SPELL_ATTR_EX4_IGNORE_RESISTANCES          = 0x00000001,            // 0 not may be resisted (in magic case) and have binary resistance method (in melee case).
        SPELL_ATTR_EX4_UNK1                        = 0x00000002,            // 1 proc on finishing move?
        SPELL_ATTR_EX4_UNK2                        = 0x00000004,            // 2
        SPELL_ATTR_EX4_UNK3                        = 0x00000008,            // 3
        SPELL_ATTR_EX4_UNK4                        = 0x00000010,            // 4 This will no longer cause guards to attack on use??
        SPELL_ATTR_EX4_UNK5                        = 0x00000020,            // 5
        SPELL_ATTR_EX4_NOT_STEALABLE               = 0x00000040,            // 6 although such auras might be dispellable, they cannot be stolen
        SPELL_ATTR_EX4_FORCE_TRIGGERED             = 0x00000080,            // 7 forced triggered?
        SPELL_ATTR_EX4_STACK_DOT_MODIFIER          = 0x00000100,            // 8 no effect on non DoTs?
        SPELL_ATTR_EX4_UNK9                        = 0x00000200,            // 9
        SPELL_ATTR_EX4_SPELL_VS_EXTEND_COST        = 0x00000400,            // 10 Rogue Shiv have this flag
        SPELL_ATTR_EX4_UNK11                       = 0x00000800,            // 11
        SPELL_ATTR_EX4_UNK12                       = 0x00001000,            // 12
        SPELL_ATTR_EX4_UNK13                       = 0x00002000,            // 13
        SPELL_ATTR_EX4_DAMAGE_DOESNT_BREAK_AURAS   = 0x00004000,            // 14 doesn't break auras by damage from these spells
        SPELL_ATTR_EX4_UNK15                       = 0x00008000,            // 15
        SPELL_ATTR_EX4_NOT_USABLE_IN_ARENA         = 0x00010000,            // 16 not usable in arena
        SPELL_ATTR_EX4_USABLE_IN_ARENA             = 0x00020000,            // 17 usable in arena
        SPELL_ATTR_EX4_UNK18                       = 0x00040000,            // 18
        SPELL_ATTR_EX4_UNK19                       = 0x00080000,            // 19
        SPELL_ATTR_EX4_UNK20                       = 0x00100000,            // 20 do not give "more powerful spell" error message
        SPELL_ATTR_EX4_UNK21                       = 0x00200000,            // 21
        SPELL_ATTR_EX4_UNK22                       = 0x00400000,            // 22
        SPELL_ATTR_EX4_UNK23                       = 0x00800000,            // 23
        SPELL_ATTR_EX4_UNK24                       = 0x01000000,            // 24
        SPELL_ATTR_EX4_PET_SCALING_AURA            = 0x02000000,            // 25 pet scaling auras
        SPELL_ATTR_EX4_CAST_ONLY_IN_OUTLAND        = 0x04000000,            // 26 Can only be used in Outland.
        SPELL_ATTR_EX4_UNK27                       = 0x08000000,            // 27
        SPELL_ATTR_EX4_UNK28                       = 0x10000000,            // 28
        SPELL_ATTR_EX4_UNK29                       = 0x20000000,            // 29
        SPELL_ATTR_EX4_UNK30                       = 0x40000000,            // 30
        SPELL_ATTR_EX4_UNK31                       = 1 << 31                // 31

    };

    [Flags]
    public enum SpellAtributeEx5
    {
        SPELL_ATTR_EX5_ALL                         =         -1,
        SPELL_ATTR_EX5_NONE                        =       0x00,
        SPELL_ATTR_EX5_UNK0                        = 0x00000001,            // 0
        SPELL_ATTR_EX5_NO_REAGENT_WHILE_PREP       = 0x00000002,            // 1 not need reagents if UNIT_FLAG_PREPARATION
        SPELL_ATTR_EX5_REMOVE_AT_ENTER_ARENA       = 0x00000004,            // 2 removed at enter arena (e.g. 31850 since 3.3.3)
        SPELL_ATTR_EX5_USABLE_WHILE_STUNNED        = 0x00000008,            // 3 usable while stunned
        SPELL_ATTR_EX5_UNK4                        = 0x00000010,            // 4
        SPELL_ATTR_EX5_SINGLE_TARGET_SPELL         = 0x00000020,            // 5 Only one target can be apply at a time
        SPELL_ATTR_EX5_UNK6                        = 0x00000040,            // 6
        SPELL_ATTR_EX5_UNK7                        = 0x00000080,            // 7
        SPELL_ATTR_EX5_UNK8                        = 0x00000100,            // 8
        SPELL_ATTR_EX5_START_PERIODIC_AT_APPLY     = 0x00000200,            // 9  begin periodic tick at aura apply
        SPELL_ATTR_EX5_NO_DURATION                 = 0x00000400,            // 10 not send duration to client
        SPELL_ATTR_EX5_UNK11                       = 0x00000800,            // 11
        SPELL_ATTR_EX5_UNK12                       = 0x00001000,            // 12
        SPELL_ATTR_EX5_AFFECTED_BY_HASTE           = 0x00002000,            // 13 haste affects duration (e.g. 8050 since 3.3.3)
        SPELL_ATTR_EX5_UNK14                       = 0x00004000,            // 14
        SPELL_ATTR_EX5_UNK15                       = 0x00008000,            // 15
        SPELL_ATTR_EX5_UNK16                       = 0x00010000,            // 16
        SPELL_ATTR_EX5_USABLE_WHILE_FEARED         = 0x00020000,            // 17 usable while feared
        SPELL_ATTR_EX5_USABLE_WHILE_CONFUSED       = 0x00040000,            // 18 usable while confused
        SPELL_ATTR_EX5_UNK19                       = 0x00080000,            // 19
        SPELL_ATTR_EX5_UNK20                       = 0x00100000,            // 20
        SPELL_ATTR_EX5_UNK21                       = 0x00200000,            // 21
        SPELL_ATTR_EX5_UNK22                       = 0x00400000,            // 22
        SPELL_ATTR_EX5_UNK23                       = 0x00800000,            // 23
        SPELL_ATTR_EX5_UNK24                       = 0x01000000,            // 24
        SPELL_ATTR_EX5_UNK25                       = 0x02000000,            // 25
        SPELL_ATTR_EX5_UNK26                       = 0x04000000,            // 26
        SPELL_ATTR_EX5_UNK27                       = 0x08000000,            // 27
        SPELL_ATTR_EX5_UNK28                       = 0x10000000,            // 28
        SPELL_ATTR_EX5_UNK29                       = 0x20000000,            // 29
        SPELL_ATTR_EX5_UNK30                       = 0x40000000,            // 30
        SPELL_ATTR_EX5_UNK31                       = 1 << 31                // 31 Forces all nearby enemies to focus attacks caster

    };

    [Flags]
    public enum SpellAtributeEx6
    {
        SPELL_ATTR_EX6_ALL                         =         -1,
        SPELL_ATTR_EX6_NONE                        =       0x00,
        SPELL_ATTR_EX6_UNK0                        = 0x00000001,            // 0 Only Move spell have this flag
        SPELL_ATTR_EX6_ONLY_IN_ARENA               = 0x00000002,            // 1 only usable in arena, not used in 3.2.0a and early
        SPELL_ATTR_EX6_UNK2                        = 0x00000004,            // 2
        SPELL_ATTR_EX6_UNK3                        = 0x00000008,            // 3
        SPELL_ATTR_EX6_UNK4                        = 0x00000010,            // 4
        SPELL_ATTR_EX6_UNK5                        = 0x00000020,            // 5
        SPELL_ATTR_EX6_UNK6                        = 0x00000040,            // 6
        SPELL_ATTR_EX6_UNK7                        = 0x00000080,            // 7
        SPELL_ATTR_EX6_IGNORE_CCED_TARGETS         = 0x00000100,            // 8
        SPELL_ATTR_EX6_IGNORE_DETECTION            = 0x00000200,            // 9 many spells, ignored unit detections/phasing.
        SPELL_ATTR_EX6_NORMAL_DIFFICULTY           = 0x00000400,            // 10 this spells not have heroic difficulty versions in DBC (may be only one from effects?)
        SPELL_ATTR_EX6_NOT_IN_RAID_INSTANCE        = 0x00000800,            // 11 not usable in raid instance
        SPELL_ATTR_EX6_CASTABLE_ON_VEHICLE         = 0x00001000,            // 12 for auras SPELL_AURA_TRACK_CREATURES, SPELL_AURA_TRACK_RESOURCES and SPELL_AURA_TRACK_STEALTHED select non-stacking tracking spells
        SPELL_ATTR_EX6_CAN_TARGET_INVISIBLE        = 0x00002000,            // 13 ignore visibility requirement for spell target (phases, invisibility, etc.)
        SPELL_ATTR_EX6_UNK14                       = 0x00004000,            // 14
        SPELL_ATTR_EX6_UNK15                       = 0x00008000,            // 15 not set in 3.0.3
        SPELL_ATTR_EX6_UNK16                       = 0x00010000,            // 16
        SPELL_ATTR_EX6_UNK17                       = 0x00020000,            // 17
        SPELL_ATTR_EX6_UNK18                       = 0x00040000,            // 18
        SPELL_ATTR_EX6_UNK19                       = 0x00080000,            // 19
        SPELL_ATTR_EX6_UNK20                       = 0x00100000,            // 20
        SPELL_ATTR_EX6_UNK21                       = 0x00200000,            // 21
        SPELL_ATTR_EX6_UNK22                       = 0x00400000,            // 22
        SPELL_ATTR_EX6_NO_STACK_DEBUFF_MAJOR       = 0x00800000,            // 23 only debuff and debuff-like spells in 3.3.5a
        SPELL_ATTR_EX6_UNK24                       = 0x01000000,            // 24 not set in 3.0.3
        SPELL_ATTR_EX6_UNK25                       = 0x02000000,            // 25 not set in 3.0.3
        SPELL_ATTR_EX6_NO_STACK_BUFF               = 0x04000000,            // 26 not set in 3.0.3
        SPELL_ATTR_EX6_UNK27                       = 0x08000000,            // 27 not set in 3.0.3
        SPELL_ATTR_EX6_UNK28                       = 0x10000000,            // 28 not set in 3.0.3
        SPELL_ATTR_EX6_NO_DMG_MODS                 = 0x20000000,            // 29 do not apply damage mods (usually in cases where it has already been applied)
        SPELL_ATTR_EX6_UNK30                       = 0x40000000,            // 30 not set in 3.0.3
        SPELL_ATTR_EX6_UNK31                       = 1 << 31                // 31 not set in 3.0.3

    };
    
    [Flags]
    public enum SpellAtributeEx7
    {
        SPELL_ATTR_EX7_ALL                         =         -1,
        SPELL_ATTR_EX7_NONE                        =       0x00,
        SPELL_ATTR_EX7_UNK0                        = 0x00000001,            // 0
        SPELL_ATTR_EX7_UNK1                        = 0x00000002,            // 1
        SPELL_ATTR_EX7_PALADIN_AURA                = 0x00000004,            // 2
        SPELL_ATTR_EX7_GM_ONLY                     = 0x00000008,            // 3 Cannot cast if caster doesn't have UnitFlag2 & UNIT_FLAG2_GM_MODE
        SPELL_ATTR_EX7_UNK4                        = 0x00000010,            // 4
        SPELL_ATTR_EX7_TOTEM_SPELL                 = 0x00000020,            // 5  shaman summon totem spells
        SPELL_ATTR_EX7_UNK6                        = 0x00000040,            // 6
        SPELL_ATTR_EX7_UNK7                        = 0x00000080,            // 7
        SPELL_ATTR_EX7_UNK8                        = 0x00000100,            // 8
        SPELL_ATTR_EX7_UNK9                        = 0x00000200,            // 9
        SPELL_ATTR_EX7_DISPEL_CHARGES              = 0x00000400,            // 10 Dispel and Spellsteal individual charges instead of whole aura.
        SPELL_ATTR_EX7_UNK11                       = 0x00000800,            // 11
        SPELL_ATTR_EX7_UNK12                       = 0x00001000,            // 12
        SPELL_ATTR_EX7_UNK13                       = 0x00002000,            // 13
        SPELL_ATTR_EX7_UNK14                       = 0x00004000,            // 14
        SPELL_ATTR_EX7_UNK15                       = 0x00008000,            // 15
        SPELL_ATTR_EX7_UNK16                       = 0x00010000,            // 16
        SPELL_ATTR_EX7_UNK17                       = 0x00020000,            // 17
        SPELL_ATTR_EX7_HAS_CHARGE_EFFECT           = 0x00040000,            // 18 Only spell with Charge effect (used for calculate traectory/delay)
        SPELL_ATTR_EX7_UNK19                       = 0x00080000,            // 19
        SPELL_ATTR_EX7_UNK20                       = 0x00100000,            // 20
        SPELL_ATTR_EX7_UNK21                       = 0x00200000,            // 21
        SPELL_ATTR_EX7_UNK22                       = 0x00400000,            // 22
        SPELL_ATTR_EX7_UNK23                       = 0x00800000,            // 23
        SPELL_ATTR_EX7_UNK24                       = 0x01000000,            // 24
        SPELL_ATTR_EX7_UNK25                       = 0x02000000,            // 25
        SPELL_ATTR_EX7_UNK26                       = 0x04000000,            // 26
        SPELL_ATTR_EX7_UNK27                       = 0x08000000,            // 27
        SPELL_ATTR_EX7_REPLACEABLE_AURA            = 0x10000000,            // 28
        SPELL_ATTR_EX7_UNK29                       = 0x20000000,            // 29
        SPELL_ATTR_EX7_UNK30                       = 0x40000000,            // 30
        SPELL_ATTR_EX7_UNK31                       = 1 << 31                // 31

    };

    [Flags]
    public enum CombatRating
    {
        CR_WEAPON_SKILL             = 1 << 0x00,
        CR_DEFENSE_SKILL            = 1 << 0x01,
        CR_DODGE                    = 1 << 0x02,
        CR_PARRY                    = 1 << 0x03,
        CR_BLOCK                    = 1 << 0x04,
        CR_HIT_MELEE                = 1 << 0x05,
        CR_HIT_RANGED               = 1 << 0x06,
        CR_HIT_SPELL                = 1 << 0x07,
        CR_CRIT_MELEE               = 1 << 0x08,
        CR_CRIT_RANGED              = 1 << 0x09,
        CR_CRIT_SPELL               = 1 << 0x0A,
        CR_HIT_TAKEN_MELEE          = 1 << 0x0B,
        CR_HIT_TAKEN_RANGED         = 1 << 0x0C,
        CR_HIT_TAKEN_SPELL          = 1 << 0x0D,
        CR_CRIT_TAKEN_MELEE         = 1 << 0x0E,
        CR_CRIT_TAKEN_RANGED        = 1 << 0x0F,
        CR_CRIT_TAKEN_SPELL         = 1 << 0x10,
        CR_HASTE_MELEE              = 1 << 0x11,
        CR_HASTE_RANGED             = 1 << 0x12,
        CR_HASTE_SPELL              = 1 << 0x13,
        CR_WEAPON_SKILL_MAINHAND    = 1 << 0x14,
        CR_WEAPON_SKILL_OFFHAND     = 1 << 0x15,
        CR_WEAPON_SKILL_RANGED      = 1 << 0x16,
        CR_EXPERTISE                = 1 << 0x17,
        CR_ARMOR_PENETRATION        = 1 << 0x18,
    };

    public enum UnitMods
    {
        UNIT_MOD_ALL_STAT               =-1,                  // STRENGTH, AGILITY, STAMINA, INTELLECT, SPIRIT
        UNIT_MOD_STAT_STRENGTH          = 0,                  // UNIT_MOD_STAT_STRENGTH..UNIT_MOD_STAT_SPIRIT must be in existed order, it's accessed by index values of Stats enum.
        UNIT_MOD_STAT_AGILITY           = 1,
        UNIT_MOD_STAT_STAMINA           = 2,
        UNIT_MOD_STAT_INTELLECT         = 3,
        UNIT_MOD_STAT_SPIRIT            = 4,
        UNIT_MOD_HEALTH                 = 5,
        UNIT_MOD_MANA                   = 6,                  // UNIT_MOD_MANA..UNIT_MOD_RUNIC_POWER must be in existed order, it's accessed by index values of Powers enum.
        UNIT_MOD_RAGE                   = 7,
        UNIT_MOD_FOCUS                  = 8,
        UNIT_MOD_ENERGY                 = 9,
        UNIT_MOD_HAPPINESS              = 10,
        UNIT_MOD_RUNE                   = 11,
        UNIT_MOD_RUNIC_POWER            = 12,
        UNIT_MOD_ARMOR                  = 13,                 // UNIT_MOD_ARMOR..UNIT_MOD_RESISTANCE_ARCANE must be in existed order, it's accessed by index values of SpellSchools enum.
        UNIT_MOD_RESISTANCE_HOLY        = 14,
        UNIT_MOD_RESISTANCE_FIRE        = 15,
        UNIT_MOD_RESISTANCE_NATURE      = 16,
        UNIT_MOD_RESISTANCE_FROST       = 17,
        UNIT_MOD_RESISTANCE_SHADOW      = 18,
        UNIT_MOD_RESISTANCE_ARCANE      = 19,
        UNIT_MOD_ATTACK_POWER           = 20,
        UNIT_MOD_ATTACK_POWER_RANGED    = 21,
        UNIT_MOD_DAMAGE_MAINHAND        = 22,
        UNIT_MOD_DAMAGE_OFFHAND         = 23,
        UNIT_MOD_DAMAGE_RANGED          = 24,
        UNIT_MOD_END                    = 25,
        // synonyms
        UNIT_MOD_STAT_START             = UNIT_MOD_STAT_STRENGTH,
        UNIT_MOD_STAT_END               = UNIT_MOD_STAT_SPIRIT       + 1,
        UNIT_MOD_RESISTANCE_START       = UNIT_MOD_ARMOR,
        UNIT_MOD_RESISTANCE_END         = UNIT_MOD_RESISTANCE_ARCANE + 1,
        UNIT_MOD_POWER_START            = UNIT_MOD_MANA,
        UNIT_MOD_POWER_END              = UNIT_MOD_RUNIC_POWER       + 1,
    };

    public enum LockType
    {
        LOCKTYPE_PICKLOCK = 1,
        LOCKTYPE_HERBALISM = 2,
        LOCKTYPE_MINING = 3,
        LOCKTYPE_DISARM_TRAP = 4,
        LOCKTYPE_OPEN = 5,
        LOCKTYPE_TREASURE = 6,
        LOCKTYPE_CALCIFIED_ELVEN_GEMS = 7,
        LOCKTYPE_CLOSE = 8,
        LOCKTYPE_ARM_TRAP = 9,
        LOCKTYPE_QUICK_OPEN = 10,
        LOCKTYPE_QUICK_CLOSE = 11,
        LOCKTYPE_OPEN_TINKERING = 12,
        LOCKTYPE_OPEN_KNEELING = 13,
        LOCKTYPE_OPEN_ATTACKING = 14,
        LOCKTYPE_GAHZRIDIAN = 15,
        LOCKTYPE_BLASTING = 16,
        LOCKTYPE_SLOW_OPEN = 17,
        LOCKTYPE_SLOW_CLOSE = 18,
        LOCKTYPE_FISHING = 19,
        LOCKTYPE_INSCRIPTION = 20,
        LOCKTYPE_OPEN_FROM_VEHICLE = 21
    };

    public class SpellEnums
    {
        #region ProcFlagDesc

        public static readonly string[] ProcFlagDesc = 
        {
            //00 0x00000001 000000000000000000000001 -
            "00 Killed by aggressor that receive experience or honor",
            //01 0x00000002 000000000000000000000010 -
            "01 Kill that yields experience or honor",

            //02 0x00000004 000000000000000000000100 -
            "02 Successful melee attack",
            //03 0x00000008 000000000000000000001000 -
            "03 Taken damage from melee strike hit",

            //04 0x00000010 000000000000000000010000 -
            "04 Successful attack by Spell that use melee weapon",
            //05 0x00000020 000000000000000000100000 -
            "05 Taken damage by Spell that use melee weapon",

            //06 0x00000040 000000000000000001000000 -
            "06 Successful Ranged attack(and wand spell cast)",
            //07 0x00000080 000000000000000010000000 -
            "07 Taken damage from ranged attack",

            //08 0x00000100 000000000000000100000000 -
            "08 Successful Ranged attack by Spell that use ranged weapon",
            //09 0x00000200 000000000000001000000000 -
            "09 Taken damage by Spell that use ranged weapon",

            //10 0x00000400 000000000000010000000000 -
            "10 Successful ??? spell hit",
            //11 0x00000800 000000000000100000000000 -
            "11 Taken ??? spell hit",

            //12 0x00001000 000000000001000000000000 -
            "12 Successful ??? spell cast",
            //13 0x00002000 000000000010000000000000 -
            "13 Taken ??? spell hit",

            //14 0x00004000 000000000100000000000000 -
            "14 Successful cast positive spell",
            //15 0x00008000 000000001000000000000000 -
            "15 Taken positive spell hit",

            //16 0x00010000 000000010000000000000000 -
            "16 Successful damage from harmful spell cast (каст дамажащего спелла)",
            //17 0x00020000 000000100000000000000000 -
            "17 Taken spell damage",

            //18 0x00040000 000001000000000000000000 -
            "18 Deal periodic damage",
            //19 0x00080000 000010000000000000000000 -
            "19 Taken periodic damage",

            //20 0x00100000 000100000000000000000000 -
            "20 Taken any damage",
            //21 0x00200000 001000000000000000000000 -
            "21 On trap activation (При срабатывании ловушки)",

            //22 0x00800000 010000000000000000000000 -
            "22 Taken off-hand melee attacks",
            //23 0x00800000 100000000000000000000000 -
            "23 Successful off-hand melee attacks",

            //24 0x00800000
            "24 On caster's death",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"
        };
        #endregion
    }
    
   public    enum RuneType
    {
        RUNE_BLOOD      = 0,
        RUNE_UNHOLY     = 1,
        RUNE_FROST      = 2,
        RUNE_DEATH      = 3
    };

    public   enum MeleeHitOutcome
    {
        MELEE_HIT_EVADE     = 0,
        MELEE_HIT_MISS      = 1,
        MELEE_HIT_DODGE     = 2,                                // used as misc in SPELL_AURA_IGNORE_COMBAT_RESULT
        MELEE_HIT_BLOCK     = 3,                                // used as misc in SPELL_AURA_IGNORE_COMBAT_RESULT
        MELEE_HIT_PARRY     = 4,                                // used as misc in SPELL_AURA_IGNORE_COMBAT_RESULT
        MELEE_HIT_GLANCING  = 5,
        MELEE_HIT_CRIT      = 6,
        MELEE_HIT_CRUSHING  = 7,
        MELEE_HIT_NORMAL    = 8,
    };

    [Flags]
    public   enum SpellInterruptFlags
    {
        SPELL_INTERRUPT_FLAG_MOVEMENT     = 0x01,
        SPELL_INTERRUPT_FLAG_DAMAGE       = 0x02,
        SPELL_INTERRUPT_FLAG_INTERRUPT    = 0x04,
        SPELL_INTERRUPT_FLAG_AUTOATTACK   = 0x08,
        SPELL_INTERRUPT_FLAG_ABORT_ON_DMG = 0x10,               // _complete_ interrupt on direct damage
        //SPELL_INTERRUPT_UNK             = 0x20                // unk, 564 of 727 spells having this spell start with "Glyph"
    };

    [Flags]
   public    enum SpellChannelInterruptFlags
    {
        CHANNEL_FLAG_DAMAGE      = 0x0002,
        CHANNEL_FLAG_MOVEMENT    = 0x0008,
        CHANNEL_FLAG_TURNING     = 0x0010,
        CHANNEL_FLAG_DAMAGE2     = 0x0080,
        CHANNEL_FLAG_DELAY       = 0x4000
    };

    [Flags]
    public   enum SpellAuraInterruptFlags
    {
        AURA_INTERRUPT_FLAG_SPELLHIT                    = 0x00000001,   // 0    removed when getting hit by a negative spell?
        AURA_INTERRUPT_FLAG_DAMAGE                      = 0x00000002,   // 1    removed by any damage
        AURA_INTERRUPT_FLAG_CAST                        = 0x00000004,   // 2
        AURA_INTERRUPT_FLAG_MOVE                        = 0x00000008,   // 3    removed by any movement
        AURA_INTERRUPT_FLAG_TURNING                     = 0x00000010,   // 4    removed by any turning
        AURA_INTERRUPT_FLAG_ENTER_COMBAT                = 0x00000020,   // 5    removed by entering combat
        AURA_INTERRUPT_FLAG_NOT_MOUNTED                 = 0x00000040,   // 6    removed by unmounting
        AURA_INTERRUPT_FLAG_NOT_ABOVEWATER              = 0x00000080,   // 7    removed by entering water
        AURA_INTERRUPT_FLAG_NOT_UNDERWATER              = 0x00000100,   // 8    removed by leaving water
        AURA_INTERRUPT_FLAG_NOT_SHEATHED                = 0x00000200,   // 9    removed by unsheathing
        AURA_INTERRUPT_FLAG_ACTION                      = 0x00000400,   // 10
        AURA_INTERRUPT_FLAG_USE                         = 0x00000800,   // 11   removed by casting a spell
        AURA_INTERRUPT_FLAG_MELEE_ATTACK                = 0x00001000,   // 12   removed by attack?
        AURA_INTERRUPT_FLAG_SPELL_ATTACK                = 0x00002000,   // 13
        AURA_INTERRUPT_FLAG_UNK14                       = 0x00004000,   // 14
        AURA_INTERRUPT_FLAG_TRANSFORM                   = 0x00008000,   // 15   removed by casting a spell?
        AURA_INTERRUPT_FLAG_UNK16                       = 0x00010000,   // 16
        AURA_INTERRUPT_FLAG_MOUNTING                    = 0x00020000,   // 17   removed by mounting
        AURA_INTERRUPT_FLAG_NOT_SEATED                  = 0x00040000,   // 18   removed by standing up (used by food and drink mostly and sleep/Fake Death like)
        AURA_INTERRUPT_FLAG_CHANGE_MAP                  = 0x00080000,   // 19   leaving map/getting teleported
        AURA_INTERRUPT_FLAG_IMMUNE_OR_LOST_SELECTION    = 0x00100000,   // 20   removed by auras that make you invulnerable, or make other to loose selection on you
        AURA_INTERRUPT_FLAG_UNK21                       = 0x00200000,   // 21
        AURA_INTERRUPT_FLAG_TELEPORTED                  = 0x00400000,   // 22
        AURA_INTERRUPT_FLAG_ENTER_PVP_COMBAT            = 0x00800000,   // 23   removed by entering pvp combat
        AURA_INTERRUPT_FLAG_DIRECT_DAMAGE               = 0x01000000,   // 24   removed by any direct damage
        AURA_INTERRUPT_FLAG_LANDING                     = 0x02000000,   // 25   removed by hitting the ground
    };

}
