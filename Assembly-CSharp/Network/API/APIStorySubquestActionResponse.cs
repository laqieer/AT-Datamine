// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestActionResponse
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
  [Token(Token = "0x2001E70")]
  [Serializable]
  public class APIStorySubquestActionResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x40082B1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x40082B2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x40082B3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x40082B4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x40082B5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x40082B6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40082B7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40082B8")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40082B9")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private PlayerStorySubQuestType player_subquest;

    [Token(Token = "0x170024E4")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B48D"), Address(RVA = "0x22E6660", Offset = "0x22E6660", VA = "0x22E6660", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x170024E5")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B48E"), Address(RVA = "0x22E6668", Offset = "0x22E6668", VA = "0x22E6668", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x170024E6")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B48F"), Address(RVA = "0x22E6670", Offset = "0x22E6670", VA = "0x22E6670", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x170024E7")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B490"), Address(RVA = "0x22E6678", Offset = "0x22E6678", VA = "0x22E6678", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x170024E8")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B491"), Address(RVA = "0x22E6680", Offset = "0x22E6680", VA = "0x22E6680", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x170024E9")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B492"), Address(RVA = "0x22E6688", Offset = "0x22E6688", VA = "0x22E6688", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170024EA")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B493"), Address(RVA = "0x22E6690", Offset = "0x22E6690", VA = "0x22E6690", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170024EB")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B494"), Address(RVA = "0x22E6698", Offset = "0x22E6698", VA = "0x22E6698", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170024EC")]
    public PlayerStorySubQuestType PlayerSubquest
    {
      [Token(Token = "0x600B495"), Address(RVA = "0x22E66A0", Offset = "0x22E66A0", VA = "0x22E66A0")] get
      {
        return (PlayerStorySubQuestType) null;
      }
    }

    [Token(Token = "0x600B496")]
    [Address(RVA = "0x22E66A8", Offset = "0x22E66A8", VA = "0x22E66A8")]
    public APIStorySubquestActionResponse()
    {
    }
  }
}
