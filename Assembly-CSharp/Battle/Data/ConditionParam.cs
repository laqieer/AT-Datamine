// Decompiled with JetBrains decompiler
// Type: Battle.Data.ConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002749")]
  public abstract class ConditionParam
  {
    [Token(Token = "0x400A7DC")]
    [FieldOffset(Offset = "0x38")]
    public ActionResult ActionResult;

    [Token(Token = "0x17003456")]
    public BoardData Board
    {
      [Token(Token = "0x600F4DA"), Address(RVA = "0x1FB0D3C", Offset = "0x1FB0D3C", VA = "0x1FB0D3C")] get
      {
        return (BoardData) null;
      }
      [Token(Token = "0x600F4DB"), Address(RVA = "0x1FB0D44", Offset = "0x1FB0D44", VA = "0x1FB0D44")] protected set
      {
      }
    }

    [Token(Token = "0x17003457")]
    public ITargettable Activator
    {
      [Token(Token = "0x600F4DC"), Address(RVA = "0x1FB0D4C", Offset = "0x1FB0D4C", VA = "0x1FB0D4C")] get
      {
        return (ITargettable) null;
      }
      [Token(Token = "0x600F4DD"), Address(RVA = "0x1FB0D54", Offset = "0x1FB0D54", VA = "0x1FB0D54")] protected set
      {
      }
    }

    [Token(Token = "0x17003458")]
    public WeaponParameterData ActivatorWeaponParam
    {
      [Token(Token = "0x600F4DE"), Address(RVA = "0x1FB0D5C", Offset = "0x1FB0D5C", VA = "0x1FB0D5C")] get
      {
        return (WeaponParameterData) null;
      }
      [Token(Token = "0x600F4DF"), Address(RVA = "0x1FB0D64", Offset = "0x1FB0D64", VA = "0x1FB0D64")] protected set
      {
      }
    }

    [Token(Token = "0x17003459")]
    public ITargettable Target
    {
      [Token(Token = "0x600F4E0"), Address(RVA = "0x1FB0D6C", Offset = "0x1FB0D6C", VA = "0x1FB0D6C")] get
      {
        return (ITargettable) null;
      }
      [Token(Token = "0x600F4E1"), Address(RVA = "0x1FB0D74", Offset = "0x1FB0D74", VA = "0x1FB0D74")] protected set
      {
      }
    }

    [Token(Token = "0x1700345A")]
    public WeaponParameterData TargetWeaponParam
    {
      [Token(Token = "0x600F4E2"), Address(RVA = "0x1FB0D7C", Offset = "0x1FB0D7C", VA = "0x1FB0D7C")] get
      {
        return (WeaponParameterData) null;
      }
      [Token(Token = "0x600F4E3"), Address(RVA = "0x1FB0D84", Offset = "0x1FB0D84", VA = "0x1FB0D84")] protected set
      {
      }
    }

    [Token(Token = "0x1700345B")]
    public ConditionTargetTypeEnum ConditionTargetType
    {
      [Token(Token = "0x600F4E4"), Address(RVA = "0x1FB0D8C", Offset = "0x1FB0D8C", VA = "0x1FB0D8C")] get
      {
        return new ConditionTargetTypeEnum();
      }
      [Token(Token = "0x600F4E5"), Address(RVA = "0x1FB0D94", Offset = "0x1FB0D94", VA = "0x1FB0D94")] protected set
      {
      }
    }

    [Token(Token = "0x600F4E6")]
    [Address(RVA = "0x1FB0ADC", Offset = "0x1FB0ADC", VA = "0x1FB0ADC")]
    protected ConditionParam(
      BoardData board,
      ITargettable activator,
      WeaponParameterData activatorWeaponParam,
      ITargettable target,
      WeaponParameterData targetWeaponParam)
    {
    }

    [Token(Token = "0x600F4E7")]
    [Address(RVA = "0x1FB0D9C", Offset = "0x1FB0D9C", VA = "0x1FB0D9C")]
    public bool IsMatchCondition(
      SkillTriggerConditionDetailData detail,
      ConditionTargetTypeEnum targetType)
    {
      return new bool();
    }

    [Token(Token = "0x600F4E8")]
    [Address(RVA = "0x1FB0E0C", Offset = "0x1FB0E0C", VA = "0x1FB0E0C", Slot = "4")]
    public virtual void SetConditionTarget(ConditionTargetTypeEnum targetType)
    {
    }

    [Token(Token = "0x600F4E9")]
    public abstract bool IsValidCondition(SkillTriggerConditionTypeEnum conditionType);

    [Token(Token = "0x600F4EA")]
    protected abstract bool IsMatchConditionImpl(SkillTriggerConditionDetailData detail);
  }
}
