// Decompiled with JetBrains decompiler
// Type: LightControlClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x2000342")]
[Serializable]
public class LightControlClip : PlayableAsset, ITimelineClipAsset
{
  [Token(Token = "0x40013A5")]
  [FieldOffset(Offset = "0x18")]
  public LightControlBehaviour template;

  [Token(Token = "0x170001D8")]
  public ClipCaps clipCaps
  {
    [Token(Token = "0x600130A"), Address(RVA = "0x28659B4", Offset = "0x28659B4", VA = "0x28659B4", Slot = "9")] get
    {
      return new ClipCaps();
    }
  }

  [Token(Token = "0x600130B")]
  [Address(RVA = "0x28659BC", Offset = "0x28659BC", VA = "0x28659BC", Slot = "6")]
  public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => new Playable();

  [Token(Token = "0x600130C")]
  [Address(RVA = "0x2865A64", Offset = "0x2865A64", VA = "0x2865A64")]
  public LightControlClip()
  {
  }
}
