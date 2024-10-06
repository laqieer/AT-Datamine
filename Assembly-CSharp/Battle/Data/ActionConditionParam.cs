// Decompiled with JetBrains decompiler
// Type: Battle.Data.ActionConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002747")]
  public class ActionConditionParam : ConditionParam
  {
    [Token(Token = "0x400A7CF")]
    [FieldOffset(Offset = "0x44")]
    public ActiveSkillActionGroup duelActionType;
    [Token(Token = "0x400A7D0")]
    [FieldOffset(Offset = "0x48")]
    private bool isLaunchAttack;
    [Token(Token = "0x400A7D1")]
    [FieldOffset(Offset = "0x49")]
    private bool isLaunchedAttack;
    [Token(Token = "0x400A7D2")]
    [FieldOffset(Offset = "0x4A")]
    private bool isAttackFromOutOfRange;
    [Token(Token = "0x400A7D3")]
    [FieldOffset(Offset = "0x4B")]
    private bool isAttackedFromOutOfRange;

    [Token(Token = "0x600F4D2")]
    [Address(RVA = "0x1FB09C0", Offset = "0x1FB09C0", VA = "0x1FB09C0")]
    public static ActionConditionParam Create(
      BoardData board,
      ITargettable activator,
      WeaponParameterData activatorWeaponParam,
      ITargettable target,
      WeaponParameterData targetWeaponParam,
      bool isLaunchAttack,
      bool isLaunchedAttack,
      bool isAttackFromOutOfRange,
      bool isAttackedFromOutOfRange)
    {
      return (ActionConditionParam) null;
    }

    [Token(Token = "0x600F4D3")]
    [Address(RVA = "0x1FB0A8C", Offset = "0x1FB0A8C", VA = "0x1FB0A8C")]
    private ActionConditionParam(
      BoardData board,
      ITargettable activator,
      WeaponParameterData activatorWeaponParam,
      ITargettable target,
      WeaponParameterData targetWeaponParam)
    {
    }

    [Token(Token = "0x600F4D4")]
    [Address(RVA = "0x1FB0B2C", Offset = "0x1FB0B2C", VA = "0x1FB0B2C", Slot = "5")]
    public override bool IsValidCondition(SkillTriggerConditionTypeEnum conditionType)
    {
      return new bool();
    }

    [Token(Token = "0x600F4D5")]
    [Address(RVA = "0x1FB0B50", Offset = "0x1FB0B50", VA = "0x1FB0B50", Slot = "6")]
    protected override bool IsMatchConditionImpl(SkillTriggerConditionDetailData detail)
    {
      return new bool();
    }
  }
}
