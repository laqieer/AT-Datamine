// Decompiled with JetBrains decompiler
// Type: ShaderTimeline.ShaderTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace ShaderTimeline
{
  [Token(Token = "0x2000773")]
  [TrackBindingType(typeof (ShaderPlayableValue))]
  [TrackColor(0.0f, 0.0f, 1f)]
  [TrackClipType(typeof (ShaderClip))]
  public class ShaderTrack : TrackAsset
  {
    [Token(Token = "0x600298E")]
    [Address(RVA = "0x36828A0", Offset = "0x36828A0", VA = "0x36828A0", Slot = "24")]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
      return new Playable();
    }

    [Token(Token = "0x600298F")]
    [Address(RVA = "0x3682A08", Offset = "0x3682A08", VA = "0x3682A08")]
    public ShaderTrack()
    {
    }
  }
}
