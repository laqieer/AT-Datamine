// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFreeactionSkipResponse
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
  [Token(Token = "0x2001E40")]
  [Serializable]
  public class APIStoryFreeactionSkipResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x4008198")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x4008199")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x400819A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x400819B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x400819C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x400819D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400819E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x400819F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;

    [Token(Token = "0x17002443")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B32C"), Address(RVA = "0x22E2408", Offset = "0x22E2408", VA = "0x22E2408", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x17002444")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B32D"), Address(RVA = "0x22E2410", Offset = "0x22E2410", VA = "0x22E2410", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x17002445")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B32E"), Address(RVA = "0x22E2418", Offset = "0x22E2418", VA = "0x22E2418", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x17002446")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B32F"), Address(RVA = "0x22E2420", Offset = "0x22E2420", VA = "0x22E2420", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x17002447")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B330"), Address(RVA = "0x22E2428", Offset = "0x22E2428", VA = "0x22E2428", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17002448")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B331"), Address(RVA = "0x22E2430", Offset = "0x22E2430", VA = "0x22E2430", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002449")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B332"), Address(RVA = "0x22E2438", Offset = "0x22E2438", VA = "0x22E2438", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700244A")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B333"), Address(RVA = "0x22E2440", Offset = "0x22E2440", VA = "0x22E2440", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x600B334")]
    [Address(RVA = "0x22E2448", Offset = "0x22E2448", VA = "0x22E2448")]
    public APIStoryFreeactionSkipResponse()
    {
    }
  }
}
