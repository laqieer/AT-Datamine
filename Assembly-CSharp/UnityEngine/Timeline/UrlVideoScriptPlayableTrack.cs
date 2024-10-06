// Decompiled with JetBrains decompiler
// Type: UnityEngine.Timeline.UrlVideoScriptPlayableTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Playables;

#nullable disable
namespace UnityEngine.Timeline
{
  [Token(Token = "0x2003F40")]
  [TrackColor(0.008f, 0.698f, 0.655f)]
  [TrackClipType(typeof (UrlVideoScriptPlayableAsset))]
  [Serializable]
  public class UrlVideoScriptPlayableTrack : TrackAsset
  {
    [Token(Token = "0x601989D")]
    [Address(RVA = "0x3747A60", Offset = "0x3747A60", VA = "0x3747A60", Slot = "24")]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
      return new Playable();
    }

    [Token(Token = "0x601989E")]
    [Address(RVA = "0x3747BB8", Offset = "0x3747BB8", VA = "0x3747BB8")]
    public UrlVideoScriptPlayableTrack()
    {
    }
  }
}
