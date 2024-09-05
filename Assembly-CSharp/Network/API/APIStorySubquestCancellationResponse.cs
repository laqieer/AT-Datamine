// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestCancellationResponse
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
  [Token(Token = "0x2001E7C")]
  [Serializable]
  public class APIStorySubquestCancellationResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4008303")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008304")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008305")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4008306")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerStorySubQuestType player_subquest;

    [Token(Token = "0x17002510")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B4E9"), Address(RVA = "0x22E7714", Offset = "0x22E7714", VA = "0x22E7714", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002511")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B4EA"), Address(RVA = "0x22E771C", Offset = "0x22E771C", VA = "0x22E771C", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002512")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B4EB"), Address(RVA = "0x22E7724", Offset = "0x22E7724", VA = "0x22E7724", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002513")]
    public PlayerStorySubQuestType PlayerSubquest
    {
      [Token(Token = "0x600B4EC"), Address(RVA = "0x22E772C", Offset = "0x22E772C", VA = "0x22E772C")] get
      {
        return (PlayerStorySubQuestType) null;
      }
    }

    [Token(Token = "0x600B4ED")]
    [Address(RVA = "0x22E7734", Offset = "0x22E7734", VA = "0x22E7734")]
    public APIStorySubquestCancellationResponse()
    {
    }
  }
}
