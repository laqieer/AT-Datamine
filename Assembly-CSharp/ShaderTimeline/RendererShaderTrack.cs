// Decompiled with JetBrains decompiler
// Type: ShaderTimeline.RendererShaderTrack
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
  [Token(Token = "0x2000769")]
  [TrackColor(0.0f, 1f, 0.0f)]
  [TrackClipType(typeof (ShaderClip))]
  [TrackBindingType(typeof (Renderer))]
  public class RendererShaderTrack : TrackAsset
  {
    [Token(Token = "0x6002976")]
    [Address(RVA = "0x3680BBC", Offset = "0x3680BBC", VA = "0x3680BBC", Slot = "24")]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
      return new Playable();
    }

    [Token(Token = "0x6002977")]
    [Address(RVA = "0x3680D24", Offset = "0x3680D24", VA = "0x3680D24")]
    public RendererShaderTrack()
    {
    }
  }
}
