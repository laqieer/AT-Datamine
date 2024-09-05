// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.StyleSortToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData.Sort;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.SortFilter
{
  [Token(Token = "0x200094B")]
  public class StyleSortToggle : MonoBehaviour
  {
    [Token(Token = "0x4002B27")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle toggle;
    [Token(Token = "0x4002B28")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StyleSortCondition condition;
    [Token(Token = "0x4002B29")]
    [FieldOffset(Offset = "0x28")]
    private Action<StyleSortCondition> OnToggleAction;

    [Token(Token = "0x600346D")]
    [Address(RVA = "0x3630E10", Offset = "0x3630E10", VA = "0x3630E10")]
    public void Initialized(StyleSortCondition sortCondition, Action<StyleSortCondition> action)
    {
    }

    [Token(Token = "0x600346E")]
    [Address(RVA = "0x36319C8", Offset = "0x36319C8", VA = "0x36319C8")]
    public void OnValueChangedToggle(bool isOn)
    {
    }

    [Token(Token = "0x600346F")]
    [Address(RVA = "0x36318A4", Offset = "0x36318A4", VA = "0x36318A4")]
    public void UpdateToggleStatus(StyleSortCondition sortCondition)
    {
    }

    [Token(Token = "0x6003470")]
    [Address(RVA = "0x36319EC", Offset = "0x36319EC", VA = "0x36319EC")]
    public StyleSortToggle()
    {
    }
  }
}
