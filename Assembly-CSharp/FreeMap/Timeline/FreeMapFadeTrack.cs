// Decompiled with JetBrains decompiler
// Type: FreeMap.Timeline.FreeMapFadeTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace FreeMap.Timeline
{
  [Token(Token = "0x2001780")]
  [TrackClipType(typeof (FreeMapFadePlayableAsset))]
  public class FreeMapFadeTrack : TrackAsset
  {
    [Token(Token = "0x6008538")]
    [Address(RVA = "0x406AEF4", Offset = "0x406AEF4", VA = "0x406AEF4", Slot = "32")]
    protected override Playable CreatePlayable(
      PlayableGraph graph,
      GameObject gameObject,
      TimelineClip clip)
    {
      return new Playable();
    }

    [Token(Token = "0x6008539")]
    [Address(RVA = "0x406AFA8", Offset = "0x406AFA8", VA = "0x406AFA8")]
    public FreeMapFadeTrack()
    {
    }
  }
}
