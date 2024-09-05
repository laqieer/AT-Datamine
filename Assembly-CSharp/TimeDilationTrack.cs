// Decompiled with JetBrains decompiler
// Type: TimeDilationTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x2000354")]
[TrackClipType(typeof (TimeDilationClip))]
[TrackColor(0.855f, 0.8623f, 0.87f)]
public class TimeDilationTrack : TrackAsset
{
  [Token(Token = "0x6001339")]
  [Address(RVA = "0x286789C", Offset = "0x286789C", VA = "0x286789C", Slot = "24")]
  public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
  {
    return new Playable();
  }

  [Token(Token = "0x600133A")]
  [Address(RVA = "0x286793C", Offset = "0x286793C", VA = "0x286793C")]
  public TimeDilationTrack()
  {
  }
}
