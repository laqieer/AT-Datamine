// Decompiled with JetBrains decompiler
// Type: TeamOrganization.PartyTransitionConfirmPopup
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
  [Token(Token = "0x20007FF")]
  public class PartyTransitionConfirmPopup : PopupBase
  {
    [Token(Token = "0x40025A8")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x40025A9")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton decisionButton;
    [Token(Token = "0x40025AA")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton saveButton;

    [Token(Token = "0x6002DD2")]
    [Address(RVA = "0x3A8B46C", Offset = "0x3A8B46C", VA = "0x3A8B46C")]
    public void Initialized(
      Action positiveAction,
      Action closeAction,
      Action saveAction,
      bool saveButtonInactive)
    {
    }

    [Token(Token = "0x6002DD3")]
    [Address(RVA = "0x3A8B660", Offset = "0x3A8B660", VA = "0x3A8B660")]
    public PartyTransitionConfirmPopup()
    {
    }
  }
}
