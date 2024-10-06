// Decompiled with JetBrains decompiler
// Type: Battle.Staging.InitiateSingleSkillSequence
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
  [Token(Token = "0x2002582")]
  public sealed class InitiateSingleSkillSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A12A")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData owner;
    [Token(Token = "0x400A12B")]
    [FieldOffset(Offset = "0x20")]
    private CharacterActor ownerActor;
    [Token(Token = "0x400A12C")]
    [FieldOffset(Offset = "0x28")]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x400A12D")]
    [FieldOffset(Offset = "0x30")]
    private ParticleEmitter.Handle handle;
    [Token(Token = "0x400A12E")]
    [FieldOffset(Offset = "0x40")]
    private Action onCompleted;

    [Token(Token = "0x600E779")]
    [Address(RVA = "0x4874164", Offset = "0x4874164", VA = "0x4874164")]
    public static InitiateSingleSkillSequence Create(
      UnitParameterData owner,
      CharacterActor ownerActor,
      IDirector mainDirector,
      Action onCompleted)
    {
      return (InitiateSingleSkillSequence) null;
    }

    [Token(Token = "0x17003190")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E77A"), Address(RVA = "0x487ED60", Offset = "0x487ED60", VA = "0x487ED60", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E77B"), Address(RVA = "0x487ED68", Offset = "0x487ED68", VA = "0x487ED68")] private set
      {
      }
    }

    [Token(Token = "0x600E77C")]
    [Address(RVA = "0x487EC50", Offset = "0x487EC50", VA = "0x487EC50")]
    private InitiateSingleSkillSequence(
      UnitParameterData owner,
      CharacterActor ownerActor,
      IDirector mainDirector,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E77D")]
    [Address(RVA = "0x487ED74", Offset = "0x487ED74", VA = "0x487ED74", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E77E")]
    [Address(RVA = "0x487EE20", Offset = "0x487EE20", VA = "0x487EE20", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E77F")]
    [Address(RVA = "0x487EE6C", Offset = "0x487EE6C", VA = "0x487EE6C", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E780")]
    [Address(RVA = "0x487EE9C", Offset = "0x487EE9C", VA = "0x487EE9C", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E781")]
    [Address(RVA = "0x487ED78", Offset = "0x487ED78", VA = "0x487ED78")]
    private void ShowStartSkillVfx()
    {
    }
  }
}
