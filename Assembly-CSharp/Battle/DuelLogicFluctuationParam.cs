// Decompiled with JetBrains decompiler
// Type: Battle.DuelLogicFluctuationParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle
{
  [Token(Token = "0x200228F")]
  public struct DuelLogicFluctuationParam
  {
    [Token(Token = "0x40091A2")]
    [FieldOffset(Offset = "0x0")]
    public bool isAttackFromOutOfRange;
    [Token(Token = "0x40091A3")]
    [FieldOffset(Offset = "0x1")]
    public bool isAttackedFromOutOfRange;
    [Token(Token = "0x40091A4")]
    [FieldOffset(Offset = "0x8")]
    public (UnitParameterData supportUnit, SkillParameterData skill)? supportAttackParam;
    [Token(Token = "0x40091A5")]
    [FieldOffset(Offset = "0x20")]
    public (UnitParameterData supportUnit, SkillParameterData skill)? supportGuardParam;
    [Token(Token = "0x40091A6")]
    [FieldOffset(Offset = "0x38")]
    public bool isChasableAtkSpeed;
    [Token(Token = "0x40091A7")]
    [FieldOffset(Offset = "0x39")]
    public bool isSecondAttackable;
    [Token(Token = "0x40091A8")]
    [FieldOffset(Offset = "0x3A")]
    public bool isNullSecondAttack;
    [Token(Token = "0x40091A9")]
    [FieldOffset(Offset = "0x3B")]
    public bool isAbsoluteSecondAttack;
    [Token(Token = "0x40091AA")]
    [FieldOffset(Offset = "0x3C")]
    public bool isNullChase;
    [Token(Token = "0x40091AB")]
    [FieldOffset(Offset = "0x3D")]
    public bool isAbsoluteChase;
    [Token(Token = "0x40091AC")]
    [FieldOffset(Offset = "0x3E")]
    public bool isFirstStrikable;
    [Token(Token = "0x40091AD")]
    [FieldOffset(Offset = "0x3F")]
    public bool isSecondStrikable;
    [Token(Token = "0x40091AE")]
    [FieldOffset(Offset = "0x40")]
    public bool isFastChasable;

    [Token(Token = "0x600D2BF")]
    [Address(RVA = "0x1965284", Offset = "0x1965284", VA = "0x1965284")]
    public bool IsReverse(DuelLogicFluctuationParam target) => new bool();
  }
}
