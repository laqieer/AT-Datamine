// Decompiled with JetBrains decompiler
// Type: TeamOrganization.PartyConfirmationPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007E9")]
  public class PartyConfirmationPopup : PopupBase
  {
    [Token(Token = "0x4002511")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x4002512")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton decisionButton;

    [Token(Token = "0x6002D2E")]
    [Address(RVA = "0x3A861E8", Offset = "0x3A861E8", VA = "0x3A861E8")]
    public void Initialized(Action positiveAction, Action closeAction)
    {
    }

    [Token(Token = "0x6002D2F")]
    [Address(RVA = "0x3A86348", Offset = "0x3A86348", VA = "0x3A86348")]
    public PartyConfirmationPopup()
    {
    }
  }
}
