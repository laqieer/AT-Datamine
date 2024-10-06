// Decompiled with JetBrains decompiler
// Type: Battle.Data.DuelConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200274E")]
  public class DuelConditionParam : ConditionParam
  {
    [Token(Token = "0x400A7E6")]
    [FieldOffset(Offset = "0x44")]
    private ActiveSkillActionGroup duelActionType;

    [Token(Token = "0x600F51A")]
    [Address(RVA = "0x1FB387C", Offset = "0x1FB387C", VA = "0x1FB387C")]
    public static DuelConditionParam Create(
      BoardData board,
      ITargettable activator,
      WeaponParameterData activatorWeaponParam,
      ITargettable target,
      WeaponParameterData targetWeaponParam,
      ActiveSkillActionGroup duelActionType)
    {
      return (DuelConditionParam) null;
    }

    [Token(Token = "0x600F51B")]
    [Address(RVA = "0x1FB3D14", Offset = "0x1FB3D14", VA = "0x1FB3D14")]
    private DuelConditionParam(
      BoardData board,
      ITargettable activator,
      WeaponParameterData activatorWeaponParam,
      ITargettable target,
      WeaponParameterData targetWeaponParam)
    {
    }

    [Token(Token = "0x600F51C")]
    [Address(RVA = "0x1FB3D64", Offset = "0x1FB3D64", VA = "0x1FB3D64", Slot = "5")]
    public override bool IsValidCondition(SkillTriggerConditionTypeEnum conditionType)
    {
      return new bool();
    }

    [Token(Token = "0x600F51D")]
    [Address(RVA = "0x1FB3D74", Offset = "0x1FB3D74", VA = "0x1FB3D74", Slot = "6")]
    protected override bool IsMatchConditionImpl(SkillTriggerConditionDetailData detail)
    {
      return new bool();
    }
  }
}
