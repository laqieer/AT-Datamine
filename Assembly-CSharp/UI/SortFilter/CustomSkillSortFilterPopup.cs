// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.CustomSkillSortFilterPopup
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
  [Token(Token = "0x200092A")]
  public class CustomSkillSortFilterPopup : MonoBehaviour
  {
    [Token(Token = "0x4002A93")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002A94")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ScrollRect sortRect;
    [Token(Token = "0x4002A95")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollRect filterRect;
    [Token(Token = "0x4002A96")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Toggle sortOrderAscendingToggle;
    [Token(Token = "0x4002A97")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Toggle sortOrderDesendingToggle;
    [Token(Token = "0x4002A98")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    protected Button sortClearButton;
    [Token(Token = "0x4002A99")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Toggle sortEquipToggle;
    [Token(Token = "0x4002A9A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CustomSkillSortToggle[] sortToggles;
    [Token(Token = "0x4002A9B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CustomSkillFilterToggleGroup[] filterToggleGroups;
    [Token(Token = "0x4002A9C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    protected BtnFullScreen btnFullScreen;
    [Token(Token = "0x4002A9D")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4002A9E")]
    [FieldOffset(Offset = "0x70")]
    private Action<List<CustomSkill>> sortAction;
    [Token(Token = "0x4002A9F")]
    [FieldOffset(Offset = "0x78")]
    private CustomSkillSortCondition sortSelect;
    [Token(Token = "0x4002AA0")]
    [FieldOffset(Offset = "0x7C")]
    private bool isAscending;
    [Token(Token = "0x4002AA1")]
    [FieldOffset(Offset = "0x7D")]
    private bool isSortEquip;
    [Token(Token = "0x4002AA2")]
    [FieldOffset(Offset = "0x80")]
    private List<CustomSkill> customSkillList;
    [Token(Token = "0x4002AA3")]
    [FieldOffset(Offset = "0x88")]
    private bool isFirstIn;
    [Token(Token = "0x4002AA4")]
    [FieldOffset(Offset = "0x90")]
    private List<UniqueID> setUniqueIDs;

    [Token(Token = "0x6003392")]
    [Address(RVA = "0x3629490", Offset = "0x3629490", VA = "0x3629490")]
    public void Initialized()
    {
    }

    [Token(Token = "0x6003393")]
    [Address(RVA = "0x3629BD0", Offset = "0x3629BD0", VA = "0x3629BD0")]
    public void Open(List<CustomSkill> list)
    {
    }

    [Token(Token = "0x6003394")]
    [Address(RVA = "0x3629DE8", Offset = "0x3629DE8", VA = "0x3629DE8")]
    public void Open(List<CustomSkill> skillList, List<UniqueID> setUniqueIDs)
    {
    }

    [Token(Token = "0x6003395")]
    [Address(RVA = "0x3629EE0", Offset = "0x3629EE0", VA = "0x3629EE0")]
    public void Close()
    {
    }

    [Token(Token = "0x6003396")]
    [Address(RVA = "0x3629FC0", Offset = "0x3629FC0", VA = "0x3629FC0")]
    private void FinishedOpen()
    {
    }

    [Token(Token = "0x6003397")]
    [Address(RVA = "0x362A074", Offset = "0x362A074", VA = "0x362A074")]
    private void FinishedClose()
    {
    }

    [Token(Token = "0x6003398")]
    [Address(RVA = "0x362A160", Offset = "0x362A160", VA = "0x362A160")]
    public void SetSortAction(Action<List<CustomSkill>> action)
    {
    }

    [Token(Token = "0x6003399")]
    [Address(RVA = "0x362A168", Offset = "0x362A168", VA = "0x362A168")]
    public void OnSortAction()
    {
    }

    [Token(Token = "0x600339A")]
    [Address(RVA = "0x362A4A8", Offset = "0x362A4A8", VA = "0x362A4A8")]
    public void OnSortClear()
    {
    }

    [Token(Token = "0x600339B")]
    [Address(RVA = "0x3629B1C", Offset = "0x3629B1C", VA = "0x3629B1C")]
    private void UpdateSortToggleViews()
    {
    }

    [Token(Token = "0x600339C")]
    [Address(RVA = "0x3629B90", Offset = "0x3629B90", VA = "0x3629B90")]
    private void UpdateSortOrderToggleViews()
    {
    }

    [Token(Token = "0x600339D")]
    [Address(RVA = "0x362A594", Offset = "0x362A594", VA = "0x362A594")]
    public void OnValueChangedSortToggle(CustomSkillSortCondition condition)
    {
    }

    [Token(Token = "0x600339E")]
    [Address(RVA = "0x362A59C", Offset = "0x362A59C", VA = "0x362A59C")]
    public void OnFilterAllOn()
    {
    }

    [Token(Token = "0x600339F")]
    [Address(RVA = "0x362A5FC", Offset = "0x362A5FC", VA = "0x362A5FC")]
    public void OnFilterAllClear()
    {
    }

    [Token(Token = "0x60033A0")]
    [Address(RVA = "0x3629838", Offset = "0x3629838", VA = "0x3629838")]
    private void LoadSortFilterSaveData()
    {
    }

    [Token(Token = "0x60033A1")]
    [Address(RVA = "0x362A2D0", Offset = "0x362A2D0", VA = "0x362A2D0")]
    private void SortFilterDataSave()
    {
    }

    [Token(Token = "0x60033A2")]
    [Address(RVA = "0x362A4C8", Offset = "0x362A4C8", VA = "0x362A4C8")]
    private void ResetToDefaultSortData()
    {
    }

    [Token(Token = "0x60033A3")]
    [Address(RVA = "0x362A664", Offset = "0x362A664", VA = "0x362A664")]
    public CustomSkillSortFilterPopup()
    {
    }
  }
}
