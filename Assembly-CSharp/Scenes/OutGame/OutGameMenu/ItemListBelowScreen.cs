// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ItemListBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.Armoury.ItemList;
using Scenes.OutGame.OutGameMenu.GlobalShop;
using Scenes.OutGame.OutGameMenu.GlobalShop.SalePopupContent;
using Scenes.OutGame.Utility;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039CC")]
  public class ItemListBelowScreen : OutGameMenuBelowScreenBase
  {
    [Token(Token = "0x400FCB2")]
    [FieldOffset(Offset = "0x0")]
    private static readonly float scrollAdjustmentTime;
    [Token(Token = "0x400FCB3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text zenyButtonText;
    [Token(Token = "0x400FCB4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject boxTimeLimit;
    [Token(Token = "0x400FCB5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI boxTimeLimitText;
    [Token(Token = "0x400FCB6")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private HorizontalGridInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400FCB7")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x400FCB8")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400FCB9")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CanvasGroup topCanvasGroup;
    [Token(Token = "0x400FCBA")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400FCBB")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ItemListSubMenu subMenu;
    [Token(Token = "0x400FCBC")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton fullScreenButton;
    [Token(Token = "0x400FCBD")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400FCBE")]
    [FieldOffset(Offset = "0xA0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400FCBF")]
    [FieldOffset(Offset = "0xA8")]
    private ItemListBelowScreen.Param itemListParam;
    [Token(Token = "0x400FCC0")]
    [FieldOffset(Offset = "0xB0")]
    private List<string>[] loadWaitItemId;
    [Token(Token = "0x400FCC1")]
    [FieldOffset(Offset = "0xB8")]
    private int loadWaitItemIdOfs;
    [Token(Token = "0x400FCC2")]
    [FieldOffset(Offset = "0xC0")]
    private Coroutine loadThumbAssetBundleCoroutine;
    [Token(Token = "0x400FCC3")]
    [FieldOffset(Offset = "0xC8")]
    private Coroutine instantiateItemThumbCoroutine;
    [Token(Token = "0x400FCC4")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400FCC5")]
    private const string ItemListAssetBundle = "ui_page_itemlist";
    [Token(Token = "0x400FCC6")]
    private const string GlobalShopAssetBundle = "ui_page_globalshop_prefab";
    [Token(Token = "0x400FCC7")]
    [FieldOffset(Offset = "0xD0")]
    private int selectedSubMenuIndex;
    [Token(Token = "0x400FCC8")]
    [FieldOffset(Offset = "0xD4")]
    private ItemListBelowScreen.eItemListKind selectedSubMenuItemListKind;
    [Token(Token = "0x400FCC9")]
    [FieldOffset(Offset = "0xD8")]
    private UITweenGroup selectTweenGroup;
    [Token(Token = "0x400FCCA")]
    [FieldOffset(Offset = "0xE0")]
    private ItemListSaleDialog itemSaleDialog;
    [Token(Token = "0x400FCCB")]
    [FieldOffset(Offset = "0xE8")]
    private SaleAfterPopup saleAfterPopup;
    [Token(Token = "0x400FCCC")]
    [FieldOffset(Offset = "0xF0")]
    private SaleCheckContainer saleCheckContainer;
    [Token(Token = "0x400FCCD")]
    [FieldOffset(Offset = "0xF8")]
    private int prevZeny;
    [Token(Token = "0x400FCCE")]
    [FieldOffset(Offset = "0x100")]
    private GameObject boxItemUsePopupPrefab;
    [Token(Token = "0x400FCCF")]
    [FieldOffset(Offset = "0x108")]
    private List<Item> items;
    [Token(Token = "0x400FCD0")]
    [FieldOffset(Offset = "0x110")]
    private List<IArmouryItemThumbResource> itemResources;
    [Token(Token = "0x400FCD1")]
    [FieldOffset(Offset = "0x118")]
    private ItemListAssetLoader assetLoader;
    [Token(Token = "0x400FCD2")]
    [FieldOffset(Offset = "0x120")]
    private int thumbSelectIndex;
    [Token(Token = "0x400FCD3")]
    [FieldOffset(Offset = "0x124")]
    private int subMenuTrustIndex;
    [Token(Token = "0x400FCD4")]
    [FieldOffset(Offset = "0x128")]
    private readonly NewBadgeProxy newBadgeProxy;

    [Token(Token = "0x6016B1D")]
    [Address(RVA = "0x3F67D88", Offset = "0x3F67D88", VA = "0x3F67D88", Slot = "4")]
    public override void Initialize(ChangeBelowScreenParameter param = null)
    {
    }

    [Token(Token = "0x6016B1E")]
    [Address(RVA = "0x3F68318", Offset = "0x3F68318", VA = "0x3F68318", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016B1F")]
    [Address(RVA = "0x3F683A8", Offset = "0x3F683A8", VA = "0x3F683A8")]
    private void InitializeBoxItemUsePopup()
    {
    }

    [Token(Token = "0x6016B20")]
    [Address(RVA = "0x3F684AC", Offset = "0x3F684AC", VA = "0x3F684AC")]
    private void SetIntractable(bool flg)
    {
    }

    [Token(Token = "0x6016B21")]
    [Address(RVA = "0x3F68200", Offset = "0x3F68200", VA = "0x3F68200")]
    private void UpdateItemList(bool immediateSnap = false)
    {
    }

    [Token(Token = "0x6016B22")]
    [Address(RVA = "0x3F684F0", Offset = "0x3F684F0", VA = "0x3F684F0")]
    private void SetThumbSelectIndex(int i)
    {
    }

    [Token(Token = "0x6016B23")]
    [Address(RVA = "0x3F6AF44", Offset = "0x3F6AF44", VA = "0x3F6AF44")]
    private void SetSubMenuTrustIndex(int newThumbSelectIndex)
    {
    }

    [Token(Token = "0x6016B24")]
    [Address(RVA = "0x3F6AF84", Offset = "0x3F6AF84", VA = "0x3F6AF84", Slot = "7")]
    public override void Open(string preBelowName)
    {
    }

    [Token(Token = "0x6016B25")]
    [Address(RVA = "0x3F6B0F4", Offset = "0x3F6B0F4", VA = "0x3F6B0F4", Slot = "8")]
    public override void Close(string nextBelowName)
    {
    }

    [Token(Token = "0x6016B26")]
    [Address(RVA = "0x3F68530", Offset = "0x3F68530", VA = "0x3F68530")]
    private void CreateItemList()
    {
    }

    [Token(Token = "0x6016B27")]
    [Address(RVA = "0x3F6AD70", Offset = "0x3F6AD70", VA = "0x3F6AD70")]
    private void SetItemListView()
    {
    }

    [Token(Token = "0x6016B28")]
    [Address(RVA = "0x3F6B21C", Offset = "0x3F6B21C", VA = "0x3F6B21C")]
    private void ThumbTouch(int index)
    {
    }

    [Token(Token = "0x6016B29")]
    [Address(RVA = "0x3F6B258", Offset = "0x3F6B258", VA = "0x3F6B258")]
    private void SubmenuOutRange()
    {
    }

    [Token(Token = "0x6016B2A")]
    [Address(RVA = "0x3F6B298", Offset = "0x3F6B298", VA = "0x3F6B298")]
    public void OnChangeSubMenu(int addValue)
    {
    }

    [Token(Token = "0x6016B2B")]
    [Address(RVA = "0x3F6B29C", Offset = "0x3F6B29C", VA = "0x3F6B29C")]
    public void OnSaleDialog()
    {
    }

    [Token(Token = "0x6016B2C")]
    [Address(RVA = "0x3F6B3DC", Offset = "0x3F6B3DC", VA = "0x3F6B3DC")]
    private IEnumerator OpenAfterSalePopup() => (IEnumerator) null;

    [Token(Token = "0x6016B2D")]
    [Address(RVA = "0x3F6B46C", Offset = "0x3F6B46C", VA = "0x3F6B46C")]
    private IEnumerator LoadSaleAfterPopup() => (IEnumerator) null;

    [Token(Token = "0x6016B2E")]
    [Address(RVA = "0x3F6B4FC", Offset = "0x3F6B4FC", VA = "0x3F6B4FC")]
    private IEnumerator LoadSaleCheckContainer() => (IEnumerator) null;

    [Token(Token = "0x6016B2F")]
    [Address(RVA = "0x3F6B58C", Offset = "0x3F6B58C", VA = "0x3F6B58C")]
    private void OnUseDialog()
    {
    }

    [Token(Token = "0x6016B30")]
    [Address(RVA = "0x3F6B670", Offset = "0x3F6B670", VA = "0x3F6B670")]
    private IEnumerator OpenBoxItemUsePopup(Item item) => (IEnumerator) null;

    [Token(Token = "0x6016B31")]
    [Address(RVA = "0x3F6B70C", Offset = "0x3F6B70C", VA = "0x3F6B70C")]
    private IEnumerator CreateBoxItemUsePopup(Item item, Action<BoxItemUsePopup> finished)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016B32")]
    [Address(RVA = "0x3F68154", Offset = "0x3F68154", VA = "0x3F68154")]
    private void SetZenyInHandParameter()
    {
    }

    [Token(Token = "0x6016B33")]
    [Address(RVA = "0x3F6B7B0", Offset = "0x3F6B7B0", VA = "0x3F6B7B0")]
    private void Update()
    {
    }

    [Token(Token = "0x6016B34")]
    [Address(RVA = "0x3F6B7CC", Offset = "0x3F6B7CC", VA = "0x3F6B7CC")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6016B35")]
    [Address(RVA = "0x3F6B80C", Offset = "0x3F6B80C", VA = "0x3F6B80C", Slot = "6")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6016B36")]
    [Address(RVA = "0x3F6B9F8", Offset = "0x3F6B9F8", VA = "0x3F6B9F8")]
    public ItemListBelowScreen()
    {
    }

    [Token(Token = "0x6016B37")]
    [Address(RVA = "0x3F6BA68", Offset = "0x3F6BA68", VA = "0x3F6BA68")]
    static ItemListBelowScreen()
    {
    }

    [Token(Token = "0x20039CD")]
    public class Param : ChangeBelowScreenParameter
    {
      [Token(Token = "0x400FCD5")]
      [FieldOffset(Offset = "0x14")]
      public int fillterSelect;

      [Token(Token = "0x6016B42")]
      [Address(RVA = "0x3F68138", Offset = "0x3F68138", VA = "0x3F68138")]
      public Param()
      {
      }
    }

    [Token(Token = "0x20039CE")]
    public enum eItemListKind
    {
      [Token(Token = "0x400FCD7")] Consumption,
      [Token(Token = "0x400FCD8")] Material,
      [Token(Token = "0x400FCD9")] Exchange,
      [Token(Token = "0x400FCDA")] Box,
      [Token(Token = "0x400FCDB")] Story,
      [Token(Token = "0x400FCDC")] Other,
    }
  }
}
