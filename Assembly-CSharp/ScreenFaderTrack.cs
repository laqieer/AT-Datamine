// Decompiled with JetBrains decompiler
// Type: ScreenFaderTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200034C")]
[TrackColor(0.875f, 0.5944853f, 0.1737132f)]
[TrackClipType(typeof (ScreenFaderClip))]
[TrackBindingType(typeof (Image))]
public class ScreenFaderTrack : TrackAsset
{
  [Token(Token = "0x6001323")]
  [Address(RVA = "0x2866A30", Offset = "0x2866A30", VA = "0x2866A30", Slot = "24")]
  public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
  {
    return new Playable();
  }

  [Token(Token = "0x6001324")]
  [Address(RVA = "0x2866AD0", Offset = "0x2866AD0", VA = "0x2866AD0", Slot = "29")]
  public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
  {
  }

  [Token(Token = "0x6001325")]
  [Address(RVA = "0x2866AD8", Offset = "0x2866AD8", VA = "0x2866AD8")]
  public ScreenFaderTrack()
  {
  }
}
