// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.ShopLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BCE")]
  public class ShopLoader
  {
    [Token(Token = "0x40108D7")]
    public const string PREFAB_ASSET_BUNDLE_LABEL = "2dassets_ui_story_shop";
    [Token(Token = "0x40108D8")]
    public const string PREFAB_SHOP_COMMON_LABEL = "2dassets_ui_story_shopcommon";
    [Token(Token = "0x40108D9")]
    public const string PREFAB_SHOP_ASSET_LABEL = "ui_page_globalshop_prefab";
    [Token(Token = "0x40108DA")]
    public const string SHOP_TIMELINE_LABEL = "ui_page_globalshop_timeline";
    [Token(Token = "0x40108DB")]
    public const string SHOP_TIMELINE_ASSET = "GlobalShop";
    [Token(Token = "0x40108DC")]
    public const string POPUP_BASE_TIMELINE_LABEL_NAME = "ui_common_timeline";
    [Token(Token = "0x40108DD")]
    public const string POPUP_BASE_TIMELINE_ASSET_NAME = "Com_Popup_Base_2";
    [Token(Token = "0x40108DE")]
    public const string PREFAB_SHORTAGE_LABEL = "ui_common_prefabs";
    [Token(Token = "0x40108DF")]
    public const string POPUP_ITEM_DETAIL_LABEL_NAME = "ui_page_itemdetail";
    [Token(Token = "0x40108E0")]
    public const string ITEM_ICON_LABEL_NAME = "ui_common_thumb";
    [Token(Token = "0x40108E1")]
    public const string POPUP_ITEM_DETAIL_TIMELINE_LABEL_NAME = "ui_page_itemdetail_timeline";
    [Token(Token = "0x40108E2")]
    public const string POPUP_ITEM_DETAIL_TIMELINE_ASSET_NAME = "Com_Popup";
    [Token(Token = "0x40108E3")]
    public const string SALE_SELECT_NUMBER_SPRITEATLAS_NAME = "sale_select_number";
    [Token(Token = "0x40108E4")]
    public const string GLOBAL_SHOP_LABEL = "ui_page_globalshop_texture";
    [Token(Token = "0x40108E5")]
    [FieldOffset(Offset = "0x10")]
    private readonly Dictionary<int, string> prefabMap;
    [Token(Token = "0x40108E6")]
    [FieldOffset(Offset = "0x18")]
    public readonly Dictionary<int, string> TimelineMap;
    [Token(Token = "0x40108E7")]
    [FieldOffset(Offset = "0x20")]
    private readonly Dictionary<int, string> timelineLabelMap;
    [Token(Token = "0x40108E8")]
    [FieldOffset(Offset = "0x28")]
    private readonly Dictionary<int, string> timelineAssetMap;
    [Token(Token = "0x40108E9")]
    [FieldOffset(Offset = "0x30")]
    public Dictionary<int, string> SaleResourceMap;
    [Token(Token = "0x40108EA")]
    [FieldOffset(Offset = "0x38")]
    private readonly Dictionary<int, string> salePopupResourceMap;
    [Token(Token = "0x40108EB")]
    [FieldOffset(Offset = "0x40")]
    public Dictionary<int, string> BuyResourceMap;
    [Token(Token = "0x40108EC")]
    [FieldOffset(Offset = "0x48")]
    public Dictionary<int, string> BuyPopupResourceMap;
    [Token(Token = "0x40108ED")]
    [FieldOffset(Offset = "0x50")]
    public Dictionary<int, string> TargetAssetBundleLabelMap;
    [Token(Token = "0x40108EF")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<int, PopupBase> popupMap;
    [Token(Token = "0x40108F0")]
    [FieldOffset(Offset = "0x60")]
    public Dictionary<int, UITimelineController> PopupTimelineControllerMap;
    [Token(Token = "0x40108F1")]
    [FieldOffset(Offset = "0x8")]
    private static Dictionary<string, Dictionary<string, UnityEngine.Object>> assetCache;

    [Token(Token = "0x17004C64")]
    public Dictionary<int, string> PrefabMap
    {
      [Token(Token = "0x6017841"), Address(RVA = "0x265D498", Offset = "0x265D498", VA = "0x265D498")] get
      {
        return (Dictionary<int, string>) null;
      }
    }

    [Token(Token = "0x17004C65")]
    public static List<string> LoadedList
    {
      [Token(Token = "0x6017842"), Address(RVA = "0x265D4A0", Offset = "0x265D4A0", VA = "0x265D4A0")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x6017843"), Address(RVA = "0x265D4F8", Offset = "0x265D4F8", VA = "0x265D4F8")] private set
      {
      }
    }

    [Token(Token = "0x17004C66")]
    public bool IsLoading
    {
      [Token(Token = "0x6017844"), Address(RVA = "0x265D554", Offset = "0x265D554", VA = "0x265D554")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017845")]
    [Address(RVA = "0x265D5CC", Offset = "0x265D5CC", VA = "0x265D5CC")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6017846")]
    [Address(RVA = "0x265D7D4", Offset = "0x265D7D4", VA = "0x265D7D4")]
    private string[] GetSaleLoadAssetBundleList() => (string[]) null;

    [Token(Token = "0x6017847")]
    [Address(RVA = "0x265E3C0", Offset = "0x265E3C0", VA = "0x265E3C0")]
    private string[] GetBuyLoadAssetBundleList(
      Dictionary<int, PlayerShopArticleType[]> shopGroupingData)
    {
      return (string[]) null;
    }

    [Token(Token = "0x6017848")]
    [Address(RVA = "0x26504E4", Offset = "0x26504E4", VA = "0x26504E4")]
    public IEnumerator LoadBuyAsync(
      Dictionary<int, PlayerShopArticleType[]> shopGroupingData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017849")]
    [Address(RVA = "0x265F420", Offset = "0x265F420", VA = "0x265F420")]
    public IEnumerator LoadSaleAsync() => (IEnumerator) null;

    [Token(Token = "0x601784A")]
    [Address(RVA = "0x265F488", Offset = "0x265F488", VA = "0x265F488")]
    public IEnumerator LoadPassAsync() => (IEnumerator) null;

    [Token(Token = "0x601784B")]
    [Address(RVA = "0x2650558", Offset = "0x2650558", VA = "0x2650558")]
    public UITimelineSettingAsset LoadUITimelineAsset(string label = "ui_common_timeline", string assetName = "Com_Popup_Base_2")
    {
      return (UITimelineSettingAsset) null;
    }

    [Token(Token = "0x601784C")]
    [Address(RVA = "0x264EB48", Offset = "0x264EB48", VA = "0x264EB48")]
    public bool IsCreateCheck(ShopLoader.ShopAssetType shopAssetType) => new bool();

    [Token(Token = "0x601784D")]
    [Address(RVA = "0x264E6C8", Offset = "0x264E6C8", VA = "0x264E6C8")]
    public PopupBase GetPopup(ShopLoader.ShopAssetType shopAssetType) => (PopupBase) null;

    [Token(Token = "0x601784E")]
    [Address(RVA = "0x265F4E8", Offset = "0x265F4E8", VA = "0x265F4E8")]
    public void RemovePopup(ShopLoader.ShopAssetType shopAssetType)
    {
    }

    [Token(Token = "0x601784F")]
    [Address(RVA = "0x264EBA0", Offset = "0x264EBA0", VA = "0x264EBA0")]
    public IEnumerator CreatePopup(
      ShopLoader.ShopAssetType shopAssetType,
      Action<PopupBase> endCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017850")]
    [Address(RVA = "0x265F5A0", Offset = "0x265F5A0", VA = "0x265F5A0")]
    public bool IsPlayingTimeline() => new bool();

    [Token(Token = "0x6017851")]
    [Address(RVA = "0x265F6C8", Offset = "0x265F6C8", VA = "0x265F6C8")]
    public IEnumerator InitializePopup(
      string assetBundleLabel,
      ShopLoader.TimelineAssetType assetType = ShopLoader.TimelineAssetType.Common)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017852")]
    public T CreatePrefab<T>(ShopLoader.ShopAssetType shopAssetType, string label) where T : UnityEngine.Object
    {
      return (T) null;
    }

    [Token(Token = "0x6017853")]
    private static T GetCacheObject<T>(string assetLabel, string assetName) where T : UnityEngine.Object
    {
      return (T) null;
    }

    [Token(Token = "0x6017854")]
    [Address(RVA = "0x265F76C", Offset = "0x265F76C", VA = "0x265F76C")]
    public GameObject CreateGroupItem(ShopItem.ProductItemType itemType) => (GameObject) null;

    [Token(Token = "0x6017855")]
    [Address(RVA = "0x265F884", Offset = "0x265F884", VA = "0x265F884")]
    public ShopItem CreateShopItem(ShopItem.ProductItemType itemType) => (ShopItem) null;

    [Token(Token = "0x6017856")]
    [Address(RVA = "0x265F900", Offset = "0x265F900", VA = "0x265F900")]
    public GlobalShopSideMenuButton CreateSideButton() => (GlobalShopSideMenuButton) null;

    [Token(Token = "0x6017857")]
    [Address(RVA = "0x265F96C", Offset = "0x265F96C", VA = "0x265F96C")]
    public GameObject CreateLimitTimeObject() => (GameObject) null;

    [Token(Token = "0x6017858")]
    private T LoadedInstantiate<T>(string label, string assetName) where T : UnityEngine.Object
    {
      return (T) null;
    }

    [Token(Token = "0x6017859")]
    [Address(RVA = "0x265FA78", Offset = "0x265FA78", VA = "0x265FA78")]
    public GameObject GetSaleItemDataBase() => (GameObject) null;

    [Token(Token = "0x601785A")]
    [Address(RVA = "0x265FB38", Offset = "0x265FB38", VA = "0x265FB38")]
    public GameObject GetSaleGroupItemDataBase() => (GameObject) null;

    [Token(Token = "0x601785B")]
    [Address(RVA = "0x265FBF8", Offset = "0x265FBF8", VA = "0x265FBF8")]
    public GameObject GetItemIcon() => (GameObject) null;

    [Token(Token = "0x601785C")]
    public T GetAsset<T>(string label, string assetName) where T : UnityEngine.Object => (T) null;

    [Token(Token = "0x601785D")]
    [Address(RVA = "0x265FCB8", Offset = "0x265FCB8", VA = "0x265FCB8")]
    public SpriteAtlas GetSpriteAtlas(string label, string assetName) => (SpriteAtlas) null;

    [Token(Token = "0x601785E")]
    [Address(RVA = "0x265FD34", Offset = "0x265FD34", VA = "0x265FD34")]
    public SpriteAtlas GetSelectNumberAtlas() => (SpriteAtlas) null;

    [Token(Token = "0x601785F")]
    [Address(RVA = "0x265FDA8", Offset = "0x265FDA8", VA = "0x265FDA8")]
    public void RequestOtherDetailPopup(
      AssetCachedSpawner spawner,
      ShopLoader.ShopAssetType shopAssetType,
      Action<GameObject> loadedAction)
    {
    }

    [Token(Token = "0x6017860")]
    [Address(RVA = "0x265FE5C", Offset = "0x265FE5C", VA = "0x265FE5C")]
    public void UnloadAssetBundle()
    {
    }

    [Token(Token = "0x6017861")]
    [Address(RVA = "0x26600A4", Offset = "0x26600A4", VA = "0x26600A4")]
    public void RequestGameObject(
      AssetCachedSpawner spawner,
      ShopLoader.ShopAssetType shopAssetType,
      Action<GameObject> loadedAction)
    {
    }

    [Token(Token = "0x6017862")]
    [Address(RVA = "0x2660158", Offset = "0x2660158", VA = "0x2660158")]
    public void RequesUITimelineAsset(
      AssetCachedSpawner spawner,
      ShopLoader.TimelineAssetType timelineAssetType,
      Action<UITimelineSettingAsset> loadedAction)
    {
    }

    [Token(Token = "0x6017863")]
    [Address(RVA = "0x266020C", Offset = "0x266020C", VA = "0x266020C")]
    public ShopLoader()
    {
    }

    [Token(Token = "0x6017864")]
    [Address(RVA = "0x26612F4", Offset = "0x26612F4", VA = "0x26612F4")]
    static ShopLoader()
    {
    }

    [Token(Token = "0x2003BCF")]
    public enum ShopAssetType
    {
      [Token(Token = "0x40108F3")] BuyContainer,
      [Token(Token = "0x40108F4")] GroupItem,
      [Token(Token = "0x40108F5")] ShopItem,
      [Token(Token = "0x40108F6")] LargeGroupItem,
      [Token(Token = "0x40108F7")] LargeShopItem,
      [Token(Token = "0x40108F8")] SideButton,
      [Token(Token = "0x40108F9")] LimitItem,
      [Token(Token = "0x40108FA")] Popup_ReloadStone,
      [Token(Token = "0x40108FB")] Popup_ReloadZeny,
      [Token(Token = "0x40108FC")] Popup_ReloadFree,
      [Token(Token = "0x40108FD")] Popup_Purchase_Jewel,
      [Token(Token = "0x40108FE")] Popup_Purchase_Zeny,
      [Token(Token = "0x40108FF")] Popup_Purchase_Cash,
      [Token(Token = "0x4010900")] Popup_After_Purchase_AddJewel,
      [Token(Token = "0x4010901")] Popup_After_Purchase,
      [Token(Token = "0x4010902")] SaleContainer,
      [Token(Token = "0x4010903")] SaleGroupItem,
      [Token(Token = "0x4010904")] SaleItem,
      [Token(Token = "0x4010905")] SaleSetItemCountPopup,
      [Token(Token = "0x4010906")] SelectSaleCheckPopup,
      [Token(Token = "0x4010907")] AfterSalePopup,
      [Token(Token = "0x4010908")] SaleSetItemCountContianer,
      [Token(Token = "0x4010909")] SelectSaleCheckContainer,
      [Token(Token = "0x401090A")] AfterSaleContainer,
      [Token(Token = "0x401090B")] ItemDetailPopup,
      [Token(Token = "0x401090C")] BoxItemDetailPopup,
      [Token(Token = "0x401090D")] UsageName,
      [Token(Token = "0x401090E")] ItemIcon,
      [Token(Token = "0x401090F")] OtherDetailPopup,
      [Token(Token = "0x4010910")] ShortagePopup,
      [Token(Token = "0x4010911")] CommonPopup,
      [Token(Token = "0x4010912")] SaleNumberSpriteAtlas,
      [Token(Token = "0x4010913")] MedalShop,
      [Token(Token = "0x4010914")] PassRewardItem,
      [Token(Token = "0x4010915")] PassRewardGroup,
      [Token(Token = "0x4010916")] PassShopItem,
      [Token(Token = "0x4010917")] Popup_Purchase_Pass,
      [Token(Token = "0x4010918")] Popup_Pass_After_Purchase,
      [Token(Token = "0x4010919")] PassShopScene,
    }

    [Token(Token = "0x2003BD0")]
    public enum TimelineType
    {
      [Token(Token = "0x401091B")] GlobalShopIn,
      [Token(Token = "0x401091C")] GlobalShopOut,
      [Token(Token = "0x401091D")] CommonPopupIn,
      [Token(Token = "0x401091E")] CommonPopupOut,
      [Token(Token = "0x401091F")] ItemDetailIn,
      [Token(Token = "0x4010920")] ItemDetailOut,
    }

    [Token(Token = "0x2003BD1")]
    public enum TimelineAssetType
    {
      [Token(Token = "0x4010922")] Common,
      [Token(Token = "0x4010923")] ItemDetail,
      [Token(Token = "0x4010924")] Shop,
    }
  }
}
