// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardCustomBCheckPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x200331A")]
  public class AbilityBoardCustomBCheckPopup : PopupBase
  {
    [Token(Token = "0x400DCD6")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x400DCD7")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton confirmButton;
    [Token(Token = "0x400DCD8")]
    [FieldOffset(Offset = "0x98")]
    public Action OnNodeUnlockAction;

    [Token(Token = "0x6014157")]
    [Address(RVA = "0x20C2328", Offset = "0x20C2328", VA = "0x20C2328")]
    public void Init()
    {
    }

    [Token(Token = "0x6014158")]
    [Address(RVA = "0x20C2448", Offset = "0x20C2448", VA = "0x20C2448")]
    public void OnConfirmButton()
    {
    }

    [Token(Token = "0x6014159")]
    [Address(RVA = "0x20C24F4", Offset = "0x20C24F4", VA = "0x20C24F4")]
    public void OnCancelButton()
    {
    }

    [Token(Token = "0x601415A")]
    [Address(RVA = "0x20C2584", Offset = "0x20C2584", VA = "0x20C2584")]
    public AbilityBoardCustomBCheckPopup()
    {
    }
  }
}
