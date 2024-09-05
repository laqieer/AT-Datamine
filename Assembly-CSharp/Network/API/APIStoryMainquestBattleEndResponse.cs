// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestBattleEndResponse
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
  [Token(Token = "0x2001E48")]
  [Serializable]
  public class APIStoryMainquestBattleEndResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x40081D1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x40081D2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x40081D3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x40081D4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x40081D5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x40081D6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40081D7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40081D8")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40081D9")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private PlayerBattleResult results;

    [Token(Token = "0x17002460")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B369"), Address(RVA = "0x22E2F28", Offset = "0x22E2F28", VA = "0x22E2F28", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x17002461")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B36A"), Address(RVA = "0x22E2F30", Offset = "0x22E2F30", VA = "0x22E2F30", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x17002462")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B36B"), Address(RVA = "0x22E2F38", Offset = "0x22E2F38", VA = "0x22E2F38", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x17002463")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B36C"), Address(RVA = "0x22E2F40", Offset = "0x22E2F40", VA = "0x22E2F40", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x17002464")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B36D"), Address(RVA = "0x22E2F48", Offset = "0x22E2F48", VA = "0x22E2F48", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17002465")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B36E"), Address(RVA = "0x22E2F50", Offset = "0x22E2F50", VA = "0x22E2F50", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002466")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B36F"), Address(RVA = "0x22E2F58", Offset = "0x22E2F58", VA = "0x22E2F58", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002467")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B370"), Address(RVA = "0x22E2F60", Offset = "0x22E2F60", VA = "0x22E2F60", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002468")]
    public PlayerBattleResult Results
    {
      [Token(Token = "0x600B371"), Address(RVA = "0x22E2F68", Offset = "0x22E2F68", VA = "0x22E2F68")] get
      {
        return (PlayerBattleResult) null;
      }
    }

    [Token(Token = "0x600B372")]
    [Address(RVA = "0x22E2F70", Offset = "0x22E2F70", VA = "0x22E2F70")]
    public APIStoryMainquestBattleEndResponse()
    {
    }
  }
}
