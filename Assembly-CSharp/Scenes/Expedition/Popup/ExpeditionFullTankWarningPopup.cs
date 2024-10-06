// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.ExpeditionFullTankWarningPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C6D")]
  public class ExpeditionFullTankWarningPopup : PopupBase
  {
    [Token(Token = "0x400BD4F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x400BD50")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton decisionButton;
    [Token(Token = "0x400BD51")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject warningMaxExpObj;
    [Token(Token = "0x400BD52")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject warningMaxBoxObj;
    [Token(Token = "0x400BD53")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject warningMaxPararaObj;

    [Token(Token = "0x6011648")]
    [Address(RVA = "0x4E1E458", Offset = "0x4E1E458", VA = "0x4E1E458")]
    public void Initialized(Action positiveAction, Action closeAction)
    {
    }

    [Token(Token = "0x6011649")]
    [Address(RVA = "0x4E1E5B8", Offset = "0x4E1E5B8", VA = "0x4E1E5B8")]
    public void SetData(bool warningMaxExp, bool warningMaxBox, bool warningMaxParara)
    {
    }

    [Token(Token = "0x601164A")]
    [Address(RVA = "0x4E1E614", Offset = "0x4E1E614", VA = "0x4E1E614")]
    public ExpeditionFullTankWarningPopup()
    {
    }
  }
}
