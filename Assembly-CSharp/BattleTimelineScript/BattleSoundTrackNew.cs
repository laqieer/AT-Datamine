// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattleSoundTrackNew
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
  [Token(Token = "0x2002201")]
  [TrackClipType(typeof (BattleSoundPlayableAssetNew))]
  [TrackColor(0.0f, 1f, 0.0f)]
  public class BattleSoundTrackNew : TrackAsset
  {
    [Token(Token = "0x600CF15")]
    [Address(RVA = "0x4B69AE8", Offset = "0x4B69AE8", VA = "0x4B69AE8", Slot = "24")]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
      return new Playable();
    }

    [Token(Token = "0x600CF16")]
    [Address(RVA = "0x4B69EF4", Offset = "0x4B69EF4", VA = "0x4B69EF4")]
    public BattleSoundTrackNew()
    {
    }
  }
}
