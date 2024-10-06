// Decompiled with JetBrains decompiler
// Type: Network.API.APIShopPurchaseResponse
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
  [Token(Token = "0x2001E14")]
  [Serializable]
  public class APIShopPurchaseResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40080B9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40080BA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40080BB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40080BC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerShopType> shops;
    [Token(Token = "0x40080BD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerShopArticleType> articles;
    [Token(Token = "0x40080BE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerRewardPassType> player_reward_pass;

    [Token(Token = "0x170023C1")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B1FA"), Address(RVA = "0x22DE7C4", Offset = "0x22DE7C4", VA = "0x22DE7C4", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170023C2")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B1FB"), Address(RVA = "0x22DE7CC", Offset = "0x22DE7CC", VA = "0x22DE7CC", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170023C3")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B1FC"), Address(RVA = "0x22DE7D4", Offset = "0x22DE7D4", VA = "0x22DE7D4", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170023C4")]
    public List<PlayerShopType> Shops
    {
      [Token(Token = "0x600B1FD"), Address(RVA = "0x22DE7DC", Offset = "0x22DE7DC", VA = "0x22DE7DC")] get
      {
        return (List<PlayerShopType>) null;
      }
    }

    [Token(Token = "0x170023C5")]
    public List<PlayerShopArticleType> Articles
    {
      [Token(Token = "0x600B1FE"), Address(RVA = "0x22DE7E4", Offset = "0x22DE7E4", VA = "0x22DE7E4")] get
      {
        return (List<PlayerShopArticleType>) null;
      }
    }

    [Token(Token = "0x170023C6")]
    public List<PlayerRewardPassType> PlayerRewardPass
    {
      [Token(Token = "0x600B1FF"), Address(RVA = "0x22DE7EC", Offset = "0x22DE7EC", VA = "0x22DE7EC")] get
      {
        return (List<PlayerRewardPassType>) null;
      }
    }

    [Token(Token = "0x600B200")]
    [Address(RVA = "0x22DE7F4", Offset = "0x22DE7F4", VA = "0x22DE7F4")]
    public APIShopPurchaseResponse()
    {
    }
  }
}
