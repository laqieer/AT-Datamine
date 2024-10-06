// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.Check.APShortagePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.APRecovery.Check
{
  [Token(Token = "0x2003971")]
  public class APShortagePopup : PopupBase
  {
    [Token(Token = "0x400FB00")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    [Header("APアイコン")]
    private APIconView _iconView;
    [Token(Token = "0x400FB01")]
    [FieldOffset(Offset = "0x90")]
    [Header("ボタン")]
    [SerializeField]
    private CommonButton _buttonClose;
    [Token(Token = "0x400FB02")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton _buttonRecovery;

    [Token(Token = "0x601693E")]
    [Address(RVA = "0x42F193C", Offset = "0x42F193C", VA = "0x42F193C")]
    public void Initialize(int ap, Action close, Action recover)
    {
    }

    [Token(Token = "0x601693F")]
    [Address(RVA = "0x42F1ABC", Offset = "0x42F1ABC", VA = "0x42F1ABC")]
    public APShortagePopup()
    {
    }
  }
}
