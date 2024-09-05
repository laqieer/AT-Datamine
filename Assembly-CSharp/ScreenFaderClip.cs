// Decompiled with JetBrains decompiler
// Type: ScreenFaderClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x200034A")]
[Serializable]
public class ScreenFaderClip : PlayableAsset, ITimelineClipAsset
{
  [Token(Token = "0x40013B1")]
  [FieldOffset(Offset = "0x18")]
  public ScreenFaderBehaviour template;

  [Token(Token = "0x170001DA")]
  public ClipCaps clipCaps
  {
    [Token(Token = "0x600131D"), Address(RVA = "0x2866580", Offset = "0x2866580", VA = "0x2866580", Slot = "9")] get
    {
      return new ClipCaps();
    }
  }

  [Token(Token = "0x600131E")]
  [Address(RVA = "0x2866588", Offset = "0x2866588", VA = "0x2866588", Slot = "6")]
  public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => new Playable();

  [Token(Token = "0x600131F")]
  [Address(RVA = "0x2866630", Offset = "0x2866630", VA = "0x2866630")]
  public ScreenFaderClip()
  {
  }
}
