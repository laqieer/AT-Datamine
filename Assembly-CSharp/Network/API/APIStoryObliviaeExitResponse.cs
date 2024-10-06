// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryObliviaeExitResponse
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
  [Token(Token = "0x2001E64")]
  [Serializable]
  public class APIStoryObliviaeExitResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x400827E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x400827F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x4008280")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x4008281")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x4008282")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x4008283")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008284")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008285")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;

    [Token(Token = "0x170024C4")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B43D"), Address(RVA = "0x22E560C", Offset = "0x22E560C", VA = "0x22E560C", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x170024C5")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B43E"), Address(RVA = "0x22E5614", Offset = "0x22E5614", VA = "0x22E5614", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x170024C6")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B43F"), Address(RVA = "0x22E561C", Offset = "0x22E561C", VA = "0x22E561C", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x170024C7")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B440"), Address(RVA = "0x22E5624", Offset = "0x22E5624", VA = "0x22E5624", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x170024C8")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B441"), Address(RVA = "0x22E562C", Offset = "0x22E562C", VA = "0x22E562C", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x170024C9")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B442"), Address(RVA = "0x22E5634", Offset = "0x22E5634", VA = "0x22E5634", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170024CA")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B443"), Address(RVA = "0x22E563C", Offset = "0x22E563C", VA = "0x22E563C", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170024CB")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B444"), Address(RVA = "0x22E5644", Offset = "0x22E5644", VA = "0x22E5644", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x600B445")]
    [Address(RVA = "0x22E564C", Offset = "0x22E564C", VA = "0x22E564C")]
    public APIStoryObliviaeExitResponse()
    {
    }
  }
}
