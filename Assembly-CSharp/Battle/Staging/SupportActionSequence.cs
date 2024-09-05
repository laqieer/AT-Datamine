// Decompiled with JetBrains decompiler
// Type: Battle.Staging.SupportActionSequence
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
  [Token(Token = "0x200258F")]
  public class SupportActionSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A18E")]
    [FieldOffset(Offset = "0x18")]
    protected UnitParameterData Owner;
    [Token(Token = "0x400A18F")]
    [FieldOffset(Offset = "0x20")]
    protected CharacterActor OwnerActor;
    [Token(Token = "0x400A190")]
    [FieldOffset(Offset = "0x28")]
    protected UnitParameterData Supporter;
    [Token(Token = "0x400A191")]
    [FieldOffset(Offset = "0x30")]
    protected CharacterActor SupportActor;
    [Token(Token = "0x400A192")]
    [FieldOffset(Offset = "0x38")]
    protected UnitParameterData Target;
    [Token(Token = "0x400A193")]
    [FieldOffset(Offset = "0x40")]
    protected CharacterActor TargetActor;
    [Token(Token = "0x400A194")]
    [FieldOffset(Offset = "0x48")]
    protected ParticleEmitter ParticleEmitter;
    [Token(Token = "0x400A195")]
    [FieldOffset(Offset = "0x50")]
    protected bool IsPlayingParticle;
    [Token(Token = "0x400A196")]
    [FieldOffset(Offset = "0x58")]
    protected Action OnCompleted;
    [Token(Token = "0x400A197")]
    [FieldOffset(Offset = "0x60")]
    protected IDirector MainDirector;
    [Token(Token = "0x400A198")]
    [FieldOffset(Offset = "0x68")]
    protected SupportActionType ActionType;
    [Token(Token = "0x400A199")]
    [FieldOffset(Offset = "0x6C")]
    protected bool IsDouble;
    [Token(Token = "0x400A19A")]
    [FieldOffset(Offset = "0x6D")]
    protected bool IsEndAttack;

    [Token(Token = "0x1700319C")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E7E7"), Address(RVA = "0x4C3B064", Offset = "0x4C3B064", VA = "0x4C3B064", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E7E8"), Address(RVA = "0x4C3B06C", Offset = "0x4C3B06C", VA = "0x4C3B06C")] private set
      {
      }
    }

    [Token(Token = "0x600E7E9")]
    [Address(RVA = "0x4C3B078", Offset = "0x4C3B078", VA = "0x4C3B078", Slot = "9")]
    public virtual void Start()
    {
    }

    [Token(Token = "0x600E7EA")]
    [Address(RVA = "0x4C3B2C4", Offset = "0x4C3B2C4", VA = "0x4C3B2C4", Slot = "10")]
    public virtual void Step(float delta)
    {
    }

    [Token(Token = "0x600E7EB")]
    [Address(RVA = "0x4C3B2DC", Offset = "0x4C3B2DC", VA = "0x4C3B2DC", Slot = "11")]
    public virtual void Complete()
    {
    }

    [Token(Token = "0x600E7EC")]
    [Address(RVA = "0x4C3B30C", Offset = "0x4C3B30C", VA = "0x4C3B30C", Slot = "12")]
    public virtual void Abort()
    {
    }

    [Token(Token = "0x600E7ED")]
    [Address(RVA = "0x4C3B310", Offset = "0x4C3B310", VA = "0x4C3B310")]
    protected StagingDirector.ISequence CreateMoveSequence(
      UnitParameterData unit,
      GridData moveFrom,
      GridData moveTo)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x600E7EE")]
    [Address(RVA = "0x4C3B3DC", Offset = "0x4C3B3DC", VA = "0x4C3B3DC")]
    protected void PlaySupportAura(Action onComplete)
    {
    }

    [Token(Token = "0x600E7EF")]
    [Address(RVA = "0x4C3B778", Offset = "0x4C3B778", VA = "0x4C3B778")]
    protected void SetActorColor()
    {
    }

    [Token(Token = "0x600E7F0")]
    [Address(RVA = "0x4C3B8EC", Offset = "0x4C3B8EC", VA = "0x4C3B8EC")]
    protected void ReturnActorColor()
    {
    }

    [Token(Token = "0x600E7F1")]
    [Address(RVA = "0x4C3B944", Offset = "0x4C3B944", VA = "0x4C3B944")]
    public SupportActionSequence()
    {
    }
  }
}
