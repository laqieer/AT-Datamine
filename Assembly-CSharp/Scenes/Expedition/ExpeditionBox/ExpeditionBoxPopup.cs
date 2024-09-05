// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.ExpeditionBox.ExpeditionBoxPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using Scenes.Expedition.Main;
using Scenes.Expedition.Popup;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.ExpeditionBox
{
  [Token(Token = "0x2002D00")]
  public class ExpeditionBoxPopup : PopupBase
  {
    [Token(Token = "0x400C0B6")]
    private const string ItemRecoveryAnimationName = "ef_A_UI_kaihou_01";
    [Token(Token = "0x400C0B7")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text soulSpotLevelText;
    [Token(Token = "0x400C0B8")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI soulSpotExpText;
    [Token(Token = "0x400C0B9")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextMeshProUGUI soulSpotExpMaxText;
    [Token(Token = "0x400C0BA")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI soulStrageText;
    [Token(Token = "0x400C0BB")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI soulStrageMaxText;
    [Token(Token = "0x400C0BC")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private TextMeshProUGUI boxCapacityText;
    [Token(Token = "0x400C0BD")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private TextMeshProUGUI boxCapacityMaxText;
    [Token(Token = "0x400C0BE")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private RectTransform soulSpotExpGauge;
    [Token(Token = "0x400C0BF")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private RectTransform soulStrageGauge;
    [Token(Token = "0x400C0C0")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Text redSoulSpotLevelText;
    [Token(Token = "0x400C0C1")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private TextMeshProUGUI redSoulSpotExpText;
    [Token(Token = "0x400C0C2")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private TextMeshProUGUI redSoulSpotExpMaxText;
    [Token(Token = "0x400C0C3")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private TextMeshProUGUI redSoulStrageText;
    [Token(Token = "0x400C0C4")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private TextMeshProUGUI redSoulStrageMaxText;
    [Token(Token = "0x400C0C5")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private RectTransform redSoulSpotExpGauge;
    [Token(Token = "0x400C0C6")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private RectTransform redSoulStrageGauge;
    [Token(Token = "0x400C0C7")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private Transform expeditionBoxItemScrollParent;
    [Token(Token = "0x400C0C8")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private ExpeditionResultItemCell itemCell;
    [Token(Token = "0x400C0C9")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private Button itemCollectionButton;
    [Token(Token = "0x400C0CA")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private GameObject itemCollectPopup;
    [Token(Token = "0x400C0CB")]
    [FieldOffset(Offset = "0x128")]
    private ExpeditionItemCollectPopup expeditionItemCollectPopup;
    [Token(Token = "0x400C0CC")]
    [FieldOffset(Offset = "0x130")]
    private List<PlayerExpeditionSoulSpotType> soulSpots;
    [Token(Token = "0x400C0CD")]
    [FieldOffset(Offset = "0x138")]
    private List<PlayerExpeditionStageType> stages;
    [Token(Token = "0x400C0CE")]
    [FieldOffset(Offset = "0x140")]
    private List<int> itemDropDescriptionIds;
    [Token(Token = "0x400C0CF")]
    [FieldOffset(Offset = "0x148")]
    private PlayerExpeditionType playerExpeditionType;
    [Token(Token = "0x400C0D0")]
    [FieldOffset(Offset = "0x150")]
    private Action<bool> onCollection;
    [Token(Token = "0x400C0D1")]
    [FieldOffset(Offset = "0x158")]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400C0D2")]
    [FieldOffset(Offset = "0x160")]
    private int blueSoulProductionValue;
    [Token(Token = "0x400C0D3")]
    [FieldOffset(Offset = "0x164")]
    private int redSoulProductionValue;
    [Token(Token = "0x400C0D4")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private Text blueSoulMaxText;
    [Token(Token = "0x400C0D5")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private Text redSoulMaxText;
    [Token(Token = "0x400C0D6")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private Text blueSoulSpotMaxLevelText;
    [Token(Token = "0x400C0D7")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    private Text redSoulSpotMaxLevelText;
    [Token(Token = "0x400C0D8")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private GameObject canLevelUpBlueSoulSpotObj;
    [Token(Token = "0x400C0D9")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private GameObject canLevelUpRedSoulSpotObj;
    [Token(Token = "0x400C0DA")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    private CommonButton blueSoulSpotForcementButton;
    [Token(Token = "0x400C0DB")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    private CommonButton redSoulSpotForcementButton;
    [Token(Token = "0x400C0DC")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    private CommonButton boxForcementButton;
    [Token(Token = "0x400C0DD")]
    [FieldOffset(Offset = "0x1B0")]
    private int beforeBlueSoul;
    [Token(Token = "0x400C0DE")]
    [FieldOffset(Offset = "0x1B4")]
    private int beforeRedSoul;
    [Token(Token = "0x400C0DF")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    private GameObject prefabSpotReinforcementDialogVariant;
    [Token(Token = "0x400C0E0")]
    [FieldOffset(Offset = "0x1C0")]
    private SoulSpotForcementPopup soulSpotForcementPopup;
    [Token(Token = "0x400C0E1")]
    [FieldOffset(Offset = "0x1C8")]
    [SerializeField]
    private GameObject expeditionBoxForcement;
    [Token(Token = "0x400C0E2")]
    [FieldOffset(Offset = "0x1D0")]
    private SoulSpotBoxForcementPopup expeditionBoxForcementPopup;
    [Token(Token = "0x400C0E3")]
    [FieldOffset(Offset = "0x1D8")]
    private ExpeditionStyleExpPopup expeditionStyleExpPrefab;
    [Token(Token = "0x400C0E4")]
    [FieldOffset(Offset = "0x1E0")]
    private ExpeditionStyleExpPopup expeditionStyleExpPopup;
    [Token(Token = "0x400C0E5")]
    [FieldOffset(Offset = "0x1E8")]
    private List<ExpeditionResultItemCell> itemCells;
    [Token(Token = "0x400C0E6")]
    [FieldOffset(Offset = "0x1F0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400C0E7")]
    [FieldOffset(Offset = "0x1F8")]
    private bool isBlueSoulSpotLevelMax;
    [Token(Token = "0x400C0E8")]
    [FieldOffset(Offset = "0x1F9")]
    private bool isRedSoulSpotLevelMax;
    [Token(Token = "0x400C0E9")]
    [FieldOffset(Offset = "0x1FA")]
    private bool isBoxLevelMax;
    [Token(Token = "0x400C0EA")]
    [FieldOffset(Offset = "0x1FC")]
    private float updateTimer;
    [Token(Token = "0x400C0EB")]
    private const int UPDATE_TIME = 10;
    [Token(Token = "0x400C0EC")]
    [FieldOffset(Offset = "0x200")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400C0ED")]
    [FieldOffset(Offset = "0x208")]
    private bool isPlayingButtonAction;

    [Token(Token = "0x60119BF")]
    [Address(RVA = "0x46A7618", Offset = "0x46A7618", VA = "0x46A7618")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60119C0")]
    [Address(RVA = "0x46A7834", Offset = "0x46A7834", VA = "0x46A7834")]
    private void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x60119C1")]
    [Address(RVA = "0x46A8D44", Offset = "0x46A8D44", VA = "0x46A8D44")]
    public void SetCallback(Action<bool> onCollection)
    {
    }

    [Token(Token = "0x60119C2")]
    [Address(RVA = "0x46A8D4C", Offset = "0x46A8D4C", VA = "0x46A8D4C")]
    public void SetData(
      List<PlayerExpeditionStageType> stages,
      List<PlayerExpeditionSoulSpotType> soulSpot,
      List<PlayerExpeditionBoxType> boxItems,
      PlayerExpeditionType playerExpeditionType)
    {
    }

    [Token(Token = "0x60119C3")]
    [Address(RVA = "0x46A8F54", Offset = "0x46A8F54", VA = "0x46A8F54")]
    public void SetData(
      List<PlayerExpeditionStageType> stages,
      List<PlayerExpeditionSoulSpotType> soulSpot,
      List<int> boxItems,
      PlayerExpeditionType playerExpeditionType)
    {
    }

    [Token(Token = "0x60119C4")]
    [Address(RVA = "0x46A903C", Offset = "0x46A903C", VA = "0x46A903C")]
    public void OnCollection()
    {
    }

    [Token(Token = "0x60119C5")]
    [Address(RVA = "0x46A92B8", Offset = "0x46A92B8", VA = "0x46A92B8")]
    public void OnClose()
    {
    }

    [Token(Token = "0x60119C6")]
    [Address(RVA = "0x46A9384", Offset = "0x46A9384", VA = "0x46A9384")]
    private void OpenStyleExpPopup(
      ExpeditionOrganization.ExpeditionOldParty[] oldPartys,
      APIExpeditionBoxOpenResponse response)
    {
    }

    [Token(Token = "0x60119C7")]
    [Address(RVA = "0x46A96D4", Offset = "0x46A96D4", VA = "0x46A96D4")]
    private bool IsSoulOverTank() => new bool();

    [Token(Token = "0x60119C8")]
    [Address(RVA = "0x46A9D54", Offset = "0x46A9D54", VA = "0x46A9D54")]
    private void Update()
    {
    }

    [Token(Token = "0x60119C9")]
    [Address(RVA = "0x46A9250", Offset = "0x46A9250", VA = "0x46A9250")]
    private IEnumerator ApiExpeditionBoxOpenRequest(Action<APIExpeditionBoxOpenResponse> callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60119CA")]
    [Address(RVA = "0x46AA330", Offset = "0x46AA330", VA = "0x46AA330")]
    private IEnumerator PlayItemRecoveryAnimation(
      bool isPlayStyleExpPopup,
      bool isSoulOverTank,
      Action callback,
      Action styleExpAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60119CB")]
    [Address(RVA = "0x46A78F8", Offset = "0x46A78F8", VA = "0x46A78F8")]
    private void UpdateUI()
    {
    }

    [Token(Token = "0x60119CC")]
    [Address(RVA = "0x46AA400", Offset = "0x46AA400", VA = "0x46AA400")]
    private void GetCanUpLevelMaxData(
      SoulTypeEnum soulType,
      out int canLevelUpMaxLevel,
      out int soulSpotNextExp,
      out int soulSpotFromExp)
    {
    }

    [Token(Token = "0x60119CD")]
    [Address(RVA = "0x46AAB24", Offset = "0x46AAB24", VA = "0x46AAB24")]
    private void UpdateItemView()
    {
    }

    [Token(Token = "0x60119CE")]
    [Address(RVA = "0x46AAF10", Offset = "0x46AAF10", VA = "0x46AAF10")]
    private void DisableItems()
    {
    }

    [Token(Token = "0x60119CF")]
    [Address(RVA = "0x46A9DA8", Offset = "0x46A9DA8", VA = "0x46A9DA8")]
    private void UpdateGaugeSoulSpot()
    {
    }

    [Token(Token = "0x60119D0")]
    [Address(RVA = "0x46AB074", Offset = "0x46AB074", VA = "0x46AB074")]
    public void OnClickSpotForcement(int soulType)
    {
    }

    [Token(Token = "0x60119D1")]
    [Address(RVA = "0x46AB52C", Offset = "0x46AB52C", VA = "0x46AB52C")]
    public void OnClickSpotBoxForcementPopup()
    {
    }

    [Token(Token = "0x60119D2")]
    [Address(RVA = "0x46AB82C", Offset = "0x46AB82C", VA = "0x46AB82C")]
    public ExpeditionBoxPopup()
    {
    }
  }
}
