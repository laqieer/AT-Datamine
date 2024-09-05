// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestReadResponse
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
  [Token(Token = "0x2001E54")]
  [Serializable]
  public class APIStoryMainquestReadResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x400821A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x400821B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x400821C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x400821D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x400821E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x400821F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008220")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008221")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;

    [Token(Token = "0x1700248C")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B3C5"), Address(RVA = "0x22E3FDC", Offset = "0x22E3FDC", VA = "0x22E3FDC", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x1700248D")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B3C6"), Address(RVA = "0x22E3FE4", Offset = "0x22E3FE4", VA = "0x22E3FE4", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x1700248E")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B3C7"), Address(RVA = "0x22E3FEC", Offset = "0x22E3FEC", VA = "0x22E3FEC", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x1700248F")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B3C8"), Address(RVA = "0x22E3FF4", Offset = "0x22E3FF4", VA = "0x22E3FF4", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x17002490")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B3C9"), Address(RVA = "0x22E3FFC", Offset = "0x22E3FFC", VA = "0x22E3FFC", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17002491")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B3CA"), Address(RVA = "0x22E4004", Offset = "0x22E4004", VA = "0x22E4004", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002492")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B3CB"), Address(RVA = "0x22E400C", Offset = "0x22E400C", VA = "0x22E400C", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002493")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B3CC"), Address(RVA = "0x22E4014", Offset = "0x22E4014", VA = "0x22E4014", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x600B3CD")]
    [Address(RVA = "0x22E401C", Offset = "0x22E401C", VA = "0x22E401C")]
    public APIStoryMainquestReadResponse()
    {
    }
  }
}
