// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleViewerProfilePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AC8")]
  public class StyleViewerProfilePopup : PopupBase
  {
    [Token(Token = "0x40102C1")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private StyleViewerProfileController profileController;
    [Token(Token = "0x40102C2")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton closeButton;

    [Token(Token = "0x6017205")]
    [Address(RVA = "0x30090A8", Offset = "0x30090A8", VA = "0x30090A8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6017206")]
    [Address(RVA = "0x30091C8", Offset = "0x30091C8", VA = "0x30091C8")]
    public IEnumerator Open(Style style) => (IEnumerator) null;

    [Token(Token = "0x6017207")]
    [Address(RVA = "0x3009264", Offset = "0x3009264", VA = "0x3009264", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6017208")]
    [Address(RVA = "0x3009344", Offset = "0x3009344", VA = "0x3009344")]
    public StyleViewerProfilePopup()
    {
    }
  }
}
