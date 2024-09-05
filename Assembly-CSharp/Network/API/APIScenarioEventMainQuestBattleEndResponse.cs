// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventMainQuestBattleEndResponse
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
  [Token(Token = "0x2001DE0")]
  [Serializable]
  public class APIScenarioEventMainQuestBattleEndResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x4007FBF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x4007FC0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x4007FC1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x4007FC2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x4007FC3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x4007FC4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007FC5")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007FC6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007FC7")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private PlayerBattleResult results;

    [Token(Token = "0x1700233C")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B0A5"), Address(RVA = "0x1A542DC", Offset = "0x1A542DC", VA = "0x1A542DC", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x1700233D")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B0A6"), Address(RVA = "0x1A542E4", Offset = "0x1A542E4", VA = "0x1A542E4", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x1700233E")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B0A7"), Address(RVA = "0x1A542EC", Offset = "0x1A542EC", VA = "0x1A542EC", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x1700233F")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B0A8"), Address(RVA = "0x1A542F4", Offset = "0x1A542F4", VA = "0x1A542F4", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x17002340")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B0A9"), Address(RVA = "0x1A542FC", Offset = "0x1A542FC", VA = "0x1A542FC", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17002341")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B0AA"), Address(RVA = "0x1A54304", Offset = "0x1A54304", VA = "0x1A54304", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002342")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B0AB"), Address(RVA = "0x1A5430C", Offset = "0x1A5430C", VA = "0x1A5430C", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002343")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B0AC"), Address(RVA = "0x1A54314", Offset = "0x1A54314", VA = "0x1A54314", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002344")]
    public PlayerBattleResult Results
    {
      [Token(Token = "0x600B0AD"), Address(RVA = "0x1A5431C", Offset = "0x1A5431C", VA = "0x1A5431C")] get
      {
        return (PlayerBattleResult) null;
      }
    }

    [Token(Token = "0x600B0AE")]
    [Address(RVA = "0x1A54324", Offset = "0x1A54324", VA = "0x1A54324")]
    public APIScenarioEventMainQuestBattleEndResponse()
    {
    }
  }
}
