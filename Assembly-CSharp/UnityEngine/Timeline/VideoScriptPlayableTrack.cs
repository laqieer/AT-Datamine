// Decompiled with JetBrains decompiler
// Type: UnityEngine.Timeline.VideoScriptPlayableTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Playables;

#nullable disable
namespace UnityEngine.Timeline
{
  [Token(Token = "0x2003F44")]
  [TrackColor(0.008f, 0.698f, 0.655f)]
  [TrackClipType(typeof (VideoScriptPlayableAsset))]
  [Serializable]
  public class VideoScriptPlayableTrack : TrackAsset
  {
    [Token(Token = "0x60198B5")]
    [Address(RVA = "0x3748D30", Offset = "0x3748D30", VA = "0x3748D30", Slot = "24")]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
      return new Playable();
    }

    [Token(Token = "0x60198B6")]
    [Address(RVA = "0x3748E88", Offset = "0x3748E88", VA = "0x3748E88")]
    public VideoScriptPlayableTrack()
    {
    }
  }
}
