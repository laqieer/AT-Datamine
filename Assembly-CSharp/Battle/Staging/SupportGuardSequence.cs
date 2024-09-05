// Decompiled with JetBrains decompiler
// Type: Battle.Staging.SupportGuardSequence
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
  [Token(Token = "0x2002595")]
  public sealed class SupportGuardSequence : SupportActionSequence
  {
    [Token(Token = "0x400A1A6")]
    [FieldOffset(Offset = "0x70")]
    private Action<GridObject, Action> AttackAction;

    [Token(Token = "0x600E807")]
    [Address(RVA = "0x4C3CD60", Offset = "0x4C3CD60", VA = "0x4C3CD60")]
    public SupportGuardSequence(
      UnitParameterData ownerUnit,
      UnitParameterData supportUnit,
      UnitParameterData targetUnit,
      IDirector director,
      Action<GridObject, Action> atkAction,
      Action onCompletedAction)
    {
    }

    [Token(Token = "0x600E808")]
    [Address(RVA = "0x4C3CDC8", Offset = "0x4C3CDC8", VA = "0x4C3CDC8", Slot = "9")]
    public override void Start()
    {
    }

    [Token(Token = "0x600E809")]
    [Address(RVA = "0x4C3D39C", Offset = "0x4C3D39C", VA = "0x4C3D39C")]
    private void SingleSupportGuard()
    {
    }

    [Token(Token = "0x600E80A")]
    [Address(RVA = "0x4C3D9B8", Offset = "0x4C3D9B8", VA = "0x4C3D9B8")]
    private void PlayGuardParticle()
    {
    }

    [Token(Token = "0x600E80B")]
    [Address(RVA = "0x4C3CEF8", Offset = "0x4C3CEF8", VA = "0x4C3CEF8")]
    private void DoubleSupportGuard()
    {
    }
  }
}
