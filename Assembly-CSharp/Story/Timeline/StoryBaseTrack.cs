// Decompiled with JetBrains decompiler
// Type: Story.Timeline.StoryBaseTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace Story.Timeline
{
  [Token(Token = "0x2000605")]
  public class StoryBaseTrack : TrackAsset
  {
    [Token(Token = "0x60022EC")]
    [Address(RVA = "0x2DA2944", Offset = "0x2DA2944", VA = "0x2DA2944", Slot = "32")]
    protected override Playable CreatePlayable(
      PlayableGraph graph,
      GameObject gameObject,
      TimelineClip clip)
    {
      return new Playable();
    }

    [Token(Token = "0x60022ED")]
    [Address(RVA = "0x2DA2A68", Offset = "0x2DA2A68", VA = "0x2DA2A68", Slot = "30")]
    protected override void OnCreateClip(TimelineClip clip)
    {
    }

    [Token(Token = "0x60022EE")]
    [Address(RVA = "0x2DA298C", Offset = "0x2DA298C", VA = "0x2DA298C")]
    protected void LinkAsset(TimelineClip clip)
    {
    }

    [Token(Token = "0x60022EF")]
    [Address(RVA = "0x2DA2AB4", Offset = "0x2DA2AB4", VA = "0x2DA2AB4")]
    public StoryBaseTrack()
    {
    }
  }
}
