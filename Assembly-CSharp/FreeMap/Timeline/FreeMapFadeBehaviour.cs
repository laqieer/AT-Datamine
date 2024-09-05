// Decompiled with JetBrains decompiler
// Type: FreeMap.Timeline.FreeMapFadeBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace FreeMap.Timeline
{
  [Token(Token = "0x200177D")]
  [Serializable]
  public class FreeMapFadeBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x400681D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public FreeMapFadeBehaviour.FadeType Type;

    [Token(Token = "0x1700150C")]
    public double duration
    {
      [Token(Token = "0x6008531"), Address(RVA = "0x406AC34", Offset = "0x406AC34", VA = "0x406AC34")] set
      {
      }
      [Token(Token = "0x6008532"), Address(RVA = "0x406AC3C", Offset = "0x406AC3C", VA = "0x406AC3C")] get
      {
        return new double();
      }
    }

    [Token(Token = "0x6008533")]
    [Address(RVA = "0x406AC44", Offset = "0x406AC44", VA = "0x406AC44", Slot = "17")]
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x6008534")]
    [Address(RVA = "0x406AE34", Offset = "0x406AE34", VA = "0x406AE34")]
    public FreeMapFadeBehaviour()
    {
    }

    [Token(Token = "0x200177E")]
    public enum FadeType
    {
      [Token(Token = "0x400681F")] In,
      [Token(Token = "0x4006820")] Out,
    }
  }
}
