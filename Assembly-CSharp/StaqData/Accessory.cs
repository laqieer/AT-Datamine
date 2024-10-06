// Decompiled with JetBrains decompiler
// Type: StaqData.Accessory
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
  [Token(Token = "0x2002017")]
  public sealed class Accessory : Equipment, IGrowable
  {
    [Token(Token = "0x40088A3")]
    private const float ExpRateMax = 1f;
    [Token(Token = "0x40088A7")]
    [FieldOffset(Offset = "0xC0")]
    public AccessorySkill[] AccessorySkills;
    [Token(Token = "0x40088A9")]
    [FieldOffset(Offset = "0xD0")]
    public AccessoryOptionEffect[] AccessoryOptionEffects;

    [Token(Token = "0x170027C8")]
    public InscriptionData InscriptionData
    {
      [Token(Token = "0x600BF3D"), Address(RVA = "0x2006048", Offset = "0x2006048", VA = "0x2006048")] get
      {
        return (InscriptionData) null;
      }
      [Token(Token = "0x600BF3E"), Address(RVA = "0x2006050", Offset = "0x2006050", VA = "0x2006050")] private set
      {
      }
    }

    [Token(Token = "0x170027C9")]
    public int Power
    {
      [Token(Token = "0x600BF3F"), Address(RVA = "0x2006058", Offset = "0x2006058", VA = "0x2006058")] get
      {
        return new int();
      }
      [Token(Token = "0x600BF40"), Address(RVA = "0x2006060", Offset = "0x2006060", VA = "0x2006060")] private set
      {
      }
    }

    [Token(Token = "0x170027CA")]
    public int Exp
    {
      [Token(Token = "0x600BF41"), Address(RVA = "0x2006068", Offset = "0x2006068", VA = "0x2006068", Slot = "69")] get
      {
        return new int();
      }
      [Token(Token = "0x600BF42"), Address(RVA = "0x2006070", Offset = "0x2006070", VA = "0x2006070")] private set
      {
      }
    }

    [Token(Token = "0x170027CB")]
    public AccessoriesData MasterData
    {
      [Token(Token = "0x600BF43"), Address(RVA = "0x2006078", Offset = "0x2006078", VA = "0x2006078")] get
      {
        return (AccessoriesData) null;
      }
      [Token(Token = "0x600BF44"), Address(RVA = "0x2006080", Offset = "0x2006080", VA = "0x2006080")] private set
      {
      }
    }

    [Token(Token = "0x170027CC")]
    public int Level
    {
      [Token(Token = "0x600BF45"), Address(RVA = "0x2006088", Offset = "0x2006088", VA = "0x2006088", Slot = "70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170027CD")]
    public int LimitLevel
    {
      [Token(Token = "0x600BF46"), Address(RVA = "0x2006124", Offset = "0x2006124", VA = "0x2006124")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170027CE")]
    public bool IsLevelLimit
    {
      [Token(Token = "0x600BF47"), Address(RVA = "0x20061C8", Offset = "0x20061C8", VA = "0x20061C8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170027CF")]
    public int MaxLevel
    {
      [Token(Token = "0x600BF48"), Address(RVA = "0x20061F8", Offset = "0x20061F8", VA = "0x20061F8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170027D0")]
    public bool IsLevelMax
    {
      [Token(Token = "0x600BF49"), Address(RVA = "0x2006348", Offset = "0x2006348", VA = "0x2006348")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170027D1")]
    public int NextLevelExp
    {
      [Token(Token = "0x600BF4A"), Address(RVA = "0x2006378", Offset = "0x2006378", VA = "0x2006378", Slot = "71")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170027D2")]
    public float NextLevelExpRate
    {
      [Token(Token = "0x600BF4B"), Address(RVA = "0x2006414", Offset = "0x2006414", VA = "0x2006414", Slot = "72")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170027D3")]
    public int LimitBreakCount
    {
      [Token(Token = "0x600BF4C"), Address(RVA = "0x20064D0", Offset = "0x20064D0", VA = "0x20064D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600BF4D"), Address(RVA = "0x20064D8", Offset = "0x20064D8", VA = "0x20064D8")] private set
      {
      }
    }

    [Token(Token = "0x170027D4")]
    public int LimitBreakCountMax
    {
      [Token(Token = "0x600BF4E"), Address(RVA = "0x20062A8", Offset = "0x20062A8", VA = "0x20062A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170027D5")]
    public int AccessoryTypeId
    {
      [Token(Token = "0x600BF4F"), Address(RVA = "0x20064E0", Offset = "0x20064E0", VA = "0x20064E0")] get
      {
        return new int();
      }
      [Token(Token = "0x600BF50"), Address(RVA = "0x20064E8", Offset = "0x20064E8", VA = "0x20064E8")] private set
      {
      }
    }

    [Token(Token = "0x170027D6")]
    public bool HasOptionEffects
    {
      [Token(Token = "0x600BF51"), Address(RVA = "0x20064F0", Offset = "0x20064F0", VA = "0x20064F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BF52")]
    [Address(RVA = "0x2006514", Offset = "0x2006514", VA = "0x2006514")]
    private Accessory()
    {
    }

    [Token(Token = "0x600BF53")]
    [Address(RVA = "0x20065A0", Offset = "0x20065A0", VA = "0x20065A0", Slot = "66")]
    public override int GetCombatPower() => new int();

    [Token(Token = "0x600BF54")]
    [Address(RVA = "0x200661C", Offset = "0x200661C", VA = "0x200661C", Slot = "73")]
    public (int, int) GetPredictExperience(int value) => ();

    [Token(Token = "0x600BF55")]
    [Address(RVA = "0x2006730", Offset = "0x2006730", VA = "0x2006730", Slot = "29")]
    public override int GetElementReinforceValue(ElementTypeEnum type) => new int();

    [Token(Token = "0x600BF56")]
    [Address(RVA = "0x2006768", Offset = "0x2006768", VA = "0x2006768", Slot = "32")]
    public override int GetElementResistValue(ElementTypeEnum type) => new int();

    [Token(Token = "0x600BF57")]
    [Address(RVA = "0x20067A0", Offset = "0x20067A0", VA = "0x20067A0", Slot = "30")]
    public override int GetAttackReinforceValue(AttackTypeEnum type) => new int();

    [Token(Token = "0x600BF58")]
    [Address(RVA = "0x20067D8", Offset = "0x20067D8", VA = "0x20067D8", Slot = "33")]
    public override int GetAttackResistValue(AttackTypeEnum type) => new int();

    [Token(Token = "0x600BF59")]
    [Address(RVA = "0x2006810", Offset = "0x2006810", VA = "0x2006810", Slot = "31")]
    public override int GetBadStatusReinforceValue(BattleBadStatusTypeEnum type) => new int();

    [Token(Token = "0x600BF5A")]
    [Address(RVA = "0x2006848", Offset = "0x2006848", VA = "0x2006848", Slot = "34")]
    public override int GetBadStatusResistValue(BattleBadStatusTypeEnum type) => new int();

    [Token(Token = "0x600BF5B")]
    [Address(RVA = "0x2006880", Offset = "0x2006880", VA = "0x2006880", Slot = "35")]
    public override float GetOptionEffectElementReinforceValue(ElementTypeEnum type) => new float();

    [Token(Token = "0x600BF5C")]
    [Address(RVA = "0x20068EC", Offset = "0x20068EC", VA = "0x20068EC", Slot = "36")]
    public override float GetOptionEffectAttackReinforceValue(AttackTypeEnum type) => new float();

    [Token(Token = "0x600BF5D")]
    [Address(RVA = "0x2006958", Offset = "0x2006958", VA = "0x2006958", Slot = "37")]
    public override float GetOptionEffectBadStatusReinforceValue(BattleBadStatusTypeEnum type)
    {
      return new float();
    }

    [Token(Token = "0x600BF5E")]
    [Address(RVA = "0x20069C4", Offset = "0x20069C4", VA = "0x20069C4", Slot = "38")]
    public override float GetOptionEffectElementResistValue(ElementTypeEnum type) => new float();

    [Token(Token = "0x600BF5F")]
    [Address(RVA = "0x2006A30", Offset = "0x2006A30", VA = "0x2006A30", Slot = "39")]
    public override float GetOptionEffectAttackResistValue(AttackTypeEnum type) => new float();

    [Token(Token = "0x600BF60")]
    [Address(RVA = "0x2006A9C", Offset = "0x2006A9C", VA = "0x2006A9C", Slot = "40")]
    public override float GetOptionEffectBadStatusResistValue(BattleBadStatusTypeEnum type)
    {
      return new float();
    }

    [Token(Token = "0x600BF61")]
    [Address(RVA = "0x2006B08", Offset = "0x2006B08", VA = "0x2006B08", Slot = "41")]
    public override bool IsAddedStatusElementReinforceValue(ElementTypeEnum elementType)
    {
      return new bool();
    }

    [Token(Token = "0x600BF62")]
    [Address(RVA = "0x2006B24", Offset = "0x2006B24", VA = "0x2006B24", Slot = "42")]
    public override bool IsAddedStatusAttackReinforceValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x600BF63")]
    [Address(RVA = "0x2006B40", Offset = "0x2006B40", VA = "0x2006B40", Slot = "43")]
    public override bool IsAddedStatusBadStatusReinforceValue(
      BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x600BF64")]
    [Address(RVA = "0x2006B5C", Offset = "0x2006B5C", VA = "0x2006B5C", Slot = "44")]
    public override bool IsAddedStatusElementResistValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x600BF65")]
    [Address(RVA = "0x2006B78", Offset = "0x2006B78", VA = "0x2006B78", Slot = "45")]
    public override bool IsAddedStatusAttackResistValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x600BF66")]
    [Address(RVA = "0x2006B94", Offset = "0x2006B94", VA = "0x2006B94", Slot = "46")]
    public override bool IsAddedStatusBadStatusResistValue(
      BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x600BF67")]
    [Address(RVA = "0x2006BB0", Offset = "0x2006BB0", VA = "0x2006BB0")]
    public void Apply(PlayerGearAccessoryType entity)
    {
    }

    [Token(Token = "0x600BF68")]
    [Address(RVA = "0x2006D44", Offset = "0x2006D44", VA = "0x2006D44")]
    private AccessoryOptionEffect[] CreateAccessoryOptionEffects(List<PlayerGearOptionType> entity)
    {
      return (AccessoryOptionEffect[]) null;
    }

    [Token(Token = "0x600BF69")]
    [Address(RVA = "0x200709C", Offset = "0x200709C", VA = "0x200709C")]
    public Accessory CreateAssumptionFromLevel(int level) => (Accessory) null;

    [Token(Token = "0x600BF6A")]
    [Address(RVA = "0x20071CC", Offset = "0x20071CC", VA = "0x20071CC")]
    public static Accessory CreateByServerData(PlayerGearAccessoryType entity) => (Accessory) null;

    [Token(Token = "0x600BF6B")]
    [Address(RVA = "0x200752C", Offset = "0x200752C", VA = "0x200752C")]
    public static Accessory CreateByDummyData(int masterId) => (Accessory) null;

    [Token(Token = "0x600BF6C")]
    [Address(RVA = "0x20078D0", Offset = "0x20078D0", VA = "0x20078D0")]
    public static Accessory CreateByNpcData(int masterId) => (Accessory) null;

    [Token(Token = "0x600BF6D")]
    [Address(RVA = "0x2006E58", Offset = "0x2006E58", VA = "0x2006E58")]
    private void UpdateParameters()
    {
    }

    [Token(Token = "0x170027D7")]
    public bool IsShield
    {
      [Token(Token = "0x600BF6E"), Address(RVA = "0x2007ABC", Offset = "0x2007ABC", VA = "0x2007ABC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170027D8")]
    public bool IsAccessory
    {
      [Token(Token = "0x600BF6F"), Address(RVA = "0x2007AE0", Offset = "0x2007AE0", VA = "0x2007AE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BF70")]
    [Address(RVA = "0x2007B04", Offset = "0x2007B04", VA = "0x2007B04")]
    public int CalcCombatPower(AccessoryStandardStatus status) => new int();

    [Token(Token = "0x600BF71")]
    [Address(RVA = "0x2007BA8", Offset = "0x2007BA8", VA = "0x2007BA8")]
    public void GetLimitBreakItemData(
      int limitBreakNum,
      out int possessionAmount,
      out int needAmount)
    {
    }

    [Token(Token = "0x600BF72")]
    [Address(RVA = "0x2007CE8", Offset = "0x2007CE8", VA = "0x2007CE8", Slot = "47")]
    public override bool CheckEnhancedBadge() => new bool();
  }
}
