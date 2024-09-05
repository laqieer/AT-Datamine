// Decompiled with JetBrains decompiler
// Type: ADV2.Effect.ParticleBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2.Effect
{
  [Token(Token = "0x2003E96")]
  public class ParticleBehaviour : EffectBehaviourBase
  {
    [Token(Token = "0x40112A7")]
    [FieldOffset(Offset = "0x20")]
    private EffectSEController seController;
    [Token(Token = "0x40112A8")]
    [FieldOffset(Offset = "0x28")]
    private List<ParticleBehaviour.Container> particleContainers;
    [Token(Token = "0x40112A9")]
    [FieldOffset(Offset = "0x30")]
    private int playCount;

    [Token(Token = "0x170051B8")]
    protected float globalSpeed
    {
      [Token(Token = "0x6019307"), Address(RVA = "0x2D03410", Offset = "0x2D03410", VA = "0x2D03410")] get
      {
        return new float();
      }
      [Token(Token = "0x6019308"), Address(RVA = "0x2D03418", Offset = "0x2D03418", VA = "0x2D03418")] set
      {
      }
    }

    [Token(Token = "0x170051B9")]
    protected float localSpeed
    {
      [Token(Token = "0x6019309"), Address(RVA = "0x2D03420", Offset = "0x2D03420", VA = "0x2D03420")] get
      {
        return new float();
      }
      [Token(Token = "0x601930A"), Address(RVA = "0x2D03428", Offset = "0x2D03428", VA = "0x2D03428")] private set
      {
      }
    }

    [Token(Token = "0x170051BA")]
    private IEnumerable<ParticleSystem> particles
    {
      [Token(Token = "0x601930B"), Address(RVA = "0x2D03430", Offset = "0x2D03430", VA = "0x2D03430")] get
      {
        return (IEnumerable<ParticleSystem>) null;
      }
    }

    [Token(Token = "0x170051BB")]
    public bool IsEmitting
    {
      [Token(Token = "0x601930C"), Address(RVA = "0x2D0352C", Offset = "0x2D0352C", VA = "0x2D0352C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601930D")]
    [Address(RVA = "0x2D03660", Offset = "0x2D03660", VA = "0x2D03660", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x601930E")]
    [Address(RVA = "0x2D0313C", Offset = "0x2D0313C", VA = "0x2D0313C", Slot = "5")]
    protected override void Update()
    {
    }

    [Token(Token = "0x601930F")]
    [Address(RVA = "0x2D0382C", Offset = "0x2D0382C", VA = "0x2D0382C")]
    public void EnableSE(bool enable)
    {
    }

    [Token(Token = "0x6019310")]
    [Address(RVA = "0x2D038C4", Offset = "0x2D038C4", VA = "0x2D038C4")]
    public void Play()
    {
    }

    [Token(Token = "0x6019311")]
    [Address(RVA = "0x2D03C10", Offset = "0x2D03C10", VA = "0x2D03C10", Slot = "6")]
    public override void Stop()
    {
    }

    [Token(Token = "0x6019312")]
    [Address(RVA = "0x2D03EF4", Offset = "0x2D03EF4", VA = "0x2D03EF4")]
    public void SetSpeed(float speed)
    {
    }

    [Token(Token = "0x6019313")]
    [Address(RVA = "0x2D031E0", Offset = "0x2D031E0", VA = "0x2D031E0")]
    protected void OnModifySpeed()
    {
    }

    [Token(Token = "0x6019314")]
    [Address(RVA = "0x2D03378", Offset = "0x2D03378", VA = "0x2D03378")]
    public ParticleBehaviour()
    {
    }

    [Token(Token = "0x2003E97")]
    private class Container
    {
      [Token(Token = "0x170051BC")]
      public ParticleSystem Particle
      {
        [Token(Token = "0x6019315"), Address(RVA = "0x2D03F04", Offset = "0x2D03F04", VA = "0x2D03F04")] get
        {
          return (ParticleSystem) null;
        }
        [Token(Token = "0x6019316"), Address(RVA = "0x2D03F0C", Offset = "0x2D03F0C", VA = "0x2D03F0C")] private set
        {
        }
      }

      [Token(Token = "0x170051BD")]
      public float DefaultSpeed
      {
        [Token(Token = "0x6019317"), Address(RVA = "0x2D03F14", Offset = "0x2D03F14", VA = "0x2D03F14")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x6019318")]
      [Address(RVA = "0x2D037D8", Offset = "0x2D037D8", VA = "0x2D037D8")]
      public Container(ParticleSystem particle)
      {
      }
    }
  }
}
