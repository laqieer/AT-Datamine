// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.ItemFilterPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
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
  [Token(Token = "0x2000934")]
  public class ItemFilterPopup : MonoBehaviour
  {
    [Token(Token = "0x4002AC9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002ACA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected BtnFullScreen btnFullScreen;
    [Token(Token = "0x4002ACB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x4002ACC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ItemFilterToggleGroup[] filterToggleGroups;
    [Token(Token = "0x4002ACD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x4002ACE")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton allOnButton;
    [Token(Token = "0x4002ACF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton allClearButton;
    [Token(Token = "0x4002AD0")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4002AD1")]
    [FieldOffset(Offset = "0x58")]
    private Action<List<Item>> sortAction;
    [Token(Token = "0x4002AD2")]
    [FieldOffset(Offset = "0x60")]
    private List<Item> items;
    [Token(Token = "0x4002AD3")]
    [FieldOffset(Offset = "0x68")]
    private bool isFirstIn;

    [Token(Token = "0x60033DA")]
    [Address(RVA = "0x362B5A0", Offset = "0x362B5A0", VA = "0x362B5A0")]
    public void Initialized()
    {
    }

    [Token(Token = "0x60033DB")]
    [Address(RVA = "0x362B900", Offset = "0x362B900", VA = "0x362B900")]
    public void Open(List<Item> items)
    {
    }

    [Token(Token = "0x60033DC")]
    [Address(RVA = "0x362B9E8", Offset = "0x362B9E8", VA = "0x362B9E8")]
    public void Close()
    {
    }

    [Token(Token = "0x60033DD")]
    [Address(RVA = "0x362BAA0", Offset = "0x362BAA0", VA = "0x362BAA0")]
    private void FinishOpen()
    {
    }

    [Token(Token = "0x60033DE")]
    [Address(RVA = "0x362BB40", Offset = "0x362BB40", VA = "0x362BB40")]
    private void FinishClose()
    {
    }

    [Token(Token = "0x60033DF")]
    [Address(RVA = "0x362BC2C", Offset = "0x362BC2C", VA = "0x362BC2C")]
    public void SetSortAction(Action<List<Item>> action)
    {
    }

    [Token(Token = "0x60033E0")]
    [Address(RVA = "0x362BC34", Offset = "0x362BC34", VA = "0x362BC34")]
    public void OnClickClose()
    {
    }

    [Token(Token = "0x60033E1")]
    [Address(RVA = "0x362BC38", Offset = "0x362BC38", VA = "0x362BC38")]
    private void OnSortAction()
    {
    }

    [Token(Token = "0x60033E2")]
    [Address(RVA = "0x362C088", Offset = "0x362C088", VA = "0x362C088")]
    public void OnClickAllOn()
    {
    }

    [Token(Token = "0x60033E3")]
    [Address(RVA = "0x362C17C", Offset = "0x362C17C", VA = "0x362C17C")]
    public void OnClickAllClear()
    {
    }

    [Token(Token = "0x60033E4")]
    [Address(RVA = "0x362B7D0", Offset = "0x362B7D0", VA = "0x362B7D0")]
    private void LoadSortFilterSaveData()
    {
    }

    [Token(Token = "0x60033E5")]
    [Address(RVA = "0x362BECC", Offset = "0x362BECC", VA = "0x362BECC")]
    private void SortFilterDataSave()
    {
    }

    [Token(Token = "0x60033E6")]
    [Address(RVA = "0x362C284", Offset = "0x362C284", VA = "0x362C284")]
    public ItemFilterPopup()
    {
    }
  }
}
