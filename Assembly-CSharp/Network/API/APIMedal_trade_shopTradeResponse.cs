// Decompiled with JetBrains decompiler
// Type: Network.API.APIMedal_trade_shopTradeResponse
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
  [Token(Token = "0x2001D54")]
  [Serializable]
  public class APIMedal_trade_shopTradeResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007D47")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007D48")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007D49")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007D4A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerMedalTradeCountType> player_medal_trade_info;

    [Token(Token = "0x170021C4")]
    public NoticeData Notice
    {
      [Token(Token = "0x600ACFD"), Address(RVA = "0x1A48468", Offset = "0x1A48468", VA = "0x1A48468", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170021C5")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600ACFE"), Address(RVA = "0x1A48470", Offset = "0x1A48470", VA = "0x1A48470", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170021C6")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600ACFF"), Address(RVA = "0x1A48478", Offset = "0x1A48478", VA = "0x1A48478", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170021C7")]
    public List<PlayerMedalTradeCountType> PlayerMedalTradeInfo
    {
      [Token(Token = "0x600AD00"), Address(RVA = "0x1A48480", Offset = "0x1A48480", VA = "0x1A48480")] get
      {
        return (List<PlayerMedalTradeCountType>) null;
      }
    }

    [Token(Token = "0x600AD01")]
    [Address(RVA = "0x1A48488", Offset = "0x1A48488", VA = "0x1A48488")]
    public APIMedal_trade_shopTradeResponse()
    {
    }
  }
}
