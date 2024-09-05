// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerProfile.PersonalEmblemChangePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.PersonalEmblem;
using System;
using System.Collections.Generic;
using TMPro;
using UI.SortFilter;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.PlayerProfile
{
  [Token(Token = "0x20034A1")]
  public class PersonalEmblemChangePopup : PopupBase
  {
    [Token(Token = "0x400E4F4")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private PersonalEmblemThumb personalEmblemThumb;
    [Token(Token = "0x400E4F5")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private VerticalGridInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400E4F6")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private SortFilterHeaderButton sortFilterHeaderButton;
    [Token(Token = "0x400E4F7")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI explainText;
    [Token(Token = "0x400E4FA")]
    [FieldOffset(Offset = "0xB8")]
    private int selectingEmblemId;
    [Token(Token = "0x400E4FB")]
    [FieldOffset(Offset = "0xC0")]
    private List<PersonalEmblemData> allEmblemResources;
    [Token(Token = "0x400E4FC")]
    [FieldOffset(Offset = "0xC8")]
    private List<PersonalEmblemData> emblemResources;
    [Token(Token = "0x400E4FD")]
    [FieldOffset(Offset = "0xD0")]
    private List<PersonalEmblemListItem.PersonalEmblemCellData> allResourceDatas;
    [Token(Token = "0x400E4FE")]
    [FieldOffset(Offset = "0xD8")]
    private List<PersonalEmblemListItem.PersonalEmblemCellData> resourceDatas;
    [Token(Token = "0x400E4FF")]
    [FieldOffset(Offset = "0xE0")]
    private List<InfiniteCellData> cellDatas;
    [Token(Token = "0x400E500")]
    [FieldOffset(Offset = "0xE8")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x1700448B")]
    public Action<int> OnClickExecute
    {
      [Token(Token = "0x6014A53"), Address(RVA = "0x1D63390", Offset = "0x1D63390", VA = "0x1D63390")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6014A54"), Address(RVA = "0x1D63398", Offset = "0x1D63398", VA = "0x1D63398")] private set
      {
      }
    }

    [Token(Token = "0x1700448C")]
    public Action OnClickCancel
    {
      [Token(Token = "0x6014A55"), Address(RVA = "0x1D633A0", Offset = "0x1D633A0", VA = "0x1D633A0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6014A56"), Address(RVA = "0x1D633A8", Offset = "0x1D633A8", VA = "0x1D633A8")] private set
      {
      }
    }

    [Token(Token = "0x6014A57")]
    [Address(RVA = "0x1D633B0", Offset = "0x1D633B0", VA = "0x1D633B0")]
    private void Update()
    {
    }

    [Token(Token = "0x6014A58")]
    [Address(RVA = "0x1D633CC", Offset = "0x1D633CC", VA = "0x1D633CC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6014A59")]
    [Address(RVA = "0x1D63568", Offset = "0x1D63568", VA = "0x1D63568")]
    public void OnOpenSortAndFilter()
    {
    }

    [Token(Token = "0x6014A5A")]
    [Address(RVA = "0x1D6352C", Offset = "0x1D6352C", VA = "0x1D6352C")]
    public void UpdateEmblemList()
    {
    }

    [Token(Token = "0x6014A5B")]
    [Address(RVA = "0x1D646E0", Offset = "0x1D646E0", VA = "0x1D646E0")]
    private void UpdateSortFilterAction(
      List<PersonalEmblemListItem.PersonalEmblemInfo> sortFilterList)
    {
    }

    [Token(Token = "0x6014A5C")]
    [Address(RVA = "0x1D6354C", Offset = "0x1D6354C", VA = "0x1D6354C")]
    private void UpdateSortFilterButton()
    {
    }

    [Token(Token = "0x6014A5D")]
    [Address(RVA = "0x1D63A28", Offset = "0x1D63A28", VA = "0x1D63A28")]
    private void CreateList()
    {
    }

    [Token(Token = "0x6014A5E")]
    [Address(RVA = "0x1D64714", Offset = "0x1D64714", VA = "0x1D64714")]
    private void CreateList(
      List<PersonalEmblemListItem.PersonalEmblemInfo> sortFilterList)
    {
    }

    [Token(Token = "0x6014A5F")]
    [Address(RVA = "0x1D64874", Offset = "0x1D64874", VA = "0x1D64874")]
    private void OnSelectRemoveButtonAction(int _)
    {
    }

    [Token(Token = "0x6014A60")]
    [Address(RVA = "0x1D63DC0", Offset = "0x1D63DC0", VA = "0x1D63DC0")]
    private void SetEmblemList(
      List<PersonalEmblemData> targetList,
      ref List<PersonalEmblemListItem.PersonalEmblemCellData> fillDataBox)
    {
    }

    [Token(Token = "0x6014A61")]
    [Address(RVA = "0x1D64BB8", Offset = "0x1D64BB8", VA = "0x1D64BB8")]
    private void OnSelectCellButton(int emblemId)
    {
    }

    [Token(Token = "0x6014A62")]
    [Address(RVA = "0x1D65228", Offset = "0x1D65228", VA = "0x1D65228")]
    public void SetCurrentPersonalEmblemData(int emblemId)
    {
    }

    [Token(Token = "0x6014A63")]
    [Address(RVA = "0x1D65784", Offset = "0x1D65784", VA = "0x1D65784")]
    public void SetCallbackByExecute(Action<int> onClickExecute)
    {
    }

    [Token(Token = "0x6014A64")]
    [Address(RVA = "0x1D6578C", Offset = "0x1D6578C", VA = "0x1D6578C")]
    public void SetCallbackByCancel(Action onClickCancel)
    {
    }

    [Token(Token = "0x6014A65")]
    [Address(RVA = "0x1D65794", Offset = "0x1D65794", VA = "0x1D65794")]
    public void OnClickToExecuteButton()
    {
    }

    [Token(Token = "0x6014A66")]
    [Address(RVA = "0x1D657B4", Offset = "0x1D657B4", VA = "0x1D657B4")]
    public void OnClickToCancelButton()
    {
    }

    [Token(Token = "0x6014A67")]
    [Address(RVA = "0x1D657D0", Offset = "0x1D657D0", VA = "0x1D657D0")]
    public PersonalEmblemChangePopup()
    {
    }
  }
}
