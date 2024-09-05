// Decompiled with JetBrains decompiler
// Type: StaqData.UnitTrust
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002028")]
  public class UnitTrust : Equipment
  {
    [Token(Token = "0x17002828")]
    public TrustData MasterData
    {
      [Token(Token = "0x600C050"), Address(RVA = "0x200BDD0", Offset = "0x200BDD0", VA = "0x200BDD0")] get
      {
        return (TrustData) null;
      }
      [Token(Token = "0x600C051"), Address(RVA = "0x200BDD8", Offset = "0x200BDD8", VA = "0x200BDD8")] private set
      {
      }
    }

    [Token(Token = "0x17002829")]
    public UnitTrustSkill SkillData
    {
      [Token(Token = "0x600C052"), Address(RVA = "0x200BDE0", Offset = "0x200BDE0", VA = "0x200BDE0")] get
      {
        return (UnitTrustSkill) null;
      }
      [Token(Token = "0x600C053"), Address(RVA = "0x200BDE8", Offset = "0x200BDE8", VA = "0x200BDE8")] private set
      {
      }
    }

    [Token(Token = "0x600C054")]
    [Address(RVA = "0x200BDF0", Offset = "0x200BDF0", VA = "0x200BDF0", Slot = "29")]
    public override int GetElementReinforceValue(ElementTypeEnum type) => new int();

    [Token(Token = "0x600C055")]
    [Address(RVA = "0x200BE10", Offset = "0x200BE10", VA = "0x200BE10", Slot = "32")]
    public override int GetElementResistValue(ElementTypeEnum type) => new int();

    [Token(Token = "0x600C056")]
    [Address(RVA = "0x200BE30", Offset = "0x200BE30", VA = "0x200BE30", Slot = "30")]
    public override int GetAttackReinforceValue(AttackTypeEnum type) => new int();

    [Token(Token = "0x600C057")]
    [Address(RVA = "0x200BE50", Offset = "0x200BE50", VA = "0x200BE50", Slot = "33")]
    public override int GetAttackResistValue(AttackTypeEnum type) => new int();

    [Token(Token = "0x600C058")]
    [Address(RVA = "0x200BE70", Offset = "0x200BE70", VA = "0x200BE70", Slot = "31")]
    public override int GetBadStatusReinforceValue(BattleBadStatusTypeEnum type) => new int();

    [Token(Token = "0x600C059")]
    [Address(RVA = "0x200BE90", Offset = "0x200BE90", VA = "0x200BE90", Slot = "34")]
    public override int GetBadStatusResistValue(BattleBadStatusTypeEnum type) => new int();

    [Token(Token = "0x600C05A")]
    [Address(RVA = "0x200BEB0", Offset = "0x200BEB0", VA = "0x200BEB0", Slot = "41")]
    public override bool IsAddedStatusElementReinforceValue(ElementTypeEnum elementType)
    {
      return new bool();
    }

    [Token(Token = "0x600C05B")]
    [Address(RVA = "0x200BECC", Offset = "0x200BECC", VA = "0x200BECC", Slot = "42")]
    public override bool IsAddedStatusAttackReinforceValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x600C05C")]
    [Address(RVA = "0x200BEE8", Offset = "0x200BEE8", VA = "0x200BEE8", Slot = "43")]
    public override bool IsAddedStatusBadStatusReinforceValue(
      BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x600C05D")]
    [Address(RVA = "0x200BF04", Offset = "0x200BF04", VA = "0x200BF04", Slot = "44")]
    public override bool IsAddedStatusElementResistValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x600C05E")]
    [Address(RVA = "0x200BF20", Offset = "0x200BF20", VA = "0x200BF20", Slot = "45")]
    public override bool IsAddedStatusAttackResistValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x600C05F")]
    [Address(RVA = "0x200BF3C", Offset = "0x200BF3C", VA = "0x200BF3C", Slot = "46")]
    public override bool IsAddedStatusBadStatusResistValue(
      BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x600C060")]
    [Address(RVA = "0x200BF58", Offset = "0x200BF58", VA = "0x200BF58")]
    public void Apply(PlayerGearUnitTrustType entity)
    {
    }

    [Token(Token = "0x600C061")]
    [Address(RVA = "0x200C160", Offset = "0x200C160", VA = "0x200C160")]
    public static UnitTrust CreateByServerData(PlayerGearUnitTrustType entity) => (UnitTrust) null;

    [Token(Token = "0x600C062")]
    [Address(RVA = "0x200C354", Offset = "0x200C354", VA = "0x200C354")]
    public static UnitTrust CreateByMasterData(int masterId) => (UnitTrust) null;

    [Token(Token = "0x600C063")]
    [Address(RVA = "0x200C704", Offset = "0x200C704", VA = "0x200C704", Slot = "47")]
    public override bool CheckEnhancedBadge() => new bool();

    [Token(Token = "0x600C064")]
    [Address(RVA = "0x200C34C", Offset = "0x200C34C", VA = "0x200C34C")]
    public UnitTrust()
    {
    }
  }
}
