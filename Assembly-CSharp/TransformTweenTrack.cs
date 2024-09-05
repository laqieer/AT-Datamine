// Decompiled with JetBrains decompiler
// Type: TransformTweenTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x2000359")]
[TrackColor(0.855f, 0.8623f, 0.87f)]
[TrackBindingType(typeof (Transform))]
[TrackClipType(typeof (TransformTweenClip))]
public class TransformTweenTrack : TrackAsset
{
  [Token(Token = "0x6001349")]
  [Address(RVA = "0x2868870", Offset = "0x2868870", VA = "0x2868870", Slot = "24")]
  public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
  {
    return new Playable();
  }

  [Token(Token = "0x600134A")]
  [Address(RVA = "0x2868910", Offset = "0x2868910", VA = "0x2868910", Slot = "29")]
  public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
  {
  }

  [Token(Token = "0x600134B")]
  [Address(RVA = "0x2868918", Offset = "0x2868918", VA = "0x2868918")]
  public TransformTweenTrack()
  {
  }
}
