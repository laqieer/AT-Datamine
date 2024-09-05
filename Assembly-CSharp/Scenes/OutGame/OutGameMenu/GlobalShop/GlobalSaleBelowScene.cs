// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.GlobalSaleBelowScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using GlobalMenu;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UI.ItemDetail;
using UI.SortFilter;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003B68")]
  public class GlobalSaleBelowScene : OutGameMenuBelowScreenBase
  {
    [Token(Token = "0x4010688")]
    private const int CREATE_ONE_LINE_MAX = 3;
    [Token(Token = "0x4010689")]
    private const string SELECT_NUMBER_SPRITE_NAME = "Img_Num_SoldItemSelect_{0}";
    [Token(Token = "0x401068A")]
    [FieldOffset(Offset = "0x48")]
    private ShopLoader shopLoader;
    [Token(Token = "0x401068B")]
    [FieldOffset(Offset = "0x50")]
    private ShopAPIManager shopAPI;
    [Token(Token = "0x401068C")]
    [FieldOffset(Offset = "0x58")]
    private UITimelineController uiTimelineController;
    [Token(Token = "0x401068D")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x401068E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private HorizontalLayoutGroup scrollLayout;
    [Token(Token = "0x401068F")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x4010690")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text selectItemNum;
    [Token(Token = "0x4010691")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text selectMaxNum;
    [Token(Token = "0x4010692")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text totalSaleNum;
    [Token(Token = "0x4010693")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private RectTransform[] containers;
    [Token(Token = "0x4010694")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private RectTransform[] transfers;
    [Token(Token = "0x4010695")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private RectTransform[] badges;
    [Token(Token = "0x4010696")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Button[] jumpButtons;
    [Token(Token = "0x4010697")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Header header;
    [Token(Token = "0x4010698")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Color alertColor;
    [Token(Token = "0x4010699")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private CommonButton saleButton;
    [Token(Token = "0x401069A")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private CommonButton clearButton;
    [Token(Token = "0x401069B")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GameObject nothingObject;
    [Token(Token = "0x401069C")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject jumpParentObject;
    [Token(Token = "0x401069D")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private SortFilterHeaderButton sortFilterHeaderButton;
    [Token(Token = "0x401069E")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    [Header("リストアイテムの各横幅：変更合ったらここも変える")]
    private float itemSizeWidth;
    [Token(Token = "0x401069F")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private AnimationCurve jumpMoveCurve;
    [Token(Token = "0x40106A0")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private float jumpMoveTime;
    [Token(Token = "0x40106A1")]
    [FieldOffset(Offset = "0x104")]
    private float jumpMoveTimeCount;
    [Token(Token = "0x40106A2")]
    [FieldOffset(Offset = "0x108")]
    private float jumpMoveLen;
    [Token(Token = "0x40106A3")]
    [FieldOffset(Offset = "0x10C")]
    private float jumpMoveSrcVal;
    [Token(Token = "0x40106A4")]
    [FieldOffset(Offset = "0x110")]
    private GameObject backSpaceObj;
    [Token(Token = "0x40106A5")]
    private const float backSpaceObjSize = 1250f;
    [Token(Token = "0x40106AB")]
    [FieldOffset(Offset = "0x140")]
    private Dictionary<int, List<ItemListData>> categoryItemMap;
    [Token(Token = "0x40106AC")]
    [FieldOffset(Offset = "0x148")]
    private Dictionary<ItemListData, int> saleCountMap;
    [Token(Token = "0x40106AD")]
    [FieldOffset(Offset = "0x150")]
    private List<ItemListData> saleItemIndexList;
    [Token(Token = "0x40106AE")]
    [FieldOffset(Offset = "0x158")]
    private Dictionary<int, Queue<SaleItemData>> createdSaleItemDataQueueMap;
    [Token(Token = "0x40106AF")]
    [FieldOffset(Offset = "0x160")]
    private Dictionary<int, Queue<Transform>> createdSaleGroupQueueMap;
    [Token(Token = "0x40106B0")]
    [FieldOffset(Offset = "0x168")]
    private Coroutine createCoroutine;
    [Token(Token = "0x40106B1")]
    [FieldOffset(Offset = "0x170")]
    private SpriteAtlas selectNumberAtlas;
    [Token(Token = "0x40106B2")]
    [FieldOffset(Offset = "0x178")]
    private AssetCachedSpawner cachedSpawner;
    [Token(Token = "0x40106B3")]
    [FieldOffset(Offset = "0x180")]
    private int selectedGlobalShopIndex;
    [Token(Token = "0x40106B4")]
    [FieldOffset(Offset = "0x188")]
    private Action<bool> onSetSideButtonActive;
    [Token(Token = "0x40106B5")]
    [FieldOffset(Offset = "0x190")]
    private Action<int> onMoveMedalShop;
    [Token(Token = "0x40106B6")]
    [FieldOffset(Offset = "0x198")]
    private bool isSelectSalePopupKeepsOpen;
    [Token(Token = "0x40106B7")]
    [FieldOffset(Offset = "0x199")]
    private bool isSaleCheckPopupKeepsOpen;
    [Token(Token = "0x40106B8")]
    [FieldOffset(Offset = "0x19A")]
    private bool isInitializeEnd;

    [Token(Token = "0x17004C1E")]
    public Action OnClickToChangeViewAction
    {
      [Token(Token = "0x60175F4"), Address(RVA = "0x28FE55C", Offset = "0x28FE55C", VA = "0x28FE55C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60175F5"), Address(RVA = "0x28FE564", Offset = "0x28FE564", VA = "0x28FE564")] set
      {
      }
    }

    [Token(Token = "0x17004C1F")]
    public Action<ItemListData> OnClickToSaleItemAction
    {
      [Token(Token = "0x60175F6"), Address(RVA = "0x28FE56C", Offset = "0x28FE56C", VA = "0x28FE56C")] get
      {
        return (Action<ItemListData>) null;
      }
      [Token(Token = "0x60175F7"), Address(RVA = "0x28FE574", Offset = "0x28FE574", VA = "0x28FE574")] set
      {
      }
    }

    [Token(Token = "0x17004C20")]
    public Action OnClickToSaleFinalCheckAction
    {
      [Token(Token = "0x60175F8"), Address(RVA = "0x28FE57C", Offset = "0x28FE57C", VA = "0x28FE57C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60175F9"), Address(RVA = "0x28FE584", Offset = "0x28FE584", VA = "0x28FE584")] set
      {
      }
    }

    [Token(Token = "0x17004C21")]
    public Action OnClickToClearAction
    {
      [Token(Token = "0x60175FA"), Address(RVA = "0x28FE58C", Offset = "0x28FE58C", VA = "0x28FE58C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60175FB"), Address(RVA = "0x28FE594", Offset = "0x28FE594", VA = "0x28FE594")] set
      {
      }
    }

    [Token(Token = "0x17004C22")]
    public Action OnClickToDeactiveAlertAction
    {
      [Token(Token = "0x60175FC"), Address(RVA = "0x28FE59C", Offset = "0x28FE59C", VA = "0x28FE59C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60175FD"), Address(RVA = "0x28FE5A4", Offset = "0x28FE5A4", VA = "0x28FE5A4")] set
      {
      }
    }

    [Token(Token = "0x60175FE")]
    [Address(RVA = "0x28FE5AC", Offset = "0x28FE5AC", VA = "0x28FE5AC")]
    public void ChangeHeaderText()
    {
    }

    [Token(Token = "0x60175FF")]
    [Address(RVA = "0x28FE720", Offset = "0x28FE720", VA = "0x28FE720", Slot = "4")]
    public override void Initialize(ChangeBelowScreenParameter param = null)
    {
    }

    [Token(Token = "0x6017600")]
    [Address(RVA = "0x28FEB0C", Offset = "0x28FEB0C", VA = "0x28FEB0C")]
    private void UpdateSortFilterButton()
    {
    }

    [Token(Token = "0x6017601")]
    [Address(RVA = "0x28FEBB0", Offset = "0x28FEBB0", VA = "0x28FEBB0", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6017602")]
    [Address(RVA = "0x28FEC40", Offset = "0x28FEC40", VA = "0x28FEC40")]
    public void UpdateSale(bool isConnectApi, bool isInitialize = false)
    {
    }

    [Token(Token = "0x6017603")]
    [Address(RVA = "0x28FEE64", Offset = "0x28FEE64", VA = "0x28FEE64")]
    private IEnumerator CreateSaleItem(bool isConnectApi, bool isInitialize = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017604")]
    [Address(RVA = "0x28FEF14", Offset = "0x28FEF14", VA = "0x28FEF14")]
    private List<Sprite> GetSprites(int index) => (List<Sprite>) null;

    [Token(Token = "0x6017605")]
    [Address(RVA = "0x28FF140", Offset = "0x28FF140", VA = "0x28FF140")]
    public void SetIconDeactive()
    {
    }

    [Token(Token = "0x6017606")]
    [Address(RVA = "0x28FEB28", Offset = "0x28FEB28", VA = "0x28FEB28")]
    private void SetButtonEnable()
    {
    }

    [Token(Token = "0x6017607")]
    [Address(RVA = "0x28FF6CC", Offset = "0x28FF6CC", VA = "0x28FF6CC")]
    public void SetSelectCount()
    {
    }

    [Token(Token = "0x6017608")]
    [Address(RVA = "0x28FFE84", Offset = "0x28FFE84", VA = "0x28FFE84")]
    public void OnClickToClear()
    {
    }

    [Token(Token = "0x6017609")]
    [Address(RVA = "0x29002C4", Offset = "0x29002C4", VA = "0x29002C4")]
    public void OnClickToSort()
    {
    }

    [Token(Token = "0x601760A")]
    [Address(RVA = "0x290036C", Offset = "0x290036C", VA = "0x290036C")]
    public void OnClickToChangeView()
    {
    }

    [Token(Token = "0x601760B")]
    [Address(RVA = "0x290057C", Offset = "0x290057C", VA = "0x290057C")]
    public void OnClickToSelectMaxAlert()
    {
    }

    [Token(Token = "0x601760C")]
    [Address(RVA = "0x2900700", Offset = "0x2900700", VA = "0x2900700")]
    public void OnClickToSaleItem(ItemListData itemListData)
    {
    }

    [Token(Token = "0x601760D")]
    [Address(RVA = "0x290089C", Offset = "0x290089C", VA = "0x290089C")]
    private void OpenSaleSetItemCountPopup(SaleSetItemCountPopup popup, ItemListData itemListData)
    {
    }

    [Token(Token = "0x601760E")]
    [Address(RVA = "0x2901004", Offset = "0x2901004", VA = "0x2901004")]
    private void OpenItemDetailPopup(
      ItemDetailPopup popup,
      ItemListData itemData,
      ShopLoader.ShopAssetType popupType)
    {
    }

    [Token(Token = "0x601760F")]
    [Address(RVA = "0x2901288", Offset = "0x2901288", VA = "0x2901288")]
    public void OnClickToCheckSale(bool isExchangeOnly = false)
    {
    }

    [Token(Token = "0x6017610")]
    [Address(RVA = "0x290142C", Offset = "0x290142C", VA = "0x290142C")]
    private void OpenCheckSalePopup(CheckSalePopup popup, bool isExchangeOnly)
    {
    }

    [Token(Token = "0x6017611")]
    [Address(RVA = "0x29016DC", Offset = "0x29016DC", VA = "0x29016DC")]
    private void OpenAfterSalePopup(int beforeZeny, int getZeny)
    {
    }

    [Token(Token = "0x6017612")]
    [Address(RVA = "0x2901858", Offset = "0x2901858", VA = "0x2901858")]
    private void OpenSaleAfterPopup(SaleAfterPopup popup, int beforeZeny, int getZeny)
    {
    }

    [Token(Token = "0x6017613")]
    [Address(RVA = "0x2901A9C", Offset = "0x2901A9C", VA = "0x2901A9C")]
    private void DestroyListObj()
    {
    }

    [Token(Token = "0x6017614")]
    [Address(RVA = "0x2900D80", Offset = "0x2900D80", VA = "0x2900D80")]
    private void OpenPopup(
      ShopLoader.ShopAssetType shopAssetType,
      PopupBase popup,
      Action finishCallback = null,
      ShopLoader.TimelineType timelineType = ShopLoader.TimelineType.CommonPopupIn)
    {
    }

    [Token(Token = "0x6017615")]
    [Address(RVA = "0x29021BC", Offset = "0x29021BC", VA = "0x29021BC")]
    private void ClosePopup(
      ShopLoader.ShopAssetType shopAssetType,
      PopupBase popup,
      Action finishCallback = null,
      ShopLoader.TimelineType timelineType = ShopLoader.TimelineType.CommonPopupOut)
    {
    }

    [Token(Token = "0x6017616")]
    [Address(RVA = "0x2902418", Offset = "0x2902418", VA = "0x2902418")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6017617")]
    [Address(RVA = "0x29024C0", Offset = "0x29024C0", VA = "0x29024C0", Slot = "7")]
    public override void Open(string preBelowName)
    {
    }

    [Token(Token = "0x6017618")]
    [Address(RVA = "0x29026C0", Offset = "0x29026C0", VA = "0x29026C0", Slot = "8")]
    public override void Close(string nextBelowName)
    {
    }

    [Token(Token = "0x6017619")]
    [Address(RVA = "0x29028F0", Offset = "0x29028F0", VA = "0x29028F0")]
    public void DummyCatalogOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x601761A")]
    [Address(RVA = "0x29028FC", Offset = "0x29028FC", VA = "0x29028FC")]
    private void UpdateJumpMove()
    {
    }

    [Token(Token = "0x601761B")]
    [Address(RVA = "0x2902990", Offset = "0x2902990", VA = "0x2902990")]
    private void SetJumpMove(float val)
    {
    }

    [Token(Token = "0x601761C")]
    [Address(RVA = "0x29029E4", Offset = "0x29029E4", VA = "0x29029E4")]
    private void ListLabelPlacement(Transform parent, RectTransform badge, RectTransform transfer)
    {
    }

    [Token(Token = "0x601761D")]
    [Address(RVA = "0x2902C1C", Offset = "0x2902C1C", VA = "0x2902C1C")]
    private void Update()
    {
    }

    [Token(Token = "0x601761E")]
    [Address(RVA = "0x2902434", Offset = "0x2902434", VA = "0x2902434")]
    private void DestroyObj()
    {
    }

    [Token(Token = "0x601761F")]
    [Address(RVA = "0x2902CA4", Offset = "0x2902CA4", VA = "0x2902CA4")]
    public GlobalSaleBelowScene()
    {
    }

    [Token(Token = "0x2003B69")]
    public class GlobalSaleBelowScreenParam : ChangeBelowScreenParameter
    {
      [Token(Token = "0x40106B9")]
      [FieldOffset(Offset = "0x18")]
      private ShopLoader shopLoader;
      [Token(Token = "0x40106BA")]
      [FieldOffset(Offset = "0x20")]
      private ShopAPIManager shopAPI;
      [Token(Token = "0x40106BB")]
      [FieldOffset(Offset = "0x28")]
      private AssetCachedSpawner cachedSpawner;
      [Token(Token = "0x40106BC")]
      [FieldOffset(Offset = "0x30")]
      private int nowShopIndex;
      [Token(Token = "0x40106BD")]
      [FieldOffset(Offset = "0x38")]
      private Action<bool> onSetSideButtonActive;
      [Token(Token = "0x40106BE")]
      [FieldOffset(Offset = "0x40")]
      private Action<int> onMoveMedalShop;

      [Token(Token = "0x17004C23")]
      public ShopLoader ShopLoader
      {
        [Token(Token = "0x6017625"), Address(RVA = "0x2903124", Offset = "0x2903124", VA = "0x2903124")] get
        {
          return (ShopLoader) null;
        }
      }

      [Token(Token = "0x17004C24")]
      public ShopAPIManager ShopAPI
      {
        [Token(Token = "0x6017626"), Address(RVA = "0x290312C", Offset = "0x290312C", VA = "0x290312C")] get
        {
          return (ShopAPIManager) null;
        }
      }

      [Token(Token = "0x17004C25")]
      public AssetCachedSpawner CachedSpawner
      {
        [Token(Token = "0x6017627"), Address(RVA = "0x2903134", Offset = "0x2903134", VA = "0x2903134")] get
        {
          return (AssetCachedSpawner) null;
        }
      }

      [Token(Token = "0x17004C26")]
      public int NowShopIndex
      {
        [Token(Token = "0x6017628"), Address(RVA = "0x290313C", Offset = "0x290313C", VA = "0x290313C")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17004C27")]
      public Action<bool> OnSetSideButtonActive
      {
        [Token(Token = "0x6017629"), Address(RVA = "0x2903144", Offset = "0x2903144", VA = "0x2903144")] get
        {
          return (Action<bool>) null;
        }
      }

      [Token(Token = "0x17004C28")]
      public Action<int> OnMoveMedalShop
      {
        [Token(Token = "0x601762A"), Address(RVA = "0x290314C", Offset = "0x290314C", VA = "0x290314C")] get
        {
          return (Action<int>) null;
        }
      }

      [Token(Token = "0x601762B")]
      [Address(RVA = "0x2903154", Offset = "0x2903154", VA = "0x2903154")]
      public GlobalSaleBelowScreenParam(
        int nowShopIndex,
        ShopLoader shopLoader,
        ShopAPIManager shopAPI,
        AssetCachedSpawner cachedSpawner,
        Action<bool> onSetSideButtonActive,
        Action<int> onMoveMedalShop)
      {
      }
    }

    [Token(Token = "0x2003B6A")]
    public enum CategoryItemType
    {
      [Token(Token = "0x40106C0")] Expendables,
      [Token(Token = "0x40106C1")] NurturingMaterial,
      [Token(Token = "0x40106C2")] Exchange,
      [Token(Token = "0x40106C3")] Story,
      [Token(Token = "0x40106C4")] Max,
    }
  }
}
