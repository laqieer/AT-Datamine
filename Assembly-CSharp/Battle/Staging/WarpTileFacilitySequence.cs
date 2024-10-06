// Decompiled with JetBrains decompiler
// Type: Battle.Staging.WarpTileFacilitySequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Particle;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200259B")]
  public class WarpTileFacilitySequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1BF")]
    [FieldOffset(Offset = "0x18")]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x400A1C0")]
    [FieldOffset(Offset = "0x20")]
    private bool isPlayingParticle;
    [Token(Token = "0x400A1C1")]
    [FieldOffset(Offset = "0x28")]
    private Transform target;
    [Token(Token = "0x400A1C2")]
    [FieldOffset(Offset = "0x30")]
    private BattleFacilityTypeEnum type;
    [Token(Token = "0x400A1C3")]
    [FieldOffset(Offset = "0x38")]
    private Action onCompleted;
    [Token(Token = "0x400A1C4")]
    [FieldOffset(Offset = "0x40")]
    private float particleDuration;
    [Token(Token = "0x400A1C5")]
    private const float COMPLETE_PER = 0.8f;
    [Token(Token = "0x400A1C6")]
    [FieldOffset(Offset = "0x44")]
    private float _progress;
    [Token(Token = "0x400A1C7")]
    [FieldOffset(Offset = "0x48")]
    private bool _onceflag;

    [Token(Token = "0x170031A0")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E83A"), Address(RVA = "0x4C3F204", Offset = "0x4C3F204", VA = "0x4C3F204", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E83B"), Address(RVA = "0x4C3F20C", Offset = "0x4C3F20C", VA = "0x4C3F20C")] private set
      {
      }
    }

    [Token(Token = "0x600E83C")]
    [Address(RVA = "0x4C3F218", Offset = "0x4C3F218", VA = "0x4C3F218")]
    private WarpTileFacilitySequence()
    {
    }

    [Token(Token = "0x600E83D")]
    [Address(RVA = "0x4C3F220", Offset = "0x4C3F220", VA = "0x4C3F220")]
    public static WarpTileFacilitySequence Create(
      ParticleEmitter particle,
      Transform target,
      BattleFacilityTypeEnum type,
      Action onCompleted)
    {
      return (WarpTileFacilitySequence) null;
    }

    [Token(Token = "0x600E83E")]
    [Address(RVA = "0x4C3F2AC", Offset = "0x4C3F2AC", VA = "0x4C3F2AC", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E83F")]
    [Address(RVA = "0x4C3F4A0", Offset = "0x4C3F4A0", VA = "0x4C3F4A0", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E840")]
    [Address(RVA = "0x4C3F508", Offset = "0x4C3F508", VA = "0x4C3F508", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E841")]
    [Address(RVA = "0x4C3F514", Offset = "0x4C3F514", VA = "0x4C3F514", Slot = "6")]
    public void Abort()
    {
    }
  }
}
