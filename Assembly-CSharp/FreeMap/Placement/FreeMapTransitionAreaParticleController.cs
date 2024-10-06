// Decompiled with JetBrains decompiler
// Type: FreeMap.Placement.FreeMapTransitionAreaParticleController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Placement
{
  [Token(Token = "0x200185A")]
  public class FreeMapTransitionAreaParticleController : 
    MonoBehaviour,
    IFreeMapTransitionAreaFxController
  {
    [Token(Token = "0x4006A24")]
    [FieldOffset(Offset = "0x18")]
    private ParticleSystem parent;
    [Token(Token = "0x4006A25")]
    [FieldOffset(Offset = "0x20")]
    private ParticleSystem[] childrens;

    [Token(Token = "0x60089B7")]
    [Address(RVA = "0x451D350", Offset = "0x451D350", VA = "0x451D350")]
    private void Start()
    {
    }

    [Token(Token = "0x60089B8")]
    [Address(RVA = "0x451D408", Offset = "0x451D408", VA = "0x451D408", Slot = "4")]
    public void FadeIn(bool isTransition)
    {
    }

    [Token(Token = "0x60089B9")]
    [Address(RVA = "0x451D504", Offset = "0x451D504", VA = "0x451D504", Slot = "5")]
    public void FadeOut(bool isTransition)
    {
    }

    [Token(Token = "0x60089BA")]
    [Address(RVA = "0x451D5B8", Offset = "0x451D5B8", VA = "0x451D5B8")]
    public FreeMapTransitionAreaParticleController()
    {
    }
  }
}
