// Decompiled with JetBrains decompiler
// Type: FreeMap.Timeline.FreeMapFadePlayableAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace FreeMap.Timeline
{
  [Token(Token = "0x200177F")]
  [Serializable]
  public class FreeMapFadePlayableAsset : PlayableAsset, ITimelineClipAsset
  {
    [Token(Token = "0x4006821")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public FreeMapFadeBehaviour Template;

    [Token(Token = "0x1700150D")]
    public ClipCaps clipCaps
    {
      [Token(Token = "0x6008535"), Address(RVA = "0x406AE3C", Offset = "0x406AE3C", VA = "0x406AE3C", Slot = "9")] get
      {
        return new ClipCaps();
      }
    }

    [Token(Token = "0x6008536")]
    [Address(RVA = "0x406AE44", Offset = "0x406AE44", VA = "0x406AE44", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
      return new Playable();
    }

    [Token(Token = "0x6008537")]
    [Address(RVA = "0x406AEEC", Offset = "0x406AEEC", VA = "0x406AEEC")]
    public FreeMapFadePlayableAsset()
    {
    }
  }
}
