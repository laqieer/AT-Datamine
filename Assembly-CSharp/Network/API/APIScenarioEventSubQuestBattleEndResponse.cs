// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventSubQuestBattleEndResponse
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
  [Token(Token = "0x2001DE8")]
  [Serializable]
  public class APIScenarioEventSubQuestBattleEndResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x4007FFA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x4007FFB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x4007FFC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x4007FFD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x4007FFE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x4007FFF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008000")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008001")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4008002")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private PlayerStorySubQuestType player_subquest;
    [Token(Token = "0x4008003")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private PlayerBattleResult results;

    [Token(Token = "0x17002358")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B0E1"), Address(RVA = "0x22DAC48", Offset = "0x22DAC48", VA = "0x22DAC48", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x17002359")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B0E2"), Address(RVA = "0x22DAC50", Offset = "0x22DAC50", VA = "0x22DAC50", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x1700235A")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B0E3"), Address(RVA = "0x22DAC58", Offset = "0x22DAC58", VA = "0x22DAC58", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x1700235B")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B0E4"), Address(RVA = "0x22DAC60", Offset = "0x22DAC60", VA = "0x22DAC60", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x1700235C")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B0E5"), Address(RVA = "0x22DAC68", Offset = "0x22DAC68", VA = "0x22DAC68", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x1700235D")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B0E6"), Address(RVA = "0x22DAC70", Offset = "0x22DAC70", VA = "0x22DAC70", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700235E")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B0E7"), Address(RVA = "0x22DAC78", Offset = "0x22DAC78", VA = "0x22DAC78", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700235F")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B0E8"), Address(RVA = "0x22DAC80", Offset = "0x22DAC80", VA = "0x22DAC80", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002360")]
    public PlayerStorySubQuestType PlayerSubquest
    {
      [Token(Token = "0x600B0E9"), Address(RVA = "0x22DAC88", Offset = "0x22DAC88", VA = "0x22DAC88")] get
      {
        return (PlayerStorySubQuestType) null;
      }
    }

    [Token(Token = "0x17002361")]
    public PlayerBattleResult Results
    {
      [Token(Token = "0x600B0EA"), Address(RVA = "0x22DAC90", Offset = "0x22DAC90", VA = "0x22DAC90")] get
      {
        return (PlayerBattleResult) null;
      }
    }

    [Token(Token = "0x600B0EB")]
    [Address(RVA = "0x22DAC98", Offset = "0x22DAC98", VA = "0x22DAC98")]
    public APIScenarioEventSubQuestBattleEndResponse()
    {
    }
  }
}
