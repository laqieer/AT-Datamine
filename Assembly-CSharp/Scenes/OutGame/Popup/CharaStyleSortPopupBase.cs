// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.CharaStyleSortPopupBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnitList.Data;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x200342E")]
  public class CharaStyleSortPopupBase : PopupBase
  {
    [Token(Token = "0x400E2EF")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Dictionary<SortCondition, string> SortConditionTextDictionary;
    [Token(Token = "0x400E2F0")]
    private const string OpenAmimID = "Sort_In";
    [Token(Token = "0x400E2F1")]
    private const string CloseAnimID = "Sort_Out";
    [Token(Token = "0x400E2F2")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private List<Toggle> toggles;
    [Token(Token = "0x400E2F3")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Toggle toggleAscend;
    [Token(Token = "0x400E2F4")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Toggle toggleDiscend;
    [Token(Token = "0x400E2F5")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Toggle toggleOrganization;
    [Token(Token = "0x400E2F6")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private CommonButton closeBtn;
    [Token(Token = "0x400E2F7")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CommonButton decisionBtn;
    [Token(Token = "0x400E2F8")]
    [FieldOffset(Offset = "0xB8")]
    private Action<bool, SortCondition, Order, bool> closeCallback;
    [Token(Token = "0x400E2F9")]
    [FieldOffset(Offset = "0xC0")]
    private SortCondition selectedCondition;
    [Token(Token = "0x400E2FA")]
    [FieldOffset(Offset = "0xC4")]
    private Order selectedOrder;
    [Token(Token = "0x400E2FB")]
    [FieldOffset(Offset = "0xC8")]
    private bool organization;

    [Token(Token = "0x601481E")]
    public static IEnumerator Create<T>(
      string assetBundleName,
      string prefabName,
      Action<T> callback)
      where T : CharaStyleSortPopupBase
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601481F")]
    [Address(RVA = "0x189A620", Offset = "0x189A620", VA = "0x189A620")]
    private void Start()
    {
    }

    [Token(Token = "0x6014820")]
    [Address(RVA = "0x1898BE8", Offset = "0x1898BE8", VA = "0x1898BE8")]
    public void Open(
      CharaStyleSortPopupBase.OpenParamBase param,
      Action<bool, SortCondition, Order, bool> callback)
    {
    }

    [Token(Token = "0x6014821")]
    [Address(RVA = "0x189AA60", Offset = "0x189AA60", VA = "0x189AA60")]
    private IEnumerator ScrollToTop() => (IEnumerator) null;

    [Token(Token = "0x6014822")]
    [Address(RVA = "0x1898F10", Offset = "0x1898F10", VA = "0x1898F10")]
    public CharaStyleSortPopupBase()
    {
    }

    [Token(Token = "0x6014823")]
    [Address(RVA = "0x189AAF0", Offset = "0x189AAF0", VA = "0x189AAF0")]
    static CharaStyleSortPopupBase()
    {
    }

    [Token(Token = "0x200342F")]
    public class OpenParamBase
    {
      [Token(Token = "0x400E2FC")]
      [FieldOffset(Offset = "0x10")]
      public SortCondition[] conditions;
      [Token(Token = "0x400E2FD")]
      [FieldOffset(Offset = "0x18")]
      public SortCondition defaultCondition;
      [Token(Token = "0x400E2FE")]
      [FieldOffset(Offset = "0x1C")]
      public Order defaultOrder;
      [Token(Token = "0x400E2FF")]
      [FieldOffset(Offset = "0x20")]
      public bool defaultOrganization;

      [Token(Token = "0x6014829")]
      [Address(RVA = "0x1898BE0", Offset = "0x1898BE0", VA = "0x1898BE0")]
      public OpenParamBase()
      {
      }
    }
  }
}
