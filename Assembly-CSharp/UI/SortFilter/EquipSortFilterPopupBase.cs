// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.EquipSortFilterPopupBase
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
  [Token(Token = "0x2000930")]
  public class EquipSortFilterPopupBase : MonoBehaviour
  {
    [Token(Token = "0x4002AB1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002AB2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ScrollRect sortRect;
    [Token(Token = "0x4002AB3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollRect filterRect;
    [Token(Token = "0x4002AB4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Toggle sortOrderAscendingToggle;
    [Token(Token = "0x4002AB5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Toggle sortOrderDesendingToggle;
    [Token(Token = "0x4002AB6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button sortClearButton;
    [Token(Token = "0x4002AB7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Toggle sortEquipToggle;
    [Token(Token = "0x4002AB8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    protected EquipSortToggle[] sortToggles;
    [Token(Token = "0x4002AB9")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    protected EquipFilterToggleGroup[] filterToggleGroups;
    [Token(Token = "0x4002ABA")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    protected BtnFullScreen btnFullScreen;
    [Token(Token = "0x4002ABB")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4002ABC")]
    [FieldOffset(Offset = "0x70")]
    protected Action<List<Equipment>> sortAction;
    [Token(Token = "0x4002ABD")]
    [FieldOffset(Offset = "0x78")]
    protected EquipmentSortCondition sortSelect;
    [Token(Token = "0x4002ABE")]
    [FieldOffset(Offset = "0x7C")]
    protected bool isAscending;
    [Token(Token = "0x4002ABF")]
    [FieldOffset(Offset = "0x7D")]
    protected bool isSortEquip;
    [Token(Token = "0x4002AC0")]
    [FieldOffset(Offset = "0x80")]
    protected List<Equipment> equipmentList;
    [Token(Token = "0x4002AC1")]
    [FieldOffset(Offset = "0x88")]
    private bool isFirstIn;
    [Token(Token = "0x4002AC2")]
    [FieldOffset(Offset = "0x90")]
    protected List<UniqueID> setEquipmentUniqueIDs;

    [Token(Token = "0x60033BC")]
    [Address(RVA = "0x362A96C", Offset = "0x362A96C", VA = "0x362A96C")]
    public void Initialized()
    {
    }

    [Token(Token = "0x60033BD")]
    [Address(RVA = "0x36282CC", Offset = "0x36282CC", VA = "0x36282CC", Slot = "4")]
    protected virtual void LoadSortFilterSaveData()
    {
    }

    [Token(Token = "0x60033BE")]
    [Address(RVA = "0x362AEDC", Offset = "0x362AEDC", VA = "0x362AEDC", Slot = "5")]
    protected virtual void ResetToDefaultSortData()
    {
    }

    [Token(Token = "0x60033BF")]
    [Address(RVA = "0x362AEE0", Offset = "0x362AEE0", VA = "0x362AEE0")]
    public void Open(List<Equipment> list)
    {
    }

    [Token(Token = "0x60033C0")]
    [Address(RVA = "0x362B0E4", Offset = "0x362B0E4", VA = "0x362B0E4")]
    public void Open(List<Equipment> equipList, List<UniqueID> setEquipmentUniqueIDs)
    {
    }

    [Token(Token = "0x60033C1")]
    [Address(RVA = "0x3628C20", Offset = "0x3628C20", VA = "0x3628C20")]
    public void Close()
    {
    }

    [Token(Token = "0x60033C2")]
    [Address(RVA = "0x362B204", Offset = "0x362B204", VA = "0x362B204")]
    private void FinishedOpen()
    {
    }

    [Token(Token = "0x60033C3")]
    [Address(RVA = "0x362B290", Offset = "0x362B290", VA = "0x362B290")]
    private void FinishedClose()
    {
    }

    [Token(Token = "0x60033C4")]
    [Address(RVA = "0x362B37C", Offset = "0x362B37C", VA = "0x362B37C")]
    public void SetSortAction(Action<List<Equipment>> action)
    {
    }

    [Token(Token = "0x60033C5")]
    [Address(RVA = "0x362B384", Offset = "0x362B384", VA = "0x362B384", Slot = "6")]
    public virtual void OnSortAction()
    {
    }

    [Token(Token = "0x60033C6")]
    [Address(RVA = "0x362B388", Offset = "0x362B388", VA = "0x362B388")]
    public void OnSortClear()
    {
    }

    [Token(Token = "0x60033C7")]
    [Address(RVA = "0x362AE24", Offset = "0x362AE24", VA = "0x362AE24")]
    private void UpdateSortToggleViews()
    {
    }

    [Token(Token = "0x60033C8")]
    [Address(RVA = "0x362AE9C", Offset = "0x362AE9C", VA = "0x362AE9C")]
    private void UpdateSortOrderToggleViews()
    {
    }

    [Token(Token = "0x60033C9")]
    [Address(RVA = "0x362B3DC", Offset = "0x362B3DC", VA = "0x362B3DC")]
    public void OnValueChangedSortToggle(EquipmentSortCondition condition)
    {
    }

    [Token(Token = "0x60033CA")]
    [Address(RVA = "0x362B3E4", Offset = "0x362B3E4", VA = "0x362B3E4")]
    public void OnFilterAllOn()
    {
    }

    [Token(Token = "0x60033CB")]
    [Address(RVA = "0x362B444", Offset = "0x362B444", VA = "0x362B444")]
    public void OnFilterAllClear()
    {
    }

    [Token(Token = "0x60033CC")]
    [Address(RVA = "0x3628894", Offset = "0x3628894", VA = "0x3628894")]
    protected void SortFilterDataSave(EquipmentType equipmentType)
    {
    }

    [Token(Token = "0x60033CD")]
    [Address(RVA = "0x3628D08", Offset = "0x3628D08", VA = "0x3628D08")]
    public EquipSortFilterPopupBase()
    {
    }
  }
}
