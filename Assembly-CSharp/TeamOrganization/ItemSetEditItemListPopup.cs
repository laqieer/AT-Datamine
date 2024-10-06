// Decompiled with JetBrains decompiler
// Type: TeamOrganization.ItemSetEditItemListPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000778")]
  public class ItemSetEditItemListPopup : MonoBehaviour
  {
    [Token(Token = "0x4002215")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002216")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x4002217")]
    [FieldOffset(Offset = "0x28")]
    private Action closeAction;
    [Token(Token = "0x4002218")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x4002219")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x400221A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Transform recoveryThumbParent;
    [Token(Token = "0x400221B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform buffThumbParent;
    [Token(Token = "0x400221C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject srcRecoveryThumbGroup;
    [Token(Token = "0x400221D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject srcBuffThumbGroup;
    [Token(Token = "0x400221E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject recoveryNothing;
    [Token(Token = "0x400221F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject buffNothing;
    [Token(Token = "0x4002220")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private RectTransform recoveryBadge;
    [Token(Token = "0x4002221")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private RectTransform buffBadge;
    [Token(Token = "0x4002222")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private RectTransform recoveryLabelTransfer;
    [Token(Token = "0x4002223")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RectTransform buffLabelTransfer;
    [Token(Token = "0x4002224")]
    public const int BaseEntryMax = 3;
    [Token(Token = "0x4002225")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Button fillterButton;
    [Token(Token = "0x4002226")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Button recoveryButton;
    [Token(Token = "0x4002227")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Button buffButton;
    [Token(Token = "0x4002228")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject selectButtonsObject;
    [Token(Token = "0x4002229")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject changeButtonObject;
    [Token(Token = "0x400222A")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject removeButtonObject;
    [Token(Token = "0x400222B")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text changeButtonText;
    [Token(Token = "0x400222C")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400222D")]
    [FieldOffset(Offset = "0xC8")]
    private readonly string[] thumbBaseAssetName;
    [Token(Token = "0x400222E")]
    [FieldOffset(Offset = "0xD0")]
    private List<string>[] loadWaitItemId;
    [Token(Token = "0x400222F")]
    [FieldOffset(Offset = "0xD8")]
    private int loadWaitItemIdOfs;
    [Token(Token = "0x4002230")]
    [FieldOffset(Offset = "0xE0")]
    private Coroutine loadThumbAssetBundleCoroutine;
    [Token(Token = "0x4002231")]
    [FieldOffset(Offset = "0xE8")]
    private List<Expendable> recoveryItemList;
    [Token(Token = "0x4002232")]
    [FieldOffset(Offset = "0xF0")]
    private List<Expendable> buffItemList;
    [Token(Token = "0x4002233")]
    [FieldOffset(Offset = "0xF8")]
    private List<ItemListThumbIconElement> recoveryBaseList;
    [Token(Token = "0x4002234")]
    [FieldOffset(Offset = "0x100")]
    private List<ItemListThumbIconElement> buffBaseList;
    [Token(Token = "0x4002235")]
    [FieldOffset(Offset = "0x108")]
    private GameObject backSpaceObj;
    [Token(Token = "0x4002236")]
    private const float backSpaceObjSize = 280f;
    [Token(Token = "0x4002237")]
    private const float backSpaceObjSize_0 = 926f;
    [Token(Token = "0x4002238")]
    private const float backSpaceObjSize_Add0 = 75f;
    [Token(Token = "0x4002239")]
    private const float backSpaceObjSize_Add1 = 44f;
    [Token(Token = "0x400223A")]
    [FieldOffset(Offset = "0x110")]
    private float jumpMoveTimeCount;
    [Token(Token = "0x400223B")]
    [FieldOffset(Offset = "0x114")]
    private float jumpMoveLen;
    [Token(Token = "0x400223C")]
    [FieldOffset(Offset = "0x118")]
    private float jumpMoveSrcVal;
    [Token(Token = "0x400223D")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private AnimationCurve jumpMoveCurve;
    [Token(Token = "0x400223E")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private float jumpMoveTime;
    [Token(Token = "0x400223F")]
    [FieldOffset(Offset = "0x12C")]
    public float screenDiff;
    [Token(Token = "0x4002240")]
    [FieldOffset(Offset = "0x130")]
    private int selectItemIndex;
    [Token(Token = "0x4002241")]
    [FieldOffset(Offset = "0x138")]
    private Expendable selectItemsetItem;
    [Token(Token = "0x4002242")]
    [FieldOffset(Offset = "0x140")]
    private bool isSelectListItem;
    [Token(Token = "0x4002243")]
    [FieldOffset(Offset = "0x144")]
    private int selectListItemIndex;
    [Token(Token = "0x4002244")]
    [FieldOffset(Offset = "0x148")]
    private ItemSetThumb selectListThumb;
    [Token(Token = "0x4002246")]
    [FieldOffset(Offset = "0x158")]
    private Action<Expendable> onChangeItemAction;
    [Token(Token = "0x4002247")]
    [FieldOffset(Offset = "0x160")]
    private Action onRemoveItemAction;
    [Token(Token = "0x4002248")]
    [FieldOffset(Offset = "0x168")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x4002249")]
    [FieldOffset(Offset = "0x170")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x17000644")]
    public List<int> setItemIdList
    {
      [Token(Token = "0x60029A9"), Address(RVA = "0x34F81E4", Offset = "0x34F81E4", VA = "0x34F81E4")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x60029AA"), Address(RVA = "0x34F81EC", Offset = "0x34F81EC", VA = "0x34F81EC")] private set
      {
      }
    }

    [Token(Token = "0x60029AB")]
    [Address(RVA = "0x34F81F4", Offset = "0x34F81F4", VA = "0x34F81F4")]
    public void Initialized(Action closeAction, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60029AC")]
    [Address(RVA = "0x34F8614", Offset = "0x34F8614", VA = "0x34F8614")]
    public void Open(int selectItemIndex, Expendable selectItemsetItem, List<int> setItemIdList)
    {
    }

    [Token(Token = "0x60029AD")]
    [Address(RVA = "0x34F8F38", Offset = "0x34F8F38", VA = "0x34F8F38")]
    public void Close()
    {
    }

    [Token(Token = "0x60029AE")]
    [Address(RVA = "0x34F9018", Offset = "0x34F9018", VA = "0x34F9018")]
    private void FinishedClose()
    {
    }

    [Token(Token = "0x60029AF")]
    [Address(RVA = "0x34F90C0", Offset = "0x34F90C0", VA = "0x34F90C0")]
    public void SetOnButtonAction(Action<Expendable> onChange, Action onRemove)
    {
    }

    [Token(Token = "0x60029B0")]
    [Address(RVA = "0x34F90C8", Offset = "0x34F90C8", VA = "0x34F90C8")]
    public void ThumbnailOnClickChange()
    {
    }

    [Token(Token = "0x60029B1")]
    [Address(RVA = "0x34F9144", Offset = "0x34F9144", VA = "0x34F9144")]
    public void ThumbnailOnClickDetail()
    {
    }

    [Token(Token = "0x60029B2")]
    [Address(RVA = "0x34F91A8", Offset = "0x34F91A8", VA = "0x34F91A8")]
    private IEnumerator OpenItemDetailAsync(ItemTypeEnum itemTypeEnum, int itemId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60029B3")]
    [Address(RVA = "0x34F924C", Offset = "0x34F924C", VA = "0x34F924C")]
    public void ThumbnailOnClickSelect(
      int index,
      ItemSetEditItemListPopup.eItemListKind kind,
      ItemSetThumb thumb)
    {
    }

    [Token(Token = "0x60029B4")]
    [Address(RVA = "0x34F9718", Offset = "0x34F9718", VA = "0x34F9718")]
    public void ChangeSelectItemSetItem(int selectItemIndex, Expendable selectItemsetItem)
    {
    }

    [Token(Token = "0x60029B5")]
    [Address(RVA = "0x34F998C", Offset = "0x34F998C", VA = "0x34F998C")]
    public void ItemListOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x60029B6")]
    [Address(RVA = "0x34F9BB8", Offset = "0x34F9BB8", VA = "0x34F9BB8")]
    public void UpdateItemList()
    {
    }

    [Token(Token = "0x60029B7")]
    [Address(RVA = "0x34F8860", Offset = "0x34F8860", VA = "0x34F8860")]
    private void CreateItemList()
    {
    }

    [Token(Token = "0x60029B8")]
    [Address(RVA = "0x34FA0BC", Offset = "0x34FA0BC", VA = "0x34FA0BC")]
    private int SortAmount(Expendable a, Expendable b) => new int();

    [Token(Token = "0x60029B9")]
    [Address(RVA = "0x34F8BF4", Offset = "0x34F8BF4", VA = "0x34F8BF4")]
    private void SetItemList()
    {
    }

    [Token(Token = "0x60029BA")]
    [Address(RVA = "0x34F9F78", Offset = "0x34F9F78", VA = "0x34F9F78")]
    public void SetBackSpace()
    {
    }

    [Token(Token = "0x60029BB")]
    [Address(RVA = "0x34F7CBC", Offset = "0x34F7CBC", VA = "0x34F7CBC")]
    public Expendable GetItemList(int idx, ItemSetEditItemListPopup.eItemListKind kind)
    {
      return (Expendable) null;
    }

    [Token(Token = "0x60029BC")]
    [Address(RVA = "0x34FA0F4", Offset = "0x34FA0F4", VA = "0x34FA0F4")]
    public Sprite GetRarityBaseImage(RarityTypeEnum rarity) => (Sprite) null;

    [Token(Token = "0x60029BD")]
    [Address(RVA = "0x34FA1CC", Offset = "0x34FA1CC", VA = "0x34FA1CC")]
    public string GetThumbAssetBundleName(int index, ItemSetEditItemListPopup.eItemListKind kind)
    {
      return (string) null;
    }

    [Token(Token = "0x60029BE")]
    [Address(RVA = "0x34FA2A0", Offset = "0x34FA2A0", VA = "0x34FA2A0")]
    public string GetThumbAssetName(int index, ItemSetEditItemListPopup.eItemListKind kind)
    {
      return (string) null;
    }

    [Token(Token = "0x60029BF")]
    [Address(RVA = "0x34F8078", Offset = "0x34F8078", VA = "0x34F8078")]
    public bool isView(ItemListThumbIconElement thumb) => new bool();

    [Token(Token = "0x60029C0")]
    [Address(RVA = "0x34FA374", Offset = "0x34FA374", VA = "0x34FA374")]
    public void AddThumbAssetBundle(int index, ItemSetEditItemListPopup.eItemListKind kind)
    {
    }

    [Token(Token = "0x60029C1")]
    [Address(RVA = "0x34F87F8", Offset = "0x34F87F8", VA = "0x34F87F8")]
    public IEnumerator SetLoadThumbAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x60029C2")]
    [Address(RVA = "0x34FA494", Offset = "0x34FA494", VA = "0x34FA494")]
    private void Update()
    {
    }

    [Token(Token = "0x60029C3")]
    [Address(RVA = "0x34FA750", Offset = "0x34FA750", VA = "0x34FA750")]
    private void SetJumpMove(float val)
    {
    }

    [Token(Token = "0x60029C4")]
    [Address(RVA = "0x34FA54C", Offset = "0x34FA54C", VA = "0x34FA54C")]
    private void ListLabelPlacement(Transform parent, RectTransform badge, RectTransform transfer)
    {
    }

    [Token(Token = "0x60029C5")]
    [Address(RVA = "0x34FA7A8", Offset = "0x34FA7A8", VA = "0x34FA7A8")]
    public ItemSetEditItemListPopup()
    {
    }

    [Token(Token = "0x2000779")]
    public enum eFillterKind
    {
      [Token(Token = "0x400224C")] Error,
      [Token(Token = "0x400224B")] Recovery,
    }

    [Token(Token = "0x200077A")]
    public enum eThumbAssetBundleNameIndex
    {
      [Token(Token = "0x400224E")] Expendable,
    }

    [Token(Token = "0x200077B")]
    public enum eItemListKind
    {
      [Token(Token = "0x4002250")] Recovery,
      [Token(Token = "0x4002251")] Buff,
    }
  }
}
