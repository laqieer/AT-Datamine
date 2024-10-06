// Decompiled with JetBrains decompiler
// Type: Battle.Particle.ParticleEmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Utility;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Particle
{
  [Token(Token = "0x20024C4")]
  public sealed class ParticleEmitter : MonoBehaviour, IStepUpdate
  {
    [Token(Token = "0x4009DA8")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, ObjectPool<PoolableParticle, ParticleSystem>> particlePools;
    [Token(Token = "0x4009DA9")]
    [FieldOffset(Offset = "0x20")]
    private Queue<(string name, int count)> loadTargets;
    [Token(Token = "0x4009DAA")]
    [FieldOffset(Offset = "0x28")]
    private List<PoolableParticle> usingParticles;
    [Token(Token = "0x4009DAB")]
    [FieldOffset(Offset = "0x30")]
    private Coroutine loadingCoroutine;
    [Token(Token = "0x4009DAC")]
    [FieldOffset(Offset = "0x38")]
    private bool isLoadedAssetBundle;
    [Token(Token = "0x4009DAD")]
    [FieldOffset(Offset = "0x40")]
    private readonly string[] LoadAssetBundleLabelList;

    [Token(Token = "0x17003076")]
    public bool IsLoading
    {
      [Token(Token = "0x600E229"), Address(RVA = "0x4014A70", Offset = "0x4014A70", VA = "0x4014A70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E22A")]
    [Address(RVA = "0x4014A80", Offset = "0x4014A80", VA = "0x4014A80")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600E22B")]
    [Address(RVA = "0x4014A84", Offset = "0x4014A84", VA = "0x4014A84")]
    public void Release()
    {
    }

    [Token(Token = "0x600E22C")]
    [Address(RVA = "0x4014C94", Offset = "0x4014C94", VA = "0x4014C94")]
    public void ResetParticle()
    {
    }

    [Token(Token = "0x600E22D")]
    [Address(RVA = "0x4014F34", Offset = "0x4014F34", VA = "0x4014F34")]
    public void ReserveLoading(string name, int count)
    {
    }

    [Token(Token = "0x600E22E")]
    [Address(RVA = "0x40150F8", Offset = "0x40150F8", VA = "0x40150F8")]
    public void StartLoadingReserved(int loadCountPerOnce)
    {
    }

    [Token(Token = "0x600E22F")]
    [Address(RVA = "0x4014C70", Offset = "0x4014C70", VA = "0x4014C70")]
    public void AbortLoadingReserved()
    {
    }

    [Token(Token = "0x600E230")]
    [Address(RVA = "0x4015128", Offset = "0x4015128", VA = "0x4015128")]
    private IEnumerator LoadingReservedAsync(int loadCountPerOnce) => (IEnumerator) null;

    [Token(Token = "0x600E231")]
    [Address(RVA = "0x40151C8", Offset = "0x40151C8", VA = "0x40151C8")]
    private void Load(string name, int count)
    {
    }

    [Token(Token = "0x600E232")]
    [Address(RVA = "0x4015580", Offset = "0x4015580", VA = "0x4015580")]
    private IEnumerator LoadAssetBundle(Action endAction) => (IEnumerator) null;

    [Token(Token = "0x600E233")]
    [Address(RVA = "0x4015824", Offset = "0x4015824", VA = "0x4015824")]
    public ParticleEmitter.Handle Play(
      string name,
      Transform at,
      Vector3 posOffset = default (Vector3),
      Quaternion rotOffset = default (Quaternion),
      float scaleX = 1f,
      float scaleY = 1f,
      float scaleZ = 1f,
      bool loop = false,
      Action<IParticleTransformUpdater> onUpdate = null,
      Action onComplete = null)
    {
      return new ParticleEmitter.Handle();
    }

    [Token(Token = "0x600E234")]
    [Address(RVA = "0x4015DEC", Offset = "0x4015DEC", VA = "0x4015DEC")]
    public bool Stop(ParticleEmitter.Handle handle, bool clear = false, bool dispatch = false)
    {
      return new bool();
    }

    [Token(Token = "0x600E235")]
    [Address(RVA = "0x4015DF8", Offset = "0x4015DF8", VA = "0x4015DF8")]
    public bool Stop(int handleId, bool clear = false, bool dispatch = false) => new bool();

    [Token(Token = "0x600E236")]
    [Address(RVA = "0x4016108", Offset = "0x4016108", VA = "0x4016108")]
    public bool IsPlaying(ParticleEmitter.Handle handle) => new bool();

    [Token(Token = "0x600E237")]
    [Address(RVA = "0x4016120", Offset = "0x4016120", VA = "0x4016120")]
    public bool IsPlaying(int handleId) => new bool();

    [Token(Token = "0x600E238")]
    [Address(RVA = "0x4016138", Offset = "0x4016138", VA = "0x4016138")]
    private PoolableParticle FindPlayingParticle(int handleId) => (PoolableParticle) null;

    [Token(Token = "0x600E239")]
    [Address(RVA = "0x4016350", Offset = "0x4016350", VA = "0x4016350", Slot = "4")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E23A")]
    [Address(RVA = "0x4016678", Offset = "0x4016678", VA = "0x4016678")]
    public ParticleSystem GetParticle(string name) => (ParticleSystem) null;

    [Token(Token = "0x600E23B")]
    [Address(RVA = "0x4016764", Offset = "0x4016764", VA = "0x4016764")]
    public void SetParticlePools(ParticleSystem particle, string name)
    {
    }

    [Token(Token = "0x600E23C")]
    [Address(RVA = "0x4016874", Offset = "0x4016874", VA = "0x4016874")]
    public ParticleEmitter()
    {
    }

    [Token(Token = "0x20024C5")]
    public struct Handle
    {
      [Token(Token = "0x4009DAE")]
      [FieldOffset(Offset = "0x0")]
      public static readonly ParticleEmitter.Handle InvalidHandle;
      [Token(Token = "0x4009DAF")]
      public const int InvalidId = 0;
      [Token(Token = "0x4009DB0")]
      [FieldOffset(Offset = "0x0")]
      public readonly int Id;
      [Token(Token = "0x4009DB1")]
      [FieldOffset(Offset = "0x8")]
      public readonly string Name;

      [Token(Token = "0x600E23D")]
      [Address(RVA = "0x4015DE0", Offset = "0x4015DE0", VA = "0x4015DE0")]
      public Handle(int handleId, string name)
      {
      }

      [Token(Token = "0x600E23E")]
      [Address(RVA = "0x4016A70", Offset = "0x4016A70", VA = "0x4016A70", Slot = "2")]
      public override int GetHashCode() => new int();

      [Token(Token = "0x600E23F")]
      [Address(RVA = "0x4016A78", Offset = "0x4016A78", VA = "0x4016A78")]
      public static bool operator ==(ParticleEmitter.Handle a, ParticleEmitter.Handle b)
      {
        return new bool();
      }

      [Token(Token = "0x600E240")]
      [Address(RVA = "0x4016A84", Offset = "0x4016A84", VA = "0x4016A84")]
      public static bool operator !=(ParticleEmitter.Handle a, ParticleEmitter.Handle b)
      {
        return new bool();
      }

      [Token(Token = "0x600E241")]
      [Address(RVA = "0x4016A90", Offset = "0x4016A90", VA = "0x4016A90", Slot = "0")]
      public override bool Equals(object obj) => new bool();

      [Token(Token = "0x600E242")]
      [Address(RVA = "0x4016B2C", Offset = "0x4016B2C", VA = "0x4016B2C")]
      static Handle()
      {
      }
    }
  }
}
