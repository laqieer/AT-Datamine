// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestBattleEndResponse
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
  [Token(Token = "0x2001E74")]
  [Serializable]
  public class APIStorySubquestBattleEndResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x40082D3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x40082D4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x40082D5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x40082D6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x40082D7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x40082D8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40082D9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40082DA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40082DB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private PlayerStorySubQuestType player_subquest;
    [Token(Token = "0x40082DC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private PlayerBattleResult results;

    [Token(Token = "0x170024F3")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B4AC"), Address(RVA = "0x22E6BF4", Offset = "0x22E6BF4", VA = "0x22E6BF4", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x170024F4")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B4AD"), Address(RVA = "0x22E6BFC", Offset = "0x22E6BFC", VA = "0x22E6BFC", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x170024F5")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B4AE"), Address(RVA = "0x22E6C04", Offset = "0x22E6C04", VA = "0x22E6C04", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x170024F6")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B4AF"), Address(RVA = "0x22E6C0C", Offset = "0x22E6C0C", VA = "0x22E6C0C", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x170024F7")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B4B0"), Address(RVA = "0x22E6C14", Offset = "0x22E6C14", VA = "0x22E6C14", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x170024F8")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B4B1"), Address(RVA = "0x22E6C1C", Offset = "0x22E6C1C", VA = "0x22E6C1C", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170024F9")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B4B2"), Address(RVA = "0x22E6C24", Offset = "0x22E6C24", VA = "0x22E6C24", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170024FA")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B4B3"), Address(RVA = "0x22E6C2C", Offset = "0x22E6C2C", VA = "0x22E6C2C", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170024FB")]
    public PlayerStorySubQuestType PlayerSubquest
    {
      [Token(Token = "0x600B4B4"), Address(RVA = "0x22E6C34", Offset = "0x22E6C34", VA = "0x22E6C34")] get
      {
        return (PlayerStorySubQuestType) null;
      }
    }

    [Token(Token = "0x170024FC")]
    public PlayerBattleResult Results
    {
      [Token(Token = "0x600B4B5"), Address(RVA = "0x22E6C3C", Offset = "0x22E6C3C", VA = "0x22E6C3C")] get
      {
        return (PlayerBattleResult) null;
      }
    }

    [Token(Token = "0x600B4B6")]
    [Address(RVA = "0x22E6C44", Offset = "0x22E6C44", VA = "0x22E6C44")]
    public APIStorySubquestBattleEndResponse()
    {
    }
  }
}
