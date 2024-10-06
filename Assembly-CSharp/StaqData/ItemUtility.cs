// Decompiled with JetBrains decompiler
// Type: StaqData.ItemUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002041")]
  public static class ItemUtility
  {
    [Token(Token = "0x4008926")]
    private const int RESOURCE_ITEM_ID_PLAYER_EXP = 101060001;
    [Token(Token = "0x4008927")]
    private const int RESOURCE_ITEM_ID_COIN = 1;
    [Token(Token = "0x4008928")]
    private const int RESOURCE_ITEM_ID_PAID_COIN = 2;

    [Token(Token = "0x600C170")]
    [Address(RVA = "0x193A35C", Offset = "0x193A35C", VA = "0x193A35C")]
    private static string GetIconAssetBundleName(this ItemTypeEnum itemType, int id)
    {
      return (string) null;
    }

    [Token(Token = "0x600C171")]
    [Address(RVA = "0x193A424", Offset = "0x193A424", VA = "0x193A424")]
    private static string GetIconAssetName(this ItemTypeEnum itemType, int id) => (string) null;

    [Token(Token = "0x600C172")]
    [Address(RVA = "0x193A4EC", Offset = "0x193A4EC", VA = "0x193A4EC")]
    public static ItemUtility.Parameter Get(ItemTypeEnum type, int id)
    {
      return new ItemUtility.Parameter();
    }

    [Token(Token = "0x600C173")]
    [Address(RVA = "0x193C198", Offset = "0x193C198", VA = "0x193C198")]
    public static ItemUtility.Parameter Get(RewardTypeEnum type, int id, int skillLv = 1)
    {
      return new ItemUtility.Parameter();
    }

    [Token(Token = "0x600C174")]
    [Address(RVA = "0x193C89C", Offset = "0x193C89C", VA = "0x193C89C")]
    private static ItemUtility.Parameter GetAp() => new ItemUtility.Parameter();

    [Token(Token = "0x600C175")]
    [Address(RVA = "0x193C9D4", Offset = "0x193C9D4", VA = "0x193C9D4")]
    public static ItemUtility.Parameter Get(PaymentTypeEnum type, int id)
    {
      return new ItemUtility.Parameter();
    }

    [Token(Token = "0x600C176")]
    [Address(RVA = "0x193CEC8", Offset = "0x193CEC8", VA = "0x193CEC8")]
    public static ItemUtility.Parameter Get(ConditionTypeEnum type, int id)
    {
      return new ItemUtility.Parameter();
    }

    [Token(Token = "0x600C177")]
    [Address(RVA = "0x193D0DC", Offset = "0x193D0DC", VA = "0x193D0DC")]
    public static bool CheckCoin(PaymentTypeEnum paymentType) => new bool();

    [Token(Token = "0x600C178")]
    [Address(RVA = "0x193D0F8", Offset = "0x193D0F8", VA = "0x193D0F8")]
    public static PaymentTypeEnum GetPaymentType(ItemTypeEnum itemType) => new PaymentTypeEnum();

    [Token(Token = "0x600C179")]
    [Address(RVA = "0x193D11C", Offset = "0x193D11C", VA = "0x193D11C")]
    public static void Preload(AssetCachedSpawner assetCachedSpawner, ItemUtility.Parameter param)
    {
    }

    [Token(Token = "0x600C17A")]
    [Address(RVA = "0x193C17C", Offset = "0x193C17C", VA = "0x193C17C")]
    private static bool HasSaleData(ItemTypeEnum itemType, int itemId, RarityTypeEnum rarity)
    {
      return new bool();
    }

    [Token(Token = "0x600C17B")]
    [Address(RVA = "0x193D200", Offset = "0x193D200", VA = "0x193D200")]
    public static bool TryGetSaleDataRewardQuantity(
      ItemTypeEnum itemType,
      int itemId,
      RarityTypeEnum rarity,
      out long rewardQuantity)
    {
      return new bool();
    }

    [Token(Token = "0x2002042")]
    public enum RarityViewTypeEnum
    {
      [Token(Token = "0x400892D")] Default = 0,
      [Token(Token = "0x400892A")] Image = 0,
      [Token(Token = "0x400892B")] Star = 1,
      [Token(Token = "0x400892C")] Disable = 2,
    }

    [Token(Token = "0x2002043")]
    public struct Parameter
    {
      [Token(Token = "0x1700289C")]
      public int ID
      {
        [Token(Token = "0x600C17C"), Address(RVA = "0x193D2FC", Offset = "0x193D2FC", VA = "0x193D2FC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600C17D"), Address(RVA = "0x193D304", Offset = "0x193D304", VA = "0x193D304")] set
        {
        }
      }

      [Token(Token = "0x1700289D")]
      public ItemTypeEnum ItemTypeEnum
      {
        [Token(Token = "0x600C17E"), Address(RVA = "0x193D30C", Offset = "0x193D30C", VA = "0x193D30C")] readonly get
        {
          return new ItemTypeEnum();
        }
        [Token(Token = "0x600C17F"), Address(RVA = "0x193D314", Offset = "0x193D314", VA = "0x193D314")] set
        {
        }
      }

      [Token(Token = "0x1700289E")]
      public string Name
      {
        [Token(Token = "0x600C180"), Address(RVA = "0x193D31C", Offset = "0x193D31C", VA = "0x193D31C")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x600C181"), Address(RVA = "0x193D324", Offset = "0x193D324", VA = "0x193D324")] set
        {
        }
      }

      [Token(Token = "0x1700289F")]
      public string Flavor
      {
        [Token(Token = "0x600C182"), Address(RVA = "0x193D32C", Offset = "0x193D32C", VA = "0x193D32C")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x600C183"), Address(RVA = "0x193D334", Offset = "0x193D334", VA = "0x193D334")] set
        {
        }
      }

      [Token(Token = "0x170028A0")]
      public RarityTypeEnum Rarity
      {
        [Token(Token = "0x600C184"), Address(RVA = "0x193D33C", Offset = "0x193D33C", VA = "0x193D33C")] readonly get
        {
          return new RarityTypeEnum();
        }
        [Token(Token = "0x600C185"), Address(RVA = "0x193D344", Offset = "0x193D344", VA = "0x193D344")] set
        {
        }
      }

      [Token(Token = "0x170028A1")]
      public string IconCommonAssetBundleName
      {
        [Token(Token = "0x600C186"), Address(RVA = "0x193D34C", Offset = "0x193D34C", VA = "0x193D34C")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x600C187"), Address(RVA = "0x193D354", Offset = "0x193D354", VA = "0x193D354")] set
        {
        }
      }

      [Token(Token = "0x170028A2")]
      public string BaseAssetName
      {
        [Token(Token = "0x600C188"), Address(RVA = "0x193D35C", Offset = "0x193D35C", VA = "0x193D35C")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x600C189"), Address(RVA = "0x193D364", Offset = "0x193D364", VA = "0x193D364")] set
        {
        }
      }

      [Token(Token = "0x170028A3")]
      public string IconAssetBundleName
      {
        [Token(Token = "0x600C18A"), Address(RVA = "0x193D36C", Offset = "0x193D36C", VA = "0x193D36C")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x600C18B"), Address(RVA = "0x193D374", Offset = "0x193D374", VA = "0x193D374")] set
        {
        }
      }

      [Token(Token = "0x170028A4")]
      public string IconAssetName
      {
        [Token(Token = "0x600C18C"), Address(RVA = "0x193D37C", Offset = "0x193D37C", VA = "0x193D37C")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x600C18D"), Address(RVA = "0x193D384", Offset = "0x193D384", VA = "0x193D384")] set
        {
        }
      }

      [Token(Token = "0x170028A5")]
      public string ImageAssetBundleName
      {
        [Token(Token = "0x600C18E"), Address(RVA = "0x193D38C", Offset = "0x193D38C", VA = "0x193D38C")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x600C18F"), Address(RVA = "0x193D394", Offset = "0x193D394", VA = "0x193D394")] set
        {
        }
      }

      [Token(Token = "0x170028A6")]
      public string ImageAssetName
      {
        [Token(Token = "0x600C190"), Address(RVA = "0x193D39C", Offset = "0x193D39C", VA = "0x193D39C")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x600C191"), Address(RVA = "0x193D3A4", Offset = "0x193D3A4", VA = "0x193D3A4")] set
        {
        }
      }

      [Token(Token = "0x170028A7")]
      public bool IsSale
      {
        [Token(Token = "0x600C192"), Address(RVA = "0x193D3AC", Offset = "0x193D3AC", VA = "0x193D3AC")] readonly get
        {
          return new bool();
        }
        [Token(Token = "0x600C193"), Address(RVA = "0x193D3B4", Offset = "0x193D3B4", VA = "0x193D3B4")] set
        {
        }
      }

      [Token(Token = "0x170028A8")]
      public ItemUtility.RarityViewTypeEnum RarityViewType
      {
        [Token(Token = "0x600C194"), Address(RVA = "0x193D3C0", Offset = "0x193D3C0", VA = "0x193D3C0")] readonly get
        {
          return new ItemUtility.RarityViewTypeEnum();
        }
        [Token(Token = "0x600C195"), Address(RVA = "0x193D3C8", Offset = "0x193D3C8", VA = "0x193D3C8")] set
        {
        }
      }

      [Token(Token = "0x170028A9")]
      public int SkillLevel
      {
        [Token(Token = "0x600C196"), Address(RVA = "0x193D3D0", Offset = "0x193D3D0", VA = "0x193D3D0")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600C197"), Address(RVA = "0x193D3D8", Offset = "0x193D3D8", VA = "0x193D3D8")] set
        {
        }
      }

      [Token(Token = "0x600C198")]
      [Address(RVA = "0x193D3E0", Offset = "0x193D3E0", VA = "0x193D3E0")]
      public List<string> GetNeedAssetBundleNameList() => (List<string>) null;

      [Token(Token = "0x600C199")]
      [Address(RVA = "0x193D588", Offset = "0x193D588", VA = "0x193D588")]
      public void OutGameBaseAssetName()
      {
      }
    }
  }
}
