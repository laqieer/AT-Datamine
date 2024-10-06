// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattleVoiceTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace BattleTimelineScript
{
  [Token(Token = "0x2002203")]
  [TrackColor(0.0f, 1f, 0.0f)]
  [TrackClipType(typeof (BattleVoicePlayableAsset))]
  public class BattleVoiceTrack : TrackAsset
  {
    [Token(Token = "0x4008FB1")]
    [FieldOffset(Offset = "0xA0")]
    public string characterId;
    [Token(Token = "0x4008FB2")]
    [FieldOffset(Offset = "0xA8")]
    public string pairCharacterId;
    [Token(Token = "0x4008FB3")]
    [FieldOffset(Offset = "0xB0")]
    public BattleVoiceTimingEnum voiceTiming;

    [Token(Token = "0x600CF1D")]
    [Address(RVA = "0x4B6A764", Offset = "0x4B6A764", VA = "0x4B6A764", Slot = "24")]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
      return new Playable();
    }

    [Token(Token = "0x600CF1E")]
    [Address(RVA = "0x4B6AB54", Offset = "0x4B6AB54", VA = "0x4B6AB54")]
    public BattleVoiceTrack()
    {
    }
  }
}
