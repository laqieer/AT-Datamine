// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestTutorialResponse
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
  [Token(Token = "0x2001E58")]
  [Serializable]
  public class APIStoryMainquestTutorialResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x400822E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x400822F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x4008230")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x4008231")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x4008232")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x4008233")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008234")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008235")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;

    [Token(Token = "0x1700249A")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B3E3"), Address(RVA = "0x22E4568", Offset = "0x22E4568", VA = "0x22E4568", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x1700249B")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B3E4"), Address(RVA = "0x22E4570", Offset = "0x22E4570", VA = "0x22E4570", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x1700249C")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B3E5"), Address(RVA = "0x22E4578", Offset = "0x22E4578", VA = "0x22E4578", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x1700249D")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B3E6"), Address(RVA = "0x22E4580", Offset = "0x22E4580", VA = "0x22E4580", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x1700249E")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B3E7"), Address(RVA = "0x22E4588", Offset = "0x22E4588", VA = "0x22E4588", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x1700249F")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B3E8"), Address(RVA = "0x22E4590", Offset = "0x22E4590", VA = "0x22E4590", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170024A0")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B3E9"), Address(RVA = "0x22E4598", Offset = "0x22E4598", VA = "0x22E4598", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170024A1")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B3EA"), Address(RVA = "0x22E45A0", Offset = "0x22E45A0", VA = "0x22E45A0", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x600B3EB")]
    [Address(RVA = "0x22E45A8", Offset = "0x22E45A8", VA = "0x22E45A8")]
    public APIStoryMainquestTutorialResponse()
    {
    }
  }
}
