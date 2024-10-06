// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.StyleRanking.StyleRankingList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.StyleRanking
{
  [Token(Token = "0x2003367")]
  internal class StyleRankingList : MonoBehaviour
  {
    [Token(Token = "0x400DEB2")]
    private const int rankingMax = 100;
    [Token(Token = "0x400DEB3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image styleImage;
    [Token(Token = "0x400DEB4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI charaName;
    [Token(Token = "0x400DEB5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI styleName;
    [Token(Token = "0x400DEB6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private VerticalGridInfiniteScrollView scrollView;
    [Token(Token = "0x400DEB7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject nothing;
    [Token(Token = "0x400DEB8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject prevStyleGroup;
    [Token(Token = "0x400DEB9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton prevStyleButton;
    [Token(Token = "0x400DEBA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text prevCharaName;
    [Token(Token = "0x400DEBB")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text prevStyleName;
    [Token(Token = "0x400DEBC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject nextStyleGroup;
    [Token(Token = "0x400DEBD")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton nextStyleButton;
    [Token(Token = "0x400DEBE")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text nextCharaName;
    [Token(Token = "0x400DEBF")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text nextStyleName;
    [Token(Token = "0x400DEC0")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI pageText;
    [Token(Token = "0x400DEC1")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton prevPageButton;
    [Token(Token = "0x400DEC2")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton nextPageButton;
    [Token(Token = "0x400DEC3")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private StyleRankingThumb myRankingThumb;
    [Token(Token = "0x400DEC4")]
    [FieldOffset(Offset = "0xA0")]
    private int index;
    [Token(Token = "0x400DEC5")]
    [FieldOffset(Offset = "0xA4")]
    private int page;
    [Token(Token = "0x400DEC6")]
    [FieldOffset(Offset = "0xA8")]
    private int pageMax;
    [Token(Token = "0x400DEC7")]
    [FieldOffset(Offset = "0xB0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400DEC8")]
    [FieldOffset(Offset = "0xB8")]
    private List<StyleRankingCellResource> resources;
    [Token(Token = "0x400DEC9")]
    [FieldOffset(Offset = "0xC0")]
    private Action<int, int> updateRankingAction;
    [Token(Token = "0x400DECA")]
    [FieldOffset(Offset = "0xC8")]
    private Action<BasePowerRankingType> onClickAction;

    [Token(Token = "0x6014326")]
    [Address(RVA = "0x1E17470", Offset = "0x1E17470", VA = "0x1E17470")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      Action<int, int> updateRankingAction,
      Action<BasePowerRankingType> onClickAction)
    {
    }

    [Token(Token = "0x6014327")]
    [Address(RVA = "0x1E1767C", Offset = "0x1E1767C", VA = "0x1E1767C")]
    public void UpdateList(
      int styleId,
      int page,
      int index,
      int indexMax,
      int prevStyleId,
      int nextStyleId,
      List<BasePowerRankingType> rankings,
      BasePowerRankingType myRanking,
      int rankingCount)
    {
    }

    [Token(Token = "0x6014328")]
    [Address(RVA = "0x1E17B04", Offset = "0x1E17B04", VA = "0x1E17B04")]
    private void UpdateStyleInfo(int styleId)
    {
    }

    [Token(Token = "0x6014329")]
    [Address(RVA = "0x1E17D18", Offset = "0x1E17D18", VA = "0x1E17D18")]
    private void UpdateMyRanking(BasePowerRankingType myRanking)
    {
    }

    [Token(Token = "0x601432A")]
    [Address(RVA = "0x1E17F74", Offset = "0x1E17F74", VA = "0x1E17F74")]
    private void CreateList(List<BasePowerRankingType> rankings, long myRankingShortId)
    {
    }

    [Token(Token = "0x601432B")]
    [Address(RVA = "0x1E182C8", Offset = "0x1E182C8", VA = "0x1E182C8")]
    private void SetList()
    {
    }

    [Token(Token = "0x601432C")]
    [Address(RVA = "0x1E18674", Offset = "0x1E18674", VA = "0x1E18674")]
    private void OnClickRankingList(StyleRankingCellResource resource)
    {
    }

    [Token(Token = "0x601432D")]
    [Address(RVA = "0x1E17800", Offset = "0x1E17800", VA = "0x1E17800")]
    private void SetPrevNextStyle(int index, int indexMax, int prevStyleId, int nextStyleId)
    {
    }

    [Token(Token = "0x601432E")]
    [Address(RVA = "0x1E186A0", Offset = "0x1E186A0", VA = "0x1E186A0")]
    private void OnClickPrevStyle()
    {
    }

    [Token(Token = "0x601432F")]
    [Address(RVA = "0x1E186D4", Offset = "0x1E186D4", VA = "0x1E186D4")]
    private void OnClickNextStyle()
    {
    }

    [Token(Token = "0x6014330")]
    [Address(RVA = "0x1E18708", Offset = "0x1E18708", VA = "0x1E18708")]
    private void onClickPrevPage()
    {
    }

    [Token(Token = "0x6014331")]
    [Address(RVA = "0x1E1873C", Offset = "0x1E1873C", VA = "0x1E1873C")]
    private void onClickNextPage()
    {
    }

    [Token(Token = "0x6014332")]
    [Address(RVA = "0x1E18280", Offset = "0x1E18280", VA = "0x1E18280")]
    private void SetPageInteractable()
    {
    }

    [Token(Token = "0x6014333")]
    [Address(RVA = "0x1E18250", Offset = "0x1E18250", VA = "0x1E18250")]
    private void CalcPageMax(int rankingCount)
    {
    }

    [Token(Token = "0x6014334")]
    [Address(RVA = "0x1E18770", Offset = "0x1E18770", VA = "0x1E18770")]
    public StyleRankingList()
    {
    }
  }
}
