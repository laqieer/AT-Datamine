// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardCustomNodeBView
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
  [Token(Token = "0x200331D")]
  public class AbilityBoardCustomNodeBView : MonoBehaviour
  {
    [Token(Token = "0x400DD02")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400DD03")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AbilityBoardIcon nodeIcon;
    [Token(Token = "0x400DD04")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text rewardText;
    [Token(Token = "0x400DD05")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text lotText;
    [Token(Token = "0x400DD06")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private AbilityBoardEffectController lotEffect;
    [Token(Token = "0x400DD07")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400DD08")]
    [FieldOffset(Offset = "0x48")]
    private Color numColor;
    [Token(Token = "0x400DD09")]
    [FieldOffset(Offset = "0x58")]
    private bool isItemLack;
    [Token(Token = "0x400DD0A")]
    [FieldOffset(Offset = "0x59")]
    private bool isBulkRelease;
    [Token(Token = "0x400DD0B")]
    [FieldOffset(Offset = "0x5A")]
    private bool isLock;
    [Token(Token = "0x400DD0C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject txtInfo;
    [Token(Token = "0x400DD0D")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text totalCountText;
    [Token(Token = "0x400DD0E")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text unlockButtonText;
    [Token(Token = "0x400DD0F")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonButton unlockButton;
    [Token(Token = "0x400DD10")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Image unlockButtonImage;
    [Token(Token = "0x400DD11")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Color disableColor;
    [Token(Token = "0x400DD12")]
    [FieldOffset(Offset = "0x98")]
    private AbilityBoardCustomBCheckPopup confirmPopup;
    [Token(Token = "0x400DD13")]
    [FieldOffset(Offset = "0xA0")]
    private Style style;
    [Token(Token = "0x400DD14")]
    [FieldOffset(Offset = "0xA8")]
    private AbilityBoardStyleSettingData styleSettingData;
    [Token(Token = "0x400DD15")]
    [FieldOffset(Offset = "0xB0")]
    private AbilityBoardNodeData nodeData;
    [Token(Token = "0x400DD16")]
    [FieldOffset(Offset = "0xB8")]
    private IReadOnlyList<AbilityBoardRewardAllocationData> rewardAllocationList;
    [Token(Token = "0x400DD17")]
    [FieldOffset(Offset = "0xC0")]
    private List<PlayerUnitAbilityBoardType> unlockNodeData;
    [Token(Token = "0x400DD18")]
    [FieldOffset(Offset = "0xC8")]
    private List<PlayerUnitAbilityBoardCustomBNodeType> custombDatas;
    [Token(Token = "0x400DD19")]
    [FieldOffset(Offset = "0xD0")]
    private int boardId;
    [Token(Token = "0x400DD1A")]
    [FieldOffset(Offset = "0xD4")]
    private int boardListId;
    [Token(Token = "0x400DD1B")]
    [FieldOffset(Offset = "0xD8")]
    private int customId;
    [Token(Token = "0x400DD1C")]
    [FieldOffset(Offset = "0xE0")]
    private List<ItemData> itemData;
    [Token(Token = "0x400DD1D")]
    [FieldOffset(Offset = "0xE8")]
    public IAbilityBoardIconLoader iconLoader;
    [Token(Token = "0x400DD1E")]
    [FieldOffset(Offset = "0xF0")]
    private AbilityBoardCustomBCheckPopup checkPopup;
    [Token(Token = "0x400DD1F")]
    [FieldOffset(Offset = "0xF8")]
    public Action OnNodeUnlockAction;
    [Token(Token = "0x400DD20")]
    [FieldOffset(Offset = "0x100")]
    public Action CloseCallback;
    [Token(Token = "0x400DD21")]
    [FieldOffset(Offset = "0x108")]
    public IItemDetailController itemDetailController;
    [Token(Token = "0x400DD22")]
    [FieldOffset(Offset = "0x110")]
    private bool viewControlAllowed;

    [Token(Token = "0x6014178")]
    [Address(RVA = "0x20C4864", Offset = "0x20C4864", VA = "0x20C4864")]
    public void AllowViewControl()
    {
    }

    [Token(Token = "0x6014179")]
    [Address(RVA = "0x20C4870", Offset = "0x20C4870", VA = "0x20C4870")]
    public void NotAllowViewControl()
    {
    }

    [Token(Token = "0x601417A")]
    [Address(RVA = "0x20C4878", Offset = "0x20C4878", VA = "0x20C4878")]
    public IEnumerator InitializeTimelineAsync() => (IEnumerator) null;

    [Token(Token = "0x601417B")]
    [Address(RVA = "0x20C4908", Offset = "0x20C4908", VA = "0x20C4908")]
    public void SetData(
      Style style,
      AbilityBoardStyleSettingData styleSettingData,
      int boardListId,
      int boardId,
      int nodeId,
      List<PlayerUnitAbilityBoardType> playerUnitAbilityBoardTypes,
      List<PlayerUnitAbilityBoardCustomBNodeType> custombDatas)
    {
    }

    [Token(Token = "0x601417C")]
    [Address(RVA = "0x20C545C", Offset = "0x20C545C", VA = "0x20C545C")]
    private void SetSelectRewardText()
    {
    }

    [Token(Token = "0x601417D")]
    [Address(RVA = "0x20C578C", Offset = "0x20C578C", VA = "0x20C578C")]
    private string GetRewardText(AbilityboardCustomBNodeData bNodeData) => (string) null;

    [Token(Token = "0x601417E")]
    [Address(RVA = "0x20C5404", Offset = "0x20C5404", VA = "0x20C5404")]
    private string GetRewardText(int parameter) => (string) null;

    [Token(Token = "0x601417F")]
    [Address(RVA = "0x20C58AC", Offset = "0x20C58AC", VA = "0x20C58AC")]
    private int GetParameterId(AbilityboardCustomBNodeData bNodeData) => new int();

    [Token(Token = "0x6014180")]
    [Address(RVA = "0x20C5FE4", Offset = "0x20C5FE4", VA = "0x20C5FE4")]
    private bool CheckMaxValue() => new bool();

    [Token(Token = "0x6014181")]
    [Address(RVA = "0x20C6570", Offset = "0x20C6570", VA = "0x20C6570")]
    private void OnClickItemIcon(ItemIcon itemIcon)
    {
    }

    [Token(Token = "0x6014182")]
    [Address(RVA = "0x20C6670", Offset = "0x20C6670", VA = "0x20C6670")]
    private void OnOpenButton()
    {
    }

    [Token(Token = "0x6014183")]
    [Address(RVA = "0x20C6B4C", Offset = "0x20C6B4C", VA = "0x20C6B4C")]
    public void PlayLotEffect(Action finishAction = null)
    {
    }

    [Token(Token = "0x6014184")]
    [Address(RVA = "0x20C691C", Offset = "0x20C691C", VA = "0x20C691C")]
    private void CallConfirmPopup()
    {
    }

    [Token(Token = "0x6014185")]
    [Address(RVA = "0x20C6B64", Offset = "0x20C6B64", VA = "0x20C6B64")]
    public AbilityBoardCustomNodeBView()
    {
    }
  }
}
