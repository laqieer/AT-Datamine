// Decompiled with JetBrains decompiler
// Type: StaqData.Weapon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.Utility;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200202A")]
  public sealed class Weapon : Equipment, IGrowable
  {
    [Token(Token = "0x40088F1")]
    private const float ExpRateMax = 1f;
    [Token(Token = "0x40088F9")]
    [FieldOffset(Offset = "0xC8")]
    private List<InscriptionDescriptionData> inscriptionList;
    [Token(Token = "0x40088FA")]
    [FieldOffset(Offset = "0xD0")]
    public WeaponSkill[] WeaponSkills;
    [Token(Token = "0x40088FD")]
    [FieldOffset(Offset = "0xE0")]
    public WeaponOptionEffect[] WeaponOptionEffects;

    [Token(Token = "0x1700282C")]
    public int Exp
    {
      [Token(Token = "0x600C06B"), Address(RVA = "0x200C7A8", Offset = "0x200C7A8", VA = "0x200C7A8", Slot = "69")] get
      {
        return new int();
      }
      [Token(Token = "0x600C06C"), Address(RVA = "0x200C7B0", Offset = "0x200C7B0", VA = "0x200C7B0")] private set
      {
      }
    }

    [Token(Token = "0x1700282D")]
    public WeaponData MasterData
    {
      [Token(Token = "0x600C06D"), Address(RVA = "0x200C7B8", Offset = "0x200C7B8", VA = "0x200C7B8")] get
      {
        return (WeaponData) null;
      }
      [Token(Token = "0x600C06E"), Address(RVA = "0x200C7C0", Offset = "0x200C7C0", VA = "0x200C7C0")] private set
      {
      }
    }

    [Token(Token = "0x1700282E")]
    public int Level
    {
      [Token(Token = "0x600C06F"), Address(RVA = "0x200C7C8", Offset = "0x200C7C8", VA = "0x200C7C8", Slot = "70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700282F")]
    public int LimitLevel
    {
      [Token(Token = "0x600C070"), Address(RVA = "0x200C864", Offset = "0x200C864", VA = "0x200C864")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002830")]
    public bool IsLevelLimit
    {
      [Token(Token = "0x600C071"), Address(RVA = "0x200C8FC", Offset = "0x200C8FC", VA = "0x200C8FC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002831")]
    public int MaxLevel
    {
      [Token(Token = "0x600C072"), Address(RVA = "0x200C92C", Offset = "0x200C92C", VA = "0x200C92C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002832")]
    public bool IsLevelMax
    {
      [Token(Token = "0x600C073"), Address(RVA = "0x200CA7C", Offset = "0x200CA7C", VA = "0x200CA7C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002833")]
    public int NextLevelExp
    {
      [Token(Token = "0x600C074"), Address(RVA = "0x200CAAC", Offset = "0x200CAAC", VA = "0x200CAAC", Slot = "71")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002834")]
    public float NextLevelExpRate
    {
      [Token(Token = "0x600C075"), Address(RVA = "0x200CB48", Offset = "0x200CB48", VA = "0x200CB48", Slot = "72")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002835")]
    public int Power
    {
      [Token(Token = "0x600C076"), Address(RVA = "0x200CC04", Offset = "0x200CC04", VA = "0x200CC04")] get
      {
        return new int();
      }
      [Token(Token = "0x600C077"), Address(RVA = "0x200CC0C", Offset = "0x200CC0C", VA = "0x200CC0C")] private set
      {
      }
    }

    [Token(Token = "0x17002836")]
    public InscriptionData InscriptionData
    {
      [Token(Token = "0x600C078"), Address(RVA = "0x200CC14", Offset = "0x200CC14", VA = "0x200CC14")] get
      {
        return (InscriptionData) null;
      }
      [Token(Token = "0x600C079"), Address(RVA = "0x200CC1C", Offset = "0x200CC1C", VA = "0x200CC1C")] private set
      {
      }
    }

    [Token(Token = "0x17002837")]
    public int Durable
    {
      [Token(Token = "0x600C07A"), Address(RVA = "0x200CC24", Offset = "0x200CC24", VA = "0x200CC24")] get
      {
        return new int();
      }
      [Token(Token = "0x600C07B"), Address(RVA = "0x200CC2C", Offset = "0x200CC2C", VA = "0x200CC2C")] private set
      {
      }
    }

    [Token(Token = "0x17002838")]
    public int InitialRange
    {
      [Token(Token = "0x600C07C"), Address(RVA = "0x200CC34", Offset = "0x200CC34", VA = "0x200CC34")] get
      {
        return new int();
      }
      [Token(Token = "0x600C07D"), Address(RVA = "0x200CC3C", Offset = "0x200CC3C", VA = "0x200CC3C")] set
      {
      }
    }

    [Token(Token = "0x17002839")]
    public int LimitRange
    {
      [Token(Token = "0x600C07E"), Address(RVA = "0x200CC44", Offset = "0x200CC44", VA = "0x200CC44")] get
      {
        return new int();
      }
      [Token(Token = "0x600C07F"), Address(RVA = "0x200CC4C", Offset = "0x200CC4C", VA = "0x200CC4C")] set
      {
      }
    }

    [Token(Token = "0x1700283A")]
    public int WeaponTypeId
    {
      [Token(Token = "0x600C080"), Address(RVA = "0x200CC54", Offset = "0x200CC54", VA = "0x200CC54")] get
      {
        return new int();
      }
      [Token(Token = "0x600C081"), Address(RVA = "0x200CC5C", Offset = "0x200CC5C", VA = "0x200CC5C")] private set
      {
      }
    }

    [Token(Token = "0x1700283B")]
    public int LimitBreak
    {
      [Token(Token = "0x600C082"), Address(RVA = "0x200CC64", Offset = "0x200CC64", VA = "0x200CC64")] get
      {
        return new int();
      }
      [Token(Token = "0x600C083"), Address(RVA = "0x200CC6C", Offset = "0x200CC6C", VA = "0x200CC6C")] private set
      {
      }
    }

    [Token(Token = "0x1700283C")]
    public int LimitBreakCountMax
    {
      [Token(Token = "0x600C084"), Address(RVA = "0x200C9DC", Offset = "0x200C9DC", VA = "0x200C9DC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700283D")]
    public bool HasOptionEffects
    {
      [Token(Token = "0x600C085"), Address(RVA = "0x200CC74", Offset = "0x200CC74", VA = "0x200CC74")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700283E")]
    public WeaponAdditionalEffect WeaponAdditionalEffect
    {
      [Token(Token = "0x600C086"), Address(RVA = "0x200CC98", Offset = "0x200CC98", VA = "0x200CC98")] get
      {
        return (WeaponAdditionalEffect) null;
      }
      [Token(Token = "0x600C087"), Address(RVA = "0x200CCA0", Offset = "0x200CCA0", VA = "0x200CCA0")] private set
      {
      }
    }

    [Token(Token = "0x600C088")]
    [Address(RVA = "0x200CCA8", Offset = "0x200CCA8", VA = "0x200CCA8")]
    private Weapon()
    {
    }

    [Token(Token = "0x600C089")]
    [Address(RVA = "0x200CD74", Offset = "0x200CD74", VA = "0x200CD74", Slot = "73")]
    public (int, int) GetPredictExperience(int value) => ();

    [Token(Token = "0x600C08A")]
    [Address(RVA = "0x200CE88", Offset = "0x200CE88", VA = "0x200CE88", Slot = "29")]
    public override int GetElementReinforceValue(ElementTypeEnum type) => new int();

    [Token(Token = "0x600C08B")]
    [Address(RVA = "0x200CEC0", Offset = "0x200CEC0", VA = "0x200CEC0", Slot = "32")]
    public override int GetElementResistValue(ElementTypeEnum type) => new int();

    [Token(Token = "0x600C08C")]
    [Address(RVA = "0x200CEF8", Offset = "0x200CEF8", VA = "0x200CEF8", Slot = "30")]
    public override int GetAttackReinforceValue(AttackTypeEnum type) => new int();

    [Token(Token = "0x600C08D")]
    [Address(RVA = "0x200CF30", Offset = "0x200CF30", VA = "0x200CF30", Slot = "33")]
    public override int GetAttackResistValue(AttackTypeEnum type) => new int();

    [Token(Token = "0x600C08E")]
    [Address(RVA = "0x200CF68", Offset = "0x200CF68", VA = "0x200CF68", Slot = "31")]
    public override int GetBadStatusReinforceValue(BattleBadStatusTypeEnum type) => new int();

    [Token(Token = "0x600C08F")]
    [Address(RVA = "0x200CFA0", Offset = "0x200CFA0", VA = "0x200CFA0", Slot = "34")]
    public override int GetBadStatusResistValue(BattleBadStatusTypeEnum type) => new int();

    [Token(Token = "0x600C090")]
    [Address(RVA = "0x200CFD8", Offset = "0x200CFD8", VA = "0x200CFD8", Slot = "35")]
    public override float GetOptionEffectElementReinforceValue(ElementTypeEnum type) => new float();

    [Token(Token = "0x600C091")]
    [Address(RVA = "0x200D044", Offset = "0x200D044", VA = "0x200D044", Slot = "36")]
    public override float GetOptionEffectAttackReinforceValue(AttackTypeEnum type) => new float();

    [Token(Token = "0x600C092")]
    [Address(RVA = "0x200D0B0", Offset = "0x200D0B0", VA = "0x200D0B0", Slot = "37")]
    public override float GetOptionEffectBadStatusReinforceValue(BattleBadStatusTypeEnum type)
    {
      return new float();
    }

    [Token(Token = "0x600C093")]
    [Address(RVA = "0x200D11C", Offset = "0x200D11C", VA = "0x200D11C", Slot = "41")]
    public override bool IsAddedStatusElementReinforceValue(ElementTypeEnum elementType)
    {
      return new bool();
    }

    [Token(Token = "0x600C094")]
    [Address(RVA = "0x200D138", Offset = "0x200D138", VA = "0x200D138", Slot = "42")]
    public override bool IsAddedStatusAttackReinforceValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x600C095")]
    [Address(RVA = "0x200D154", Offset = "0x200D154", VA = "0x200D154", Slot = "43")]
    public override bool IsAddedStatusBadStatusReinforceValue(
      BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x600C096")]
    [Address(RVA = "0x200D170", Offset = "0x200D170", VA = "0x200D170", Slot = "44")]
    public override bool IsAddedStatusElementResistValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x600C097")]
    [Address(RVA = "0x200D18C", Offset = "0x200D18C", VA = "0x200D18C", Slot = "45")]
    public override bool IsAddedStatusAttackResistValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x600C098")]
    [Address(RVA = "0x200D1A8", Offset = "0x200D1A8", VA = "0x200D1A8", Slot = "46")]
    public override bool IsAddedStatusBadStatusResistValue(
      BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x600C099")]
    [Address(RVA = "0x200D1C4", Offset = "0x200D1C4", VA = "0x200D1C4")]
    public void Apply(PlayerGearWeaponType entity)
    {
    }

    [Token(Token = "0x600C09A")]
    [Address(RVA = "0x200D674", Offset = "0x200D674", VA = "0x200D674")]
    public Weapon CreateAssumptionFromLevel(int level) => (Weapon) null;

    [Token(Token = "0x600C09B")]
    [Address(RVA = "0x200D7AC", Offset = "0x200D7AC", VA = "0x200D7AC")]
    public static Weapon CreateByServerData(PlayerGearWeaponType entity) => (Weapon) null;

    [Token(Token = "0x600C09C")]
    [Address(RVA = "0x200DD24", Offset = "0x200DD24", VA = "0x200DD24")]
    public static Weapon CreateByDummyData(int masterId) => (Weapon) null;

    [Token(Token = "0x600C09D")]
    [Address(RVA = "0x200DF20", Offset = "0x200DF20", VA = "0x200DF20")]
    public static Weapon CreateByNpcData(int masterId) => (Weapon) null;

    [Token(Token = "0x600C09E")]
    [Address(RVA = "0x200D580", Offset = "0x200D580", VA = "0x200D580")]
    private void UpdateBattleParameters()
    {
    }

    [Token(Token = "0x600C09F")]
    [Address(RVA = "0x200E0E8", Offset = "0x200E0E8", VA = "0x200E0E8")]
    public bool IsCoeffcicent(Style style) => new bool();

    [Token(Token = "0x600C0A0")]
    [Address(RVA = "0x200E290", Offset = "0x200E290", VA = "0x200E290", Slot = "67")]
    public override IBattleParameter GetBattleParameterByStyle(Style style)
    {
      return (IBattleParameter) null;
    }

    [Token(Token = "0x600C0A1")]
    [Address(RVA = "0x200E720", Offset = "0x200E720", VA = "0x200E720")]
    public BattleParameter GetWeaponAptitudeStatus(Style style) => (BattleParameter) null;

    [Token(Token = "0x600C0A2")]
    [Address(RVA = "0x200EB68", Offset = "0x200EB68", VA = "0x200EB68")]
    public IBattleParameter GetWeaponAddProficiencyStatus(Style style) => (IBattleParameter) null;

    [Token(Token = "0x600C0A3")]
    [Address(RVA = "0x200EE40", Offset = "0x200EE40", VA = "0x200EE40")]
    public WeaponRarityAptitudeDescriptionData GetWeaponRarityAptitude(Style style)
    {
      return (WeaponRarityAptitudeDescriptionData) null;
    }

    [Token(Token = "0x600C0A4")]
    [Address(RVA = "0x200F1E8", Offset = "0x200F1E8", VA = "0x200F1E8", Slot = "68")]
    public override int GetWeightByAptitude(Style style) => new int();

    [Token(Token = "0x600C0A5")]
    [Address(RVA = "0x200F270", Offset = "0x200F270", VA = "0x200F270", Slot = "66")]
    public override int GetCombatPower() => new int();

    [Token(Token = "0x600C0A6")]
    [Address(RVA = "0x200F274", Offset = "0x200F274", VA = "0x200F274")]
    public int CalcCombatPower() => new int();

    [Token(Token = "0x600C0A7")]
    [Address(RVA = "0x200F8A8", Offset = "0x200F8A8", VA = "0x200F8A8")]
    public int CalcCombatPower(WeaponStandardStatus assumption) => new int();

    [Token(Token = "0x600C0A8")]
    [Address(RVA = "0x200F9B0", Offset = "0x200F9B0", VA = "0x200F9B0")]
    public int CalcCombatPower(Style style) => new int();

    [Token(Token = "0x600C0A9")]
    [Address(RVA = "0x200F2DC", Offset = "0x200F2DC", VA = "0x200F2DC")]
    private static int CalcCombatPower(
      int baseHP,
      WeaponAttackTypeEnum weaponAttackType,
      int basePower,
      int basePhysicalDef,
      int baseMagicalDef,
      int baseHit,
      int baseAvoid,
      int baseCritical,
      int baseCriticalAvoid,
      int baseAtkSpeed,
      int baseWeight,
      int equipmentClassification)
    {
      return new int();
    }

    [Token(Token = "0x600C0AA")]
    [Address(RVA = "0x200FE2C", Offset = "0x200FE2C", VA = "0x200FE2C")]
    public void GetLimitBreakItemData(
      int limitBreakNum,
      out int possessionAmount,
      out int needAmount)
    {
    }

    [Token(Token = "0x600C0AB")]
    [Address(RVA = "0x200FF6C", Offset = "0x200FF6C", VA = "0x200FF6C", Slot = "47")]
    public override bool CheckEnhancedBadge() => new bool();

    [Token(Token = "0x600C0AC")]
    [Address(RVA = "0x201010C", Offset = "0x201010C", VA = "0x201010C")]
    public static Weapon CreateForExpedition(int masterId, Style style) => (Weapon) null;
  }
}
