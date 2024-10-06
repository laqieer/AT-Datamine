// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardBulkReleasePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x200330F")]
  public class AbilityBoardBulkReleasePopup : PopupBase
  {
    [Token(Token = "0x400DC8D")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RectTransform alertUIParent;
    [Token(Token = "0x400DC8E")]
    [FieldOffset(Offset = "0x90")]
    private AlertUI alertUI;
    [Token(Token = "0x400DC8F")]
    [FieldOffset(Offset = "0x98")]
    public Action<List<AbilityBoardReleaseNodeData>> OnNodeUnlockAction;
    [Token(Token = "0x400DC90")]
    [FieldOffset(Offset = "0xA0")]
    public Action CloseAction;
    [Token(Token = "0x400DC91")]
    [FieldOffset(Offset = "0xA8")]
    public IItemDetailController itemDetailController;
    [Token(Token = "0x400DC92")]
    [FieldOffset(Offset = "0xB0")]
    public IAbilityBoardIconLoader iconLoader;
    [Token(Token = "0x400DC93")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private RectTransform nodeParent;
    [Token(Token = "0x400DC94")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private AbilityBoardBulkReleaseNodeContent node;
    [Token(Token = "0x400DC95")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private RectTransform paramParent;
    [Token(Token = "0x400DC96")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private AbilityBoardBulkReleaseParameterContent param;
    [Token(Token = "0x400DC97")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400DC98")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CommonButton releaseButton;
    [Token(Token = "0x400DC99")]
    [FieldOffset(Offset = "0xE8")]
    private Style style;
    [Token(Token = "0x400DC9A")]
    [FieldOffset(Offset = "0xF0")]
    private List<ItemData> items;
    [Token(Token = "0x400DC9B")]
    [FieldOffset(Offset = "0xF8")]
    private List<AbilityBoardReleaseNodeData> nodeDatas;
    [Token(Token = "0x400DC9C")]
    [FieldOffset(Offset = "0x100")]
    private bool isItemLack;
    [Token(Token = "0x400DC9D")]
    [FieldOffset(Offset = "0x101")]
    private bool isClosed;

    [Token(Token = "0x6014106")]
    [Address(RVA = "0x20BB5D0", Offset = "0x20BB5D0", VA = "0x20BB5D0")]
    public void SetData(List<AbilityBoardReleaseNodeData> nodeData, Style style)
    {
    }

    [Token(Token = "0x6014107")]
    [Address(RVA = "0x20BBB40", Offset = "0x20BBB40", VA = "0x20BBB40")]
    private void CheckReleaseItem(ItemData item)
    {
    }

    [Token(Token = "0x6014108")]
    [Address(RVA = "0x20BBD60", Offset = "0x20BBD60", VA = "0x20BBD60")]
    public void OnBulkReleaseButton()
    {
    }

    [Token(Token = "0x6014109")]
    [Address(RVA = "0x20BBF20", Offset = "0x20BBF20", VA = "0x20BBF20")]
    public void OnCloseButton()
    {
    }

    [Token(Token = "0x601410A")]
    [Address(RVA = "0x20BBF2C", Offset = "0x20BBF2C", VA = "0x20BBF2C", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x601410B")]
    [Address(RVA = "0x20BC070", Offset = "0x20BC070", VA = "0x20BC070", Slot = "6")]
    public override void OnBackClosed()
    {
    }

    [Token(Token = "0x601410C")]
    [Address(RVA = "0x20BC09C", Offset = "0x20BC09C", VA = "0x20BC09C")]
    private void PlayAlertUI(string alertText)
    {
    }

    [Token(Token = "0x601410D")]
    [Address(RVA = "0x20BC144", Offset = "0x20BC144", VA = "0x20BC144")]
    public AbilityBoardBulkReleasePopup()
    {
    }
  }
}
