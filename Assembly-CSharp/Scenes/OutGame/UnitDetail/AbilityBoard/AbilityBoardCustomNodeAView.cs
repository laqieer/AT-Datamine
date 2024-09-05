// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardCustomNodeAView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x200331B")]
  public class AbilityBoardCustomNodeAView : MonoBehaviour
  {
    [Token(Token = "0x400DCD9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400DCDA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AbilityBoardIcon nodeIcon;
    [Token(Token = "0x400DCDB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text nodeText;
    [Token(Token = "0x400DCDC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private AbilityBoardCustomNodeSlotUI slot;
    [Token(Token = "0x400DCDD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private AbilityBoardEffectController[] lotEffects;
    [Token(Token = "0x400DCDE")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400DCDF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text itemAmountText;
    [Token(Token = "0x400DCE0")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton selectItemButton;
    [Token(Token = "0x400DCE1")]
    [FieldOffset(Offset = "0x58")]
    private AbilityBoardCustomAItemSelectView itemSelect;
    [Token(Token = "0x400DCE2")]
    [FieldOffset(Offset = "0x60")]
    private bool isItemLack;
    [Token(Token = "0x400DCE3")]
    [FieldOffset(Offset = "0x61")]
    private bool isBulkRelease;
    [Token(Token = "0x400DCE4")]
    [FieldOffset(Offset = "0x62")]
    private bool isLock;
    [Token(Token = "0x400DCE5")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text countText;
    [Token(Token = "0x400DCE6")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton minusButton;
    [Token(Token = "0x400DCE7")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonButton plusButton;
    [Token(Token = "0x400DCE8")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton maxButton;
    [Token(Token = "0x400DCE9")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject txtInfo;
    [Token(Token = "0x400DCEA")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text totalCountText;
    [Token(Token = "0x400DCEB")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton unlockButton;
    [Token(Token = "0x400DCEC")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text unlockButtonText;
    [Token(Token = "0x400DCED")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Image unlockButtonImage;
    [Token(Token = "0x400DCEE")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Color disableColor;
    [Token(Token = "0x400DCEF")]
    [FieldOffset(Offset = "0xC0")]
    private Style style;
    [Token(Token = "0x400DCF0")]
    [FieldOffset(Offset = "0xC8")]
    private AbilityBoardStyleSettingData styleSettingData;
    [Token(Token = "0x400DCF1")]
    [FieldOffset(Offset = "0xD0")]
    private AbilityBoardNodeData nodeData;
    [Token(Token = "0x400DCF2")]
    [FieldOffset(Offset = "0xD8")]
    private IReadOnlyList<AbilityBoardRewardAllocationData> rewardAllocationList;
    [Token(Token = "0x400DCF3")]
    [FieldOffset(Offset = "0xE0")]
    private List<PlayerUnitAbilityBoardType> unlockNodeData;
    [Token(Token = "0x400DCF4")]
    [FieldOffset(Offset = "0xE8")]
    private int boardId;
    [Token(Token = "0x400DCF5")]
    [FieldOffset(Offset = "0xEC")]
    private int boardListId;
    [Token(Token = "0x400DCF6")]
    [FieldOffset(Offset = "0xF0")]
    public IAbilityBoardIconLoader iconLoader;
    [Token(Token = "0x400DCF7")]
    [FieldOffset(Offset = "0xF8")]
    public Action<int, int> OnNodeUnlockAction;
    [Token(Token = "0x400DCF8")]
    [FieldOffset(Offset = "0x100")]
    public Action CloseCallback;
    [Token(Token = "0x400DCF9")]
    [FieldOffset(Offset = "0x108")]
    public IItemDetailController itemDetailController;
    [Token(Token = "0x400DCFA")]
    [FieldOffset(Offset = "0x110")]
    private int lotteryCount;
    [Token(Token = "0x400DCFB")]
    [FieldOffset(Offset = "0x118")]
    private ItemData selectItem;
    [Token(Token = "0x400DCFC")]
    [FieldOffset(Offset = "0x120")]
    private int customId;
    [Token(Token = "0x400DCFD")]
    [FieldOffset(Offset = "0x124")]
    private MoldTypeEnum selectMoldType;
    [Token(Token = "0x400DCFE")]
    [FieldOffset(Offset = "0x128")]
    private bool viewControlAllowed;

    [Token(Token = "0x601415D")]
    [Address(RVA = "0x20C2594", Offset = "0x20C2594", VA = "0x20C2594")]
    public void AllowViewControl()
    {
    }

    [Token(Token = "0x601415E")]
    [Address(RVA = "0x20C25A0", Offset = "0x20C25A0", VA = "0x20C25A0")]
    public void NotAllowViewControl()
    {
    }

    [Token(Token = "0x601415F")]
    [Address(RVA = "0x20C25A8", Offset = "0x20C25A8", VA = "0x20C25A8")]
    public IEnumerator InitializeTimelineAsync() => (IEnumerator) null;

    [Token(Token = "0x6014160")]
    [Address(RVA = "0x20C2638", Offset = "0x20C2638", VA = "0x20C2638")]
    public void SetData(
      Style style,
      AbilityBoardStyleSettingData styleSettingData,
      int boardListId,
      int boardId,
      int nodeId,
      List<PlayerUnitAbilityBoardType> playerUnitAbilityBoardTypes,
      List<PlayerUnitAbilityBoardCustomANodeType> customaDatas)
    {
    }

    [Token(Token = "0x6014161")]
    [Address(RVA = "0x20C37A0", Offset = "0x20C37A0", VA = "0x20C37A0")]
    private void SetItemData(MoldTypeEnum moldType)
    {
    }

    [Token(Token = "0x6014162")]
    [Address(RVA = "0x20C3BC0", Offset = "0x20C3BC0", VA = "0x20C3BC0")]
    private void OnClickItemIcon(ItemIcon itemIcon)
    {
    }

    [Token(Token = "0x6014163")]
    [Address(RVA = "0x20C3C98", Offset = "0x20C3C98", VA = "0x20C3C98")]
    private void OnOpenButton()
    {
    }

    [Token(Token = "0x6014164")]
    [Address(RVA = "0x20C3F34", Offset = "0x20C3F34", VA = "0x20C3F34")]
    public void PlayLotEffect(Action finishAction = null)
    {
    }

    [Token(Token = "0x6014165")]
    [Address(RVA = "0x20C3768", Offset = "0x20C3768", VA = "0x20C3768")]
    private void UpdateLotCountText()
    {
    }

    [Token(Token = "0x6014166")]
    [Address(RVA = "0x20C4064", Offset = "0x20C4064", VA = "0x20C4064")]
    private void OnCountAddButton()
    {
    }

    [Token(Token = "0x6014167")]
    [Address(RVA = "0x20C417C", Offset = "0x20C417C", VA = "0x20C417C")]
    private void OnCountDecButton()
    {
    }

    [Token(Token = "0x6014168")]
    [Address(RVA = "0x20C4214", Offset = "0x20C4214", VA = "0x20C4214")]
    private void OnCountMaxButton()
    {
    }

    [Token(Token = "0x6014169")]
    [Address(RVA = "0x20C431C", Offset = "0x20C431C", VA = "0x20C431C")]
    private void OnItemSelectButton()
    {
    }

    [Token(Token = "0x601416A")]
    [Address(RVA = "0x20C3A78", Offset = "0x20C3A78", VA = "0x20C3A78")]
    private void ItemLackCheck()
    {
    }

    [Token(Token = "0x601416B")]
    [Address(RVA = "0x20C45B4", Offset = "0x20C45B4", VA = "0x20C45B4")]
    public AbilityBoardCustomNodeAView()
    {
    }
  }
}
