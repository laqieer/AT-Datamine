// Decompiled with JetBrains decompiler
// Type: Scenes.Title.TitleTermsPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x2002922")]
  public class TitleTermsPopup : PopupBase
  {
    [Token(Token = "0x400AF6B")]
    private const string TITLEMENU_TWEEN_IN = "in";
    [Token(Token = "0x400AF6C")]
    private const string TITLEMENU_TWEEN_OUT = "out";
    [Token(Token = "0x400AF6D")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UITweenGroup uiTweenGroup;

    [Token(Token = "0x170038B4")]
    public Action OnClickToConfirmAction
    {
      [Token(Token = "0x60102F1"), Address(RVA = "0x474C72C", Offset = "0x474C72C", VA = "0x474C72C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60102F2"), Address(RVA = "0x474C734", Offset = "0x474C734", VA = "0x474C734")] set
      {
      }
    }

    [Token(Token = "0x170038B5")]
    public Action OnClickToCancelAction
    {
      [Token(Token = "0x60102F3"), Address(RVA = "0x474C73C", Offset = "0x474C73C", VA = "0x474C73C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60102F4"), Address(RVA = "0x474C744", Offset = "0x474C744", VA = "0x474C744")] set
      {
      }
    }

    [Token(Token = "0x60102F5")]
    [Address(RVA = "0x474C74C", Offset = "0x474C74C", VA = "0x474C74C")]
    public void Show()
    {
    }

    [Token(Token = "0x60102F6")]
    [Address(RVA = "0x474C7F0", Offset = "0x474C7F0", VA = "0x474C7F0", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x60102F7")]
    [Address(RVA = "0x474C880", Offset = "0x474C880", VA = "0x474C880")]
    public void OnConfirmButton()
    {
    }

    [Token(Token = "0x60102F8")]
    [Address(RVA = "0x474C89C", Offset = "0x474C89C", VA = "0x474C89C")]
    public void OnCancelButton()
    {
    }

    [Token(Token = "0x60102F9")]
    [Address(RVA = "0x474C8B8", Offset = "0x474C8B8", VA = "0x474C8B8")]
    public TitleTermsPopup()
    {
    }
  }
}
