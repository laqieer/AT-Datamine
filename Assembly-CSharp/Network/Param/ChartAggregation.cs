// Decompiled with JetBrains decompiler
// Type: Network.Param.ChartAggregation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A48")]
  [Serializable]
  public class ChartAggregation
  {
    [Token(Token = "0x400705E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerMainStorySequenceTransitionType> sequences;
    [Token(Token = "0x400705F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerMainStorySequenceTransitionLogType> all_sequences;
    [Token(Token = "0x4007060")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<int> all_ending_sequence_ids;
    [Token(Token = "0x4007061")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<int> adv_ids;
    [Token(Token = "0x4007062")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<int> all_adv_ids;
    [Token(Token = "0x4007063")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerAdvOptionType> adv_options;
    [Token(Token = "0x4007064")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerAdvOptionLogType> all_adv_options;
    [Token(Token = "0x4007065")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<int> all_adv_additional_option_ids;
    [Token(Token = "0x4007066")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerStoryBattleMissionType> story_battle_missions;
    [Token(Token = "0x4007067")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayerStoryBattleMissionLogType> all_story_battle_missions;

    [Token(Token = "0x17001894")]
    public List<PlayerMainStorySequenceTransitionType> Sequences
    {
      [Token(Token = "0x6009606"), Address(RVA = "0x48EEE6C", Offset = "0x48EEE6C", VA = "0x48EEE6C")] get
      {
        return (List<PlayerMainStorySequenceTransitionType>) null;
      }
      [Token(Token = "0x6009607"), Address(RVA = "0x48EEE74", Offset = "0x48EEE74", VA = "0x48EEE74")] set
      {
      }
    }

    [Token(Token = "0x17001895")]
    public List<PlayerMainStorySequenceTransitionLogType> AllSequences
    {
      [Token(Token = "0x6009608"), Address(RVA = "0x48EEE7C", Offset = "0x48EEE7C", VA = "0x48EEE7C")] get
      {
        return (List<PlayerMainStorySequenceTransitionLogType>) null;
      }
      [Token(Token = "0x6009609"), Address(RVA = "0x48EEE84", Offset = "0x48EEE84", VA = "0x48EEE84")] set
      {
      }
    }

    [Token(Token = "0x17001896")]
    public List<int> AllEndingSequenceIds
    {
      [Token(Token = "0x600960A"), Address(RVA = "0x48EEE8C", Offset = "0x48EEE8C", VA = "0x48EEE8C")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600960B"), Address(RVA = "0x48EEE94", Offset = "0x48EEE94", VA = "0x48EEE94")] set
      {
      }
    }

    [Token(Token = "0x17001897")]
    public List<int> AdvIds
    {
      [Token(Token = "0x600960C"), Address(RVA = "0x48EEE9C", Offset = "0x48EEE9C", VA = "0x48EEE9C")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600960D"), Address(RVA = "0x48EEEA4", Offset = "0x48EEEA4", VA = "0x48EEEA4")] set
      {
      }
    }

    [Token(Token = "0x17001898")]
    public List<int> AllAdvIds
    {
      [Token(Token = "0x600960E"), Address(RVA = "0x48EEEAC", Offset = "0x48EEEAC", VA = "0x48EEEAC")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600960F"), Address(RVA = "0x48EEEB4", Offset = "0x48EEEB4", VA = "0x48EEEB4")] set
      {
      }
    }

    [Token(Token = "0x17001899")]
    public List<PlayerAdvOptionType> AdvOptions
    {
      [Token(Token = "0x6009610"), Address(RVA = "0x48EEEBC", Offset = "0x48EEEBC", VA = "0x48EEEBC")] get
      {
        return (List<PlayerAdvOptionType>) null;
      }
      [Token(Token = "0x6009611"), Address(RVA = "0x48EEEC4", Offset = "0x48EEEC4", VA = "0x48EEEC4")] set
      {
      }
    }

    [Token(Token = "0x1700189A")]
    public List<PlayerAdvOptionLogType> AllAdvOptions
    {
      [Token(Token = "0x6009612"), Address(RVA = "0x48EEECC", Offset = "0x48EEECC", VA = "0x48EEECC")] get
      {
        return (List<PlayerAdvOptionLogType>) null;
      }
      [Token(Token = "0x6009613"), Address(RVA = "0x48EEED4", Offset = "0x48EEED4", VA = "0x48EEED4")] set
      {
      }
    }

    [Token(Token = "0x1700189B")]
    public List<int> AllAdvAdditionalOptionIds
    {
      [Token(Token = "0x6009614"), Address(RVA = "0x48EEEDC", Offset = "0x48EEEDC", VA = "0x48EEEDC")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x6009615"), Address(RVA = "0x48EEEE4", Offset = "0x48EEEE4", VA = "0x48EEEE4")] set
      {
      }
    }

    [Token(Token = "0x1700189C")]
    public List<PlayerStoryBattleMissionType> StoryBattleMissions
    {
      [Token(Token = "0x6009616"), Address(RVA = "0x48EEEEC", Offset = "0x48EEEEC", VA = "0x48EEEEC")] get
      {
        return (List<PlayerStoryBattleMissionType>) null;
      }
      [Token(Token = "0x6009617"), Address(RVA = "0x48EEEF4", Offset = "0x48EEEF4", VA = "0x48EEEF4")] set
      {
      }
    }

    [Token(Token = "0x1700189D")]
    public List<PlayerStoryBattleMissionLogType> AllStoryBattleMissions
    {
      [Token(Token = "0x6009618"), Address(RVA = "0x48EEEFC", Offset = "0x48EEEFC", VA = "0x48EEEFC")] get
      {
        return (List<PlayerStoryBattleMissionLogType>) null;
      }
      [Token(Token = "0x6009619"), Address(RVA = "0x48EEF04", Offset = "0x48EEF04", VA = "0x48EEF04")] set
      {
      }
    }

    [Token(Token = "0x600961A")]
    [Address(RVA = "0x48EEF0C", Offset = "0x48EEF0C", VA = "0x48EEF0C")]
    public ChartAggregation()
    {
    }
  }
}
