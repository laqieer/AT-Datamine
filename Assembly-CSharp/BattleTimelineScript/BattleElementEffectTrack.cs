// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattleElementEffectTrack
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
  [Token(Token = "0x20021F9")]
  [TrackColor(1f, 0.0f, 1f)]
  [TrackClipType(typeof (BattleElementEffectPlayableAsset))]
  [TrackBindingType(typeof (GameObject))]
  public class BattleElementEffectTrack : BattleEffectTrack
  {
    [Token(Token = "0x4008F9C")]
    [FieldOffset(Offset = "0xA0")]
    public ElementEffectItem.ElementType elementType;

    [Token(Token = "0x600CEF7")]
    [Address(RVA = "0x4B68AC8", Offset = "0x4B68AC8", VA = "0x4B68AC8", Slot = "24")]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
      return new Playable();
    }

    [Token(Token = "0x600CEF8")]
    [Address(RVA = "0x4B68EA0", Offset = "0x4B68EA0", VA = "0x4B68EA0")]
    public BattleElementEffectTrack()
    {
    }
  }
}
