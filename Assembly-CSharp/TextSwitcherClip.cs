// Decompiled with JetBrains decompiler
// Type: TextSwitcherClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x200034E")]
[Serializable]
public class TextSwitcherClip : PlayableAsset, ITimelineClipAsset
{
  [Token(Token = "0x40013B8")]
  [FieldOffset(Offset = "0x18")]
  public TextSwitcherBehaviour template;

  [Token(Token = "0x170001DB")]
  public ClipCaps clipCaps
  {
    [Token(Token = "0x6001327"), Address(RVA = "0x2866B48", Offset = "0x2866B48", VA = "0x2866B48", Slot = "9")] get
    {
      return new ClipCaps();
    }
  }

  [Token(Token = "0x6001328")]
  [Address(RVA = "0x2866B50", Offset = "0x2866B50", VA = "0x2866B50", Slot = "6")]
  public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => new Playable();

  [Token(Token = "0x6001329")]
  [Address(RVA = "0x2866BF8", Offset = "0x2866BF8", VA = "0x2866BF8")]
  public TextSwitcherClip()
  {
  }
}
