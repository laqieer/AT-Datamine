// Decompiled with JetBrains decompiler
// Type: Battle.Staging.AutoTurretAttackEffectSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Particle;
using Battle.Unit;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200256D")]
  public sealed class AutoTurretAttackEffectSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A096")]
    [FieldOffset(Offset = "0x10")]
    private Transform transform;
    [Token(Token = "0x400A097")]
    [FieldOffset(Offset = "0x18")]
    private CharacterActor targetActor;
    [Token(Token = "0x400A098")]
    [FieldOffset(Offset = "0x20")]
    private IDirector mainDirector;
    [Token(Token = "0x400A099")]
    [FieldOffset(Offset = "0x28")]
    private string particleName;
    [Token(Token = "0x400A09A")]
    [FieldOffset(Offset = "0x30")]
    private ParticleEmitter.Handle handle;
    [Token(Token = "0x400A09B")]
    [FieldOffset(Offset = "0x40")]
    private Action onCompleted;

    [Token(Token = "0x1700317E")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E6C3"), Address(RVA = "0x4876A60", Offset = "0x4876A60", VA = "0x4876A60", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E6C4"), Address(RVA = "0x4876A68", Offset = "0x4876A68", VA = "0x4876A68")] private set
      {
      }
    }

    [Token(Token = "0x600E6C5")]
    [Address(RVA = "0x4876A74", Offset = "0x4876A74", VA = "0x4876A74")]
    private AutoTurretAttackEffectSequence()
    {
    }

    [Token(Token = "0x600E6C6")]
    [Address(RVA = "0x4876B00", Offset = "0x4876B00", VA = "0x4876B00")]
    public static StagingDirector.ISequence Create(
      Transform transform,
      string particleName,
      IDirector mainDirector,
      Action onCompleted = null)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x600E6C7")]
    [Address(RVA = "0x4876B84", Offset = "0x4876B84", VA = "0x4876B84", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E6C8")]
    [Address(RVA = "0x4876CE8", Offset = "0x4876CE8", VA = "0x4876CE8", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E6C9")]
    [Address(RVA = "0x4876D78", Offset = "0x4876D78", VA = "0x4876D78", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E6CA")]
    [Address(RVA = "0x4876E90", Offset = "0x4876E90", VA = "0x4876E90", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E6CB")]
    [Address(RVA = "0x4876F84", Offset = "0x4876F84", VA = "0x4876F84")]
    private void OnEndParticle()
    {
    }
  }
}
