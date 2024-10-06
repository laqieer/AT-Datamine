// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.SaleItemSortPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame;
using System;
using System.Collections.Generic;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.SortFilter
{
  [Token(Token = "0x200093B")]
  public class SaleItemSortPopup : MonoBehaviour
  {
    [Token(Token = "0x4002AD9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002ADA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ScrollRect sortRect;
    [Token(Token = "0x4002ADB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected Toggle sortOrderAscendingToggle;
    [Token(Token = "0x4002ADC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    protected Toggle sortOrderDesendingToggle;
    [Token(Token = "0x4002ADD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected Button sortClearButton;
    [Token(Token = "0x4002ADE")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private SaleItemSortPopup.SortToggle[] sortToggles;
    [Token(Token = "0x4002ADF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    protected BtnFullScreen btnFullScreen;
    [Token(Token = "0x4002AE0")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4002AE1")]
    [FieldOffset(Offset = "0x58")]
    private Action<Dictionary<int, List<ItemListData>>> sortAction;
    [Token(Token = "0x4002AE2")]
    [FieldOffset(Offset = "0x60")]
    private SaleItemSortPopup.SaleSortType saleSortType;
    [Token(Token = "0x4002AE3")]
    [FieldOffset(Offset = "0x64")]
    private bool isAscending;
    [Token(Token = "0x4002AE4")]
    [FieldOffset(Offset = "0x65")]
    private bool isSortEquip;
    [Token(Token = "0x4002AE5")]
    [FieldOffset(Offset = "0x68")]
    private Dictionary<int, List<ItemListData>> categoryItemMap;

    [Token(Token = "0x6003400")]
    [Address(RVA = "0x362CC10", Offset = "0x362CC10", VA = "0x362CC10")]
    public void Initialized(
      Dictionary<int, List<ItemListData>> categoryItemMap,
      Action<Dictionary<int, List<ItemListData>>> sortAction)
    {
    }

    [Token(Token = "0x6003401")]
    [Address(RVA = "0x362D2F8", Offset = "0x362D2F8", VA = "0x362D2F8")]
    private void Save()
    {
    }

    [Token(Token = "0x6003402")]
    [Address(RVA = "0x362D460", Offset = "0x362D460", VA = "0x362D460")]
    private void ResetToDefaultSortData()
    {
    }

    [Token(Token = "0x6003403")]
    [Address(RVA = "0x362D500", Offset = "0x362D500", VA = "0x362D500")]
    public void OnSortClear()
    {
    }

    [Token(Token = "0x6003404")]
    [Address(RVA = "0x362D110", Offset = "0x362D110", VA = "0x362D110")]
    private void InitializeSortToggles()
    {
    }

    [Token(Token = "0x6003405")]
    [Address(RVA = "0x362D254", Offset = "0x362D254", VA = "0x362D254")]
    private void UpdateSortToggleViews()
    {
    }

    [Token(Token = "0x6003406")]
    [Address(RVA = "0x362D2B8", Offset = "0x362D2B8", VA = "0x362D2B8")]
    private void UpdateSortOrderToggleViews()
    {
    }

    [Token(Token = "0x6003407")]
    [Address(RVA = "0x362D554", Offset = "0x362D554", VA = "0x362D554")]
    public void Open()
    {
    }

    [Token(Token = "0x6003408")]
    [Address(RVA = "0x362D628", Offset = "0x362D628", VA = "0x362D628")]
    public void Close()
    {
    }

    [Token(Token = "0x6003409")]
    [Address(RVA = "0x362D708", Offset = "0x362D708", VA = "0x362D708")]
    private void FinishedOpen()
    {
    }

    [Token(Token = "0x600340A")]
    [Address(RVA = "0x362D794", Offset = "0x362D794", VA = "0x362D794")]
    private void FinishedClose()
    {
    }

    [Token(Token = "0x600340B")]
    [Address(RVA = "0x362D880", Offset = "0x362D880", VA = "0x362D880")]
    private void Sort()
    {
    }

    [Token(Token = "0x600340C")]
    [Address(RVA = "0x362D894", Offset = "0x362D894", VA = "0x362D894")]
    public void OnClickToClose()
    {
    }

    [Token(Token = "0x600340D")]
    [Address(RVA = "0x362D8E8", Offset = "0x362D8E8", VA = "0x362D8E8")]
    public SaleItemSortPopup()
    {
    }

    [Token(Token = "0x200093C")]
    public enum SaleSortType
    {
      [Token(Token = "0x4002AE7")] ID,
      [Token(Token = "0x4002AE8")] SalesAmount,
      [Token(Token = "0x4002AE9")] Rarity,
    }

    [Token(Token = "0x200093D")]
    [Serializable]
    private class SortToggle
    {
      [Token(Token = "0x4002AEA")]
      [FieldOffset(Offset = "0x10")]
      public SaleItemSortPopup.SaleSortType sortType;
      [Token(Token = "0x4002AEB")]
      [FieldOffset(Offset = "0x18")]
      public Toggle toggle;

      [Token(Token = "0x6003410")]
      [Address(RVA = "0x362D528", Offset = "0x362D528", VA = "0x362D528")]
      public void UpdateToggleStatus(SaleItemSortPopup.SaleSortType sortCondition)
      {
      }

      [Token(Token = "0x6003411")]
      [Address(RVA = "0x362D980", Offset = "0x362D980", VA = "0x362D980")]
      public SortToggle()
      {
      }
    }
  }
}
