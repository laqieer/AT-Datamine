// Decompiled with JetBrains decompiler
// Type: Network.Param.HotDealInfoType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A70")]
  [Serializable]
  public class HotDealInfoType
  {
    [Token(Token = "0x4007175")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_hot_deal_id;
    [Token(Token = "0x4007176")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string end_at;
    [Token(Token = "0x4007177")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinShopArticleType article;
    [Token(Token = "0x4007178")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<Reward> article_rewards;

    [Token(Token = "0x170019AC")]
    public string PlayerHotDealId
    {
      [Token(Token = "0x600985D"), Address(RVA = "0x48F015C", Offset = "0x48F015C", VA = "0x48F015C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600985E"), Address(RVA = "0x48F0164", Offset = "0x48F0164", VA = "0x48F0164")] set
      {
      }
    }

    [Token(Token = "0x170019AD")]
    public string EndAt
    {
      [Token(Token = "0x600985F"), Address(RVA = "0x48F016C", Offset = "0x48F016C", VA = "0x48F016C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009860"), Address(RVA = "0x48F0174", Offset = "0x48F0174", VA = "0x48F0174")] set
      {
      }
    }

    [Token(Token = "0x170019AE")]
    public PlayerCoinShopArticleType Article
    {
      [Token(Token = "0x6009861"), Address(RVA = "0x48F017C", Offset = "0x48F017C", VA = "0x48F017C")] get
      {
        return (PlayerCoinShopArticleType) null;
      }
      [Token(Token = "0x6009862"), Address(RVA = "0x48F0184", Offset = "0x48F0184", VA = "0x48F0184")] set
      {
      }
    }

    [Token(Token = "0x170019AF")]
    public List<Reward> ArticleRewards
    {
      [Token(Token = "0x6009863"), Address(RVA = "0x48F018C", Offset = "0x48F018C", VA = "0x48F018C")] get
      {
        return (List<Reward>) null;
      }
      [Token(Token = "0x6009864"), Address(RVA = "0x48F0194", Offset = "0x48F0194", VA = "0x48F0194")] set
      {
      }
    }

    [Token(Token = "0x6009865")]
    [Address(RVA = "0x48F019C", Offset = "0x48F019C", VA = "0x48F019C")]
    public HotDealInfoType()
    {
    }
  }
}
