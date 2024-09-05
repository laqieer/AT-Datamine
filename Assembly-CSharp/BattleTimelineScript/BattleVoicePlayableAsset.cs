// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattleVoicePlayableAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace BattleTimelineScript
{
  [Token(Token = "0x2002202")]
  public class BattleVoicePlayableAsset : PlayableAsset, ITimelineClipAsset
  {
    [Token(Token = "0x4008FAC")]
    [FieldOffset(Offset = "0x18")]
    public bool voiceIdByCharacterCombination;
    [Token(Token = "0x4008FAD")]
    [FieldOffset(Offset = "0x20")]
    public List<string> voiceIds;
    [Token(Token = "0x4008FAE")]
    [FieldOffset(Offset = "0x28")]
    public string voiceCategory;
    [Token(Token = "0x4008FAF")]
    [FieldOffset(Offset = "0x30")]
    [NonSerialized]
    public TimelineClip owningClip;
    [Token(Token = "0x4008FB0")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public BattleVoiceTrack track;

    [Token(Token = "0x17002D20")]
    public ClipCaps clipCaps
    {
      [Token(Token = "0x600CF17"), Address(RVA = "0x4B69F4C", Offset = "0x4B69F4C", VA = "0x4B69F4C", Slot = "9")] get
      {
        return new ClipCaps();
      }
    }

    [Token(Token = "0x600CF18")]
    [Address(RVA = "0x4B69F54", Offset = "0x4B69F54", VA = "0x4B69F54", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
      return new Playable();
    }

    [Token(Token = "0x600CF19")]
    [Address(RVA = "0x4B6A4B4", Offset = "0x4B6A4B4", VA = "0x4B6A4B4")]
    private string CreateSoundName(string characterId, string voiceId, string voiceCategory)
    {
      return (string) null;
    }

    [Token(Token = "0x600CF1A")]
    [Address(RVA = "0x4B6A310", Offset = "0x4B6A310", VA = "0x4B6A310")]
    private string CreateVoicePairSoundName(string characterId, string voiceId) => (string) null;

    [Token(Token = "0x600CF1B")]
    [Address(RVA = "0x4B6A654", Offset = "0x4B6A654", VA = "0x4B6A654")]
    public BattleVoicePlayableAsset()
    {
    }
  }
}
