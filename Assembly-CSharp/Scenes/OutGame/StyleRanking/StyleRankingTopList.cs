// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.StyleRanking.StyleRankingTopList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;
using System.Collections.Generic;
using UI.SortFilter;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.StyleRanking
{
  [Token(Token = "0x200337C")]
  internal class StyleRankingTopList : MonoBehaviour
  {
    [Token(Token = "0x400DF2F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private VerticalGridInfiniteScrollView scrollView;
    [Token(Token = "0x400DF30")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject nothing;
    [Token(Token = "0x400DF31")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SortFilterHeaderButton sortFilterHeaderButton;
    [Token(Token = "0x400DF32")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton combatPowerRanking;
    [Token(Token = "0x400DF33")]
    [FieldOffset(Offset = "0x38")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400DF34")]
    [FieldOffset(Offset = "0x40")]
    private List<StyleRankingTopCellResource> resources;
    [Token(Token = "0x400DF35")]
    [FieldOffset(Offset = "0x48")]
    private List<BaseRankingListType> rankingTops;
    [Token(Token = "0x400DF36")]
    [FieldOffset(Offset = "0x50")]
    private Action<int> onClickAction;
    [Token(Token = "0x400DF37")]
    [FieldOffset(Offset = "0x58")]
    private Action<List<int>> setListAction;
    [Token(Token = "0x400DF38")]
    [FieldOffset(Offset = "0x60")]
    private StyleRankingFilterPopup filterPopup;

    [Token(Token = "0x60143B0")]
    [Address(RVA = "0x1E18B38", Offset = "0x1E18B38", VA = "0x1E18B38")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      Action<int> onClickAction,
      Action<List<int>> setListAction)
    {
    }

    [Token(Token = "0x60143B1")]
    [Address(RVA = "0x1E1A44C", Offset = "0x1E1A44C", VA = "0x1E1A44C")]
    public void UpdateList(List<BaseRankingListType> rankingTops)
    {
    }

    [Token(Token = "0x60143B2")]
    [Address(RVA = "0x1E18CB4", Offset = "0x1E18CB4", VA = "0x1E18CB4")]
    public bool CloseFilterPopup() => new bool();

    [Token(Token = "0x60143B3")]
    [Address(RVA = "0x1E1B350", Offset = "0x1E1B350", VA = "0x1E1B350")]
    private void CreateList()
    {
    }

    [Token(Token = "0x60143B4")]
    [Address(RVA = "0x1E1BEAC", Offset = "0x1E1BEAC", VA = "0x1E1BEAC")]
    private void OnClickSortFilter()
    {
    }

    [Token(Token = "0x60143B5")]
    [Address(RVA = "0x1E1C014", Offset = "0x1E1C014", VA = "0x1E1C014")]
    private void UpdateSortFilterAction(List<Style> filterList)
    {
    }

    [Token(Token = "0x60143B6")]
    [Address(RVA = "0x1E1BA80", Offset = "0x1E1BA80", VA = "0x1E1BA80")]
    private void UpdateSortFilterButton()
    {
    }

    [Token(Token = "0x60143B7")]
    [Address(RVA = "0x1E1C040", Offset = "0x1E1C040", VA = "0x1E1C040")]
    private void CreateList(List<Style> filterList)
    {
    }

    [Token(Token = "0x60143B8")]
    [Address(RVA = "0x1E1BA9C", Offset = "0x1E1BA9C", VA = "0x1E1BA9C")]
    private List<BaseRankingListType> ApplySortFilter(List<Style> filterList)
    {
      return (List<BaseRankingListType>) null;
    }

    [Token(Token = "0x60143B9")]
    [Address(RVA = "0x1E1B678", Offset = "0x1E1B678", VA = "0x1E1B678")]
    private void SetList()
    {
    }

    [Token(Token = "0x60143BA")]
    [Address(RVA = "0x1E1C30C", Offset = "0x1E1C30C", VA = "0x1E1C30C")]
    private void OnClickTopList(int index)
    {
    }

    [Token(Token = "0x60143BB")]
    [Address(RVA = "0x1E1C348", Offset = "0x1E1C348", VA = "0x1E1C348")]
    public StyleRankingTopList()
    {
    }
  }
}
