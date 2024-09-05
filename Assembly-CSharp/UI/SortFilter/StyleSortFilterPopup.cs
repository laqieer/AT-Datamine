// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.StyleSortFilterPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using StaqData.Sort;
using System;
using System.Collections.Generic;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.SortFilter
{
  [Token(Token = "0x200094A")]
  public class StyleSortFilterPopup : MonoBehaviour
  {
    [Token(Token = "0x4002B12")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002B13")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ScrollRect sortRect;
    [Token(Token = "0x4002B14")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollRect filterRect;
    [Token(Token = "0x4002B15")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    protected Toggle sortOrderAscendingToggle;
    [Token(Token = "0x4002B16")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected Toggle sortOrderDesendingToggle;
    [Token(Token = "0x4002B17")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    protected Button sortClearButton;
    [Token(Token = "0x4002B18")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Toggle sortEquipToggle;
    [Token(Token = "0x4002B19")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private StyleSortToggle[] sortToggles;
    [Token(Token = "0x4002B1A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private StyleFilterToggleGroup[] filterToggleGroups;
    [Token(Token = "0x4002B1B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    protected BtnFullScreen btnFullScreen;
    [Token(Token = "0x4002B1C")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4002B1D")]
    [FieldOffset(Offset = "0x70")]
    private Action<List<Style>> sortAction;
    [Token(Token = "0x4002B1E")]
    [FieldOffset(Offset = "0x78")]
    private Action closeAction;
    [Token(Token = "0x4002B1F")]
    [FieldOffset(Offset = "0x80")]
    private StyleSortCondition sortSelect;
    [Token(Token = "0x4002B20")]
    [FieldOffset(Offset = "0x84")]
    private bool isAscending;
    [Token(Token = "0x4002B21")]
    [FieldOffset(Offset = "0x85")]
    private bool isSortEquip;
    [Token(Token = "0x4002B22")]
    [FieldOffset(Offset = "0x88")]
    private List<Style> styleList;
    [Token(Token = "0x4002B23")]
    [FieldOffset(Offset = "0x90")]
    private List<Style> possessionList;
    [Token(Token = "0x4002B24")]
    [FieldOffset(Offset = "0x98")]
    private List<Style> notPossessionList;
    [Token(Token = "0x4002B25")]
    [FieldOffset(Offset = "0xA0")]
    private bool isFirstIn;
    [Token(Token = "0x4002B26")]
    [FieldOffset(Offset = "0xA8")]
    private List<int> setStyleIDs;

    [Token(Token = "0x6003455")]
    [Address(RVA = "0x362F7D0", Offset = "0x362F7D0", VA = "0x362F7D0")]
    public void Initialized()
    {
    }

    [Token(Token = "0x6003456")]
    [Address(RVA = "0x362FB48", Offset = "0x362FB48", VA = "0x362FB48")]
    public void Open(List<Style> styleList, List<int> setStyleIDs)
    {
    }

    [Token(Token = "0x6003457")]
    [Address(RVA = "0x362FC40", Offset = "0x362FC40", VA = "0x362FC40")]
    public void Open(
      List<Style> possessionList,
      List<Style> notPossessionList,
      List<int> setStyleIDs)
    {
    }

    [Token(Token = "0x6003458")]
    [Address(RVA = "0x3630F9C", Offset = "0x3630F9C", VA = "0x3630F9C")]
    public void Close()
    {
    }

    [Token(Token = "0x6003459")]
    [Address(RVA = "0x3631054", Offset = "0x3631054", VA = "0x3631054")]
    private void FinishedOpen()
    {
    }

    [Token(Token = "0x600345A")]
    [Address(RVA = "0x3631108", Offset = "0x3631108", VA = "0x3631108")]
    private void FinishedClose()
    {
    }

    [Token(Token = "0x600345B")]
    [Address(RVA = "0x363120C", Offset = "0x363120C", VA = "0x363120C")]
    public void SetSortAction(Action<List<Style>> action)
    {
    }

    [Token(Token = "0x600345C")]
    [Address(RVA = "0x3631214", Offset = "0x3631214", VA = "0x3631214")]
    public void SetCloseAction(Action action)
    {
    }

    [Token(Token = "0x600345D")]
    [Address(RVA = "0x363121C", Offset = "0x363121C", VA = "0x363121C")]
    public void OnSortAction()
    {
    }

    [Token(Token = "0x600345E")]
    [Address(RVA = "0x36314AC", Offset = "0x36314AC", VA = "0x36314AC")]
    private void OnSortActionStyleEdit()
    {
    }

    [Token(Token = "0x600345F")]
    [Address(RVA = "0x363122C", Offset = "0x363122C", VA = "0x363122C")]
    private void OnSortActionStyleList()
    {
    }

    [Token(Token = "0x6003460")]
    [Address(RVA = "0x36317E4", Offset = "0x36317E4", VA = "0x36317E4")]
    public void OnSortClear()
    {
    }

    [Token(Token = "0x6003461")]
    [Address(RVA = "0x3630EE8", Offset = "0x3630EE8", VA = "0x3630EE8")]
    private void UpdateSortToggleViews()
    {
    }

    [Token(Token = "0x6003462")]
    [Address(RVA = "0x3630F5C", Offset = "0x3630F5C", VA = "0x3630F5C")]
    private void UpdateSortOrderToggleViews()
    {
    }

    [Token(Token = "0x6003463")]
    [Address(RVA = "0x36318D0", Offset = "0x36318D0", VA = "0x36318D0")]
    public void OnValueChangedSortToggle(StyleSortCondition condition)
    {
    }

    [Token(Token = "0x6003464")]
    [Address(RVA = "0x36318D8", Offset = "0x36318D8", VA = "0x36318D8")]
    public void OnFilterAllOn()
    {
    }

    [Token(Token = "0x6003465")]
    [Address(RVA = "0x3631938", Offset = "0x3631938", VA = "0x3631938")]
    public void OnFilterAllClear()
    {
    }

    [Token(Token = "0x6003466")]
    [Address(RVA = "0x3630CEC", Offset = "0x3630CEC", VA = "0x3630CEC")]
    private void LoadSortFilterSaveData()
    {
    }

    [Token(Token = "0x6003467")]
    [Address(RVA = "0x363160C", Offset = "0x363160C", VA = "0x363160C")]
    private void SortFilterDataSave()
    {
    }

    [Token(Token = "0x6003468")]
    [Address(RVA = "0x3631804", Offset = "0x3631804", VA = "0x3631804")]
    private void ResetToDefaultSortData()
    {
    }

    [Token(Token = "0x6003469")]
    [Address(RVA = "0x3631998", Offset = "0x3631998", VA = "0x3631998")]
    public StyleSortFilterPopup()
    {
    }
  }
}
