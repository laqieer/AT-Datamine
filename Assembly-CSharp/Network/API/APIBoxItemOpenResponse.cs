// Decompiled with JetBrains decompiler
// Type: Network.API.APIBoxItemOpenResponse
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
  [Token(Token = "0x2001BBC")]
  [Serializable]
  public class APIBoxItemOpenResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40076DF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40076E0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40076E1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40076E2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<RewardGiveResultEntityType> rewards;

    [Token(Token = "0x17001E26")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A2FF"), Address(RVA = "0x46CD3BC", Offset = "0x46CD3BC", VA = "0x46CD3BC", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001E27")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A300"), Address(RVA = "0x46CD3C4", Offset = "0x46CD3C4", VA = "0x46CD3C4", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001E28")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A301"), Address(RVA = "0x46CD3CC", Offset = "0x46CD3CC", VA = "0x46CD3CC", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001E29")]
    public List<RewardGiveResultEntityType> Rewards
    {
      [Token(Token = "0x600A302"), Address(RVA = "0x46CD3D4", Offset = "0x46CD3D4", VA = "0x46CD3D4")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
    }

    [Token(Token = "0x600A303")]
    [Address(RVA = "0x46CD3DC", Offset = "0x46CD3DC", VA = "0x46CD3DC")]
    public APIBoxItemOpenResponse()
    {
    }
  }
}
