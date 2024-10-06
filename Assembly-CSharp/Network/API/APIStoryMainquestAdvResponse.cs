// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestAdvResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E44")]
  [Serializable]
  public class APIStoryMainquestAdvResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x40081AD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x40081AE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x40081AF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x40081B0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x40081B1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x40081B2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40081B3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40081B4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40081B5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerCommunicationSkillType> updated_communication_skills;

    [Token(Token = "0x17002451")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B34A"), Address(RVA = "0x22E2994", Offset = "0x22E2994", VA = "0x22E2994", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x17002452")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B34B"), Address(RVA = "0x22E299C", Offset = "0x22E299C", VA = "0x22E299C", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x17002453")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B34C"), Address(RVA = "0x22E29A4", Offset = "0x22E29A4", VA = "0x22E29A4", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x17002454")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B34D"), Address(RVA = "0x22E29AC", Offset = "0x22E29AC", VA = "0x22E29AC", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x17002455")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B34E"), Address(RVA = "0x22E29B4", Offset = "0x22E29B4", VA = "0x22E29B4", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17002456")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B34F"), Address(RVA = "0x22E29BC", Offset = "0x22E29BC", VA = "0x22E29BC", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002457")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B350"), Address(RVA = "0x22E29C4", Offset = "0x22E29C4", VA = "0x22E29C4", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002458")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B351"), Address(RVA = "0x22E29CC", Offset = "0x22E29CC", VA = "0x22E29CC", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002459")]
    public List<PlayerCommunicationSkillType> UpdatedCommunicationSkills
    {
      [Token(Token = "0x600B352"), Address(RVA = "0x22E29D4", Offset = "0x22E29D4", VA = "0x22E29D4")] get
      {
        return (List<PlayerCommunicationSkillType>) null;
      }
    }

    [Token(Token = "0x600B353")]
    [Address(RVA = "0x22E29DC", Offset = "0x22E29DC", VA = "0x22E29DC")]
    public APIStoryMainquestAdvResponse()
    {
    }
  }
}
