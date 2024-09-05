// Decompiled with JetBrains decompiler
// Type: Scenes.Story.ChapterShop.ChapterShopLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.Story.ChapterShop
{
  [Token(Token = "0x2002EF8")]
  public class ChapterShopLoader
  {
    [Token(Token = "0x400C968")]
    private const string PREFAB_CHAPTER_ASSET_BUNDLE_LABEL = "ui_page_chaptershop_prefab";
    [Token(Token = "0x400C969")]
    private const string PREFAB_SHOP_ASSET_LABEL = "ui_page_globalshop_prefab";
    [Token(Token = "0x400C96A")]
    private const string TIMELINE_ASSET_BUNDLE_LABEL_NAME = "content_effect_common_outgamemenu_timeline";
    [Token(Token = "0x400C96B")]
    private const string TIMELINE_ASSET_NAME = "OutGameMenu";
    [Token(Token = "0x400C96C")]
    private const string ICON_BASE_IMAGE_NAME = "Img_Thumb_Base_{0}";
    [Token(Token = "0x400C96D")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<ChapterShopLoader.ResourceType, string> ResourceMap;
    [Token(Token = "0x400C96E")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<ChapterShopLoader.ResourceType, string> PopupResourceMap;
    [Token(Token = "0x400C96F")]
    [FieldOffset(Offset = "0x20")]
    public Dictionary<ChapterShopLoader.ResourceType, string> TargetAssetBundleLabelMap;
    [Token(Token = "0x400C970")]
    [FieldOffset(Offset = "0x28")]
    public readonly Dictionary<int, string> TimelineMap;
    [Token(Token = "0x400C971")]
    [FieldOffset(Offset = "0x30")]
    public readonly Dictionary<int, string> TimelineLabelMap;
    [Token(Token = "0x400C972")]
    [FieldOffset(Offset = "0x38")]
    public readonly Dictionary<int, string> TimelineAssetMap;
    [Token(Token = "0x400C974")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<ChapterShopLoader.ResourceType, PopupBase> popupMap;
    [Token(Token = "0x400C975")]
    [FieldOffset(Offset = "0x48")]
    public Dictionary<int, UITimelineController> PopupTimelineControllerMap;

    [Token(Token = "0x17003E47")]
    public static List<string> LoadedList
    {
      [Token(Token = "0x60125AA"), Address(RVA = "0x22FB73C", Offset = "0x22FB73C", VA = "0x22FB73C")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x60125AB"), Address(RVA = "0x22FB794", Offset = "0x22FB794", VA = "0x22FB794")] private set
      {
      }
    }

    [Token(Token = "0x60125AC")]
    [Address(RVA = "0x22FB7F0", Offset = "0x22FB7F0", VA = "0x22FB7F0")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60125AD")]
    [Address(RVA = "0x22FB9F8", Offset = "0x22FB9F8", VA = "0x22FB9F8")]
    private string[] GetLoadAssetBundleList(List<ChapterShopData> chapterShopDatas)
    {
      return (string[]) null;
    }

    [Token(Token = "0x60125AE")]
    [Address(RVA = "0x22FC694", Offset = "0x22FC694", VA = "0x22FC694")]
    public IEnumerator LoadBuyAsync(List<ChapterShopData> chapterShopDatas) => (IEnumerator) null;

    [Token(Token = "0x60125AF")]
    [Address(RVA = "0x22FC730", Offset = "0x22FC730", VA = "0x22FC730")]
    public UITimelineSettingAsset LoadUITimelineAsset(string label, string assetName)
    {
      return (UITimelineSettingAsset) null;
    }

    [Token(Token = "0x60125B0")]
    [Address(RVA = "0x22FC830", Offset = "0x22FC830", VA = "0x22FC830")]
    public bool IsCreateCheck(ChapterShopLoader.ResourceType shopAssetType) => new bool();

    [Token(Token = "0x60125B1")]
    [Address(RVA = "0x22FC888", Offset = "0x22FC888", VA = "0x22FC888")]
    public PopupBase GetPopup(ChapterShopLoader.ResourceType shopAssetType) => (PopupBase) null;

    [Token(Token = "0x60125B2")]
    [Address(RVA = "0x22FC900", Offset = "0x22FC900", VA = "0x22FC900")]
    public bool IsPlayingTimeline() => new bool();

    [Token(Token = "0x60125B3")]
    [Address(RVA = "0x22FCA28", Offset = "0x22FCA28", VA = "0x22FCA28")]
    public IEnumerator InitializePopup(
      ChapterShopLoader.ResourceType resourceType,
      ChapterShopLoader.TimelineAssetType assetType)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60125B4")]
    public T CreatePrefab<T>(ChapterShopLoader.ResourceType resourceType, string label) where T : Object
    {
      return (T) null;
    }

    [Token(Token = "0x60125B5")]
    private T LoadedInstantiate<T>(string label, string assetName) where T : Object => (T) null;

    [Token(Token = "0x60125B6")]
    public T GetAsset<T>(string label, string assetName) where T : Object => (T) null;

    [Token(Token = "0x60125B7")]
    [Address(RVA = "0x22FCACC", Offset = "0x22FCACC", VA = "0x22FCACC")]
    public GameObject GetAsset(string label, string assetName) => (GameObject) null;

    [Token(Token = "0x60125B8")]
    [Address(RVA = "0x22FCBA8", Offset = "0x22FCBA8", VA = "0x22FCBA8")]
    public Sprite GetIconBaseSprite(RarityTypeEnum? rarityType) => (Sprite) null;

    [Token(Token = "0x60125B9")]
    [Address(RVA = "0x22FCD00", Offset = "0x22FCD00", VA = "0x22FCD00")]
    public void UnloadAssetBundle()
    {
    }

    [Token(Token = "0x60125BA")]
    [Address(RVA = "0x22FCF40", Offset = "0x22FCF40", VA = "0x22FCF40")]
    public ChapterShopLoader()
    {
    }

    [Token(Token = "0x60125BB")]
    [Address(RVA = "0x22FD5DC", Offset = "0x22FD5DC", VA = "0x22FD5DC")]
    static ChapterShopLoader()
    {
    }

    [Token(Token = "0x2002EF9")]
    public enum ResourceType
    {
      [Token(Token = "0x400C977")] ContainerShop,
      [Token(Token = "0x400C978")] ContainerShopListParts,
      [Token(Token = "0x400C979")] SingleItemPurchasePopup,
      [Token(Token = "0x400C97A")] ItemDescriptionPopup,
      [Token(Token = "0x400C97B")] CommonPopup,
      [Token(Token = "0x400C97C")] Popup_After_Purchase_AddJewel,
      [Token(Token = "0x400C97D")] Popup_After_Purchase,
      [Token(Token = "0x400C97E")] UsageName,
      [Token(Token = "0x400C97F")] ItemIcon,
      [Token(Token = "0x400C980")] OtherDetailPopup,
    }

    [Token(Token = "0x2002EFA")]
    public enum TimelineType
    {
      [Token(Token = "0x400C982")] GlobalShopIn,
      [Token(Token = "0x400C983")] GlobalShopOut,
      [Token(Token = "0x400C984")] CommonPopupIn,
      [Token(Token = "0x400C985")] CommonPopupOut,
      [Token(Token = "0x400C986")] ItemDetailIn,
      [Token(Token = "0x400C987")] ItemDetailOut,
    }

    [Token(Token = "0x2002EFB")]
    public enum TimelineAssetType
    {
      [Token(Token = "0x400C989")] Common,
      [Token(Token = "0x400C98A")] ItemDetail,
      [Token(Token = "0x400C98B")] Scene,
    }
  }
}
