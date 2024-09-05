// Decompiled with JetBrains decompiler
// Type: ShaderTimeline.UIShaderTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

#nullable disable
namespace ShaderTimeline
{
  [Token(Token = "0x2000775")]
  [TrackClipType(typeof (ShaderClip))]
  [TrackBindingType(typeof (Graphic))]
  [TrackColor(1f, 0.0f, 0.0f)]
  public class UIShaderTrack : TrackAsset
  {
    [Token(Token = "0x6002997")]
    [Address(RVA = "0x34F6F00", Offset = "0x34F6F00", VA = "0x34F6F00", Slot = "24")]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
      return new Playable();
    }

    [Token(Token = "0x6002998")]
    [Address(RVA = "0x34F7068", Offset = "0x34F7068", VA = "0x34F7068")]
    public UIShaderTrack()
    {
    }
  }
}
