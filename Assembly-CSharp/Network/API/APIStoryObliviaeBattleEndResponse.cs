// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryObliviaeBattleEndResponse
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
  [Token(Token = "0x2001E5C")]
  [Serializable]
  public class APIStoryObliviaeBattleEndResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x400824F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x4008250")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x4008251")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x4008252")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x4008253")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x4008254")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008255")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008256")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4008257")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private PlayerBattleResult results;

    [Token(Token = "0x170024A8")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B401"), Address(RVA = "0x22E4AF4", Offset = "0x22E4AF4", VA = "0x22E4AF4", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x170024A9")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B402"), Address(RVA = "0x22E4AFC", Offset = "0x22E4AFC", VA = "0x22E4AFC", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x170024AA")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B403"), Address(RVA = "0x22E4B04", Offset = "0x22E4B04", VA = "0x22E4B04", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x170024AB")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B404"), Address(RVA = "0x22E4B0C", Offset = "0x22E4B0C", VA = "0x22E4B0C", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x170024AC")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B405"), Address(RVA = "0x22E4B14", Offset = "0x22E4B14", VA = "0x22E4B14", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x170024AD")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B406"), Address(RVA = "0x22E4B1C", Offset = "0x22E4B1C", VA = "0x22E4B1C", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170024AE")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B407"), Address(RVA = "0x22E4B24", Offset = "0x22E4B24", VA = "0x22E4B24", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170024AF")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B408"), Address(RVA = "0x22E4B2C", Offset = "0x22E4B2C", VA = "0x22E4B2C", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170024B0")]
    public PlayerBattleResult Results
    {
      [Token(Token = "0x600B409"), Address(RVA = "0x22E4B34", Offset = "0x22E4B34", VA = "0x22E4B34")] get
      {
        return (PlayerBattleResult) null;
      }
    }

    [Token(Token = "0x600B40A")]
    [Address(RVA = "0x22E4B3C", Offset = "0x22E4B3C", VA = "0x22E4B3C")]
    public APIStoryObliviaeBattleEndResponse()
    {
    }
  }
}
