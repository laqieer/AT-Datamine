// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.StyleRankingFilterPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.SortFilter
{
  [Token(Token = "0x2000947")]
  public class StyleRankingFilterPopup : MonoBehaviour
  {
    [Token(Token = "0x4002B06")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002B07")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected BtnFullScreen btnFullScreen;
    [Token(Token = "0x4002B08")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform contentTrans;
    [Token(Token = "0x4002B09")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x4002B0A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private StyleFilterToggleGroup[] filterToggleGroups;
    [Token(Token = "0x4002B0B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x4002B0C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton allOnButton;
    [Token(Token = "0x4002B0D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton allClearButton;
    [Token(Token = "0x4002B0E")]
    [FieldOffset(Offset = "0x58")]
    private Action<List<Style>> sortAction;
    [Token(Token = "0x4002B0F")]
    [FieldOffset(Offset = "0x60")]
    private Action closeAction;
    [Token(Token = "0x4002B10")]
    [FieldOffset(Offset = "0x68")]
    private List<Style> styleList;
    [Token(Token = "0x4002B11")]
    [FieldOffset(Offset = "0x70")]
    private bool isFirstIn;

    [Token(Token = "0x6003442")]
    [Address(RVA = "0x3630218", Offset = "0x3630218", VA = "0x3630218")]
    public void Initialized()
    {
    }

    [Token(Token = "0x6003443")]
    [Address(RVA = "0x363052C", Offset = "0x363052C", VA = "0x363052C")]
    public void Open(List<Style> styleList)
    {
    }

    [Token(Token = "0x6003444")]
    [Address(RVA = "0x3630614", Offset = "0x3630614", VA = "0x3630614")]
    public void Close()
    {
    }

    [Token(Token = "0x6003445")]
    [Address(RVA = "0x36306CC", Offset = "0x36306CC", VA = "0x36306CC")]
    private void FinishOpen()
    {
    }

    [Token(Token = "0x6003446")]
    [Address(RVA = "0x363076C", Offset = "0x363076C", VA = "0x363076C")]
    private void FinishClose()
    {
    }

    [Token(Token = "0x6003447")]
    [Address(RVA = "0x3630870", Offset = "0x3630870", VA = "0x3630870")]
    public void SetSortAction(Action<List<Style>> action)
    {
    }

    [Token(Token = "0x6003448")]
    [Address(RVA = "0x3630878", Offset = "0x3630878", VA = "0x3630878")]
    public void OnClickClose()
    {
    }

    [Token(Token = "0x6003449")]
    [Address(RVA = "0x363087C", Offset = "0x363087C", VA = "0x363087C")]
    private void OnSortActionStyleList()
    {
    }

    [Token(Token = "0x600344A")]
    [Address(RVA = "0x3630B00", Offset = "0x3630B00", VA = "0x3630B00")]
    public void OnClickAllOn()
    {
    }

    [Token(Token = "0x600344B")]
    [Address(RVA = "0x3630B60", Offset = "0x3630B60", VA = "0x3630B60")]
    public void OnClickAllClear()
    {
    }

    [Token(Token = "0x600344C")]
    [Address(RVA = "0x36303FC", Offset = "0x36303FC", VA = "0x36303FC")]
    private void LoadSortFilterSaveData()
    {
    }

    [Token(Token = "0x600344D")]
    [Address(RVA = "0x3630944", Offset = "0x3630944", VA = "0x3630944")]
    private void SortFilterDataSave()
    {
    }

    [Token(Token = "0x600344E")]
    [Address(RVA = "0x3630BC0", Offset = "0x3630BC0", VA = "0x3630BC0")]
    public StyleRankingFilterPopup()
    {
    }
  }
}
