// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFacilityExecutionResponse
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
  [Token(Token = "0x2001E30")]
  [Serializable]
  public class APIStoryFacilityExecutionResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x4008152")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x4008153")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x4008154")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x4008155")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x4008156")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x4008157")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008158")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008159")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x400815A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private PlayerStoryFacilityType player_facility;
    [Token(Token = "0x400815B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private StoryFacilityUseResult facility_use_result;

    [Token(Token = "0x17002417")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B2C0"), Address(RVA = "0x22E0E38", Offset = "0x22E0E38", VA = "0x22E0E38", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x17002418")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B2C1"), Address(RVA = "0x22E0E40", Offset = "0x22E0E40", VA = "0x22E0E40", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x17002419")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B2C2"), Address(RVA = "0x22E0E48", Offset = "0x22E0E48", VA = "0x22E0E48", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x1700241A")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B2C3"), Address(RVA = "0x22E0E50", Offset = "0x22E0E50", VA = "0x22E0E50", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x1700241B")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B2C4"), Address(RVA = "0x22E0E58", Offset = "0x22E0E58", VA = "0x22E0E58", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x1700241C")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B2C5"), Address(RVA = "0x22E0E60", Offset = "0x22E0E60", VA = "0x22E0E60", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700241D")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B2C6"), Address(RVA = "0x22E0E68", Offset = "0x22E0E68", VA = "0x22E0E68", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700241E")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B2C7"), Address(RVA = "0x22E0E70", Offset = "0x22E0E70", VA = "0x22E0E70", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x1700241F")]
    public PlayerStoryFacilityType PlayerFacility
    {
      [Token(Token = "0x600B2C8"), Address(RVA = "0x22E0E78", Offset = "0x22E0E78", VA = "0x22E0E78")] get
      {
        return (PlayerStoryFacilityType) null;
      }
    }

    [Token(Token = "0x17002420")]
    public StoryFacilityUseResult FacilityUseResult
    {
      [Token(Token = "0x600B2C9"), Address(RVA = "0x22E0E80", Offset = "0x22E0E80", VA = "0x22E0E80")] get
      {
        return (StoryFacilityUseResult) null;
      }
    }

    [Token(Token = "0x600B2CA")]
    [Address(RVA = "0x22E0E88", Offset = "0x22E0E88", VA = "0x22E0E88")]
    public APIStoryFacilityExecutionResponse()
    {
    }
  }
}
