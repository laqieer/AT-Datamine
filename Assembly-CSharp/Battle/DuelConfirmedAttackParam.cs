// Decompiled with JetBrains decompiler
// Type: Battle.DuelConfirmedAttackParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002290")]
  public class DuelConfirmedAttackParam
  {
    [Token(Token = "0x40091AF")]
    [FieldOffset(Offset = "0x10")]
    public readonly TargetPair Atk;
    [Token(Token = "0x40091B0")]
    [FieldOffset(Offset = "0x18")]
    private readonly SkillParameterData specifiedAtkSkill;
    [Token(Token = "0x40091B1")]
    [FieldOffset(Offset = "0x20")]
    public readonly TargetPair MainDef;
    [Token(Token = "0x40091B2")]
    [FieldOffset(Offset = "0x28")]
    public readonly List<TargetPair> Defs;
    [Token(Token = "0x40091B3")]
    [FieldOffset(Offset = "0x30")]
    public readonly UnitParameterData SupportGuardUnit;
    [Token(Token = "0x40091B4")]
    [FieldOffset(Offset = "0x38")]
    public readonly SkillParameterData SupportGuardParam;

    [Token(Token = "0x600D2C0")]
    [Address(RVA = "0x19652C0", Offset = "0x19652C0", VA = "0x19652C0")]
    public DuelConfirmedAttackParam(
      TargetPair atk,
      SkillParameterData specifiedAtkSkill,
      TargetPair mainDef,
      List<TargetPair> defs,
      UnitParameterData supportGuardUnit,
      SkillParameterData supportGuardParam)
    {
    }

    [Token(Token = "0x17002DB4")]
    public SkillParameterData AtkSkill
    {
      [Token(Token = "0x600D2C1"), Address(RVA = "0x1965314", Offset = "0x1965314", VA = "0x1965314")] get
      {
        return (SkillParameterData) null;
      }
    }
  }
}
