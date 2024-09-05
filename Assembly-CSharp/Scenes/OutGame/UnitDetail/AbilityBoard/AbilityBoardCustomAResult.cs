// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardCustomAResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003318")]
  public class AbilityBoardCustomAResult : PopupBase
  {
    [Token(Token = "0x400DCC6")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private AbilityBoardCustomNodeSlotUI currentSlot;
    [Token(Token = "0x400DCC7")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private AbilityBoardCustomNodeSlotUI selectSlot;
    [Token(Token = "0x400DCC8")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private AbilityBoardCustomNodeSlotUI[] resultSlots;
    [Token(Token = "0x400DCC9")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton[] chooseButton;
    [Token(Token = "0x400DCCA")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private UITweenGroup[] tweens;
    [Token(Token = "0x400DCCB")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject negativeGroup;
    [Token(Token = "0x400DCCC")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400DCCD")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CommonButton decisionButton;
    [Token(Token = "0x400DCCE")]
    [FieldOffset(Offset = "0xC8")]
    public Action<string, bool> OnSelectAction;
    [Token(Token = "0x400DCCF")]
    [FieldOffset(Offset = "0xD0")]
    private int selectIndex;
    [Token(Token = "0x400DCD0")]
    [FieldOffset(Offset = "0xD8")]
    private List<PlayerUnitAbilityBoardCustomALotteryType> customANodeList;
    [Token(Token = "0x400DCD1")]
    [FieldOffset(Offset = "0xE0")]
    private AbilityBoardStyleSettingData styleSettingData;
    [Token(Token = "0x400DCD2")]
    [FieldOffset(Offset = "0xE8")]
    private IReadOnlyList<AbilityBoardRewardAllocationData> rewardAllocationList;
    [Token(Token = "0x400DCD3")]
    [FieldOffset(Offset = "0xF0")]
    private int customId;

    [Token(Token = "0x6014145")]
    [Address(RVA = "0x20C0360", Offset = "0x20C0360", VA = "0x20C0360")]
    public void SetData(
      int nodeId,
      AbilityBoardStyleSettingData styleSettingData,
      List<PlayerUnitAbilityBoardCustomALotteryType> customANodeList,
      List<PlayerUnitAbilityBoardCustomANodeType> currentDatas)
    {
    }

    [Token(Token = "0x6014146")]
    [Address(RVA = "0x20C1DD8", Offset = "0x20C1DD8", VA = "0x20C1DD8")]
    public void OnDecisionButton()
    {
    }

    [Token(Token = "0x6014147")]
    [Address(RVA = "0x20C1EB8", Offset = "0x20C1EB8", VA = "0x20C1EB8")]
    public void OnCloseButton()
    {
    }

    [Token(Token = "0x6014148")]
    [Address(RVA = "0x20C1F80", Offset = "0x20C1F80", VA = "0x20C1F80", Slot = "6")]
    public override void OnBackClosed()
    {
    }

    [Token(Token = "0x6014149")]
    [Address(RVA = "0x20C1CFC", Offset = "0x20C1CFC", VA = "0x20C1CFC")]
    public void OnChooseButton(int index)
    {
    }

    [Token(Token = "0x601414A")]
    [Address(RVA = "0x20C150C", Offset = "0x20C150C", VA = "0x20C150C")]
    private void SetResultSlot()
    {
    }

    [Token(Token = "0x601414B")]
    [Address(RVA = "0x20C1974", Offset = "0x20C1974", VA = "0x20C1974")]
    private void SetSelectSlot()
    {
    }

    [Token(Token = "0x601414C")]
    [Address(RVA = "0x20C213C", Offset = "0x20C213C", VA = "0x20C213C")]
    public AbilityBoardCustomAResult()
    {
    }
  }
}
