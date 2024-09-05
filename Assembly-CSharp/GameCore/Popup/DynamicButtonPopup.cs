// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.DynamicButtonPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CF4")]
  public class DynamicButtonPopup : PopupBase
  {
    [Token(Token = "0x40039E6")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TextMeshProUGUI newTitle;
    [Token(Token = "0x40039E7")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI message;
    [Token(Token = "0x40039E8")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Button confirmButton;
    [Token(Token = "0x40039E9")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Button cancelButton;
    [Token(Token = "0x40039EA")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Button closeButton;

    [Token(Token = "0x17000AE7")]
    public Action OnClickToConfirmAction
    {
      [Token(Token = "0x6004A72"), Address(RVA = "0x313EE64", Offset = "0x313EE64", VA = "0x313EE64")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6004A73"), Address(RVA = "0x313EE6C", Offset = "0x313EE6C", VA = "0x313EE6C")] set
      {
      }
    }

    [Token(Token = "0x17000AE8")]
    public Action OnClickToCancelAction
    {
      [Token(Token = "0x6004A74"), Address(RVA = "0x313EE74", Offset = "0x313EE74", VA = "0x313EE74")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6004A75"), Address(RVA = "0x313EE7C", Offset = "0x313EE7C", VA = "0x313EE7C")] set
      {
      }
    }

    [Token(Token = "0x17000AE9")]
    public Action OnClickToCloseAction
    {
      [Token(Token = "0x6004A76"), Address(RVA = "0x313EE84", Offset = "0x313EE84", VA = "0x313EE84")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6004A77"), Address(RVA = "0x313EE8C", Offset = "0x313EE8C", VA = "0x313EE8C")] set
      {
      }
    }

    [Token(Token = "0x6004A78")]
    [Address(RVA = "0x313EE94", Offset = "0x313EE94", VA = "0x313EE94")]
    public void Show(
      string title,
      string message,
      Action confirmAction,
      Action cancelction,
      Action closeAction,
      Action outOfRangeAction)
    {
    }

    [Token(Token = "0x6004A79")]
    [Address(RVA = "0x313F21C", Offset = "0x313F21C", VA = "0x313F21C")]
    public void OnConfirmButton()
    {
    }

    [Token(Token = "0x6004A7A")]
    [Address(RVA = "0x313F238", Offset = "0x313F238", VA = "0x313F238")]
    public void OnCancelButton()
    {
    }

    [Token(Token = "0x6004A7B")]
    [Address(RVA = "0x313F254", Offset = "0x313F254", VA = "0x313F254", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6004A7C")]
    [Address(RVA = "0x313F270", Offset = "0x313F270", VA = "0x313F270")]
    public DynamicButtonPopup()
    {
    }
  }
}
