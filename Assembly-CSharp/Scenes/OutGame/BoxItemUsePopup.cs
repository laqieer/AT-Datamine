// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.BoxItemUsePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Common;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031E7")]
  public class BoxItemUsePopup : PopupBase
  {
    [Token(Token = "0x400D4DA")]
    private const string CONFIRM_ASSETBUNDLE_NAME = "ui_page_itemlist";
    [Token(Token = "0x400D4DB")]
    private const string CONFIRM_ASSET_NAME = "Com_Popup_Base_L_BoxItem_Confirm";
    [Token(Token = "0x400D4DC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CanvasGroup popupCanvas;
    [Token(Token = "0x400D4DD")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x400D4DE")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton decideButton;
    [Token(Token = "0x400D4DF")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private ItemIcon boxItemIcon;
    [Token(Token = "0x400D4E0")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private RarityIcon boxItemRarity;
    [Token(Token = "0x400D4E1")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text txtTitle;
    [Token(Token = "0x400D4E2")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject limitRoot;
    [Token(Token = "0x400D4E3")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text txtLimitValue;
    [Token(Token = "0x400D4E4")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private TextMeshProUGUI txtPossessionValue;
    [Token(Token = "0x400D4E5")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private TextMeshProUGUI txtExplanation;
    [Token(Token = "0x400D4E6")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private TextMeshProUGUI txtExplanationLottery;
    [Token(Token = "0x400D4E7")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private TextMeshProUGUI txtExplanationChoice;
    [Token(Token = "0x400D4E8")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject contentItemBoxListParts;
    [Token(Token = "0x400D4E9")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private Text txtCountValue;
    [Token(Token = "0x400D4EA")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private Text txtMaxValue;
    [Token(Token = "0x400D4EB")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private GameObject useCountButtons;
    [Token(Token = "0x400D4EC")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private CommonButton firstButton;
    [Token(Token = "0x400D4ED")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private CommonButton prevButton;
    [Token(Token = "0x400D4EE")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400D4EF")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private CommonButton lastButton;
    [Token(Token = "0x400D4F0")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private GameObject attention;
    [Token(Token = "0x400D4F1")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400D4F2")]
    [FieldOffset(Offset = "0x138")]
    private Item item;
    [Token(Token = "0x400D4F3")]
    [FieldOffset(Offset = "0x140")]
    private BoxItemData boxItemData;
    [Token(Token = "0x400D4F4")]
    [FieldOffset(Offset = "0x148")]
    private List<BoxItemContentsData> boxItemContentsDataList;
    [Token(Token = "0x400D4F5")]
    [FieldOffset(Offset = "0x150")]
    private List<BoxItemRewardListSheet> sheets;
    [Token(Token = "0x400D4F6")]
    [FieldOffset(Offset = "0x158")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D4F7")]
    [FieldOffset(Offset = "0x160")]
    private ItemDetailPopupProvider itemDetailPopup;
    [Token(Token = "0x400D4F8")]
    [FieldOffset(Offset = "0x168")]
    private Action updatePlayerDataSet;
    [Token(Token = "0x400D4F9")]
    [FieldOffset(Offset = "0x170")]
    private Action listButtonUpdateAction;
    [Token(Token = "0x400D4FA")]
    [FieldOffset(Offset = "0x178")]
    private int useCount;
    [Token(Token = "0x400D4FB")]
    [FieldOffset(Offset = "0x17C")]
    private int maxUseCount;
    [Token(Token = "0x400D4FC")]
    [FieldOffset(Offset = "0x180")]
    private bool canAddUseCount;
    [Token(Token = "0x400D4FD")]
    [FieldOffset(Offset = "0x181")]
    private bool canItemUse;
    [Token(Token = "0x400D4FE")]
    [FieldOffset(Offset = "0x188")]
    private string toasterMsg;

    [Token(Token = "0x601379C")]
    [Address(RVA = "0x4E10E90", Offset = "0x4E10E90", VA = "0x4E10E90")]
    public IEnumerator InitializeAsync(Item item, Action updatePlayerDataSet) => (IEnumerator) null;

    [Token(Token = "0x601379D")]
    [Address(RVA = "0x4E10F0C", Offset = "0x4E10F0C", VA = "0x4E10F0C")]
    private void InitializeContents()
    {
    }

    [Token(Token = "0x601379E")]
    [Address(RVA = "0x4E122A0", Offset = "0x4E122A0", VA = "0x4E122A0")]
    private void OnClickDecideButton()
    {
    }

    [Token(Token = "0x601379F")]
    [Address(RVA = "0x4E12148", Offset = "0x4E12148", VA = "0x4E12148")]
    private void UpdateButtonInteractable()
    {
    }

    [Token(Token = "0x60137A0")]
    [Address(RVA = "0x4E121D8", Offset = "0x4E121D8", VA = "0x4E121D8")]
    private void UpdateDecideButtonState()
    {
    }

    [Token(Token = "0x60137A1")]
    [Address(RVA = "0x4E12704", Offset = "0x4E12704", VA = "0x4E12704")]
    private void CheckTimeOver()
    {
    }

    [Token(Token = "0x60137A2")]
    [Address(RVA = "0x4E12868", Offset = "0x4E12868", VA = "0x4E12868")]
    private void OpenConfirmPopup(
      List<BoxItemContentsData> boxItemContentsDataList,
      int useCount,
      Action onDecide,
      Action onCancel)
    {
    }

    [Token(Token = "0x60137A3")]
    [Address(RVA = "0x4E12A1C", Offset = "0x4E12A1C", VA = "0x4E12A1C")]
    private void OpenConfirmPopup(
      List<BoxItemContentSelectType> selectContents,
      Action onDecide,
      Action onCancel)
    {
    }

    [Token(Token = "0x60137A4")]
    [Address(RVA = "0x4E12020", Offset = "0x4E12020", VA = "0x4E12020")]
    private void InitializeTxtExplanation(BoxItemOpenTypeEnum boxItemOpenType)
    {
    }

    [Token(Token = "0x60137A5")]
    [Address(RVA = "0x4E12B3C", Offset = "0x4E12B3C", VA = "0x4E12B3C")]
    private bool AddUseCount(int addUseCount) => new bool();

    [Token(Token = "0x60137A6")]
    [Address(RVA = "0x4E12BD0", Offset = "0x4E12BD0", VA = "0x4E12BD0")]
    private void SetlistButtonUpdateAction(Action updateAction)
    {
    }

    [Token(Token = "0x60137A7")]
    [Address(RVA = "0x4E12C50", Offset = "0x4E12C50", VA = "0x4E12C50")]
    private bool GetCanAddUseCount() => new bool();

    [Token(Token = "0x60137A8")]
    [Address(RVA = "0x4E12990", Offset = "0x4E12990", VA = "0x4E12990")]
    private IEnumerator OpenBoxItem(
      int itemId,
      int count,
      List<BoxItemContentSelectType> selectContents)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60137A9")]
    [Address(RVA = "0x4E12C58", Offset = "0x4E12C58", VA = "0x4E12C58")]
    private IEnumerator RequestBoxItemOpen(
      int itemId,
      int count,
      List<BoxItemContentSelectType> selectContents,
      Action<APIBoxItemOpenResponse> finished)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60137AA")]
    [Address(RVA = "0x4E12CE8", Offset = "0x4E12CE8", VA = "0x4E12CE8")]
    private IEnumerator OpenRewardPopup(APIBoxItemOpenResponse response) => (IEnumerator) null;

    [Token(Token = "0x60137AB")]
    [Address(RVA = "0x4E12D50", Offset = "0x4E12D50", VA = "0x4E12D50")]
    private IEnumerator ShowTransferPresentToaster(
      APIBoxItemOpenResponse response,
      Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60137AC")]
    [Address(RVA = "0x4E12DC4", Offset = "0x4E12DC4", VA = "0x4E12DC4")]
    private static void ConvertToDisplayItemRewardInfoData(
      out List<DisplayItemRewardInfoData> infos,
      List<RewardGiveResultEntityType> rewards)
    {
    }

    [Token(Token = "0x60137AD")]
    [Address(RVA = "0x4E12FFC", Offset = "0x4E12FFC", VA = "0x4E12FFC")]
    private void SetCanvasInteractable(bool state)
    {
    }

    [Token(Token = "0x60137AE")]
    [Address(RVA = "0x4E1301C", Offset = "0x4E1301C", VA = "0x4E1301C")]
    public BoxItemUsePopup()
    {
    }
  }
}
