// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerShopArticleType
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
  [Token(Token = "0x2001ADD")]
  [Serializable]
  public class PlayerShopArticleType
  {
    [Token(Token = "0x400732D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int article_id;
    [Token(Token = "0x400732E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int shop_id;
    [Token(Token = "0x400732F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string article_name;
    [Token(Token = "0x4007330")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string description;
    [Token(Token = "0x4007331")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string product_id;
    [Token(Token = "0x4007332")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int additional_free_coin;
    [Token(Token = "0x4007333")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private int additional_paid_coin;
    [Token(Token = "0x4007334")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int pass_id;
    [Token(Token = "0x4007335")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerShopContentType> contents;
    [Token(Token = "0x4007336")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private bool limited;
    [Token(Token = "0x4007337")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private int remain_count;
    [Token(Token = "0x4007338")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private int max_count;
    [Token(Token = "0x4007339")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private int article_set_icon_id;
    [Token(Token = "0x400733A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private int show_priority;
    [Token(Token = "0x400733B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ShopPaymentType payment_item;

    [Token(Token = "0x17001B8F")]
    public int ArticleId
    {
      [Token(Token = "0x6009C66"), Address(RVA = "0x48F23C4", Offset = "0x48F23C4", VA = "0x48F23C4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C67"), Address(RVA = "0x48F23CC", Offset = "0x48F23CC", VA = "0x48F23CC")] set
      {
      }
    }

    [Token(Token = "0x17001B90")]
    public int ShopId
    {
      [Token(Token = "0x6009C68"), Address(RVA = "0x48F23D4", Offset = "0x48F23D4", VA = "0x48F23D4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C69"), Address(RVA = "0x48F23DC", Offset = "0x48F23DC", VA = "0x48F23DC")] set
      {
      }
    }

    [Token(Token = "0x17001B91")]
    public string ArticleName
    {
      [Token(Token = "0x6009C6A"), Address(RVA = "0x48F23E4", Offset = "0x48F23E4", VA = "0x48F23E4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009C6B"), Address(RVA = "0x48F23EC", Offset = "0x48F23EC", VA = "0x48F23EC")] set
      {
      }
    }

    [Token(Token = "0x17001B92")]
    public string Description
    {
      [Token(Token = "0x6009C6C"), Address(RVA = "0x48F23F4", Offset = "0x48F23F4", VA = "0x48F23F4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009C6D"), Address(RVA = "0x48F23FC", Offset = "0x48F23FC", VA = "0x48F23FC")] set
      {
      }
    }

    [Token(Token = "0x17001B93")]
    public string ProductId
    {
      [Token(Token = "0x6009C6E"), Address(RVA = "0x48F2404", Offset = "0x48F2404", VA = "0x48F2404")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009C6F"), Address(RVA = "0x48F240C", Offset = "0x48F240C", VA = "0x48F240C")] set
      {
      }
    }

    [Token(Token = "0x17001B94")]
    public int AdditionalFreeCoin
    {
      [Token(Token = "0x6009C70"), Address(RVA = "0x48F2414", Offset = "0x48F2414", VA = "0x48F2414")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C71"), Address(RVA = "0x48F241C", Offset = "0x48F241C", VA = "0x48F241C")] set
      {
      }
    }

    [Token(Token = "0x17001B95")]
    public int AdditionalPaidCoin
    {
      [Token(Token = "0x6009C72"), Address(RVA = "0x48F2424", Offset = "0x48F2424", VA = "0x48F2424")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C73"), Address(RVA = "0x48F242C", Offset = "0x48F242C", VA = "0x48F242C")] set
      {
      }
    }

    [Token(Token = "0x17001B96")]
    public int PassId
    {
      [Token(Token = "0x6009C74"), Address(RVA = "0x48F2434", Offset = "0x48F2434", VA = "0x48F2434")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C75"), Address(RVA = "0x48F243C", Offset = "0x48F243C", VA = "0x48F243C")] set
      {
      }
    }

    [Token(Token = "0x17001B97")]
    public List<PlayerShopContentType> Contents
    {
      [Token(Token = "0x6009C76"), Address(RVA = "0x48F2444", Offset = "0x48F2444", VA = "0x48F2444")] get
      {
        return (List<PlayerShopContentType>) null;
      }
      [Token(Token = "0x6009C77"), Address(RVA = "0x48F244C", Offset = "0x48F244C", VA = "0x48F244C")] set
      {
      }
    }

    [Token(Token = "0x17001B98")]
    public bool Limited
    {
      [Token(Token = "0x6009C78"), Address(RVA = "0x48F2454", Offset = "0x48F2454", VA = "0x48F2454")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009C79"), Address(RVA = "0x48F245C", Offset = "0x48F245C", VA = "0x48F245C")] set
      {
      }
    }

    [Token(Token = "0x17001B99")]
    public int RemainCount
    {
      [Token(Token = "0x6009C7A"), Address(RVA = "0x48F2468", Offset = "0x48F2468", VA = "0x48F2468")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C7B"), Address(RVA = "0x48F2470", Offset = "0x48F2470", VA = "0x48F2470")] set
      {
      }
    }

    [Token(Token = "0x17001B9A")]
    public int MaxCount
    {
      [Token(Token = "0x6009C7C"), Address(RVA = "0x48F2478", Offset = "0x48F2478", VA = "0x48F2478")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C7D"), Address(RVA = "0x48F2480", Offset = "0x48F2480", VA = "0x48F2480")] set
      {
      }
    }

    [Token(Token = "0x17001B9B")]
    public int ArticleSetIconId
    {
      [Token(Token = "0x6009C7E"), Address(RVA = "0x48F2488", Offset = "0x48F2488", VA = "0x48F2488")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C7F"), Address(RVA = "0x48F2490", Offset = "0x48F2490", VA = "0x48F2490")] set
      {
      }
    }

    [Token(Token = "0x17001B9C")]
    public int ShowPriority
    {
      [Token(Token = "0x6009C80"), Address(RVA = "0x48F2498", Offset = "0x48F2498", VA = "0x48F2498")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C81"), Address(RVA = "0x48F24A0", Offset = "0x48F24A0", VA = "0x48F24A0")] set
      {
      }
    }

    [Token(Token = "0x17001B9D")]
    public ShopPaymentType PaymentItem
    {
      [Token(Token = "0x6009C82"), Address(RVA = "0x48F24A8", Offset = "0x48F24A8", VA = "0x48F24A8")] get
      {
        return (ShopPaymentType) null;
      }
      [Token(Token = "0x6009C83"), Address(RVA = "0x48F24B0", Offset = "0x48F24B0", VA = "0x48F24B0")] set
      {
      }
    }

    [Token(Token = "0x6009C84")]
    [Address(RVA = "0x48F24B8", Offset = "0x48F24B8", VA = "0x48F24B8")]
    public PlayerShopArticleType()
    {
    }
  }
}
