// Decompiled with JetBrains decompiler
// Type: Battle.Staging.DrainHealingSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Particle;
using Battle.Unit;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002579")]
  public sealed class DrainHealingSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A0EE")]
    [FieldOffset(Offset = "0x18")]
    private CharacterActor owner;
    [Token(Token = "0x400A0EF")]
    [FieldOffset(Offset = "0x20")]
    private CharacterActor target;
    [Token(Token = "0x400A0F0")]
    [FieldOffset(Offset = "0x28")]
    private int healValue;
    [Token(Token = "0x400A0F1")]
    [FieldOffset(Offset = "0x30")]
    private IDirector mainDirector;
    [Token(Token = "0x400A0F2")]
    [FieldOffset(Offset = "0x38")]
    private UnitParameterData targetUnitParam;
    [Token(Token = "0x400A0F3")]
    [FieldOffset(Offset = "0x40")]
    private UnitParameterData targetDoubleUnitParam;
    [Token(Token = "0x400A0F4")]
    [FieldOffset(Offset = "0x48")]
    private FieldDamageDirector fieldDmg;
    [Token(Token = "0x400A0F5")]
    [FieldOffset(Offset = "0x50")]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x400A0F6")]
    [FieldOffset(Offset = "0x58")]
    private ParticleEmitter.Handle particleHandle;
    [Token(Token = "0x400A0F7")]
    [FieldOffset(Offset = "0x68")]
    private Action onCompleted;

    [Token(Token = "0x600E72A")]
    [Address(RVA = "0x4872990", Offset = "0x4872990", VA = "0x4872990")]
    public static DrainHealingSequence Create(
      CharacterActor owner,
      int healValue,
      CharacterActor target,
      IDirector mainDirector,
      UnitParameterData ownerUnitParam,
      UnitParameterData ownerDoubleUnitParam,
      Action onCompleted)
    {
      return (DrainHealingSequence) null;
    }

    [Token(Token = "0x17003186")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E72B"), Address(RVA = "0x487BB34", Offset = "0x487BB34", VA = "0x487BB34", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E72C"), Address(RVA = "0x487BB3C", Offset = "0x487BB3C", VA = "0x487BB3C")] private set
      {
      }
    }

    [Token(Token = "0x600E72D")]
    [Address(RVA = "0x487B9D8", Offset = "0x487B9D8", VA = "0x487B9D8")]
    private DrainHealingSequence(
      CharacterActor owner,
      int healValue,
      CharacterActor target,
      IDirector mainDirector,
      UnitParameterData targetUnitParam,
      UnitParameterData targetDoubleUnitParam,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E72E")]
    [Address(RVA = "0x487BB48", Offset = "0x487BB48", VA = "0x487BB48", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E72F")]
    [Address(RVA = "0x487BC20", Offset = "0x487BC20", VA = "0x487BC20", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E730")]
    [Address(RVA = "0x487BC70", Offset = "0x487BC70", VA = "0x487BC70", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E731")]
    [Address(RVA = "0x487BD70", Offset = "0x487BD70", VA = "0x487BD70", Slot = "6")]
    public void Abort()
    {
    }
  }
}
