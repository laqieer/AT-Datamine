// Decompiled with JetBrains decompiler
// Type: TimeDilationClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x2000352")]
[Serializable]
public class TimeDilationClip : PlayableAsset, ITimelineClipAsset
{
  [Token(Token = "0x40013BF")]
  [FieldOffset(Offset = "0x18")]
  public TimeDilationBehaviour template;

  [Token(Token = "0x170001DC")]
  public ClipCaps clipCaps
  {
    [Token(Token = "0x6001331"), Address(RVA = "0x286734C", Offset = "0x286734C", VA = "0x286734C", Slot = "9")] get
    {
      return new ClipCaps();
    }
  }

  [Token(Token = "0x6001332")]
  [Address(RVA = "0x2867354", Offset = "0x2867354", VA = "0x2867354", Slot = "6")]
  public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => new Playable();

  [Token(Token = "0x6001333")]
  [Address(RVA = "0x28673FC", Offset = "0x28673FC", VA = "0x28673FC")]
  public TimeDilationClip()
  {
  }
}
