// Decompiled with JetBrains decompiler
// Type: Scenes.Title.MenuButtonInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x2002923")]
  [Serializable]
  public class MenuButtonInfo
  {
    [Token(Token = "0x400AF70")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button objectButton;
    [Token(Token = "0x400AF71")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text textLabel;
    [Token(Token = "0x400AF72")]
    [FieldOffset(Offset = "0x20")]
    [NonSerialized]
    public int Index;

    [Token(Token = "0x170038B6")]
    public Button ObjectButton
    {
      [Token(Token = "0x60102FA"), Address(RVA = "0x474C8C0", Offset = "0x474C8C0", VA = "0x474C8C0")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x170038B7")]
    public string TextLabel
    {
      [Token(Token = "0x60102FB"), Address(RVA = "0x474C8C8", Offset = "0x474C8C8", VA = "0x474C8C8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60102FC")]
    [Address(RVA = "0x474C8EC", Offset = "0x474C8EC", VA = "0x474C8EC")]
    public void AddOnClick(Action<MenuButtonInfo> onClick)
    {
    }

    [Token(Token = "0x60102FD")]
    [Address(RVA = "0x474C9C4", Offset = "0x474C9C4", VA = "0x474C9C4")]
    public MenuButtonInfo()
    {
    }
  }
}
