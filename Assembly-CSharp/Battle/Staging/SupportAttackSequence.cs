// Decompiled with JetBrains decompiler
// Type: Battle.Staging.SupportAttackSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Grid;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002593")]
  public sealed class SupportAttackSequence : SupportActionSequence
  {
    [Token(Token = "0x400A1A1")]
    [FieldOffset(Offset = "0x70")]
    private Action<GridObject, Action> AttackAction;

    [Token(Token = "0x600E7F6")]
    [Address(RVA = "0x4C3B984", Offset = "0x4C3B984", VA = "0x4C3B984")]
    public SupportAttackSequence(
      UnitParameterData ownerUnit,
      UnitParameterData supportUnit,
      UnitParameterData targetUnit,
      IDirector director,
      Action<GridObject, Action> atkAction,
      Action onCompletedAction)
    {
    }

    [Token(Token = "0x600E7F7")]
    [Address(RVA = "0x4C3B9E8", Offset = "0x4C3B9E8", VA = "0x4C3B9E8", Slot = "9")]
    public override void Start()
    {
    }

    [Token(Token = "0x600E7F8")]
    [Address(RVA = "0x4C3C020", Offset = "0x4C3C020", VA = "0x4C3C020")]
    private void SingleSupportAttack()
    {
    }

    [Token(Token = "0x600E7F9")]
    [Address(RVA = "0x4C3BB7C", Offset = "0x4C3BB7C", VA = "0x4C3BB7C")]
    private void DoubleSupportAttack()
    {
    }
  }
}
