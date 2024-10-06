// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MedalShop.MedalShopLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.MedalShop
{
  [Token(Token = "0x2003B27")]
  public class MedalShopLoader
  {
    [Token(Token = "0x401050B")]
    public const string PREFAB_SHOP_ASSET_LABEL = "ui_page_globalshop_prefab";
    [Token(Token = "0x401050C")]
    public const string SHOP_TIMELINE_LABEL = "ui_page_globalshop_timeline";
    [Token(Token = "0x401050D")]
    public const string SHOP_TIMELINE_ASSET = "GlobalShop";
    [Token(Token = "0x401050E")]
    public const string POPUP_BASE_TIMELINE_LABEL_NAME = "ui_common_timeline";
    [Token(Token = "0x401050F")]
    public const string POPUP_BASE_TIMELINE_ASSET_NAME = "Com_Popup_Base";
    [Token(Token = "0x4010510")]
    public const string POPUP_ITEM_DETAIL_LABEL_NAME = "ui_page_itemdetail";
    [Token(Token = "0x4010511")]
    public const string ITEM_ICON_LABEL_NAME = "ui_common_thumb";
    [Token(Token = "0x4010512")]
    public const string POPUP_ITEM_DETAIL_TIMELINE_LABEL_NAME = "ui_page_itemdetail_timeline";
    [Token(Token = "0x4010513")]
    public const string POPUP_ITEM_DETAIL_TIMELINE_ASSET_NAME = "Com_Popup";
    [Token(Token = "0x4010514")]
    private const string ICON_BASE_IMAGE_NAME = "Img_Thumb_Base_{0}";
    [Token(Token = "0x4010515")]
    [FieldOffset(Offset = "0x10")]
    public readonly Dictionary<int, string> PrefabMap;
    [Token(Token = "0x4010516")]
    [FieldOffset(Offset = "0x18")]
    public readonly Dictionary<int, string> TimelineMap;
    [Token(Token = "0x4010517")]
    [FieldOffset(Offset = "0x20")]
    private readonly Dictionary<int, string> timelineLabelMap;
    [Token(Token = "0x4010518")]
    [FieldOffset(Offset = "0x28")]
    private readonly Dictionary<int, string> timelineAssetMap;
    [Token(Token = "0x4010519")]
    [FieldOffset(Offset = "0x30")]
    public Dictionary<int, string> TargetAssetBundleLabelMap;
    [Token(Token = "0x401051B")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<int, PopupBase> popupMap;
    [Token(Token = "0x401051C")]
    [FieldOffset(Offset = "0x40")]
    public Dictionary<int, UITimelineController> PopupTimelineControllerMap;

    [Token(Token = "0x17004BF1")]
    public static List<string> LoadedList
    {
      [Token(Token = "0x6017480"), Address(RVA = "0x271C2B8", Offset = "0x271C2B8", VA = "0x271C2B8")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x6017481"), Address(RVA = "0x271C310", Offset = "0x271C310", VA = "0x271C310")] private set
      {
      }
    }

    [Token(Token = "0x17004BF2")]
    public bool IsLoading
    {
      [Token(Token = "0x6017482"), Address(RVA = "0x271C36C", Offset = "0x271C36C", VA = "0x271C36C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017483")]
    [Address(RVA = "0x271C3E4", Offset = "0x271C3E4", VA = "0x271C3E4")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6017484")]
    [Address(RVA = "0x271C5EC", Offset = "0x271C5EC", VA = "0x271C5EC")]
    public IEnumerator GetMedalBanner(
      int medalShopId,
      int bannerId,
      Action<Texture2D> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017485")]
    [Address(RVA = "0x271B608", Offset = "0x271B608", VA = "0x271B608")]
    public void PreloadSpriteRequest(AssetCachedSpawner spawner, int targetMedalShopId)
    {
    }

    [Token(Token = "0x6017486")]
    [Address(RVA = "0x2713F9C", Offset = "0x2713F9C", VA = "0x2713F9C")]
    public void RequestGameObject(
      AssetCachedSpawner spawner,
      MedalShopLoader.ShopAssetType shopAssetType,
      Action<GameObject> loadedAction)
    {
    }

    [Token(Token = "0x6017487")]
    [Address(RVA = "0x271C698", Offset = "0x271C698", VA = "0x271C698")]
    public void RequesPaymentIcon(
      AssetCachedSpawner spawner,
      ItemUtility.Parameter param,
      Action<Sprite> loadedAction)
    {
    }

    [Token(Token = "0x6017488")]
    [Address(RVA = "0x271C700", Offset = "0x271C700", VA = "0x271C700")]
    public void RequesRarityImage(
      AssetCachedSpawner spawner,
      ItemUtility.Parameter param,
      Action<Sprite> loadedAction)
    {
    }

    [Token(Token = "0x6017489")]
    [Address(RVA = "0x2712064", Offset = "0x2712064", VA = "0x2712064")]
    public void RequesUITimelineAsset(
      AssetCachedSpawner spawner,
      MedalShopLoader.TimelineAssetType timelineAssetType,
      Action<UITimelineSettingAsset> loadedAction)
    {
    }

    [Token(Token = "0x601748A")]
    [Address(RVA = "0x27155C0", Offset = "0x27155C0", VA = "0x27155C0")]
    public MedalShopLoader()
    {
    }

    [Token(Token = "0x601748B")]
    [Address(RVA = "0x271C7CC", Offset = "0x271C7CC", VA = "0x271C7CC")]
    static MedalShopLoader()
    {
    }

    [Token(Token = "0x2003B28")]
    public enum ShopAssetType
    {
      [Token(Token = "0x401051E")] Top,
      [Token(Token = "0x401051F")] TopBannerBtn,
      [Token(Token = "0x4010520")] ListTop,
      [Token(Token = "0x4010521")] ListSideMenu,
      [Token(Token = "0x4010522")] ListSideItem,
      [Token(Token = "0x4010523")] GroupItem,
      [Token(Token = "0x4010524")] ShopItem,
      [Token(Token = "0x4010525")] Popup,
      [Token(Token = "0x4010526")] Popup_After_Purchase,
      [Token(Token = "0x4010527")] ItemDetailPopup,
      [Token(Token = "0x4010528")] BoxItemDetailPopup,
      [Token(Token = "0x4010529")] UsageName,
      [Token(Token = "0x401052A")] ItemIcon,
      [Token(Token = "0x401052B")] OtherDetailPopup,
      [Token(Token = "0x401052C")] BuyContainer,
      [Token(Token = "0x401052D")] PassShopScene,
    }

    [Token(Token = "0x2003B29")]
    public enum TimelineType
    {
      [Token(Token = "0x401052F")] GlobalShopIn,
      [Token(Token = "0x4010530")] GlobalShopOut,
      [Token(Token = "0x4010531")] CommonPopupIn,
      [Token(Token = "0x4010532")] CommonPopupOut,
      [Token(Token = "0x4010533")] ItemDetailIn,
      [Token(Token = "0x4010534")] ItemDetailOut,
    }

    [Token(Token = "0x2003B2A")]
    public enum TimelineAssetType
    {
      [Token(Token = "0x4010536")] Common,
      [Token(Token = "0x4010537")] ItemDetail,
      [Token(Token = "0x4010538")] MedalShop,
    }
  }
}
