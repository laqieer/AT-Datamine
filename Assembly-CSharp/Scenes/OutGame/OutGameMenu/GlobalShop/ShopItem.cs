// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.ShopItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Data;
using GameCore;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BCA")]
  public class ShopItem : MonoBehaviour
  {
    [Token(Token = "0x40108A8")]
    private const string SET_ICON_NAME = "{0}_SpecialPanel.png";
    [Token(Token = "0x40108A9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform selfRectTransform;
    [Token(Token = "0x40108AA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI itemName;
    [Token(Token = "0x40108AB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform thumbParent;
    [Token(Token = "0x40108AC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x40108AD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image setItemIcon;
    [Token(Token = "0x40108AE")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text limitedNumText;
    [Token(Token = "0x40108AF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject paidObject;
    [Token(Token = "0x40108B0")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text paidPriceValue;
    [Token(Token = "0x40108B1")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject paidSaleObj;
    [Token(Token = "0x40108B2")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text paidSaleText;
    [Token(Token = "0x40108B3")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text paidSaleNormalText;
    [Token(Token = "0x40108B4")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject freeObject;
    [Token(Token = "0x40108B5")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text freePriceValue;
    [Token(Token = "0x40108B6")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject freeSaleObj;
    [Token(Token = "0x40108B7")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text freeSaleText;
    [Token(Token = "0x40108B8")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text freeSaleNormalText;
    [Token(Token = "0x40108B9")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject coinObject;
    [Token(Token = "0x40108BA")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text coinText;
    [Token(Token = "0x40108BB")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject freeStoneIcon;
    [Token(Token = "0x40108BC")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject freeZenyIcon;
    [Token(Token = "0x40108BD")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Image medalIcon;
    [Token(Token = "0x40108BE")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject soldOutObject;
    [Token(Token = "0x40108BF")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject[] saleObjs;
    [Token(Token = "0x40108C0")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject lockObj;
    [Token(Token = "0x40108C1")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GameObject remainTimeObj;
    [Token(Token = "0x40108C2")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Text remainTimeText;
    [Token(Token = "0x40108C3")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Text NotItemNumText;
    [Token(Token = "0x40108C4")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private UITweenGroup badgeIcon;
    [Token(Token = "0x40108C5")]
    [FieldOffset(Offset = "0xF8")]
    private CommonShopItemData commonShopItem;
    [Token(Token = "0x40108C6")]
    [FieldOffset(Offset = "0x100")]
    private StyleThumb styleThumb;
    [Token(Token = "0x40108C7")]
    [FieldOffset(Offset = "0x108")]
    private MindequipmentThumb mindequipmentThumb;
    [Token(Token = "0x40108C8")]
    [FieldOffset(Offset = "0x110")]
    private Coroutine rawImageCoroutine;
    [Token(Token = "0x40108C9")]
    [FieldOffset(Offset = "0x118")]
    private bool isDestroy;
    [Token(Token = "0x40108CA")]
    [FieldOffset(Offset = "0x119")]
    private bool isSoldOut;
    [Token(Token = "0x40108CD")]
    [FieldOffset(Offset = "0x130")]
    private AssetCachedSpawner cachedSpawner;

    [Token(Token = "0x17004C5F")]
    public RectTransform SelfRectTransform
    {
      [Token(Token = "0x6017823"), Address(RVA = "0x265BA3C", Offset = "0x265BA3C", VA = "0x265BA3C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004C60")]
    public Action<ShopItem.ProductItemType, CommonShopItemData> OnShopItemAction
    {
      [Token(Token = "0x6017824"), Address(RVA = "0x265BA44", Offset = "0x265BA44", VA = "0x265BA44")] get
      {
        return (Action<ShopItem.ProductItemType, CommonShopItemData>) null;
      }
      [Token(Token = "0x6017825"), Address(RVA = "0x265BA4C", Offset = "0x265BA4C", VA = "0x265BA4C")] set
      {
      }
    }

    [Token(Token = "0x17004C61")]
    public ShopItem.ProductItemType NowShopItemType
    {
      [Token(Token = "0x6017826"), Address(RVA = "0x265BA54", Offset = "0x265BA54", VA = "0x265BA54")] get
      {
        return new ShopItem.ProductItemType();
      }
      [Token(Token = "0x6017827"), Address(RVA = "0x265BA5C", Offset = "0x265BA5C", VA = "0x265BA5C")] private set
      {
      }
    }

    [Token(Token = "0x6017828")]
    [Address(RVA = "0x265BA64", Offset = "0x265BA64", VA = "0x265BA64")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6017829")]
    [Address(RVA = "0x265BBAC", Offset = "0x265BBAC", VA = "0x265BBAC")]
    public void SetAssetCacheSpawner(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x601782A")]
    [Address(RVA = "0x265BBB4", Offset = "0x265BBB4", VA = "0x265BBB4")]
    public void InitializeBySingle(
      CommonShopItemData commonShopItem,
      Action<ShopItem.ProductItemType, CommonShopItemData> onClickShopItem)
    {
    }

    [Token(Token = "0x601782B")]
    [Address(RVA = "0x265C90C", Offset = "0x265C90C", VA = "0x265C90C")]
    public void InitializeBySetItem(
      CommonShopItemData commonShopItem,
      Action<ShopItem.ProductItemType, CommonShopItemData> onClickShopItem)
    {
    }

    [Token(Token = "0x601782C")]
    [Address(RVA = "0x265C918", Offset = "0x265C918", VA = "0x265C918")]
    public void SetMedalIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x601782D")]
    [Address(RVA = "0x265C9D8", Offset = "0x265C9D8", VA = "0x265C9D8")]
    public IEnumerator GetSetItemBanner(int setItemId, Action<Texture2D> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601782E")]
    [Address(RVA = "0x265CA78", Offset = "0x265CA78", VA = "0x265CA78")]
    private void SetupStyleThumb(int styleId)
    {
    }

    [Token(Token = "0x601782F")]
    [Address(RVA = "0x265CBF0", Offset = "0x265CBF0", VA = "0x265CBF0")]
    private void SetupMindEquipmentThumb(int mindEquipmentId)
    {
    }

    [Token(Token = "0x6017830")]
    [Address(RVA = "0x265BBC4", Offset = "0x265BBC4", VA = "0x265BBC4")]
    private void Initialize(
      CommonShopItemData commonShopItem,
      Action<ShopItem.ProductItemType, CommonShopItemData> onClickShopItem,
      bool useOtherThumb = false)
    {
    }

    [Token(Token = "0x6017831")]
    [Address(RVA = "0x265BB88", Offset = "0x265BB88", VA = "0x265BB88")]
    private void ResetCoroutine()
    {
    }

    [Token(Token = "0x6017832")]
    [Address(RVA = "0x265CD50", Offset = "0x265CD50", VA = "0x265CD50")]
    private void BadgeActive(bool isActive)
    {
    }

    [Token(Token = "0x6017833")]
    [Address(RVA = "0x265CDC8", Offset = "0x265CDC8", VA = "0x265CDC8")]
    public void OnClickItem()
    {
    }

    [Token(Token = "0x6017834")]
    [Address(RVA = "0x265CDF4", Offset = "0x265CDF4", VA = "0x265CDF4")]
    public ShopItem()
    {
    }

    [Token(Token = "0x2003BCB")]
    public enum ProductItemType
    {
      [Token(Token = "0x40108CF")] Set,
      [Token(Token = "0x40108D0")] Single,
    }
  }
}
