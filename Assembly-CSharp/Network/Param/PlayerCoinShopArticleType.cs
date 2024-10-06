// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerCoinShopArticleType
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
  [Token(Token = "0x2001A9B")]
  [Serializable]
  public class PlayerCoinShopArticleType
  {
    [Token(Token = "0x4007205")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string product_id;
    [Token(Token = "0x4007206")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int purchase_limit;
    [Token(Token = "0x4007207")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int purchase_count;
    [Token(Token = "0x4007208")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int additional_free_coin;
    [Token(Token = "0x4007209")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int additional_paid_coin;
    [Token(Token = "0x400720A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int pass_id;
    [Token(Token = "0x400720B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<Reward> article_rewards;
    [Token(Token = "0x400720C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string name;
    [Token(Token = "0x400720D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string resource_name;
    [Token(Token = "0x400720E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private int show_priority;

    [Token(Token = "0x17001A52")]
    public string ProductId
    {
      [Token(Token = "0x60099BF"), Address(RVA = "0x48F0CF0", Offset = "0x48F0CF0", VA = "0x48F0CF0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60099C0"), Address(RVA = "0x48F0CF8", Offset = "0x48F0CF8", VA = "0x48F0CF8")] set
      {
      }
    }

    [Token(Token = "0x17001A53")]
    public int PurchaseLimit
    {
      [Token(Token = "0x60099C1"), Address(RVA = "0x48F0D00", Offset = "0x48F0D00", VA = "0x48F0D00")] get
      {
        return new int();
      }
      [Token(Token = "0x60099C2"), Address(RVA = "0x48F0D08", Offset = "0x48F0D08", VA = "0x48F0D08")] set
      {
      }
    }

    [Token(Token = "0x17001A54")]
    public int PurchaseCount
    {
      [Token(Token = "0x60099C3"), Address(RVA = "0x48F0D10", Offset = "0x48F0D10", VA = "0x48F0D10")] get
      {
        return new int();
      }
      [Token(Token = "0x60099C4"), Address(RVA = "0x48F0D18", Offset = "0x48F0D18", VA = "0x48F0D18")] set
      {
      }
    }

    [Token(Token = "0x17001A55")]
    public int AdditionalFreeCoin
    {
      [Token(Token = "0x60099C5"), Address(RVA = "0x48F0D20", Offset = "0x48F0D20", VA = "0x48F0D20")] get
      {
        return new int();
      }
      [Token(Token = "0x60099C6"), Address(RVA = "0x48F0D28", Offset = "0x48F0D28", VA = "0x48F0D28")] set
      {
      }
    }

    [Token(Token = "0x17001A56")]
    public int AdditionalPaidCoin
    {
      [Token(Token = "0x60099C7"), Address(RVA = "0x48F0D30", Offset = "0x48F0D30", VA = "0x48F0D30")] get
      {
        return new int();
      }
      [Token(Token = "0x60099C8"), Address(RVA = "0x48F0D38", Offset = "0x48F0D38", VA = "0x48F0D38")] set
      {
      }
    }

    [Token(Token = "0x17001A57")]
    public int PassId
    {
      [Token(Token = "0x60099C9"), Address(RVA = "0x48F0D40", Offset = "0x48F0D40", VA = "0x48F0D40")] get
      {
        return new int();
      }
      [Token(Token = "0x60099CA"), Address(RVA = "0x48F0D48", Offset = "0x48F0D48", VA = "0x48F0D48")] set
      {
      }
    }

    [Token(Token = "0x17001A58")]
    public List<Reward> ArticleRewards
    {
      [Token(Token = "0x60099CB"), Address(RVA = "0x48F0D50", Offset = "0x48F0D50", VA = "0x48F0D50")] get
      {
        return (List<Reward>) null;
      }
      [Token(Token = "0x60099CC"), Address(RVA = "0x48F0D58", Offset = "0x48F0D58", VA = "0x48F0D58")] set
      {
      }
    }

    [Token(Token = "0x17001A59")]
    public string Name
    {
      [Token(Token = "0x60099CD"), Address(RVA = "0x48F0D60", Offset = "0x48F0D60", VA = "0x48F0D60")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60099CE"), Address(RVA = "0x48F0D68", Offset = "0x48F0D68", VA = "0x48F0D68")] set
      {
      }
    }

    [Token(Token = "0x17001A5A")]
    public string ResourceName
    {
      [Token(Token = "0x60099CF"), Address(RVA = "0x48F0D70", Offset = "0x48F0D70", VA = "0x48F0D70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60099D0"), Address(RVA = "0x48F0D78", Offset = "0x48F0D78", VA = "0x48F0D78")] set
      {
      }
    }

    [Token(Token = "0x17001A5B")]
    public int ShowPriority
    {
      [Token(Token = "0x60099D1"), Address(RVA = "0x48F0D80", Offset = "0x48F0D80", VA = "0x48F0D80")] get
      {
        return new int();
      }
      [Token(Token = "0x60099D2"), Address(RVA = "0x48F0D88", Offset = "0x48F0D88", VA = "0x48F0D88")] set
      {
      }
    }

    [Token(Token = "0x60099D3")]
    [Address(RVA = "0x48F0D90", Offset = "0x48F0D90", VA = "0x48F0D90")]
    public PlayerCoinShopArticleType()
    {
    }
  }
}
