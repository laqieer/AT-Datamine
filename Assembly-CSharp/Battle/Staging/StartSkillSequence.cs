// Decompiled with JetBrains decompiler
// Type: Battle.Staging.StartSkillSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Grid;
using Battle.Particle;
using Battle.Unit;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200258D")]
  public sealed class StartSkillSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A17A")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData owner;
    [Token(Token = "0x400A17B")]
    [FieldOffset(Offset = "0x20")]
    private CharacterActor ownerActor;
    [Token(Token = "0x400A17C")]
    [FieldOffset(Offset = "0x28")]
    private GridObject castFrom;
    [Token(Token = "0x400A17D")]
    [FieldOffset(Offset = "0x30")]
    private GridObject castTo;
    [Token(Token = "0x400A17E")]
    [FieldOffset(Offset = "0x38")]
    private SkillParameterData usingSkill;
    [Token(Token = "0x400A17F")]
    [FieldOffset(Offset = "0x40")]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x400A180")]
    [FieldOffset(Offset = "0x48")]
    private List<ParticleEmitter.Handle> handles;
    [Token(Token = "0x400A181")]
    [FieldOffset(Offset = "0x50")]
    private Action onCompleted;
    [Token(Token = "0x400A182")]
    [FieldOffset(Offset = "0x58")]
    private bool isUpdatePos;

    [Token(Token = "0x600E7CE")]
    [Address(RVA = "0x4C39D0C", Offset = "0x4C39D0C", VA = "0x4C39D0C")]
    public static StartSkillSequence Create(
      UnitParameterData owner,
      CharacterActor ownerActor,
      GridObject castFrom,
      GridObject castTo,
      SkillParameterData usingSkill,
      IDirector mainDirector,
      Action onCompleted,
      bool isUpdatePos = true)
    {
      return (StartSkillSequence) null;
    }

    [Token(Token = "0x1700319A")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E7CF"), Address(RVA = "0x4C39F28", Offset = "0x4C39F28", VA = "0x4C39F28", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E7D0"), Address(RVA = "0x4C39F30", Offset = "0x4C39F30", VA = "0x4C39F30")] private set
      {
      }
    }

    [Token(Token = "0x600E7D1")]
    [Address(RVA = "0x4C39DD0", Offset = "0x4C39DD0", VA = "0x4C39DD0")]
    private StartSkillSequence(
      UnitParameterData owner,
      CharacterActor ownerActor,
      GridObject castFrom,
      GridObject castTo,
      SkillParameterData usingSkill,
      IDirector mainDirector,
      Action onCompleted,
      bool isUpdatePos)
    {
    }

    [Token(Token = "0x600E7D2")]
    [Address(RVA = "0x4C39F3C", Offset = "0x4C39F3C", VA = "0x4C39F3C", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E7D3")]
    [Address(RVA = "0x4C3A3A8", Offset = "0x4C3A3A8", VA = "0x4C3A3A8", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E7D4")]
    [Address(RVA = "0x4C3A544", Offset = "0x4C3A544", VA = "0x4C3A544", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E7D5")]
    [Address(RVA = "0x4C3A574", Offset = "0x4C3A574", VA = "0x4C3A574", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E7D6")]
    [Address(RVA = "0x4C3A13C", Offset = "0x4C3A13C", VA = "0x4C3A13C")]
    private void ShowChantMagicVfxes()
    {
    }

    [Token(Token = "0x600E7D7")]
    [Address(RVA = "0x4C3A578", Offset = "0x4C3A578", VA = "0x4C3A578")]
    private void AddParticleHandle(ParticleEmitter.Handle handle)
    {
    }
  }
}
