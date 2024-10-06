// Decompiled with JetBrains decompiler
// Type: UnitList.UI.UnitScrollListCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitList.UI
{
  [Token(Token = "0x2000414")]
  public class UnitScrollListCell : UIScrollGridItem
  {
    [Token(Token = "0x4001729")]
    private const string TweenUnequip = "UnitList_Remove";
    [Token(Token = "0x400172A")]
    private const string TweenDefault = "UnitList_Default";
    [Token(Token = "0x400172B")]
    private const string TweenEmpty = "UnitList_Empty";
    [Token(Token = "0x400172C")]
    private const string TweenDark = "UnitList_Dark";
    [Token(Token = "0x400172D")]
    private const string TweenDeplicate = "UnitList_Deplicate";
    [Token(Token = "0x400172E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x400172F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001730")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject numberHeader;
    [Token(Token = "0x4001731")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject styleHeader;
    [Token(Token = "0x4001732")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text number;
    [Token(Token = "0x4001733")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image thumbnail;
    [Token(Token = "0x4001734")]
    [FieldOffset(Offset = "0x48")]
    private Style displayStyle;
    [Token(Token = "0x4001735")]
    [FieldOffset(Offset = "0x50")]
    private UnitScrollListCell.DisplayState displayState;
    [Token(Token = "0x4001736")]
    [FieldOffset(Offset = "0x54")]
    private UnitScrollListCell.ButtonState buttonState;
    [Token(Token = "0x4001737")]
    [FieldOffset(Offset = "0x58")]
    private bool needRefresh;
    [Token(Token = "0x4001738")]
    [FieldOffset(Offset = "0x59")]
    private bool isFirestTweenPlay;

    [Token(Token = "0x6001731")]
    [Address(RVA = "0x248B0C4", Offset = "0x248B0C4", VA = "0x248B0C4", Slot = "4")]
    public override void Initialize(UIScrollGridPane owner)
    {
    }

    [Token(Token = "0x6001732")]
    [Address(RVA = "0x248B0E0", Offset = "0x248B0E0", VA = "0x248B0E0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6001733")]
    [Address(RVA = "0x248B114", Offset = "0x248B114", VA = "0x248B114")]
    public void UpdateCell()
    {
    }

    [Token(Token = "0x6001734")]
    [Address(RVA = "0x248B688", Offset = "0x248B688", VA = "0x248B688")]
    public void SetStyle(Style style)
    {
    }

    [Token(Token = "0x6001735")]
    [Address(RVA = "0x248B6F0", Offset = "0x248B6F0", VA = "0x248B6F0")]
    public void UnEquip()
    {
    }

    [Token(Token = "0x6001736")]
    [Address(RVA = "0x248B710", Offset = "0x248B710", VA = "0x248B710")]
    public void UnitDark()
    {
    }

    [Token(Token = "0x6001737")]
    [Address(RVA = "0x248B730", Offset = "0x248B730", VA = "0x248B730")]
    public void UnitDeplicate()
    {
    }

    [Token(Token = "0x6001738")]
    [Address(RVA = "0x248B750", Offset = "0x248B750", VA = "0x248B750")]
    public void SetButtonAction(Action buttonAction)
    {
    }

    [Token(Token = "0x6001739")]
    [Address(RVA = "0x248B840", Offset = "0x248B840", VA = "0x248B840")]
    public void SetLongPressAction(Action longPressAction)
    {
    }

    [Token(Token = "0x600173A")]
    [Address(RVA = "0x248B930", Offset = "0x248B930", VA = "0x248B930")]
    public void SetEnableButton(bool enable)
    {
    }

    [Token(Token = "0x600173B")]
    [Address(RVA = "0x248B964", Offset = "0x248B964", VA = "0x248B964")]
    public void ShowNumber(int number)
    {
    }

    [Token(Token = "0x600173C")]
    [Address(RVA = "0x248BA20", Offset = "0x248BA20", VA = "0x248BA20")]
    public void ShowSelectLabel()
    {
    }

    [Token(Token = "0x600173D")]
    [Address(RVA = "0x248BA98", Offset = "0x248BA98", VA = "0x248BA98")]
    public void HideNumber()
    {
    }

    [Token(Token = "0x600173E")]
    [Address(RVA = "0x248B1E0", Offset = "0x248B1E0", VA = "0x248B1E0")]
    private void SetUnitHeaderActive(bool isActive)
    {
    }

    [Token(Token = "0x600173F")]
    [Address(RVA = "0x248B0F8", Offset = "0x248B0F8", VA = "0x248B0F8")]
    private void SetState(UnitScrollListCell.DisplayState state)
    {
    }

    [Token(Token = "0x6001740")]
    [Address(RVA = "0x248B278", Offset = "0x248B278", VA = "0x248B278")]
    private void ShowUnit()
    {
    }

    [Token(Token = "0x6001741")]
    [Address(RVA = "0x248B570", Offset = "0x248B570", VA = "0x248B570")]
    private void ShowEmpty()
    {
    }

    [Token(Token = "0x6001742")]
    [Address(RVA = "0x248B518", Offset = "0x248B518", VA = "0x248B518")]
    private void ShowUnEquip()
    {
    }

    [Token(Token = "0x6001743")]
    [Address(RVA = "0x248B5C8", Offset = "0x248B5C8", VA = "0x248B5C8")]
    private void ShowDark()
    {
    }

    [Token(Token = "0x6001744")]
    [Address(RVA = "0x248B628", Offset = "0x248B628", VA = "0x248B628")]
    private void ShowDeplicate()
    {
    }

    [Token(Token = "0x6001745")]
    [Address(RVA = "0x248BAB8", Offset = "0x248BAB8", VA = "0x248BAB8")]
    private void HideThumbnail()
    {
    }

    [Token(Token = "0x6001746")]
    [Address(RVA = "0x248BAD8", Offset = "0x248BAD8", VA = "0x248BAD8")]
    private void SetThumbnail(Sprite sprite)
    {
    }

    [Token(Token = "0x6001747")]
    [Address(RVA = "0x248BB0C", Offset = "0x248BB0C", VA = "0x248BB0C")]
    public UnitScrollListCell()
    {
    }

    [Token(Token = "0x2000415")]
    public enum DisplayState
    {
      [Token(Token = "0x400173A")] Initialized,
      [Token(Token = "0x400173B")] Unit,
      [Token(Token = "0x400173C")] UnEquip,
      [Token(Token = "0x400173D")] Empty,
      [Token(Token = "0x400173E")] Dark,
      [Token(Token = "0x400173F")] Deplicate,
    }

    [Token(Token = "0x2000416")]
    public enum ButtonState
    {
      [Token(Token = "0x4001741")] Enable,
      [Token(Token = "0x4001742")] Disable,
    }
  }
}
