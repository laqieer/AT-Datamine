// Decompiled with JetBrains decompiler
// Type: Battle.Data.ActionResultConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002748")]
  public class ActionResultConditionParam : ConditionParam
  {
    [Token(Token = "0x400A7D4")]
    [FieldOffset(Offset = "0x44")]
    private bool isHealedYourself;
    [Token(Token = "0x400A7D5")]
    [FieldOffset(Offset = "0x45")]
    private bool isHealedOthers;
    [Token(Token = "0x400A7D6")]
    [FieldOffset(Offset = "0x46")]
    private bool isKilledUnit;

    [Token(Token = "0x600F4D6")]
    [Address(RVA = "0x1FB0BB8", Offset = "0x1FB0BB8", VA = "0x1FB0BB8")]
    public static ActionResultConditionParam Create(
      BoardData board,
      ITargettable activator,
      WeaponParameterData activatorWeaponParam,
      ITargettable target,
      WeaponParameterData targetWeaponParam,
      bool isHealedYourself,
      bool isHealedOthers,
      bool isKilledUnit)
    {
      return (ActionResultConditionParam) null;
    }

    [Token(Token = "0x600F4D7")]
    [Address(RVA = "0x1FB0C78", Offset = "0x1FB0C78", VA = "0x1FB0C78")]
    private ActionResultConditionParam(
      BoardData board,
      ITargettable activator,
      WeaponParameterData activatorWeaponParam,
      ITargettable target,
      WeaponParameterData targetWeaponParam)
    {
    }

    [Token(Token = "0x600F4D8")]
    [Address(RVA = "0x1FB0CC8", Offset = "0x1FB0CC8", VA = "0x1FB0CC8", Slot = "5")]
    public override bool IsValidCondition(SkillTriggerConditionTypeEnum conditionType)
    {
      return new bool();
    }

    [Token(Token = "0x600F4D9")]
    [Address(RVA = "0x1FB0CE8", Offset = "0x1FB0CE8", VA = "0x1FB0CE8", Slot = "6")]
    protected override bool IsMatchConditionImpl(SkillTriggerConditionDetailData detail)
    {
      return new bool();
    }
  }
}
