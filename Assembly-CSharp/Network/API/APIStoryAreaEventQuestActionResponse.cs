// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryAreaEventQuestActionResponse
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
  [Token(Token = "0x2001E28")]
  [Serializable]
  public class APIStoryAreaEventQuestActionResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x4008126")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x4008127")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x4008128")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x4008129")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x400812A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x400812B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400812C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x400812D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x400812E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private PlayerStoryAreaEventQuestType player_area_event_quest;

    [Token(Token = "0x170023FE")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B287"), Address(RVA = "0x22E0338", Offset = "0x22E0338", VA = "0x22E0338", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x170023FF")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B288"), Address(RVA = "0x22E0340", Offset = "0x22E0340", VA = "0x22E0340", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x17002400")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B289"), Address(RVA = "0x22E0348", Offset = "0x22E0348", VA = "0x22E0348", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x17002401")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B28A"), Address(RVA = "0x22E0350", Offset = "0x22E0350", VA = "0x22E0350", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x17002402")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B28B"), Address(RVA = "0x22E0358", Offset = "0x22E0358", VA = "0x22E0358", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17002403")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B28C"), Address(RVA = "0x22E0360", Offset = "0x22E0360", VA = "0x22E0360", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002404")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B28D"), Address(RVA = "0x22E0368", Offset = "0x22E0368", VA = "0x22E0368", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002405")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B28E"), Address(RVA = "0x22E0370", Offset = "0x22E0370", VA = "0x22E0370", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002406")]
    public PlayerStoryAreaEventQuestType PlayerAreaEventQuest
    {
      [Token(Token = "0x600B28F"), Address(RVA = "0x22E0378", Offset = "0x22E0378", VA = "0x22E0378")] get
      {
        return (PlayerStoryAreaEventQuestType) null;
      }
    }

    [Token(Token = "0x600B290")]
    [Address(RVA = "0x22E0380", Offset = "0x22E0380", VA = "0x22E0380")]
    public APIStoryAreaEventQuestActionResponse()
    {
    }
  }
}
