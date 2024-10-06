// Decompiled with JetBrains decompiler
// Type: Gacha.GachaList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Utility;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001500")]
  internal class GachaList
  {
    [Token(Token = "0x400606D")]
    public const int TutorialGachaID = 1010001;
    [Token(Token = "0x400606E")]
    public const int StoryGachaID = 3220000;
    [Token(Token = "0x400606F")]
    [FieldOffset(Offset = "0x10")]
    private GachaListView view;
    [Token(Token = "0x4006070")]
    [FieldOffset(Offset = "0x18")]
    private List<GachaListItem> banners;
    [Token(Token = "0x4006072")]
    [FieldOffset(Offset = "0x28")]
    public Action<string, int> SelectedGachaChanged;
    [Token(Token = "0x4006073")]
    [FieldOffset(Offset = "0x30")]
    private GachaListInfo gachaListInfo;
    [Token(Token = "0x4006074")]
    [FieldOffset(Offset = "0x38")]
    private GameObject gachaScheduleView;
    [Token(Token = "0x4006075")]
    [FieldOffset(Offset = "0x40")]
    private GachaResourceProvider resourceProvider;
    [Token(Token = "0x4006076")]
    [FieldOffset(Offset = "0x48")]
    private Func<bool> isTutorialGacha;
    [Token(Token = "0x4006077")]
    [FieldOffset(Offset = "0x50")]
    private NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x4006078")]
    [FieldOffset(Offset = "0x58")]
    private List<GachaListItemInfo> filteredListItemInfos;

    [Token(Token = "0x1700125B")]
    public int SelectedIndex
    {
      [Token(Token = "0x60076CA"), Address(RVA = "0x44EBE6C", Offset = "0x44EBE6C", VA = "0x44EBE6C")] get
      {
        return new int();
      }
      [Token(Token = "0x60076CB"), Address(RVA = "0x44EBE74", Offset = "0x44EBE74", VA = "0x44EBE74")] private set
      {
      }
    }

    [Token(Token = "0x60076CC")]
    [Address(RVA = "0x44EBE7C", Offset = "0x44EBE7C", VA = "0x44EBE7C")]
    public GachaList(
      GachaListView view,
      GameObject gachaScheduleView,
      GachaResourceProvider resourceProvider,
      Func<bool> isTutorialGacha,
      NewBadgeProxy newBadgeProxy)
    {
    }

    [Token(Token = "0x60076CD")]
    [Address(RVA = "0x44EC240", Offset = "0x44EC240", VA = "0x44EC240")]
    public void OnGachaListChanged(GachaListInfo gachaListInfo)
    {
    }

    [Token(Token = "0x60076CE")]
    [Address(RVA = "0x44EC248", Offset = "0x44EC248", VA = "0x44EC248")]
    private void InitializeGachaList()
    {
    }

    [Token(Token = "0x60076CF")]
    [Address(RVA = "0x44EC548", Offset = "0x44EC548", VA = "0x44EC548")]
    private IEnumerable<GachaListItemInfo> FilterTutorialGacha(IEnumerable<GachaListItemInfo> gachas)
    {
      return (IEnumerable<GachaListItemInfo>) null;
    }

    [Token(Token = "0x60076D0")]
    [Address(RVA = "0x44EC7F4", Offset = "0x44EC7F4", VA = "0x44EC7F4")]
    public void OnUpdateListItemView(int index, GachaListItemView view)
    {
    }

    [Token(Token = "0x60076D1")]
    [Address(RVA = "0x44ECA48", Offset = "0x44ECA48", VA = "0x44ECA48")]
    private void OnClickGachaListItem(int index, GachaListItemView listItemView)
    {
    }

    [Token(Token = "0x60076D2")]
    [Address(RVA = "0x44ECBD0", Offset = "0x44ECBD0", VA = "0x44ECBD0")]
    private void OnSwiped(int index)
    {
    }

    [Token(Token = "0x60076D3")]
    [Address(RVA = "0x44ECA7C", Offset = "0x44ECA7C", VA = "0x44ECA7C")]
    public void Select(int index)
    {
    }

    [Token(Token = "0x60076D4")]
    [Address(RVA = "0x44ECBF8", Offset = "0x44ECBF8", VA = "0x44ECBF8")]
    public void SelectByName(string gachaName)
    {
    }
  }
}
