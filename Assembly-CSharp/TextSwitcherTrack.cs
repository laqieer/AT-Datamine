// Decompiled with JetBrains decompiler
// Type: TextSwitcherTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000350")]
[TrackColor(0.1394896f, 0.4411765f, 0.3413077f)]
[TrackBindingType(typeof (Text))]
[TrackClipType(typeof (TextSwitcherClip))]
public class TextSwitcherTrack : TrackAsset
{
  [Token(Token = "0x600132D")]
  [Address(RVA = "0x286723C", Offset = "0x286723C", VA = "0x286723C", Slot = "24")]
  public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
  {
    return new Playable();
  }

  [Token(Token = "0x600132E")]
  [Address(RVA = "0x28672DC", Offset = "0x28672DC", VA = "0x28672DC", Slot = "29")]
  public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
  {
  }

  [Token(Token = "0x600132F")]
  [Address(RVA = "0x28672E4", Offset = "0x28672E4", VA = "0x28672E4")]
  public TextSwitcherTrack()
  {
  }
}
