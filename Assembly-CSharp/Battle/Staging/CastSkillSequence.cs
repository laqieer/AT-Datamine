// Decompiled with JetBrains decompiler
// Type: Battle.Staging.CastSkillSequence
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
using UnityEngine;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002574")]
  public sealed class CastSkillSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A0BE")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Vector3 BULLET_LOOKAT_OFFSET;
    [Token(Token = "0x400A0C0")]
    [FieldOffset(Offset = "0x14")]
    private CastSkillSequence.State currentState;
    [Token(Token = "0x400A0C1")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData owner;
    [Token(Token = "0x400A0C2")]
    [FieldOffset(Offset = "0x20")]
    private CharacterActor ownerActor;
    [Token(Token = "0x400A0C3")]
    [FieldOffset(Offset = "0x28")]
    private CharacterActor targetActor;
    [Token(Token = "0x400A0C4")]
    [FieldOffset(Offset = "0x30")]
    private GridObject castFrom;
    [Token(Token = "0x400A0C5")]
    [FieldOffset(Offset = "0x38")]
    private GridObject castTo;
    [Token(Token = "0x400A0C6")]
    [FieldOffset(Offset = "0x40")]
    private SkillParameterData usingSkill;
    [Token(Token = "0x400A0C7")]
    [FieldOffset(Offset = "0x48")]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x400A0C8")]
    [FieldOffset(Offset = "0x50")]
    private List<ParticleEmitter.Handle> handles;
    [Token(Token = "0x400A0C9")]
    [FieldOffset(Offset = "0x58")]
    private Vector3Curve bulletCurve;
    [Token(Token = "0x400A0CA")]
    [FieldOffset(Offset = "0x60")]
    private Vector3 nextBulletPosition;
    [Token(Token = "0x400A0CB")]
    [FieldOffset(Offset = "0x70")]
    private ParticleEmitter.Handle bulletHandle;
    [Token(Token = "0x400A0CC")]
    [FieldOffset(Offset = "0x80")]
    private Action onCompleted;
    [Token(Token = "0x400A0CD")]
    [FieldOffset(Offset = "0x88")]
    private bool isUpdatePos;

    [Token(Token = "0x600E6F6")]
    [Address(RVA = "0x4871D8C", Offset = "0x4871D8C", VA = "0x4871D8C")]
    public static CastSkillSequence Create(
      UnitParameterData owner,
      CharacterActor ownerActor,
      CharacterActor targetActor,
      GridObject castFrom,
      GridObject castTo,
      SkillParameterData usingSkill,
      ParticleEmitter particleEmitter,
      Action onCompleted,
      bool isUpdatePos = true)
    {
      return (CastSkillSequence) null;
    }

    [Token(Token = "0x17003182")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E6F7"), Address(RVA = "0x48797F4", Offset = "0x48797F4", VA = "0x48797F4", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E6F8"), Address(RVA = "0x48797FC", Offset = "0x48797FC", VA = "0x48797FC")] private set
      {
      }
    }

    [Token(Token = "0x600E6F9")]
    [Address(RVA = "0x48796CC", Offset = "0x48796CC", VA = "0x48796CC")]
    private CastSkillSequence(
      UnitParameterData owner,
      CharacterActor ownerActor,
      CharacterActor targetActor,
      GridObject castFrom,
      GridObject castTo,
      SkillParameterData usingSkill,
      ParticleEmitter particleEmitter,
      Action onCompleted,
      bool isUpdatePos)
    {
    }

    [Token(Token = "0x600E6FA")]
    [Address(RVA = "0x4879808", Offset = "0x4879808", VA = "0x4879808", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E6FB")]
    [Address(RVA = "0x4879810", Offset = "0x4879810", VA = "0x4879810", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E6FC")]
    [Address(RVA = "0x4879B28", Offset = "0x4879B28", VA = "0x4879B28", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E6FD")]
    [Address(RVA = "0x4879B78", Offset = "0x4879B78", VA = "0x4879B78", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E6FE")]
    [Address(RVA = "0x4879994", Offset = "0x4879994", VA = "0x4879994")]
    private void PlayMotion()
    {
    }

    [Token(Token = "0x600E6FF")]
    [Address(RVA = "0x4879B7C", Offset = "0x4879B7C", VA = "0x4879B7C")]
    private Actor.AnimationType GetAnimationTypeForPlayMotion() => new Actor.AnimationType();

    [Token(Token = "0x600E700")]
    [Address(RVA = "0x4879BB4", Offset = "0x4879BB4", VA = "0x4879BB4")]
    private void PlayActorMotion()
    {
    }

    [Token(Token = "0x600E701")]
    [Address(RVA = "0x4879AA4", Offset = "0x4879AA4", VA = "0x4879AA4")]
    private void ShowCastEffect()
    {
    }

    [Token(Token = "0x600E702")]
    [Address(RVA = "0x487A03C", Offset = "0x487A03C", VA = "0x487A03C")]
    private void ShowSwingWeaponVfxes()
    {
    }

    [Token(Token = "0x600E703")]
    [Address(RVA = "0x4879C14", Offset = "0x4879C14", VA = "0x4879C14")]
    private void ShowMagicVfxes(bool afterBullet)
    {
    }

    [Token(Token = "0x600E704")]
    [Address(RVA = "0x487A1DC", Offset = "0x487A1DC", VA = "0x487A1DC")]
    private bool ShotBullet(string bulletName) => new bool();

    [Token(Token = "0x600E705")]
    [Address(RVA = "0x4879AEC", Offset = "0x4879AEC", VA = "0x4879AEC")]
    private void OnImpact()
    {
    }

    [Token(Token = "0x600E706")]
    [Address(RVA = "0x487A52C", Offset = "0x487A52C", VA = "0x487A52C")]
    private void AddParticleHandle(ParticleEmitter.Handle handle)
    {
    }

    [Token(Token = "0x600E707")]
    [Address(RVA = "0x487A62C", Offset = "0x487A62C", VA = "0x487A62C")]
    private void OnUpdateBulletEffect(IParticleTransformUpdater updater)
    {
    }

    [Token(Token = "0x600E708")]
    [Address(RVA = "0x487A7C8", Offset = "0x487A7C8", VA = "0x487A7C8")]
    static CastSkillSequence()
    {
    }

    [Token(Token = "0x2002575")]
    private enum State
    {
      [Token(Token = "0x400A0CF")] None,
      [Token(Token = "0x400A0D0")] Motion,
      [Token(Token = "0x400A0D1")] CastEffect,
      [Token(Token = "0x400A0D2")] Completed,
    }
  }
}
