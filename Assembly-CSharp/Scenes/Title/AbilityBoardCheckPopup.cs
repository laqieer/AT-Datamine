// Decompiled with JetBrains decompiler
// Type: Scenes.Title.AbilityBoardCheckPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028C3")]
  public class AbilityBoardCheckPopup : PopupBase
  {
    [Token(Token = "0x400ADD0")]
    [FieldOffset(Offset = "0x88")]
    public Action OnAction;
    [Token(Token = "0x400ADD1")]
    [FieldOffset(Offset = "0x90")]
    private List<Style> styleList;

    [Token(Token = "0x6010098")]
    [Address(RVA = "0x41670F8", Offset = "0x41670F8", VA = "0x41670F8")]
    public void OnPositiveButton()
    {
    }

    [Token(Token = "0x6010099")]
    [Address(RVA = "0x4167118", Offset = "0x4167118", VA = "0x4167118")]
    private IEnumerator ConnectAPISuspensionAbilityBoard() => (IEnumerator) null;

    [Token(Token = "0x601009A")]
    [Address(RVA = "0x41671A8", Offset = "0x41671A8", VA = "0x41671A8")]
    public AbilityBoardCheckPopup()
    {
    }
  }
}
