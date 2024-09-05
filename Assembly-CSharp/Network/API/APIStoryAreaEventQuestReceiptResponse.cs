// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryAreaEventQuestReceiptResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E2C")]
  [Serializable]
  public class APIStoryAreaEventQuestReceiptResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x400813C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400813D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x400813E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x400813F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerStoryAreaEventQuestType player_area_event_quest;

    [Token(Token = "0x1700240D")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B2A6"), Address(RVA = "0x22E08CC", Offset = "0x22E08CC", VA = "0x22E08CC", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700240E")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B2A7"), Address(RVA = "0x22E08D4", Offset = "0x22E08D4", VA = "0x22E08D4", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700240F")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B2A8"), Address(RVA = "0x22E08DC", Offset = "0x22E08DC", VA = "0x22E08DC", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002410")]
    public PlayerStoryAreaEventQuestType PlayerAreaEventQuest
    {
      [Token(Token = "0x600B2A9"), Address(RVA = "0x22E08E4", Offset = "0x22E08E4", VA = "0x22E08E4")] get
      {
        return (PlayerStoryAreaEventQuestType) null;
      }
    }

    [Token(Token = "0x600B2AA")]
    [Address(RVA = "0x22E08EC", Offset = "0x22E08EC", VA = "0x22E08EC")]
    public APIStoryAreaEventQuestReceiptResponse()
    {
    }
  }
}
