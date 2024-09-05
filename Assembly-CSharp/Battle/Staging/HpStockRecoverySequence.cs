// Decompiled with JetBrains decompiler
// Type: Battle.Staging.HpStockRecoverySequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Unit;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200257F")]
  public sealed class HpStockRecoverySequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A117")]
    [FieldOffset(Offset = "0x18")]
    private Action function;
    [Token(Token = "0x400A118")]
    [FieldOffset(Offset = "0x20")]
    private CharacterActor actor;
    [Token(Token = "0x400A119")]
    [FieldOffset(Offset = "0x28")]
    private UnitParameterData unit;
    [Token(Token = "0x400A11A")]
    [FieldOffset(Offset = "0x30")]
    private bool endParticle;

    [Token(Token = "0x1700318D")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E75C"), Address(RVA = "0x487E1C0", Offset = "0x487E1C0", VA = "0x487E1C0", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E75D"), Address(RVA = "0x487E1C8", Offset = "0x487E1C8", VA = "0x487E1C8")] private set
      {
      }
    }

    [Token(Token = "0x600E75E")]
    [Address(RVA = "0x487E1D4", Offset = "0x487E1D4", VA = "0x487E1D4")]
    public static HpStockRecoverySequence Create(CharacterActor actor, UnitParameterData unit)
    {
      return (HpStockRecoverySequence) null;
    }

    [Token(Token = "0x600E75F")]
    [Address(RVA = "0x487E244", Offset = "0x487E244", VA = "0x487E244")]
    private HpStockRecoverySequence(CharacterActor actor, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600E760")]
    [Address(RVA = "0x487E270", Offset = "0x487E270", VA = "0x487E270", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E761")]
    [Address(RVA = "0x487E3D4", Offset = "0x487E3D4", VA = "0x487E3D4", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E762")]
    [Address(RVA = "0x487E428", Offset = "0x487E428", VA = "0x487E428", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E763")]
    [Address(RVA = "0x487E434", Offset = "0x487E434", VA = "0x487E434", Slot = "6")]
    public void Abort()
    {
    }
  }
}
