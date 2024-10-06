// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryShopPurchaseResponse
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
  [Token(Token = "0x2001E6C")]
  [Serializable]
  public class APIStoryShopPurchaseResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40082A1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40082A2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40082A3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40082A4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerShopArticleStockInfoType> articles;

    [Token(Token = "0x170024DA")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B473"), Address(RVA = "0x22E60F4", Offset = "0x22E60F4", VA = "0x22E60F4", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170024DB")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B474"), Address(RVA = "0x22E60FC", Offset = "0x22E60FC", VA = "0x22E60FC", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170024DC")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B475"), Address(RVA = "0x22E6104", Offset = "0x22E6104", VA = "0x22E6104", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170024DD")]
    public List<PlayerShopArticleStockInfoType> Articles
    {
      [Token(Token = "0x600B476"), Address(RVA = "0x22E610C", Offset = "0x22E610C", VA = "0x22E610C")] get
      {
        return (List<PlayerShopArticleStockInfoType>) null;
      }
    }

    [Token(Token = "0x600B477")]
    [Address(RVA = "0x22E6114", Offset = "0x22E6114", VA = "0x22E6114")]
    public APIStoryShopPurchaseResponse()
    {
    }
  }
}
