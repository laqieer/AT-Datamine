// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.SortFilterHeaderButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.SortFilter
{
  [Token(Token = "0x200093F")]
  public abstract class SortFilterHeaderButton : MonoBehaviour
  {
    [Token(Token = "0x4002AEE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject filteredRoot;
    [Token(Token = "0x4002AEF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text sortText;
    [Token(Token = "0x4002AF0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x4002AF1")]
    [FieldOffset(Offset = "0x30")]
    public Action OnButtonClicked;

    [Token(Token = "0x6003414")]
    [Address(RVA = "0x362D9B4", Offset = "0x362D9B4", VA = "0x362D9B4")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003415")]
    [Address(RVA = "0x362DA48", Offset = "0x362DA48", VA = "0x362DA48")]
    public void RefreshView()
    {
    }

    [Token(Token = "0x6003416")]
    protected abstract void UpdateFilteredRootActive();

    [Token(Token = "0x6003417")]
    protected abstract void UpdateSortText();

    [Token(Token = "0x6003418")]
    [Address(RVA = "0x3628DA4", Offset = "0x3628DA4", VA = "0x3628DA4")]
    protected void SetFilterRootActive(bool isActive)
    {
    }

    [Token(Token = "0x6003419")]
    [Address(RVA = "0x3628D4C", Offset = "0x3628D4C", VA = "0x3628D4C")]
    protected void SetSortText(string text)
    {
    }

    [Token(Token = "0x600341A")]
    [Address(RVA = "0x3628DCC", Offset = "0x3628DCC", VA = "0x3628DCC")]
    protected SortFilterHeaderButton()
    {
    }
  }
}
