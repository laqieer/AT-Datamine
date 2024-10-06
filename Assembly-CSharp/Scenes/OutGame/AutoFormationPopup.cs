// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AutoFormationPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003282")]
  public class AutoFormationPopup : PopupBase
  {
    [Token(Token = "0x400D83F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400D840")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton decideButton;
    [Token(Token = "0x400D841")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonToggle checkToggle;
    [Token(Token = "0x400D842")]
    [FieldOffset(Offset = "0xA0")]
    private bool isCheck;

    [Token(Token = "0x6013B38")]
    [Address(RVA = "0x1856DA0", Offset = "0x1856DA0", VA = "0x1856DA0")]
    public void Initialize(Action<bool> callAutoFormationAction)
    {
    }

    [Token(Token = "0x6013B39")]
    [Address(RVA = "0x1856FAC", Offset = "0x1856FAC", VA = "0x1856FAC")]
    public IEnumerator Open(Action onFinishOpen) => (IEnumerator) null;

    [Token(Token = "0x6013B3A")]
    [Address(RVA = "0x1857048", Offset = "0x1857048", VA = "0x1857048")]
    private void OnClickCloseButton()
    {
    }

    [Token(Token = "0x6013B3B")]
    [Address(RVA = "0x1857050", Offset = "0x1857050", VA = "0x1857050")]
    private void OnClickDecideBUtton(Action<bool> action)
    {
    }

    [Token(Token = "0x6013B3C")]
    [Address(RVA = "0x1857084", Offset = "0x1857084", VA = "0x1857084")]
    public AutoFormationPopup()
    {
    }
  }
}
