// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2EffectParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.Effect;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E0F")]
  public class Adv2EffectParticle : Adv2Object
  {
    [Token(Token = "0x401104B")]
    [FieldOffset(Offset = "0xA0")]
    protected AdvParticleBehaviour particle;
    [Token(Token = "0x401104C")]
    [FieldOffset(Offset = "0xA8")]
    protected bool initEnableSE;

    [Token(Token = "0x6018FB0")]
    [Address(RVA = "0x2CB8838", Offset = "0x2CB8838", VA = "0x2CB8838", Slot = "4")]
    protected override void CheckParticleSpeed()
    {
    }

    [Token(Token = "0x6018FB1")]
    [Address(RVA = "0x2CB883C", Offset = "0x2CB883C", VA = "0x2CB883C", Slot = "15")]
    public override void SetBindObject(GameObject prefab, bool setParent)
    {
    }

    [Token(Token = "0x6018FB2")]
    [Address(RVA = "0x2CB88C4", Offset = "0x2CB88C4", VA = "0x2CB88C4", Slot = "10")]
    public override void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6018FB3")]
    [Address(RVA = "0x2CB8974", Offset = "0x2CB8974", VA = "0x2CB8974", Slot = "11")]
    public override bool IsActive() => new bool();

    [Token(Token = "0x6018FB4")]
    [Address(RVA = "0x2CB8A08", Offset = "0x2CB8A08", VA = "0x2CB8A08")]
    public void SetSpeed(float speed)
    {
    }

    [Token(Token = "0x6018FB5")]
    [Address(RVA = "0x2CB8A2C", Offset = "0x2CB8A2C", VA = "0x2CB8A2C")]
    public void Play()
    {
    }

    [Token(Token = "0x6018FB6")]
    [Address(RVA = "0x2CB8A48", Offset = "0x2CB8A48", VA = "0x2CB8A48")]
    public void Stop()
    {
    }

    [Token(Token = "0x6018FB7")]
    [Address(RVA = "0x2CB8A68", Offset = "0x2CB8A68", VA = "0x2CB8A68")]
    public static Adv2EffectParticle Create(string objectName, Transform parent, bool enableSE)
    {
      return (Adv2EffectParticle) null;
    }

    [Token(Token = "0x6018FB8")]
    [Address(RVA = "0x2CB8AE4", Offset = "0x2CB8AE4", VA = "0x2CB8AE4")]
    public Adv2EffectParticle()
    {
    }
  }
}
