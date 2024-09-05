// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerProfile.PersonalEmblemSortFilterPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using StaqData.Sort;
using System;
using System.Collections.Generic;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.PlayerProfile
{
  [Token(Token = "0x20034AC")]
  public class PersonalEmblemSortFilterPopup : MonoBehaviour
  {
    [Token(Token = "0x400E525")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform contentTrans;
    [Token(Token = "0x400E526")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400E527")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollRect sortRect;
    [Token(Token = "0x400E528")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ScrollRect filterRect;
    [Token(Token = "0x400E529")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected Toggle sortOrderAscendingToggle;
    [Token(Token = "0x400E52A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    protected Toggle sortOrderDesendingToggle;
    [Token(Token = "0x400E52B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    protected Button sortClearButton;
    [Token(Token = "0x400E52C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Toggle sortEquipToggle;
    [Token(Token = "0x400E52D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private PersonalEmblemSortToggle[] sortToggles;
    [Token(Token = "0x400E52E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private PersonalEmblemFilterToggleGroup[] filterToggleGroups;
    [Token(Token = "0x400E52F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    protected BtnFullScreen btnFullScreen;
    [Token(Token = "0x400E530")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject filterCategoryButtonPrefab;
    [Token(Token = "0x400E531")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Transform filterCategoryRoot;
    [Token(Token = "0x400E532")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private PersonalEmblemFilterToggleGroup categoryTogglegroup;
    [Token(Token = "0x400E533")]
    [FieldOffset(Offset = "0x88")]
    private Action<List<PersonalEmblemListItem.PersonalEmblemInfo>> sortAction;
    [Token(Token = "0x400E534")]
    [FieldOffset(Offset = "0x90")]
    private Action closeAction;
    [Token(Token = "0x400E535")]
    [FieldOffset(Offset = "0x98")]
    private PersonalEmblemSortUtility.PersonalEmblemSortCondition sortSelect;
    [Token(Token = "0x400E536")]
    [FieldOffset(Offset = "0x9C")]
    private bool isAscending;
    [Token(Token = "0x400E537")]
    [FieldOffset(Offset = "0x9D")]
    private bool isSortEquip;
    [Token(Token = "0x400E538")]
    [FieldOffset(Offset = "0xA0")]
    private List<PersonalEmblemListItem.PersonalEmblemInfo> emblemList;
    [Token(Token = "0x400E539")]
    [FieldOffset(Offset = "0xA8")]
    private List<PersonalEmblemListItem.PersonalEmblemInfo> possessionList;
    [Token(Token = "0x400E53A")]
    [FieldOffset(Offset = "0xB0")]
    private List<PersonalEmblemListItem.PersonalEmblemInfo> notPossessionList;
    [Token(Token = "0x400E53B")]
    [FieldOffset(Offset = "0xB8")]
    private bool isFirstIn;
    [Token(Token = "0x400E53C")]
    [FieldOffset(Offset = "0xBC")]
    private int setEmblemId;

    [Token(Token = "0x6014A8F")]
    [Address(RVA = "0x1D66AA0", Offset = "0x1D66AA0", VA = "0x1D66AA0")]
    public void Initialized()
    {
    }

    [Token(Token = "0x6014A90")]
    [Address(RVA = "0x1D66DD8", Offset = "0x1D66DD8", VA = "0x1D66DD8")]
    private void CreateCategoryButtonByMasterData()
    {
    }

    [Token(Token = "0x6014A91")]
    [Address(RVA = "0x1D6761C", Offset = "0x1D6761C", VA = "0x1D6761C")]
    public void OnSortActionEmblemList()
    {
    }

    [Token(Token = "0x6014A92")]
    [Address(RVA = "0x1D67B2C", Offset = "0x1D67B2C", VA = "0x1D67B2C")]
    public void OnSortClear()
    {
    }

    [Token(Token = "0x6014A93")]
    [Address(RVA = "0x1D67568", Offset = "0x1D67568", VA = "0x1D67568")]
    private void UpdateSortToggleViews()
    {
    }

    [Token(Token = "0x6014A94")]
    [Address(RVA = "0x1D675DC", Offset = "0x1D675DC", VA = "0x1D675DC")]
    private void UpdateSortOrderToggleViews()
    {
    }

    [Token(Token = "0x6014A95")]
    [Address(RVA = "0x1D67C18", Offset = "0x1D67C18", VA = "0x1D67C18")]
    public void Open(
      List<PersonalEmblemListItem.PersonalEmblemInfo> emblemList,
      int setEmblemId)
    {
    }

    [Token(Token = "0x6014A96")]
    [Address(RVA = "0x1D67D10", Offset = "0x1D67D10", VA = "0x1D67D10")]
    public void Open(
      List<PersonalEmblemListItem.PersonalEmblemInfo> possessionList,
      List<PersonalEmblemListItem.PersonalEmblemInfo> notPossessionList,
      int setEmblemId)
    {
    }

    [Token(Token = "0x6014A97")]
    [Address(RVA = "0x1D67E0C", Offset = "0x1D67E0C", VA = "0x1D67E0C")]
    private void FinishedOpen()
    {
    }

    [Token(Token = "0x6014A98")]
    [Address(RVA = "0x1D67A74", Offset = "0x1D67A74", VA = "0x1D67A74")]
    public void Close()
    {
    }

    [Token(Token = "0x6014A99")]
    [Address(RVA = "0x1D67EC0", Offset = "0x1D67EC0", VA = "0x1D67EC0")]
    private void FinishedClose()
    {
    }

    [Token(Token = "0x6014A9A")]
    [Address(RVA = "0x1D67FC4", Offset = "0x1D67FC4", VA = "0x1D67FC4")]
    public void OnValueChangedSortToggle(
      PersonalEmblemSortUtility.PersonalEmblemSortCondition condition)
    {
    }

    [Token(Token = "0x6014A9B")]
    [Address(RVA = "0x1D67FCC", Offset = "0x1D67FCC", VA = "0x1D67FCC")]
    public void OnFilterAllOn()
    {
    }

    [Token(Token = "0x6014A9C")]
    [Address(RVA = "0x1D6802C", Offset = "0x1D6802C", VA = "0x1D6802C")]
    public void OnFilterAllClear()
    {
    }

    [Token(Token = "0x6014A9D")]
    [Address(RVA = "0x1D6736C", Offset = "0x1D6736C", VA = "0x1D6736C")]
    private void LoadSortFilterSaveData()
    {
    }

    [Token(Token = "0x6014A9E")]
    [Address(RVA = "0x1D6789C", Offset = "0x1D6789C", VA = "0x1D6789C")]
    private void SortFilterDataSave()
    {
    }

    [Token(Token = "0x6014A9F")]
    [Address(RVA = "0x1D67B4C", Offset = "0x1D67B4C", VA = "0x1D67B4C")]
    private void ResetToDefaultSortData()
    {
    }

    [Token(Token = "0x6014AA0")]
    [Address(RVA = "0x1D6808C", Offset = "0x1D6808C", VA = "0x1D6808C")]
    public void SetSortAction(
      Action<List<PersonalEmblemListItem.PersonalEmblemInfo>> action)
    {
    }

    [Token(Token = "0x6014AA1")]
    [Address(RVA = "0x1D68094", Offset = "0x1D68094", VA = "0x1D68094")]
    public PersonalEmblemSortFilterPopup()
    {
    }
  }
}
