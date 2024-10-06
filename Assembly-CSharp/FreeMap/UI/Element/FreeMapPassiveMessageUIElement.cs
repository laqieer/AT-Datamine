// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Element.FreeMapPassiveMessageUIElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Position;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Element
{
  [Token(Token = "0x20016A6")]
  public class FreeMapPassiveMessageUIElement
  {
    [Token(Token = "0x400659A")]
    [FieldOffset(Offset = "0x10")]
    protected List<FreeMapUIControllElement> messageUIList;
    [Token(Token = "0x400659B")]
    [FieldOffset(Offset = "0x18")]
    private int currentMessageIndex;

    [Token(Token = "0x170013D0")]
    private FreeMapUIControllElement currentMessageUI
    {
      [Token(Token = "0x6008014"), Address(RVA = "0x41F1664", Offset = "0x41F1664", VA = "0x41F1664")] get
      {
        return (FreeMapUIControllElement) null;
      }
    }

    [Token(Token = "0x170013D1")]
    private int MaxShowMessageIndex
    {
      [Token(Token = "0x6008015"), Address(RVA = "0x41F16E4", Offset = "0x41F16E4", VA = "0x41F16E4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008016")]
    [Address(RVA = "0x41F1730", Offset = "0x41F1730", VA = "0x41F1730")]
    public void AddElement(FreeMapUIControllElement element)
    {
    }

    [Token(Token = "0x170013D2")]
    public bool IsShown
    {
      [Token(Token = "0x6008017"), Address(RVA = "0x41F17D8", Offset = "0x41F17D8", VA = "0x41F17D8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6008018"), Address(RVA = "0x41F17E0", Offset = "0x41F17E0", VA = "0x41F17E0")] private set
      {
      }
    }

    [Token(Token = "0x6008019")]
    [Address(RVA = "0x41F17EC", Offset = "0x41F17EC", VA = "0x41F17EC")]
    public void DestroyElement()
    {
    }

    [Token(Token = "0x600801A")]
    [Address(RVA = "0x41F0FE8", Offset = "0x41F0FE8", VA = "0x41F0FE8")]
    public void HideUI()
    {
    }

    [Token(Token = "0x600801B")]
    [Address(RVA = "0x41F0E70", Offset = "0x41F0E70", VA = "0x41F0E70")]
    public void ShowUI()
    {
    }

    [Token(Token = "0x600801C")]
    [Address(RVA = "0x41F1934", Offset = "0x41F1934", VA = "0x41F1934")]
    public void UpdateAnimation()
    {
    }

    [Token(Token = "0x600801D")]
    [Address(RVA = "0x41F0D18", Offset = "0x41F0D18", VA = "0x41F0D18")]
    public void UpdateRectTransform(
      Camera usingCamera,
      FreeMapUICanvas uiCanvas,
      UITransformAvoidHandler avoidHandler)
    {
    }

    [Token(Token = "0x600801E")]
    [Address(RVA = "0x41F0F1C", Offset = "0x41F0F1C", VA = "0x41F0F1C")]
    public bool ChangeNextMessage() => new bool();

    [Token(Token = "0x600801F")]
    [Address(RVA = "0x41F0D10", Offset = "0x41F0D10", VA = "0x41F0D10")]
    public void ResetMessageProgress()
    {
    }

    [Token(Token = "0x6008020")]
    [Address(RVA = "0x41F195C", Offset = "0x41F195C", VA = "0x41F195C")]
    public void SetAsLastSibling()
    {
    }

    [Token(Token = "0x6008021")]
    [Address(RVA = "0x41F1ADC", Offset = "0x41F1ADC", VA = "0x41F1ADC")]
    public FreeMapPassiveMessageUIElement()
    {
    }
  }
}
