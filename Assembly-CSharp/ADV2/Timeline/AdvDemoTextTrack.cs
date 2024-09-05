// Decompiled with JetBrains decompiler
// Type: ADV2.Timeline.AdvDemoTextTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace ADV2.Timeline
{
  [Token(Token = "0x2003E6A")]
  [TrackClipType(typeof (AdvDemoTextClip))]
  [TrackBindingType(typeof (GameObject))]
  [TrackColor(0.0f, 0.0f, 1f)]
  public class AdvDemoTextTrack : TrackAsset
  {
    [Token(Token = "0x60191DC")]
    [Address(RVA = "0x2CF2BB8", Offset = "0x2CF2BB8", VA = "0x2CF2BB8", Slot = "24")]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
      return new Playable();
    }

    [Token(Token = "0x60191DD")]
    [Address(RVA = "0x2CF33B4", Offset = "0x2CF33B4", VA = "0x2CF33B4")]
    public AdvDemoTextTrack()
    {
    }
  }
}
