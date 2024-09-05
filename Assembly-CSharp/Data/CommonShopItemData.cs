// Decompiled with JetBrains decompiler
// Type: Data.CommonShopItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using PurchaseModule.Product;
using StaqData;
using System;

#nullable disable
namespace Data
{
  [Token(Token = "0x2001FDC")]
  public class CommonShopItemData
  {
    [Token(Token = "0x1700270B")]
    public CommonShopItemData.CommonShopInsideData[] InsideDatas
    {
      [Token(Token = "0x600BD09"), Address(RVA = "0x1E56A28", Offset = "0x1E56A28", VA = "0x1E56A28")] get
      {
        return (CommonShopItemData.CommonShopInsideData[]) null;
      }
      [Token(Token = "0x600BD0A"), Address(RVA = "0x1E56A30", Offset = "0x1E56A30", VA = "0x1E56A30")] private set
      {
      }
    }

    [Token(Token = "0x1700270C")]
    public int RemainCount
    {
      [Token(Token = "0x600BD0B"), Address(RVA = "0x1E56A38", Offset = "0x1E56A38", VA = "0x1E56A38")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD0C"), Address(RVA = "0x1E56A40", Offset = "0x1E56A40", VA = "0x1E56A40")] private set
      {
      }
    }

    [Token(Token = "0x1700270D")]
    public bool IsLimit
    {
      [Token(Token = "0x600BD0D"), Address(RVA = "0x1E56A48", Offset = "0x1E56A48", VA = "0x1E56A48")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BD0E"), Address(RVA = "0x1E56A50", Offset = "0x1E56A50", VA = "0x1E56A50")] private set
      {
      }
    }

    [Token(Token = "0x1700270E")]
    public int SetIconID
    {
      [Token(Token = "0x600BD0F"), Address(RVA = "0x1E56A5C", Offset = "0x1E56A5C", VA = "0x1E56A5C")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD10"), Address(RVA = "0x1E56A64", Offset = "0x1E56A64", VA = "0x1E56A64")] private set
      {
      }
    }

    [Token(Token = "0x1700270F")]
    public ProductInfo ProductInfo
    {
      [Token(Token = "0x600BD11"), Address(RVA = "0x1E56A6C", Offset = "0x1E56A6C", VA = "0x1E56A6C")] get
      {
        return (ProductInfo) null;
      }
      [Token(Token = "0x600BD12"), Address(RVA = "0x1E56A74", Offset = "0x1E56A74", VA = "0x1E56A74")] private set
      {
      }
    }

    [Token(Token = "0x17002710")]
    public string SetArticlesName
    {
      [Token(Token = "0x600BD13"), Address(RVA = "0x1E56A7C", Offset = "0x1E56A7C", VA = "0x1E56A7C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BD14"), Address(RVA = "0x1E56A84", Offset = "0x1E56A84", VA = "0x1E56A84")] private set
      {
      }
    }

    [Token(Token = "0x17002711")]
    public PaymentTypeEnum PaymentType
    {
      [Token(Token = "0x600BD15"), Address(RVA = "0x1E56A8C", Offset = "0x1E56A8C", VA = "0x1E56A8C")] get
      {
        return new PaymentTypeEnum();
      }
      [Token(Token = "0x600BD16"), Address(RVA = "0x1E56A94", Offset = "0x1E56A94", VA = "0x1E56A94")] private set
      {
      }
    }

    [Token(Token = "0x17002712")]
    public int PaymentID
    {
      [Token(Token = "0x600BD17"), Address(RVA = "0x1E56A9C", Offset = "0x1E56A9C", VA = "0x1E56A9C")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD18"), Address(RVA = "0x1E56AA4", Offset = "0x1E56AA4", VA = "0x1E56AA4")] private set
      {
      }
    }

    [Token(Token = "0x17002713")]
    public int PaymentAmount
    {
      [Token(Token = "0x600BD19"), Address(RVA = "0x1E56AAC", Offset = "0x1E56AAC", VA = "0x1E56AAC")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD1A"), Address(RVA = "0x1E56AB4", Offset = "0x1E56AB4", VA = "0x1E56AB4")] private set
      {
      }
    }

    [Token(Token = "0x17002714")]
    public int ID
    {
      [Token(Token = "0x600BD1B"), Address(RVA = "0x1E56ABC", Offset = "0x1E56ABC", VA = "0x1E56ABC")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD1C"), Address(RVA = "0x1E56AC4", Offset = "0x1E56AC4", VA = "0x1E56AC4")] set
      {
      }
    }

    [Token(Token = "0x17002715")]
    public int ShopID
    {
      [Token(Token = "0x600BD1D"), Address(RVA = "0x1E56ACC", Offset = "0x1E56ACC", VA = "0x1E56ACC")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD1E"), Address(RVA = "0x1E56AD4", Offset = "0x1E56AD4", VA = "0x1E56AD4")] set
      {
      }
    }

    [Token(Token = "0x17002716")]
    public CommonShopItemData.ShopType NowShopType
    {
      [Token(Token = "0x600BD1F"), Address(RVA = "0x1E56ADC", Offset = "0x1E56ADC", VA = "0x1E56ADC")] get
      {
        return new CommonShopItemData.ShopType();
      }
      [Token(Token = "0x600BD20"), Address(RVA = "0x1E56AE4", Offset = "0x1E56AE4", VA = "0x1E56AE4")] private set
      {
      }
    }

    [Token(Token = "0x17002717")]
    public int AddPaidCoin
    {
      [Token(Token = "0x600BD21"), Address(RVA = "0x1E56AEC", Offset = "0x1E56AEC", VA = "0x1E56AEC")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD22"), Address(RVA = "0x1E56AF4", Offset = "0x1E56AF4", VA = "0x1E56AF4")] private set
      {
      }
    }

    [Token(Token = "0x17002718")]
    public int AddFreeCoin
    {
      [Token(Token = "0x600BD23"), Address(RVA = "0x1E56AFC", Offset = "0x1E56AFC", VA = "0x1E56AFC")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD24"), Address(RVA = "0x1E56B04", Offset = "0x1E56B04", VA = "0x1E56B04")] private set
      {
      }
    }

    [Token(Token = "0x17002719")]
    public int PassID
    {
      [Token(Token = "0x600BD25"), Address(RVA = "0x1E56B0C", Offset = "0x1E56B0C", VA = "0x1E56B0C")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD26"), Address(RVA = "0x1E56B14", Offset = "0x1E56B14", VA = "0x1E56B14")] private set
      {
      }
    }

    [Token(Token = "0x1700271A")]
    public DateTime? EndAt
    {
      [Token(Token = "0x600BD27"), Address(RVA = "0x1E56B1C", Offset = "0x1E56B1C", VA = "0x1E56B1C")] get
      {
        return new DateTime?();
      }
      [Token(Token = "0x600BD28"), Address(RVA = "0x1E56B28", Offset = "0x1E56B28", VA = "0x1E56B28")] set
      {
      }
    }

    [Token(Token = "0x1700271B")]
    public int ShowPriority
    {
      [Token(Token = "0x600BD29"), Address(RVA = "0x1E56B30", Offset = "0x1E56B30", VA = "0x1E56B30")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD2A"), Address(RVA = "0x1E56B38", Offset = "0x1E56B38", VA = "0x1E56B38")] set
      {
      }
    }

    [Token(Token = "0x600BD2B")]
    [Address(RVA = "0x1E56B40", Offset = "0x1E56B40", VA = "0x1E56B40")]
    public CommonShopItemData(
      PlayerShopArticleType shopArticleType,
      ProductInfo productInfo,
      PlayerShopType shopType)
    {
    }

    [Token(Token = "0x600BD2C")]
    [Address(RVA = "0x1E56E30", Offset = "0x1E56E30", VA = "0x1E56E30")]
    public CommonShopItemData(
      MedalTradePrizeData prizeData,
      PlayerMedalTradeCountType[] playerMedals)
    {
    }

    [Token(Token = "0x2001FDD")]
    public enum ShopType
    {
      [Token(Token = "0x40087F5")] Global,
      [Token(Token = "0x40087F6")] Medal,
    }

    [Token(Token = "0x2001FDE")]
    public class CommonShopInsideData
    {
      [Token(Token = "0x1700271C")]
      public RewardTypeEnum RewardType
      {
        [Token(Token = "0x600BD2D"), Address(RVA = "0x1E57288", Offset = "0x1E57288", VA = "0x1E57288")] get
        {
          return new RewardTypeEnum();
        }
        [Token(Token = "0x600BD2E"), Address(RVA = "0x1E57290", Offset = "0x1E57290", VA = "0x1E57290")] private set
        {
        }
      }

      [Token(Token = "0x1700271D")]
      public int RewardID
      {
        [Token(Token = "0x600BD2F"), Address(RVA = "0x1E57298", Offset = "0x1E57298", VA = "0x1E57298")] get
        {
          return new int();
        }
        [Token(Token = "0x600BD30"), Address(RVA = "0x1E572A0", Offset = "0x1E572A0", VA = "0x1E572A0")] private set
        {
        }
      }

      [Token(Token = "0x1700271E")]
      public int Quantity
      {
        [Token(Token = "0x600BD31"), Address(RVA = "0x1E572A8", Offset = "0x1E572A8", VA = "0x1E572A8")] get
        {
          return new int();
        }
        [Token(Token = "0x600BD32"), Address(RVA = "0x1E572B0", Offset = "0x1E572B0", VA = "0x1E572B0")] private set
        {
        }
      }

      [Token(Token = "0x1700271F")]
      public ItemUtility.Parameter Param
      {
        [Token(Token = "0x600BD33"), Address(RVA = "0x1E572B8", Offset = "0x1E572B8", VA = "0x1E572B8")] get
        {
          return new ItemUtility.Parameter();
        }
        [Token(Token = "0x600BD34"), Address(RVA = "0x1E572C8", Offset = "0x1E572C8", VA = "0x1E572C8")] private set
        {
        }
      }

      [Token(Token = "0x600BD35")]
      [Address(RVA = "0x1E56DB0", Offset = "0x1E56DB0", VA = "0x1E56DB0")]
      public CommonShopInsideData(PlayerShopContentType content)
      {
      }

      [Token(Token = "0x600BD36")]
      [Address(RVA = "0x1E57210", Offset = "0x1E57210", VA = "0x1E57210")]
      public CommonShopInsideData(MedalTradeItemData itemData)
      {
      }
    }
  }
}
