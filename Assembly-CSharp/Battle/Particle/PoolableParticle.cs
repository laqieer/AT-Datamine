// Decompiled with JetBrains decompiler
// Type: Battle.Particle.PoolableParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Utility;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.Particle
{
  [Token(Token = "0x20024CB")]
  public sealed class PoolableParticle : 
    IPoolable<ParticleSystem, PoolableParticle>,
    IDisposable,
    IParticleTransformUpdater
  {
    [Token(Token = "0x4009DBF")]
    [FieldOffset(Offset = "0x10")]
    private ParticleSystem entity;
    [Token(Token = "0x4009DC0")]
    [FieldOffset(Offset = "0x18")]
    private EffectSEController[] effectSeControllers;
    [Token(Token = "0x4009DC1")]
    [FieldOffset(Offset = "0x20")]
    private TrailRenderer[] trailRenderers;
    [Token(Token = "0x4009DC2")]
    [FieldOffset(Offset = "0x28")]
    private string name;
    [Token(Token = "0x4009DC3")]
    [FieldOffset(Offset = "0x30")]
    private Transform defaultParent;
    [Token(Token = "0x4009DC4")]
    [FieldOffset(Offset = "0x38")]
    public Action<IParticleTransformUpdater> OnUpdate;
    [Token(Token = "0x4009DC5")]
    [FieldOffset(Offset = "0x40")]
    public Action OnComplete;

    [Token(Token = "0x1700307B")]
    public ParticleSystem Entity
    {
      [Token(Token = "0x600E258"), Address(RVA = "0x40172F4", Offset = "0x40172F4", VA = "0x40172F4")] get
      {
        return (ParticleSystem) null;
      }
    }

    [Token(Token = "0x1700307C")]
    public string Name
    {
      [Token(Token = "0x600E259"), Address(RVA = "0x40172FC", Offset = "0x40172FC", VA = "0x40172FC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E25A")]
    [Address(RVA = "0x40155F4", Offset = "0x40155F4", VA = "0x40155F4")]
    public PoolableParticle(ParticleSystem entity, string name, Transform root, bool isPrefab)
    {
    }

    [Token(Token = "0x600E25B")]
    [Address(RVA = "0x4017304", Offset = "0x4017304", VA = "0x4017304", Slot = "7")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600E25C")]
    [Address(RVA = "0x40173EC", Offset = "0x40173EC", VA = "0x40173EC", Slot = "6")]
    public void BringBack()
    {
    }

    [Token(Token = "0x600E25D")]
    [Address(RVA = "0x4017568", Offset = "0x4017568", VA = "0x4017568", Slot = "5")]
    public void Reset()
    {
    }

    [Token(Token = "0x600E25E")]
    [Address(RVA = "0x401756C", Offset = "0x401756C", VA = "0x401756C", Slot = "4")]
    public PoolableParticle Clone() => (PoolableParticle) null;

    [Token(Token = "0x600E25F")]
    [Address(RVA = "0x4015CE8", Offset = "0x4015CE8", VA = "0x4015CE8")]
    public void Play()
    {
    }

    [Token(Token = "0x600E260")]
    [Address(RVA = "0x4016088", Offset = "0x4016088", VA = "0x4016088")]
    public void Stop()
    {
    }

    [Token(Token = "0x600E261")]
    [Address(RVA = "0x401605C", Offset = "0x401605C", VA = "0x401605C")]
    public void StopAndClear()
    {
    }

    [Token(Token = "0x600E262")]
    [Address(RVA = "0x4015CC4", Offset = "0x4015CC4", VA = "0x4015CC4")]
    public void Clear()
    {
    }

    [Token(Token = "0x600E263")]
    [Address(RVA = "0x40176D4", Offset = "0x40176D4", VA = "0x40176D4")]
    private void ClearTrails()
    {
    }

    [Token(Token = "0x600E264")]
    [Address(RVA = "0x4017750", Offset = "0x4017750", VA = "0x4017750", Slot = "8")]
    public void UpdatePosition(Vector3 pos)
    {
    }

    [Token(Token = "0x600E265")]
    [Address(RVA = "0x4017810", Offset = "0x4017810", VA = "0x4017810", Slot = "9")]
    public void UpdateLocalPosition(Vector3 pos)
    {
    }

    [Token(Token = "0x600E266")]
    [Address(RVA = "0x40178D0", Offset = "0x40178D0", VA = "0x40178D0", Slot = "10")]
    public void UpdateRotation(Quaternion rot)
    {
    }

    [Token(Token = "0x600E267")]
    [Address(RVA = "0x4017998", Offset = "0x4017998", VA = "0x4017998", Slot = "11")]
    public void UpdateLocalRotation(Quaternion rot)
    {
    }

    [Token(Token = "0x600E268")]
    [Address(RVA = "0x4017A60", Offset = "0x4017A60", VA = "0x4017A60", Slot = "12")]
    public void LookAtTo(Vector3 target)
    {
    }
  }
}
