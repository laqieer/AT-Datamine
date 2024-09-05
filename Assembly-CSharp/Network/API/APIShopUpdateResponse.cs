// Decompiled with JetBrains decompiler
// Type: Network.API.APIShopUpdateResponse
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
  [Token(Token = "0x2001E18")]
  [Serializable]
  public class APIShopUpdateResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40080CB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40080CC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40080CD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40080CE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerShopType> shops;
    [Token(Token = "0x40080CF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerShopArticleType> articles;

    [Token(Token = "0x170023CD")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B216"), Address(RVA = "0x22DED40", Offset = "0x22DED40", VA = "0x22DED40", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170023CE")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B217"), Address(RVA = "0x22DED48", Offset = "0x22DED48", VA = "0x22DED48", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170023CF")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B218"), Address(RVA = "0x22DED50", Offset = "0x22DED50", VA = "0x22DED50", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170023D0")]
    public List<PlayerShopType> Shops
    {
      [Token(Token = "0x600B219"), Address(RVA = "0x22DED58", Offset = "0x22DED58", VA = "0x22DED58")] get
      {
        return (List<PlayerShopType>) null;
      }
    }

    [Token(Token = "0x170023D1")]
    public List<PlayerShopArticleType> Articles
    {
      [Token(Token = "0x600B21A"), Address(RVA = "0x22DED60", Offset = "0x22DED60", VA = "0x22DED60")] get
      {
        return (List<PlayerShopArticleType>) null;
      }
    }

    [Token(Token = "0x600B21B")]
    [Address(RVA = "0x22DED68", Offset = "0x22DED68", VA = "0x22DED68")]
    public APIShopUpdateResponse()
    {
    }
  }
}
