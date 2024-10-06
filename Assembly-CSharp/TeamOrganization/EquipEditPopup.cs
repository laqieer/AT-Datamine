// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipEditPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Equipment.UI;
using Scenes.OutGame.Utility;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007AD")]
  public class EquipEditPopup : MonoBehaviour
  {
    [Token(Token = "0x40023BB")]
    private const string WeaponProficiencyAssetbundleName = "ui_page_partylist_weaponproficiency";
    [Token(Token = "0x40023BC")]
    private const string WeaponProficiencyPopupName = "Com_Popup_WeaponProficiency_Equip";
    [Token(Token = "0x40023BD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup canvas;
    [Token(Token = "0x40023BE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40023BF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x40023C0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform thumbParent;
    [Token(Token = "0x40023C1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private HorizontalGridInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x40023C2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject srcBase;
    [Token(Token = "0x40023C3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private EquipParameterViewBase equipParameterViewBase;
    [Token(Token = "0x40023C4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton sortFilterButton;
    [Token(Token = "0x40023C5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x40023C6")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private float sizePerThumb;
    [Token(Token = "0x40023C7")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject selectButtonsObject;
    [Token(Token = "0x40023C8")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject changeButtonObject;
    [Token(Token = "0x40023C9")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject removeButtonObject;
    [Token(Token = "0x40023CA")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text selectButtonText;
    [Token(Token = "0x40023CB")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private WeaponTypeIcon weaponTypeIcon;
    [Token(Token = "0x40023CC")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private EnableEquipmentClassificationView classificationView;
    [Token(Token = "0x40023CD")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject nothingObject;
    [Token(Token = "0x40023CE")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40023CF")]
    public const int ItemEntryMax = 3;
    [Token(Token = "0x40023D0")]
    [FieldOffset(Offset = "0xA8")]
    private float itemSizeW;
    [Token(Token = "0x40023D1")]
    [FieldOffset(Offset = "0xAC")]
    private float itemSizeH;
    [Token(Token = "0x40023D2")]
    [FieldOffset(Offset = "0xB0")]
    private float itemMarginW;
    [Token(Token = "0x40023D3")]
    [FieldOffset(Offset = "0xB4")]
    private float itemMarginH;
    [Token(Token = "0x40023D4")]
    private const float TopMargin = 166f;
    [Token(Token = "0x40023D5")]
    private const float EndMargin = 240f;
    [Token(Token = "0x40023D6")]
    [FieldOffset(Offset = "0xB8")]
    private Coroutine loadAssetBundleCoroutine;
    [Token(Token = "0x40023D7")]
    [FieldOffset(Offset = "0xC0")]
    private List<EquipEditPopup.ThumbData> equipList;
    [Token(Token = "0x40023D8")]
    [FieldOffset(Offset = "0xC8")]
    private List<EquipThumb> equipThumbList;
    [Token(Token = "0x40023D9")]
    [FieldOffset(Offset = "0xD0")]
    private GameObject weaponProficiencyPopupPrefab;
    [Token(Token = "0x40023DA")]
    [FieldOffset(Offset = "0xD8")]
    private WeaponProficiencyPopup weaponProficiencyPopup;
    [Token(Token = "0x40023DB")]
    [FieldOffset(Offset = "0xE0")]
    private List<int>[] loadWaitId;
    [Token(Token = "0x40023DC")]
    [FieldOffset(Offset = "0xE8")]
    private int loadWaitIdOfs;
    [Token(Token = "0x40023DD")]
    [FieldOffset(Offset = "0xF0")]
    private StaqData.Equipment currentEquip;
    [Token(Token = "0x40023DE")]
    [FieldOffset(Offset = "0xF8")]
    private int selectSlotIndex;
    [Token(Token = "0x40023DF")]
    private const float ScrollAdjustmentTime = 0.25f;
    [Token(Token = "0x40023E0")]
    [FieldOffset(Offset = "0x100")]
    private Action<StaqData.Equipment, bool> changeAction;
    [Token(Token = "0x40023E1")]
    [FieldOffset(Offset = "0x108")]
    private Action closeAction;
    [Token(Token = "0x40023E2")]
    [FieldOffset(Offset = "0x110")]
    private bool isSelectEquipment;
    [Token(Token = "0x40023E3")]
    [FieldOffset(Offset = "0x114")]
    private int selectItemIndex;
    [Token(Token = "0x40023E4")]
    [FieldOffset(Offset = "0x118")]
    private OrganizationEquipmentSlot.EquipmentSlotType slotType;
    [Token(Token = "0x40023E5")]
    [FieldOffset(Offset = "0x120")]
    private StaqData.Equipment selectEquip;
    [Token(Token = "0x40023E6")]
    [FieldOffset(Offset = "0x128")]
    private EquipmentPopup equipmentPopup;
    [Token(Token = "0x40023E8")]
    [FieldOffset(Offset = "0x138")]
    private OrganizationPartySlot[] partySlot;
    [Token(Token = "0x40023E9")]
    [FieldOffset(Offset = "0x140")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x40023EA")]
    [FieldOffset(Offset = "0x148")]
    private bool isOpenEquipDetal;
    [Token(Token = "0x40023EC")]
    [FieldOffset(Offset = "0x158")]
    private Dictionary<UniqueID, List<EquipParameterViewBase.EquipParameterInfo>> infoData;
    [Token(Token = "0x40023ED")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x40023EE")]
    [FieldOffset(Offset = "0x160")]
    private readonly string[] thumbBaseAssetName;
    [Token(Token = "0x40023EF")]
    [FieldOffset(Offset = "0x168")]
    private NewBadgeProxy newBadgeProxy;

    [Token(Token = "0x17000677")]
    public HorizontalGridInfiniteScrollView InfiniteScrollView
    {
      [Token(Token = "0x6002B48"), Address(RVA = "0x386CAB0", Offset = "0x386CAB0", VA = "0x386CAB0")] get
      {
        return (HorizontalGridInfiniteScrollView) null;
      }
    }

    [Token(Token = "0x17000678")]
    public float ItemSizeW
    {
      [Token(Token = "0x6002B49"), Address(RVA = "0x386CAB8", Offset = "0x386CAB8", VA = "0x386CAB8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000679")]
    public float ItemSizeH
    {
      [Token(Token = "0x6002B4A"), Address(RVA = "0x386CAC0", Offset = "0x386CAC0", VA = "0x386CAC0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700067A")]
    public float ItemMarginW
    {
      [Token(Token = "0x6002B4B"), Address(RVA = "0x386CAC8", Offset = "0x386CAC8", VA = "0x386CAC8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700067B")]
    public float ItemMarginH
    {
      [Token(Token = "0x6002B4C"), Address(RVA = "0x386CAD0", Offset = "0x386CAD0", VA = "0x386CAD0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700067C")]
    public Style selectStyle
    {
      [Token(Token = "0x6002B4D"), Address(RVA = "0x386CAD8", Offset = "0x386CAD8", VA = "0x386CAD8")] get
      {
        return (Style) null;
      }
      [Token(Token = "0x6002B4E"), Address(RVA = "0x386CAE0", Offset = "0x386CAE0", VA = "0x386CAE0")] private set
      {
      }
    }

    [Token(Token = "0x1700067D")]
    public List<UniqueID> partySetEquipmentUniqueIdList
    {
      [Token(Token = "0x6002B4F"), Address(RVA = "0x386CAE8", Offset = "0x386CAE8", VA = "0x386CAE8")] get
      {
        return (List<UniqueID>) null;
      }
      [Token(Token = "0x6002B50"), Address(RVA = "0x386CAF0", Offset = "0x386CAF0", VA = "0x386CAF0")] private set
      {
      }
    }

    [Token(Token = "0x6002B51")]
    [Address(RVA = "0x386CAF8", Offset = "0x386CAF8", VA = "0x386CAF8")]
    public void Initialized(OrganizationPartySlot[] partySlot)
    {
    }

    [Token(Token = "0x6002B52")]
    [Address(RVA = "0x386CF40", Offset = "0x386CF40", VA = "0x386CF40")]
    public void SetChangeAction(Action<StaqData.Equipment, bool> changeAction)
    {
    }

    [Token(Token = "0x6002B53")]
    [Address(RVA = "0x386CF48", Offset = "0x386CF48", VA = "0x386CF48")]
    public void SetCloseAction(Action closeAction)
    {
    }

    [Token(Token = "0x6002B54")]
    [Address(RVA = "0x386CF50", Offset = "0x386CF50", VA = "0x386CF50")]
    public void Open(
      StaqData.Equipment equip,
      int slotIndex,
      OrganizationEquipmentSlot.EquipmentSlotType slotType,
      Style style,
      List<UniqueID> setEquipmentUniqueIDs,
      Dictionary<UniqueID, List<EquipParameterViewBase.EquipParameterInfo>> infoData)
    {
    }

    [Token(Token = "0x6002B55")]
    [Address(RVA = "0x386D5A8", Offset = "0x386D5A8", VA = "0x386D5A8")]
    public void Close()
    {
    }

    [Token(Token = "0x6002B56")]
    [Address(RVA = "0x386D69C", Offset = "0x386D69C", VA = "0x386D69C")]
    private void SelectClear()
    {
    }

    [Token(Token = "0x6002B57")]
    [Address(RVA = "0x386D9F8", Offset = "0x386D9F8", VA = "0x386D9F8")]
    private void FinishedClose()
    {
    }

    [Token(Token = "0x6002B58")]
    [Address(RVA = "0x386DAA0", Offset = "0x386DAA0", VA = "0x386DAA0")]
    public bool IsSelectEquip(int id) => new bool();

    [Token(Token = "0x6002B59")]
    [Address(RVA = "0x386DAC0", Offset = "0x386DAC0", VA = "0x386DAC0")]
    public void OnEquipChangeButton()
    {
    }

    [Token(Token = "0x6002B5A")]
    [Address(RVA = "0x386E080", Offset = "0x386E080", VA = "0x386E080")]
    private bool CehckDuplication(UniqueID uniqueID) => new bool();

    [Token(Token = "0x6002B5B")]
    [Address(RVA = "0x386E244", Offset = "0x386E244", VA = "0x386E244")]
    public void OnEquipDetailButton()
    {
    }

    [Token(Token = "0x6002B5C")]
    [Address(RVA = "0x386E2F0", Offset = "0x386E2F0", VA = "0x386E2F0")]
    private void OpenEquipDetal()
    {
    }

    [Token(Token = "0x6002B5D")]
    [Address(RVA = "0x386ED50", Offset = "0x386ED50", VA = "0x386ED50")]
    private void CloseEquipDetal()
    {
    }

    [Token(Token = "0x6002B5E")]
    [Address(RVA = "0x386EDF4", Offset = "0x386EDF4", VA = "0x386EDF4")]
    public void OnEquipStrengthButton()
    {
    }

    [Token(Token = "0x6002B5F")]
    [Address(RVA = "0x386EEF8", Offset = "0x386EEF8", VA = "0x386EEF8")]
    public void OnEquipSelect(int index)
    {
    }

    [Token(Token = "0x6002B60")]
    [Address(RVA = "0x386D354", Offset = "0x386D354", VA = "0x386D354")]
    private void UpdateWeaponIcon()
    {
    }

    [Token(Token = "0x6002B61")]
    [Address(RVA = "0x386E04C", Offset = "0x386E04C", VA = "0x386E04C")]
    public void OnRemoveButton()
    {
    }

    [Token(Token = "0x6002B62")]
    [Address(RVA = "0x386F8B8", Offset = "0x386F8B8", VA = "0x386F8B8")]
    public void OnSortFilterButton()
    {
    }

    [Token(Token = "0x6002B63")]
    [Address(RVA = "0x3870410", Offset = "0x3870410", VA = "0x3870410")]
    private void UpdateSortFilterAction(List<StaqData.Equipment> sortFilterList)
    {
    }

    [Token(Token = "0x6002B64")]
    [Address(RVA = "0x386D0C0", Offset = "0x386D0C0", VA = "0x386D0C0")]
    public void UpdateEquipList()
    {
    }

    [Token(Token = "0x6002B65")]
    [Address(RVA = "0x3870E60", Offset = "0x3870E60", VA = "0x3870E60")]
    private IEnumerator SetScrollPos(int index, Action action) => (IEnumerator) null;

    [Token(Token = "0x6002B66")]
    [Address(RVA = "0x3870D8C", Offset = "0x3870D8C", VA = "0x3870D8C")]
    private int GetIndexMatchThumbList(StaqData.Equipment equip, List<EquipEditPopup.ThumbData> equipList)
    {
      return new int();
    }

    [Token(Token = "0x6002B67")]
    [Address(RVA = "0x3870F04", Offset = "0x3870F04", VA = "0x3870F04")]
    public void AddThumbAssetBundle(int Id)
    {
    }

    [Token(Token = "0x6002B68")]
    [Address(RVA = "0x38709AC", Offset = "0x38709AC", VA = "0x38709AC")]
    public IEnumerator SetLoadThumbAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6002B69")]
    [Address(RVA = "0x3870FF4", Offset = "0x3870FF4", VA = "0x3870FF4")]
    public string GetAseetBundleName(int id) => (string) null;

    [Token(Token = "0x6002B6A")]
    [Address(RVA = "0x3871248", Offset = "0x3871248", VA = "0x3871248")]
    public string GetAseetName(int id) => (string) null;

    [Token(Token = "0x6002B6B")]
    [Address(RVA = "0x386D284", Offset = "0x386D284", VA = "0x386D284")]
    public StaqData.Equipment GetEquipment(int index) => (StaqData.Equipment) null;

    [Token(Token = "0x6002B6C")]
    [Address(RVA = "0x3871094", Offset = "0x3871094", VA = "0x3871094")]
    public Weapon GetWeapon(int index) => (Weapon) null;

    [Token(Token = "0x6002B6D")]
    [Address(RVA = "0x38710F8", Offset = "0x38710F8", VA = "0x38710F8")]
    public Accessory GetAccessory(int index) => (Accessory) null;

    [Token(Token = "0x6002B6E")]
    [Address(RVA = "0x387115C", Offset = "0x387115C", VA = "0x387115C")]
    public MindEquipment GetMindEquipment(int index) => (MindEquipment) null;

    [Token(Token = "0x6002B6F")]
    [Address(RVA = "0x38711C0", Offset = "0x38711C0", VA = "0x38711C0")]
    public UnitTrust GetUnitTrust(int index) => (UnitTrust) null;

    [Token(Token = "0x6002B70")]
    [Address(RVA = "0x38712E8", Offset = "0x38712E8", VA = "0x38712E8")]
    public RarityTypeEnum GetRarity(int id) => new RarityTypeEnum();

    [Token(Token = "0x6002B71")]
    [Address(RVA = "0x3871364", Offset = "0x3871364", VA = "0x3871364")]
    public Sprite GetRarityBaseImage(int index) => (Sprite) null;

    [Token(Token = "0x6002B72")]
    [Address(RVA = "0x38713CC", Offset = "0x38713CC", VA = "0x38713CC")]
    private Sprite GetRarityMnemnographBaseImage(int index) => (Sprite) null;

    [Token(Token = "0x6002B73")]
    [Address(RVA = "0x38714CC", Offset = "0x38714CC", VA = "0x38714CC")]
    private Sprite GetRarityEquipBaseImage(int index) => (Sprite) null;

    [Token(Token = "0x6002B74")]
    [Address(RVA = "0x38715BC", Offset = "0x38715BC", VA = "0x38715BC")]
    public Sprite GetElementImage(int index) => (Sprite) null;

    [Token(Token = "0x6002B75")]
    [Address(RVA = "0x386D874", Offset = "0x386D874", VA = "0x386D874")]
    public int ConversionIndex(int index) => new int();

    [Token(Token = "0x6002B76")]
    [Address(RVA = "0x3870A14", Offset = "0x3870A14", VA = "0x3870A14")]
    private void CreateEquipList()
    {
    }

    [Token(Token = "0x6002B77")]
    [Address(RVA = "0x38704EC", Offset = "0x38704EC", VA = "0x38704EC")]
    private void CreateEquipList(List<StaqData.Equipment> equipmentList)
    {
    }

    [Token(Token = "0x6002B78")]
    [Address(RVA = "0x386F974", Offset = "0x386F974", VA = "0x386F974")]
    private List<StaqData.Equipment> GetEquipList() => (List<StaqData.Equipment>) null;

    [Token(Token = "0x6002B79")]
    [Address(RVA = "0x3871630", Offset = "0x3871630", VA = "0x3871630")]
    private List<int> GetAccessoryClassifications() => (List<int>) null;

    [Token(Token = "0x6002B7A")]
    [Address(RVA = "0x3871654", Offset = "0x3871654", VA = "0x3871654")]
    private static List<int> GetAccessoryClassifications(int accessoryClassificationGroup)
    {
      return (List<int>) null;
    }

    [Token(Token = "0x6002B7B")]
    [Address(RVA = "0x3870824", Offset = "0x3870824", VA = "0x3870824")]
    private void SetEquipList()
    {
    }

    [Token(Token = "0x6002B7C")]
    [Address(RVA = "0x386F5D4", Offset = "0x386F5D4", VA = "0x386F5D4")]
    private EquipThumb GetStyleEquipThumb(int equipId) => (EquipThumb) null;

    [Token(Token = "0x6002B7D")]
    [Address(RVA = "0x3871890", Offset = "0x3871890", VA = "0x3871890")]
    public void AddEquipThumb(EquipThumb equipThumb)
    {
    }

    [Token(Token = "0x6002B7E")]
    [Address(RVA = "0x3871A58", Offset = "0x3871A58", VA = "0x3871A58")]
    public void RemoveEquipThumb(EquipThumb equipThumb)
    {
    }

    [Token(Token = "0x6002B7F")]
    [Address(RVA = "0x3871BDC", Offset = "0x3871BDC", VA = "0x3871BDC")]
    public EquipEditPopup.ThumbData GetThumbData(int index) => (EquipEditPopup.ThumbData) null;

    [Token(Token = "0x6002B80")]
    [Address(RVA = "0x3871C54", Offset = "0x3871C54", VA = "0x3871C54")]
    public void OnClickToWeaponProficiencyPopup()
    {
    }

    [Token(Token = "0x6002B81")]
    [Address(RVA = "0x386E478", Offset = "0x386E478", VA = "0x386E478")]
    private Action CreateWeaponReinforceAction(UniqueID uniqueID) => (Action) null;

    [Token(Token = "0x6002B82")]
    [Address(RVA = "0x386E768", Offset = "0x386E768", VA = "0x386E768")]
    private Action CreateAccessoryReinforceAction(UniqueID uniqueID) => (Action) null;

    [Token(Token = "0x6002B83")]
    [Address(RVA = "0x386EA58", Offset = "0x386EA58", VA = "0x386EA58")]
    private Action CreateMindEquipmentReinforceAction(UniqueID uniqueID) => (Action) null;

    [Token(Token = "0x6002B84")]
    [Address(RVA = "0x386E2D0", Offset = "0x386E2D0", VA = "0x386E2D0")]
    private void SetCanvasInteractable(bool state)
    {
    }

    [Token(Token = "0x6002B85")]
    [Address(RVA = "0x3871F74", Offset = "0x3871F74", VA = "0x3871F74")]
    private void Update()
    {
    }

    [Token(Token = "0x6002B86")]
    [Address(RVA = "0x3871F90", Offset = "0x3871F90", VA = "0x3871F90")]
    public EquipEditPopup()
    {
    }

    [Token(Token = "0x20007AE")]
    public class ThumbData
    {
      [Token(Token = "0x1700067E")]
      public StaqData.Equipment Equipment
      {
        [Token(Token = "0x6002B89"), Address(RVA = "0x3872248", Offset = "0x3872248", VA = "0x3872248")] get
        {
          return (StaqData.Equipment) null;
        }
        [Token(Token = "0x6002B8A"), Address(RVA = "0x3872250", Offset = "0x3872250", VA = "0x3872250")] private set
        {
        }
      }

      [Token(Token = "0x1700067F")]
      public bool IsNew
      {
        [Token(Token = "0x6002B8B"), Address(RVA = "0x3872258", Offset = "0x3872258", VA = "0x3872258")] get
        {
          return new bool();
        }
        [Token(Token = "0x6002B8C"), Address(RVA = "0x3872260", Offset = "0x3872260", VA = "0x3872260")] set
        {
        }
      }

      [Token(Token = "0x17000680")]
      public bool IsRemove
      {
        [Token(Token = "0x6002B8D"), Address(RVA = "0x387226C", Offset = "0x387226C", VA = "0x387226C")] get
        {
          return new bool();
        }
        [Token(Token = "0x6002B8E"), Address(RVA = "0x3872274", Offset = "0x3872274", VA = "0x3872274")] private set
        {
        }
      }

      [Token(Token = "0x17000681")]
      public bool IsSelect
      {
        [Token(Token = "0x6002B8F"), Address(RVA = "0x3872280", Offset = "0x3872280", VA = "0x3872280")] get
        {
          return new bool();
        }
        [Token(Token = "0x6002B90"), Address(RVA = "0x3872288", Offset = "0x3872288", VA = "0x3872288")] set
        {
        }
      }

      [Token(Token = "0x6002B91")]
      [Address(RVA = "0x38715F8", Offset = "0x38715F8", VA = "0x38715F8")]
      public ThumbData(StaqData.Equipment equipment, bool isNew)
      {
      }

      [Token(Token = "0x6002B92")]
      [Address(RVA = "0x38715D0", Offset = "0x38715D0", VA = "0x38715D0")]
      public ThumbData()
      {
      }
    }
  }
}
