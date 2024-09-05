// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryResponse
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
  [Token(Token = "0x2001E24")]
  [Serializable]
  public class APIStoryResponse : ICommonApiResult
  {
    [Token(Token = "0x4008110")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008111")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerStoryPointType> player_story_points;
    [Token(Token = "0x4008112")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerStoryHumanParameterType> player_human_parameters;
    [Token(Token = "0x4008113")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStorySubQuestType> player_story_subquests;
    [Token(Token = "0x4008114")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerStoryAreaEventQuestType> player_area_event_quests;
    [Token(Token = "0x4008115")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerStoryCommunicationType> player_communications;
    [Token(Token = "0x4008116")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerStoryFacilityType> player_facilities;
    [Token(Token = "0x4008117")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerFreeActionSequenceStatus player_freeaction;
    [Token(Token = "0x4008118")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private PlayerAreaMapObjectStatus player_area_map;

    [Token(Token = "0x170023EF")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B268"), Address(RVA = "0x22DFDA4", Offset = "0x22DFDA4", VA = "0x22DFDA4", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170023F0")]
    public List<PlayerStoryPointType> PlayerStoryPoints
    {
      [Token(Token = "0x600B269"), Address(RVA = "0x22DFDAC", Offset = "0x22DFDAC", VA = "0x22DFDAC")] get
      {
        return (List<PlayerStoryPointType>) null;
      }
    }

    [Token(Token = "0x170023F1")]
    public List<PlayerStoryHumanParameterType> PlayerHumanParameters
    {
      [Token(Token = "0x600B26A"), Address(RVA = "0x22DFDB4", Offset = "0x22DFDB4", VA = "0x22DFDB4")] get
      {
        return (List<PlayerStoryHumanParameterType>) null;
      }
    }

    [Token(Token = "0x170023F2")]
    public List<PlayerStorySubQuestType> PlayerStorySubquests
    {
      [Token(Token = "0x600B26B"), Address(RVA = "0x22DFDBC", Offset = "0x22DFDBC", VA = "0x22DFDBC")] get
      {
        return (List<PlayerStorySubQuestType>) null;
      }
    }

    [Token(Token = "0x170023F3")]
    public List<PlayerStoryAreaEventQuestType> PlayerAreaEventQuests
    {
      [Token(Token = "0x600B26C"), Address(RVA = "0x22DFDC4", Offset = "0x22DFDC4", VA = "0x22DFDC4")] get
      {
        return (List<PlayerStoryAreaEventQuestType>) null;
      }
    }

    [Token(Token = "0x170023F4")]
    public List<PlayerStoryCommunicationType> PlayerCommunications
    {
      [Token(Token = "0x600B26D"), Address(RVA = "0x22DFDCC", Offset = "0x22DFDCC", VA = "0x22DFDCC")] get
      {
        return (List<PlayerStoryCommunicationType>) null;
      }
    }

    [Token(Token = "0x170023F5")]
    public List<PlayerStoryFacilityType> PlayerFacilities
    {
      [Token(Token = "0x600B26E"), Address(RVA = "0x22DFDD4", Offset = "0x22DFDD4", VA = "0x22DFDD4")] get
      {
        return (List<PlayerStoryFacilityType>) null;
      }
    }

    [Token(Token = "0x170023F6")]
    public PlayerFreeActionSequenceStatus PlayerFreeaction
    {
      [Token(Token = "0x600B26F"), Address(RVA = "0x22DFDDC", Offset = "0x22DFDDC", VA = "0x22DFDDC")] get
      {
        return (PlayerFreeActionSequenceStatus) null;
      }
    }

    [Token(Token = "0x170023F7")]
    public PlayerAreaMapObjectStatus PlayerAreaMap
    {
      [Token(Token = "0x600B270"), Address(RVA = "0x22DFDE4", Offset = "0x22DFDE4", VA = "0x22DFDE4")] get
      {
        return (PlayerAreaMapObjectStatus) null;
      }
    }

    [Token(Token = "0x600B271")]
    [Address(RVA = "0x22DFDEC", Offset = "0x22DFDEC", VA = "0x22DFDEC")]
    public APIStoryResponse()
    {
    }
  }
}
