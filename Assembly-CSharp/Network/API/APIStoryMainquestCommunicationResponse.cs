// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestCommunicationResponse
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
  [Token(Token = "0x2001E50")]
  [Serializable]
  public class APIStoryMainquestCommunicationResponse : 
    ISequenceTransitionResult,
    IPostApiResult,
    ICommonApiResult
  {
    [Token(Token = "0x4008203")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;
    [Token(Token = "0x4008204")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x4008205")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;
    [Token(Token = "0x4008206")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> aborted_subquests;
    [Token(Token = "0x4008207")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> released_story_gacha_titles;
    [Token(Token = "0x4008208")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008209")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x400820A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x400820B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private PlayerStoryCommunicationType player_communication;
    [Token(Token = "0x400820C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayerCommunicationSkillType> updated_communication_skills;

    [Token(Token = "0x1700247C")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600B3A5"), Address(RVA = "0x22E3A40", Offset = "0x22E3A40", VA = "0x22E3A40", Slot = "4")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x1700247D")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B3A6"), Address(RVA = "0x22E3A48", Offset = "0x22E3A48", VA = "0x22E3A48", Slot = "5")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x1700247E")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B3A7"), Address(RVA = "0x22E3A50", Offset = "0x22E3A50", VA = "0x22E3A50", Slot = "6")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x1700247F")]
    public List<PlayerStorySubQuestType> AbortedSubquests
    {
      [Token(Token = "0x600B3A8"), Address(RVA = "0x22E3A58", Offset = "0x22E3A58", VA = "0x22E3A58", Slot = "7")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x17002480")]
    public List<string> ReleasedStoryGachaTitles
    {
      [Token(Token = "0x600B3A9"), Address(RVA = "0x22E3A60", Offset = "0x22E3A60", VA = "0x22E3A60", Slot = "8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17002481")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B3AA"), Address(RVA = "0x22E3A68", Offset = "0x22E3A68", VA = "0x22E3A68", Slot = "11")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002482")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B3AB"), Address(RVA = "0x22E3A70", Offset = "0x22E3A70", VA = "0x22E3A70", Slot = "9")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002483")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B3AC"), Address(RVA = "0x22E3A78", Offset = "0x22E3A78", VA = "0x22E3A78", Slot = "10")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002484")]
    public PlayerStoryCommunicationType PlayerCommunication
    {
      [Token(Token = "0x600B3AD"), Address(RVA = "0x22E3A80", Offset = "0x22E3A80", VA = "0x22E3A80")] get
      {
        return (PlayerStoryCommunicationType) null;
      }
    }

    [Token(Token = "0x17002485")]
    public List<PlayerCommunicationSkillType> UpdatedCommunicationSkills
    {
      [Token(Token = "0x600B3AE"), Address(RVA = "0x22E3A88", Offset = "0x22E3A88", VA = "0x22E3A88")] get
      {
        return (List<PlayerCommunicationSkillType>) null;
      }
    }

    [Token(Token = "0x600B3AF")]
    [Address(RVA = "0x22E3A90", Offset = "0x22E3A90", VA = "0x22E3A90")]
    public APIStoryMainquestCommunicationResponse()
    {
    }
  }
}
