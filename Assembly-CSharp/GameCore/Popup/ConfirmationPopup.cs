// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.ConfirmationPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CE6")]
  public class ConfirmationPopup : PopupBase
  {
    [Token(Token = "0x40039BD")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton[] buttons;
    [Token(Token = "0x40039BE")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Action[] buttonActions;

    [Token(Token = "0x6004A26")]
    [Address(RVA = "0x313D674", Offset = "0x313D674", VA = "0x313D674")]
    public void SetData(string title, string messsage)
    {
    }

    [Token(Token = "0x6004A27")]
    [Address(RVA = "0x313D72C", Offset = "0x313D72C", VA = "0x313D72C")]
    public void SetCallback(ConfirmationPopup.ButtonPositionType positionType, Action action)
    {
    }

    [Token(Token = "0x6004A28")]
    [Address(RVA = "0x313D7D8", Offset = "0x313D7D8", VA = "0x313D7D8")]
    public void OnClickToCancelButton()
    {
    }

    [Token(Token = "0x6004A29")]
    [Address(RVA = "0x313D818", Offset = "0x313D818", VA = "0x313D818")]
    public void OnClickToExecuteButton()
    {
    }

    [Token(Token = "0x6004A2A")]
    [Address(RVA = "0x313D85C", Offset = "0x313D85C", VA = "0x313D85C")]
    public void OnClickToDecisionButton()
    {
    }

    [Token(Token = "0x6004A2B")]
    [Address(RVA = "0x313D8A0", Offset = "0x313D8A0", VA = "0x313D8A0")]
    public ConfirmationPopup()
    {
    }

    [Token(Token = "0x2000CE7")]
    public enum ButtonPositionType
    {
      [Token(Token = "0x40039C0")] Cancel,
      [Token(Token = "0x40039C1")] Execute,
      [Token(Token = "0x40039C2")] Decision,
      [Token(Token = "0x40039C3")] Max,
    }
  }
}
