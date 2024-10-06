// Decompiled with JetBrains decompiler
// Type: Data.ItemPurchaseData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Scenes;
using Scenes.Story.ChapterShop;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Data
{
  [Token(Token = "0x2001FE0")]
  public class ItemPurchaseData
  {
    [Token(Token = "0x40087FC")]
    [FieldOffset(Offset = "0x10")]
    private List<ItemPurchaseData.ItemRewardData> itemRewardDataList;
    [Token(Token = "0x4008806")]
    [FieldOffset(Offset = "0x40")]
    public TimeSpan limitTime;

    [Token(Token = "0x17002720")]
    public List<ItemPurchaseData.ItemRewardData> ItemRewardDataList
    {
      [Token(Token = "0x600BD39"), Address(RVA = "0x1E5730C", Offset = "0x1E5730C", VA = "0x1E5730C")] get
      {
        return (List<ItemPurchaseData.ItemRewardData>) null;
      }
    }

    [Token(Token = "0x17002721")]
    public int ArticleID
    {
      [Token(Token = "0x600BD3A"), Address(RVA = "0x1E57314", Offset = "0x1E57314", VA = "0x1E57314")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD3B"), Address(RVA = "0x1E5731C", Offset = "0x1E5731C", VA = "0x1E5731C")] set
      {
      }
    }

    [Token(Token = "0x17002722")]
    public PaymentTypeEnum PaymentType
    {
      [Token(Token = "0x600BD3C"), Address(RVA = "0x1E57324", Offset = "0x1E57324", VA = "0x1E57324")] get
      {
        return new PaymentTypeEnum();
      }
      [Token(Token = "0x600BD3D"), Address(RVA = "0x1E5732C", Offset = "0x1E5732C", VA = "0x1E5732C")] set
      {
      }
    }

    [Token(Token = "0x17002723")]
    public int ID
    {
      [Token(Token = "0x600BD3E"), Address(RVA = "0x1E57334", Offset = "0x1E57334", VA = "0x1E57334")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD3F"), Address(RVA = "0x1E5733C", Offset = "0x1E5733C", VA = "0x1E5733C")] set
      {
      }
    }

    [Token(Token = "0x17002724")]
    public int Amount
    {
      [Token(Token = "0x600BD40"), Address(RVA = "0x1E57344", Offset = "0x1E57344", VA = "0x1E57344")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD41"), Address(RVA = "0x1E5734C", Offset = "0x1E5734C", VA = "0x1E5734C")] set
      {
      }
    }

    [Token(Token = "0x17002725")]
    public string ArticleName
    {
      [Token(Token = "0x600BD42"), Address(RVA = "0x1E57354", Offset = "0x1E57354", VA = "0x1E57354")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BD43"), Address(RVA = "0x1E5735C", Offset = "0x1E5735C", VA = "0x1E5735C")] set
      {
      }
    }

    [Token(Token = "0x17002726")]
    public int RemainCount
    {
      [Token(Token = "0x600BD44"), Address(RVA = "0x1E57364", Offset = "0x1E57364", VA = "0x1E57364")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD45"), Address(RVA = "0x1E5736C", Offset = "0x1E5736C", VA = "0x1E5736C")] set
      {
      }
    }

    [Token(Token = "0x17002727")]
    public bool IsLimited
    {
      [Token(Token = "0x600BD46"), Address(RVA = "0x1E57374", Offset = "0x1E57374", VA = "0x1E57374")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BD47"), Address(RVA = "0x1E5737C", Offset = "0x1E5737C", VA = "0x1E5737C")] set
      {
      }
    }

    [Token(Token = "0x17002728")]
    public int AddPaidCoin
    {
      [Token(Token = "0x600BD48"), Address(RVA = "0x1E57388", Offset = "0x1E57388", VA = "0x1E57388")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD49"), Address(RVA = "0x1E57390", Offset = "0x1E57390", VA = "0x1E57390")] set
      {
      }
    }

    [Token(Token = "0x17002729")]
    public int AddFreeCoin
    {
      [Token(Token = "0x600BD4A"), Address(RVA = "0x1E57398", Offset = "0x1E57398", VA = "0x1E57398")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD4B"), Address(RVA = "0x1E573A0", Offset = "0x1E573A0", VA = "0x1E573A0")] set
      {
      }
    }

    [Token(Token = "0x600BD4C")]
    [Address(RVA = "0x1E573A8", Offset = "0x1E573A8", VA = "0x1E573A8")]
    public ItemPurchaseData(PlayerShopArticleType shopArticleType)
    {
    }

    [Token(Token = "0x600BD4D")]
    [Address(RVA = "0x1E57700", Offset = "0x1E57700", VA = "0x1E57700")]
    public ItemPurchaseData(PaidCoinShopPopupItemInfo info)
    {
    }

    [Token(Token = "0x600BD4E")]
    [Address(RVA = "0x1E57A44", Offset = "0x1E57A44", VA = "0x1E57A44")]
    public ItemPurchaseData(ChapterShopData chapterShopData)
    {
    }

    [Token(Token = "0x600BD4F")]
    [Address(RVA = "0x1E57C60", Offset = "0x1E57C60", VA = "0x1E57C60")]
    public ItemPurchaseData(MedalTradePrizeData prizeData, int remainCount)
    {
    }

    [Token(Token = "0x2001FE1")]
    public class ItemRewardData
    {
      [Token(Token = "0x1700272A")]
      public RewardTypeEnum RewardType
      {
        [Token(Token = "0x600BD50"), Address(RVA = "0x1E57F24", Offset = "0x1E57F24", VA = "0x1E57F24")] get
        {
          return new RewardTypeEnum();
        }
        [Token(Token = "0x600BD51"), Address(RVA = "0x1E57F2C", Offset = "0x1E57F2C", VA = "0x1E57F2C")] set
        {
        }
      }

      [Token(Token = "0x1700272B")]
      public int ID
      {
        [Token(Token = "0x600BD52"), Address(RVA = "0x1E57F34", Offset = "0x1E57F34", VA = "0x1E57F34")] get
        {
          return new int();
        }
        [Token(Token = "0x600BD53"), Address(RVA = "0x1E57F3C", Offset = "0x1E57F3C", VA = "0x1E57F3C")] set
        {
        }
      }

      [Token(Token = "0x1700272C")]
      public int Amount
      {
        [Token(Token = "0x600BD54"), Address(RVA = "0x1E57F44", Offset = "0x1E57F44", VA = "0x1E57F44")] get
        {
          return new int();
        }
        [Token(Token = "0x600BD55"), Address(RVA = "0x1E57F4C", Offset = "0x1E57F4C", VA = "0x1E57F4C")] set
        {
        }
      }

      [Token(Token = "0x1700272D")]
      public ItemUtility.Parameter Param
      {
        [Token(Token = "0x600BD56"), Address(RVA = "0x1E57F54", Offset = "0x1E57F54", VA = "0x1E57F54")] get
        {
          return new ItemUtility.Parameter();
        }
        [Token(Token = "0x600BD57"), Address(RVA = "0x1E57F64", Offset = "0x1E57F64", VA = "0x1E57F64")] set
        {
        }
      }

      [Token(Token = "0x600BD58")]
      [Address(RVA = "0x1E57680", Offset = "0x1E57680", VA = "0x1E57680")]
      public ItemRewardData(PlayerShopContentType content)
      {
      }

      [Token(Token = "0x600BD59")]
      [Address(RVA = "0x1E57BE0", Offset = "0x1E57BE0", VA = "0x1E57BE0")]
      public ItemRewardData(ChapterShopData chapterShopData)
      {
      }

      [Token(Token = "0x600BD5A")]
      [Address(RVA = "0x1E57EAC", Offset = "0x1E57EAC", VA = "0x1E57EAC")]
      public ItemRewardData(MedalTradeItemData itemData)
      {
      }

      [Token(Token = "0x600BD5B")]
      [Address(RVA = "0x1E579C8", Offset = "0x1E579C8", VA = "0x1E579C8")]
      public ItemRewardData(int id, RewardTypeEnum rewardType, int amount)
      {
      }

      [Token(Token = "0x600BD5C")]
      [Address(RVA = "0x1E57F7C", Offset = "0x1E57F7C", VA = "0x1E57F7C")]
      public ItemRewardData(int id, PaymentTypeEnum paymentType, int amount)
      {
      }

      [Token(Token = "0x600BD5D")]
      [Address(RVA = "0x1E57FF8", Offset = "0x1E57FF8", VA = "0x1E57FF8")]
      public ItemRewardData()
      {
      }
    }
  }
}
