// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MedalShop.MedalShopListBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Data;
using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Network;
using Network.Param;
using Scenes.OutGame.OutGameMenu.GlobalShop;
using System;
using System.Collections;
using System.Collections.Generic;
using UI;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.MedalShop
{
  [Token(Token = "0x2003B0E")]
  public class MedalShopListBelowScreen : OutGameMenuBelowScreenBase
  {
    [Token(Token = "0x401046B")]
    [FieldOffset(Offset = "0x48")]
    private MedalShopLoader shopLoader;
    [Token(Token = "0x401046C")]
    [FieldOffset(Offset = "0x50")]
    private MedalShopApiManager apiManager;
    [Token(Token = "0x401046D")]
    [FieldOffset(Offset = "0x58")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x401046E")]
    [FieldOffset(Offset = "0x60")]
    private OutGameMenuSubScene.OutGameMenuID? backMenuId;
    [Token(Token = "0x401046F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x4010470")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image medalIcon;
    [Token(Token = "0x4010471")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject nothingObj;
    [Token(Token = "0x4010472")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x4010473")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private HorizontalLayoutGroup scrollLayout;
    [Token(Token = "0x4010474")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x4010475")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private RectTransform[] containers;
    [Token(Token = "0x4010476")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private RectTransform[] badges;
    [Token(Token = "0x4010477")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private RectTransform[] transfers;
    [Token(Token = "0x4010478")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Button[] buttons;
    [Token(Token = "0x4010479")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text leftButtonText;
    [Token(Token = "0x401047A")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text rightButtonText;
    [Token(Token = "0x401047B")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private AnimationCurve jumpMoveCurve;
    [Token(Token = "0x401047C")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private float jumpMoveTime;
    [Token(Token = "0x401047D")]
    [FieldOffset(Offset = "0xD4")]
    private float jumpMoveTimeCount;
    [Token(Token = "0x401047E")]
    [FieldOffset(Offset = "0xD8")]
    private float jumpMoveLen;
    [Token(Token = "0x401047F")]
    [FieldOffset(Offset = "0xDC")]
    private float jumpMoveSrcVal;
    [Token(Token = "0x4010480")]
    [FieldOffset(Offset = "0xE0")]
    private GameObject backSpaceObj;
    [Token(Token = "0x4010481")]
    private const float backSpaceObjSize = 600f;
    [Token(Token = "0x4010482")]
    [FieldOffset(Offset = "0xE8")]
    private Dictionary<int, List<GameObject>> createdGroupMap;
    [Token(Token = "0x4010483")]
    [FieldOffset(Offset = "0xF0")]
    private Dictionary<int, List<ShopItem>> createdShopItemMap;
    [Token(Token = "0x4010484")]
    [FieldOffset(Offset = "0xF8")]
    private Action<bool> onSetSideButtonActive;
    [Token(Token = "0x4010485")]
    [FieldOffset(Offset = "0x100")]
    private Action<int> onMoveMedalShop;
    [Token(Token = "0x4010486")]
    [FieldOffset(Offset = "0x108")]
    private GameObject baseItemGroupObject;
    [Token(Token = "0x4010487")]
    [FieldOffset(Offset = "0x110")]
    private GameObject baseShopItem;
    [Token(Token = "0x4010488")]
    [FieldOffset(Offset = "0x118")]
    private UITimelineController uiTimelineController;
    [Token(Token = "0x4010489")]
    [FieldOffset(Offset = "0x120")]
    private GameObject itemIconPrefab;
    [Token(Token = "0x401048A")]
    [FieldOffset(Offset = "0x128")]
    private GameObject itemIconTagPrefab;
    [Token(Token = "0x401048B")]
    [FieldOffset(Offset = "0x130")]
    private PosessionMedalList posessionMedalList;
    [Token(Token = "0x401048C")]
    [FieldOffset(Offset = "0x138")]
    private int medalShopId;
    [Token(Token = "0x401048D")]
    [FieldOffset(Offset = "0x13C")]
    private bool isSingleContainer;
    [Token(Token = "0x401048E")]
    [FieldOffset(Offset = "0x13D")]
    private bool isGotoMedalShop;
    [Token(Token = "0x401048F")]
    [FieldOffset(Offset = "0x140")]
    private List<int> medalShopIdList;
    [Token(Token = "0x4010490")]
    [FieldOffset(Offset = "0x148")]
    private int nowIdListIndex;
    [Token(Token = "0x4010491")]
    [FieldOffset(Offset = "0x14C")]
    private int selectedGlobalShopIndex;
    [Token(Token = "0x4010492")]
    [FieldOffset(Offset = "0x150")]
    private bool isPassShop;
    [Token(Token = "0x4010493")]
    [FieldOffset(Offset = "0x151")]
    private bool isUpdateLineup;
    [Token(Token = "0x4010494")]
    [FieldOffset(Offset = "0x152")]
    private bool isInitializeEnd;
    [Token(Token = "0x4010495")]
    [FieldOffset(Offset = "0x153")]
    private bool isOverlappingCheck;

    [Token(Token = "0x17004BD3")]
    private PosessionMedalList PosessionMedalList
    {
      [Token(Token = "0x60173CE"), Address(RVA = "0x27122B4", Offset = "0x27122B4", VA = "0x27122B4")] get
      {
        return (PosessionMedalList) null;
      }
    }

    [Token(Token = "0x60173CF")]
    [Address(RVA = "0x2712368", Offset = "0x2712368", VA = "0x2712368")]
    private void Awake()
    {
    }

    [Token(Token = "0x60173D0")]
    [Address(RVA = "0x271240C", Offset = "0x271240C", VA = "0x271240C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60173D1")]
    [Address(RVA = "0x2712A10", Offset = "0x2712A10", VA = "0x2712A10")]
    private void SetMedalShopIds()
    {
    }

    [Token(Token = "0x60173D2")]
    [Address(RVA = "0x2712C68", Offset = "0x2712C68", VA = "0x2712C68")]
    private void UpdateChangeButtonText()
    {
    }

    [Token(Token = "0x60173D3")]
    [Address(RVA = "0x2712FA4", Offset = "0x2712FA4", VA = "0x2712FA4")]
    public void SetHeaderText()
    {
    }

    [Token(Token = "0x60173D4")]
    [Address(RVA = "0x2713118", Offset = "0x2713118", VA = "0x2713118", Slot = "4")]
    public override void Initialize(ChangeBelowScreenParameter param = null)
    {
    }

    [Token(Token = "0x60173D5")]
    [Address(RVA = "0x27131FC", Offset = "0x27131FC", VA = "0x27131FC")]
    private void UpdateScrollData()
    {
    }

    [Token(Token = "0x60173D6")]
    [Address(RVA = "0x2713768", Offset = "0x2713768", VA = "0x2713768", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60173D7")]
    [Address(RVA = "0x27137F8", Offset = "0x27137F8", VA = "0x27137F8")]
    private IEnumerator SetupTimeline() => (IEnumerator) null;

    [Token(Token = "0x60173D8")]
    [Address(RVA = "0x2713888", Offset = "0x2713888", VA = "0x2713888")]
    private RectTransform GetContainer(int rarity) => (RectTransform) null;

    [Token(Token = "0x60173D9")]
    [Address(RVA = "0x2713740", Offset = "0x2713740", VA = "0x2713740")]
    private MedalShopListBelowScreen.RarityTabType ConvertRarity(RarityTypeEnum rarityType)
    {
      return new MedalShopListBelowScreen.RarityTabType();
    }

    [Token(Token = "0x60173DA")]
    [Address(RVA = "0x27138CC", Offset = "0x27138CC", VA = "0x27138CC")]
    public IEnumerator UpdateShop() => (IEnumerator) null;

    [Token(Token = "0x60173DB")]
    [Address(RVA = "0x271395C", Offset = "0x271395C", VA = "0x271395C")]
    public IEnumerator ConnectUpdateError(NetworkErrorResult errorResult) => (IEnumerator) null;

    [Token(Token = "0x60173DC")]
    [Address(RVA = "0x27139EC", Offset = "0x27139EC", VA = "0x27139EC")]
    private IEnumerator ConnectUpdateErrorInternal() => (IEnumerator) null;

    [Token(Token = "0x60173DD")]
    [Address(RVA = "0x2713A7C", Offset = "0x2713A7C", VA = "0x2713A7C")]
    private IEnumerator OpenItemPurchasePopup(
      ShopItem.ProductItemType itemType,
      CommonShopItemData commonShopItem)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60173DE")]
    [Address(RVA = "0x2713B20", Offset = "0x2713B20", VA = "0x2713B20")]
    private IEnumerator UnreceivedRewardsCheck(List<Reward> unreceivedRewards, Action OnClickClose)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60173DF")]
    [Address(RVA = "0x2713BC4", Offset = "0x2713BC4", VA = "0x2713BC4")]
    public void OnClickShopItem(
      ShopItem.ProductItemType itemType,
      CommonShopItemData commonShopItem)
    {
    }

    [Token(Token = "0x60173E0")]
    [Address(RVA = "0x2713C74", Offset = "0x2713C74", VA = "0x2713C74")]
    private IEnumerator OpenAfterPuchasePopupInternal(
      ItemPurchaseData itemPurchaseData,
      int purchaseCount,
      bool isConvertCheck,
      Action OnClickClose)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60173E1")]
    [Address(RVA = "0x2713D34", Offset = "0x2713D34", VA = "0x2713D34")]
    private void OpenAfterPurchasePopup(
      ItemPurchaseData itemPurchaseData,
      int purchaseCount,
      bool isConvertCheck,
      Action OnClickClose)
    {
    }

    [Token(Token = "0x60173E2")]
    [Address(RVA = "0x2713D58", Offset = "0x2713D58", VA = "0x2713D58")]
    private IEnumerator OpenItemDetailPopupInternal(ItemPurchaseData.ItemRewardData rewardData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60173E3")]
    [Address(RVA = "0x2713DF4", Offset = "0x2713DF4", VA = "0x2713DF4")]
    private void OpenItemDetailPopup(ItemPurchaseData.ItemRewardData rewardData)
    {
    }

    [Token(Token = "0x60173E4")]
    [Address(RVA = "0x2713E50", Offset = "0x2713E50", VA = "0x2713E50")]
    private void OpenOtherDetailPopup(ItemPurchaseData.ItemRewardData rewardData)
    {
    }

    [Token(Token = "0x60173E5")]
    [Address(RVA = "0x2714050", Offset = "0x2714050", VA = "0x2714050")]
    public void OnClickToLeftArrow()
    {
    }

    [Token(Token = "0x60173E6")]
    [Address(RVA = "0x2714224", Offset = "0x2714224", VA = "0x2714224")]
    public void OnClickToRightArrow()
    {
    }

    [Token(Token = "0x60173E7")]
    [Address(RVA = "0x27143EC", Offset = "0x27143EC", VA = "0x27143EC", Slot = "7")]
    public override void Open(string preBelowName)
    {
    }

    [Token(Token = "0x60173E8")]
    [Address(RVA = "0x27145DC", Offset = "0x27145DC", VA = "0x27145DC", Slot = "8")]
    public override void Close(string nextBelowName)
    {
    }

    [Token(Token = "0x60173E9")]
    [Address(RVA = "0x2714870", Offset = "0x2714870", VA = "0x2714870")]
    private IEnumerator TimelineSetting(UITimelineController controller, Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60173EA")]
    [Address(RVA = "0x271490C", Offset = "0x271490C", VA = "0x271490C")]
    private void OpenPopup(
      MedalShopLoader.ShopAssetType shopAssetType,
      PopupBase popup,
      MedalShopLoader.TimelineType timelineType = MedalShopLoader.TimelineType.CommonPopupIn,
      Action onFinishAction = null)
    {
    }

    [Token(Token = "0x60173EB")]
    [Address(RVA = "0x2714B9C", Offset = "0x2714B9C", VA = "0x2714B9C")]
    private void ClosePopup(
      MedalShopLoader.ShopAssetType shopAssetType,
      PopupBase popup,
      MedalShopLoader.TimelineType timelineType = MedalShopLoader.TimelineType.CommonPopupOut,
      Action onFinish = null)
    {
    }

    [Token(Token = "0x60173EC")]
    [Address(RVA = "0x2714E14", Offset = "0x2714E14", VA = "0x2714E14")]
    public void DummyCatalogOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x60173ED")]
    [Address(RVA = "0x2714E20", Offset = "0x2714E20", VA = "0x2714E20")]
    private void UpdateJumpMove()
    {
    }

    [Token(Token = "0x60173EE")]
    [Address(RVA = "0x2714EAC", Offset = "0x2714EAC", VA = "0x2714EAC")]
    private void SetJumpMove(float val)
    {
    }

    [Token(Token = "0x60173EF")]
    [Address(RVA = "0x2714F00", Offset = "0x2714F00", VA = "0x2714F00")]
    private void ListLabelPlacement(Transform parent, RectTransform badge, RectTransform transfer)
    {
    }

    [Token(Token = "0x60173F0")]
    [Address(RVA = "0x27151BC", Offset = "0x27151BC", VA = "0x27151BC")]
    private void Update()
    {
    }

    [Token(Token = "0x60173F1")]
    [Address(RVA = "0x271524C", Offset = "0x271524C", VA = "0x271524C", Slot = "10")]
    public override void SetBackSpace()
    {
    }

    [Token(Token = "0x60173F2")]
    [Address(RVA = "0x27153E8", Offset = "0x27153E8", VA = "0x27153E8")]
    public MedalShopListBelowScreen()
    {
    }

    [Token(Token = "0x2003B0F")]
    public class MedalShopBelowListScreenParameter : ChangeBelowScreenParameter
    {
      [Token(Token = "0x4010498")]
      [FieldOffset(Offset = "0x20")]
      private AssetCachedSpawner cachedSpawner;
      [Token(Token = "0x4010499")]
      [FieldOffset(Offset = "0x28")]
      private int nowShopIndex;
      [Token(Token = "0x401049A")]
      [FieldOffset(Offset = "0x2C")]
      private bool isPassShop;
      [Token(Token = "0x401049D")]
      [FieldOffset(Offset = "0x40")]
      private Action<bool> onSetSideButtonActive;
      [Token(Token = "0x401049E")]
      [FieldOffset(Offset = "0x48")]
      private Action<int> onMoveMedalShop;

      [Token(Token = "0x17004BD4")]
      public OutGameMenuSubScene.OutGameMenuID? BackMenuID
      {
        [Token(Token = "0x6017400"), Address(RVA = "0x2715F24", Offset = "0x2715F24", VA = "0x2715F24")] get
        {
          return new OutGameMenuSubScene.OutGameMenuID?();
        }
        [Token(Token = "0x6017401"), Address(RVA = "0x2715F2C", Offset = "0x2715F2C", VA = "0x2715F2C")] private set
        {
        }
      }

      [Token(Token = "0x17004BD5")]
      public bool IsGotoMedalShop
      {
        [Token(Token = "0x6017402"), Address(RVA = "0x2715F34", Offset = "0x2715F34", VA = "0x2715F34")] get
        {
          return new bool();
        }
        [Token(Token = "0x6017403"), Address(RVA = "0x2715F3C", Offset = "0x2715F3C", VA = "0x2715F3C")] private set
        {
        }
      }

      [Token(Token = "0x17004BD6")]
      public AssetCachedSpawner CachedSpawner
      {
        [Token(Token = "0x6017404"), Address(RVA = "0x2715F48", Offset = "0x2715F48", VA = "0x2715F48")] get
        {
          return (AssetCachedSpawner) null;
        }
      }

      [Token(Token = "0x17004BD7")]
      public int NowShopIndex
      {
        [Token(Token = "0x6017405"), Address(RVA = "0x2715F50", Offset = "0x2715F50", VA = "0x2715F50")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17004BD8")]
      public bool IsPassShop
      {
        [Token(Token = "0x6017406"), Address(RVA = "0x2715F58", Offset = "0x2715F58", VA = "0x2715F58")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17004BD9")]
      public int MedalShopID
      {
        [Token(Token = "0x6017407"), Address(RVA = "0x2715F60", Offset = "0x2715F60", VA = "0x2715F60")] get
        {
          return new int();
        }
        [Token(Token = "0x6017408"), Address(RVA = "0x2715F68", Offset = "0x2715F68", VA = "0x2715F68")] private set
        {
        }
      }

      [Token(Token = "0x17004BDA")]
      public MedalShopLoader Loader
      {
        [Token(Token = "0x6017409"), Address(RVA = "0x2715F70", Offset = "0x2715F70", VA = "0x2715F70")] get
        {
          return (MedalShopLoader) null;
        }
        [Token(Token = "0x601740A"), Address(RVA = "0x2715F78", Offset = "0x2715F78", VA = "0x2715F78")] private set
        {
        }
      }

      [Token(Token = "0x17004BDB")]
      public Action<bool> OnSetSideButtonActive
      {
        [Token(Token = "0x601740B"), Address(RVA = "0x2715F80", Offset = "0x2715F80", VA = "0x2715F80")] get
        {
          return (Action<bool>) null;
        }
      }

      [Token(Token = "0x17004BDC")]
      public Action<int> OnMoveMedalShop
      {
        [Token(Token = "0x601740C"), Address(RVA = "0x2715F88", Offset = "0x2715F88", VA = "0x2715F88")] get
        {
          return (Action<int>) null;
        }
      }

      [Token(Token = "0x601740D")]
      [Address(RVA = "0x2715F90", Offset = "0x2715F90", VA = "0x2715F90")]
      public MedalShopBelowListScreenParameter(
        bool isGotoMedalShop,
        int medalShopId,
        AssetCachedSpawner cachedSpawner,
        Action<bool> onSetSideButtonActive,
        Action<int> onMoveMedalShop,
        OutGameMenuSubScene.OutGameMenuID? backMenuId,
        MedalShopLoader loader = null)
      {
      }

      [Token(Token = "0x601740E")]
      [Address(RVA = "0x2716048", Offset = "0x2716048", VA = "0x2716048")]
      public MedalShopBelowListScreenParameter(
        int shopListIndex,
        bool isPassShop,
        bool isGotoMedalShop,
        int medalShopId,
        AssetCachedSpawner cachedSpawner,
        Action<bool> onSetSideButtonActive,
        Action<int> onMoveMedalShop,
        OutGameMenuSubScene.OutGameMenuID? backMenuId,
        MedalShopLoader loader = null)
      {
      }
    }

    [Token(Token = "0x2003B10")]
    public enum RarityTabType
    {
      [Token(Token = "0x40104A0")] UR,
      [Token(Token = "0x40104A1")] SSR,
      [Token(Token = "0x40104A2")] SR,
      [Token(Token = "0x40104A3")] R,
      [Token(Token = "0x40104A4")] N,
      [Token(Token = "0x40104A5")] MAX,
    }
  }
}
