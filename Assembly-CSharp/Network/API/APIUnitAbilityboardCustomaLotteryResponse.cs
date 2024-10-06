// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardCustomaLotteryResponse
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
  [Token(Token = "0x2001E8C")]
  [Serializable]
  public class APIUnitAbilityboardCustomaLotteryResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4008343")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008344")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008345")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4008346")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerUnitAbilityBoardCustomALotteryType> lottery_results;
    [Token(Token = "0x4008347")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UpdatedPlayerItems update_items;

    [Token(Token = "0x17002536")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B54F"), Address(RVA = "0x22E8CB4", Offset = "0x22E8CB4", VA = "0x22E8CB4", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002537")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B550"), Address(RVA = "0x22E8CBC", Offset = "0x22E8CBC", VA = "0x22E8CBC", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002538")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B551"), Address(RVA = "0x22E8CC4", Offset = "0x22E8CC4", VA = "0x22E8CC4", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002539")]
    public List<PlayerUnitAbilityBoardCustomALotteryType> LotteryResults
    {
      [Token(Token = "0x600B552"), Address(RVA = "0x22E8CCC", Offset = "0x22E8CCC", VA = "0x22E8CCC")] get
      {
        return (List<PlayerUnitAbilityBoardCustomALotteryType>) null;
      }
    }

    [Token(Token = "0x1700253A")]
    public UpdatedPlayerItems UpdateItems
    {
      [Token(Token = "0x600B553"), Address(RVA = "0x22E8CD4", Offset = "0x22E8CD4", VA = "0x22E8CD4")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600B554")]
    [Address(RVA = "0x22E8CDC", Offset = "0x22E8CDC", VA = "0x22E8CDC")]
    public APIUnitAbilityboardCustomaLotteryResponse()
    {
    }
  }
}
