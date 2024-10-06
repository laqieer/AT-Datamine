// Decompiled with JetBrains decompiler
// Type: Scenes.Story.ChapterShop.ChapterBuyContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.ChapterShop
{
  [Token(Token = "0x2002EED")]
  public class ChapterBuyContainer : MonoBehaviour
  {
    [Token(Token = "0x400C90D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ChapterShopItemList[] singleItemList;
    [Token(Token = "0x400C90E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400C90F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private HorizontalLayoutGroup scrollLayout;
    [Token(Token = "0x400C910")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x400C911")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RectTransform selfRectTransform;
    [Token(Token = "0x400C912")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI nowCategoryText;
    [Token(Token = "0x400C913")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI shopLevelText;
    [Token(Token = "0x400C914")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private RectTransform benefitsParent;
    [Token(Token = "0x400C915")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private BenefitsItem benefitsBaseItem;
    [Token(Token = "0x400C916")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI chapterCoinNum;
    [Token(Token = "0x400C917")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI[] filterButtonNames;
    [Token(Token = "0x400C918")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private RectTransform[] badges;
    [Token(Token = "0x400C919")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private RectTransform[] transfers;
    [Token(Token = "0x400C91A")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private AnimationCurve jumpMoveCurve;
    [Token(Token = "0x400C91B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private float jumpMoveTime;
    [Token(Token = "0x400C91C")]
    [FieldOffset(Offset = "0x8C")]
    private float jumpMoveTimeCount;
    [Token(Token = "0x400C91D")]
    [FieldOffset(Offset = "0x90")]
    private float jumpMoveLen;
    [Token(Token = "0x400C91E")]
    [FieldOffset(Offset = "0x94")]
    private float jumpMoveSrcVal;
    [Token(Token = "0x400C91F")]
    [FieldOffset(Offset = "0x98")]
    private GameObject backSpaceObj;
    [Token(Token = "0x400C920")]
    private const float backSpaceObjSize = 1000f;
    [Token(Token = "0x400C921")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private UISafeAreaInsets safeArea;
    [Token(Token = "0x400C922")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI headerCommuNameText;
    [Token(Token = "0x400C923")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject benefitsNothingObj;
    [Token(Token = "0x400C924")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject shopChangeObject;
    [Token(Token = "0x400C925")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private TextMeshProUGUI shopChangeTxt;
    [Token(Token = "0x400C929")]
    [FieldOffset(Offset = "0xE0")]
    private Dictionary<ShopTypeEnum, int> typeToCharaIdMap;
    [Token(Token = "0x400C92A")]
    [FieldOffset(Offset = "0xE8")]
    private List<ChapterShopData> chapterShopDataList;
    [Token(Token = "0x400C92B")]
    [FieldOffset(Offset = "0xF0")]
    private Dictionary<int, List<ChapterShopData>> itemFilterMap;
    [Token(Token = "0x400C92C")]
    [FieldOffset(Offset = "0xF8")]
    private List<BenefitsItem> createdBenefitsItemList;
    [Token(Token = "0x400C92D")]
    [FieldOffset(Offset = "0x100")]
    private RewardTypeEnum[] rewardTypes;

    [Token(Token = "0x17003E2D")]
    public RectTransform SelfRectTransform
    {
      [Token(Token = "0x6012541"), Address(RVA = "0x22F72B8", Offset = "0x22F72B8", VA = "0x22F72B8")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003E2E")]
    public UISafeAreaInsets SafeArea
    {
      [Token(Token = "0x6012542"), Address(RVA = "0x22F72C0", Offset = "0x22F72C0", VA = "0x22F72C0")] get
      {
        return (UISafeAreaInsets) null;
      }
    }

    [Token(Token = "0x17003E2F")]
    public Action<ChapterShopItem.ShopItemType, ChapterShopData> OnClickToItemIcon
    {
      [Token(Token = "0x6012543"), Address(RVA = "0x22F72C8", Offset = "0x22F72C8", VA = "0x22F72C8")] get
      {
        return (Action<ChapterShopItem.ShopItemType, ChapterShopData>) null;
      }
      [Token(Token = "0x6012544"), Address(RVA = "0x22F72D0", Offset = "0x22F72D0", VA = "0x22F72D0")] set
      {
      }
    }

    [Token(Token = "0x17003E30")]
    public Action<ChapterShopData> OnClickDescriptionAction
    {
      [Token(Token = "0x6012545"), Address(RVA = "0x22F72D8", Offset = "0x22F72D8", VA = "0x22F72D8")] get
      {
        return (Action<ChapterShopData>) null;
      }
      [Token(Token = "0x6012546"), Address(RVA = "0x22F72E0", Offset = "0x22F72E0", VA = "0x22F72E0")] set
      {
      }
    }

    [Token(Token = "0x17003E31")]
    public Action OnClickChangeShopAction
    {
      [Token(Token = "0x6012547"), Address(RVA = "0x22F72E8", Offset = "0x22F72E8", VA = "0x22F72E8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6012548"), Address(RVA = "0x22F72F0", Offset = "0x22F72F0", VA = "0x22F72F0")] set
      {
      }
    }

    [Token(Token = "0x17003E32")]
    public Dictionary<ShopTypeEnum, int> TypeToCharaIdMap
    {
      [Token(Token = "0x6012549"), Address(RVA = "0x22F72F8", Offset = "0x22F72F8", VA = "0x22F72F8")] get
      {
        return (Dictionary<ShopTypeEnum, int>) null;
      }
    }

    [Token(Token = "0x601254A")]
    [Address(RVA = "0x22F7300", Offset = "0x22F7300", VA = "0x22F7300")]
    public void SetListItemPrefab(GameObject shopSingleItemBase)
    {
    }

    [Token(Token = "0x601254B")]
    [Address(RVA = "0x22F7350", Offset = "0x22F7350", VA = "0x22F7350")]
    public void SetAssetLoader(ChapterShopLoader loader)
    {
    }

    [Token(Token = "0x601254C")]
    [Address(RVA = "0x22F73A0", Offset = "0x22F73A0", VA = "0x22F73A0")]
    public void OnClickToChangeShop()
    {
    }

    [Token(Token = "0x601254D")]
    [Address(RVA = "0x22F73BC", Offset = "0x22F73BC", VA = "0x22F73BC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601254E")]
    [Address(RVA = "0x22F758C", Offset = "0x22F758C", VA = "0x22F758C")]
    private void CreateBenefitsList(string[] benefitsList)
    {
    }

    [Token(Token = "0x601254F")]
    [Address(RVA = "0x22F7908", Offset = "0x22F7908", VA = "0x22F7908")]
    public void UpdateCurrencyItem()
    {
    }

    [Token(Token = "0x6012550")]
    [Address(RVA = "0x22F798C", Offset = "0x22F798C", VA = "0x22F798C")]
    public void SetChapterShopName(ShopTypeEnum shopType, string characterName)
    {
    }

    [Token(Token = "0x6012551")]
    [Address(RVA = "0x22F7A40", Offset = "0x22F7A40", VA = "0x22F7A40")]
    private string GetChapterShopName(ShopTypeEnum shopType, string characterName) => (string) null;

    [Token(Token = "0x6012552")]
    [Address(RVA = "0x22F7B2C", Offset = "0x22F7B2C", VA = "0x22F7B2C")]
    public void SetOutGameViewing(ChapterShopType chapterShopType, ShopTypeEnum nowShopType)
    {
    }

    [Token(Token = "0x6012553")]
    [Address(RVA = "0x22F7C78", Offset = "0x22F7C78", VA = "0x22F7C78")]
    public void Initialize(List<ChapterShopData> chapterShopDataList, bool isUpdate = false)
    {
    }

    [Token(Token = "0x6012554")]
    [Address(RVA = "0x22F94FC", Offset = "0x22F94FC", VA = "0x22F94FC")]
    public void OnClickFilterButton(int keyIndex)
    {
    }

    [Token(Token = "0x6012555")]
    [Address(RVA = "0x22F9590", Offset = "0x22F9590", VA = "0x22F9590")]
    public void OnClickToFilter(int targetCategory)
    {
    }

    [Token(Token = "0x6012556")]
    [Address(RVA = "0x22F9708", Offset = "0x22F9708", VA = "0x22F9708")]
    public void OnClickToBack()
    {
    }

    [Token(Token = "0x6012557")]
    [Address(RVA = "0x22F9828", Offset = "0x22F9828", VA = "0x22F9828")]
    public void OnOpenToGlobalMenu()
    {
    }

    [Token(Token = "0x6012558")]
    [Address(RVA = "0x22F98EC", Offset = "0x22F98EC", VA = "0x22F98EC")]
    private void UpdateJumpMove()
    {
    }

    [Token(Token = "0x6012559")]
    [Address(RVA = "0x22F96B8", Offset = "0x22F96B8", VA = "0x22F96B8")]
    private void SetJumpMove(float val)
    {
    }

    [Token(Token = "0x601255A")]
    [Address(RVA = "0x22F9970", Offset = "0x22F9970", VA = "0x22F9970")]
    private void ListLabelPlacement(Transform parent, RectTransform badge, RectTransform transfer)
    {
    }

    [Token(Token = "0x601255B")]
    [Address(RVA = "0x22F9BA8", Offset = "0x22F9BA8", VA = "0x22F9BA8")]
    private void Update()
    {
    }

    [Token(Token = "0x601255C")]
    [Address(RVA = "0x22F9360", Offset = "0x22F9360", VA = "0x22F9360")]
    public void SetBackSpace()
    {
    }

    [Token(Token = "0x601255D")]
    [Address(RVA = "0x22F9C48", Offset = "0x22F9C48", VA = "0x22F9C48")]
    public ChapterBuyContainer()
    {
    }
  }
}
