// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Date.TimeElapsedCustomTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace Scenes.Story.Date
{
  [Token(Token = "0x2002EB2")]
  [TrackBindingType(typeof (GameObject))]
  [TrackClipType(typeof (TimeElapsedCustomClip))]
  public class TimeElapsedCustomTrack : TrackAsset
  {
    [Token(Token = "0x601239E")]
    [Address(RVA = "0x4598190", Offset = "0x4598190", VA = "0x4598190", Slot = "32")]
    protected override Playable CreatePlayable(
      PlayableGraph graph,
      GameObject gameObject,
      TimelineClip clip)
    {
      return new Playable();
    }

    [Token(Token = "0x601239F")]
    [Address(RVA = "0x4598198", Offset = "0x4598198", VA = "0x4598198")]
    public TimeElapsedCustomTrack()
    {
    }
  }
}
