// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattleEffectTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace BattleTimelineScript
{
  [Token(Token = "0x20021F6")]
  [TrackClipType(typeof (BattleEffectPlayableAsset))]
  [TrackBindingType(typeof (GameObject))]
  public class BattleEffectTrack : TrackAsset
  {
    [Token(Token = "0x600CEEF")]
    [Address(RVA = "0x4B68524", Offset = "0x4B68524", VA = "0x4B68524", Slot = "24")]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
      return new Playable();
    }

    [Token(Token = "0x600CEF0")]
    [Address(RVA = "0x4B688FC", Offset = "0x4B688FC", VA = "0x4B688FC")]
    public BattleEffectTrack()
    {
    }
  }
}
