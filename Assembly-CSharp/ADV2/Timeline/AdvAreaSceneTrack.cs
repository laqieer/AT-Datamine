// Decompiled with JetBrains decompiler
// Type: ADV2.Timeline.AdvAreaSceneTrack
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
  [Token(Token = "0x2003E65")]
  [TrackClipType(typeof (AdvAreaSceneClip))]
  [TrackColor(0.0f, 1f, 0.0f)]
  [TrackBindingType(typeof (Adv2BindTrack))]
  public class AdvAreaSceneTrack : TrackAsset
  {
    [Token(Token = "0x60191C5")]
    [Address(RVA = "0x2CF19E0", Offset = "0x2CF19E0", VA = "0x2CF19E0", Slot = "24")]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
      return new Playable();
    }

    [Token(Token = "0x60191C6")]
    [Address(RVA = "0x2CF1F90", Offset = "0x2CF1F90", VA = "0x2CF1F90")]
    public AdvAreaSceneTrack()
    {
    }
  }
}
