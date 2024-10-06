// Decompiled with JetBrains decompiler
// Type: LightControlTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x2000344")]
[TrackClipType(typeof (LightControlClip))]
[TrackBindingType(typeof (Light))]
[TrackColor(0.9454092f, 0.9779412f, 0.3883002f)]
public class LightControlTrack : TrackAsset
{
  [Token(Token = "0x6001310")]
  [Address(RVA = "0x2865F54", Offset = "0x2865F54", VA = "0x2865F54", Slot = "24")]
  public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
  {
    return new Playable();
  }

  [Token(Token = "0x6001311")]
  [Address(RVA = "0x2865FF4", Offset = "0x2865FF4", VA = "0x2865FF4", Slot = "29")]
  public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
  {
  }

  [Token(Token = "0x6001312")]
  [Address(RVA = "0x2865FFC", Offset = "0x2865FFC", VA = "0x2865FFC")]
  public LightControlTrack()
  {
  }
}
