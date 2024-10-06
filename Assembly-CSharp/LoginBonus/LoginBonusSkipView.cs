// Decompiled with JetBrains decompiler
// Type: LoginBonus.LoginBonusSkipView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000B0A")]
  public class LoginBonusSkipView : MonoBehaviour
  {
    [Token(Token = "0x400326E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button buttonSkip;
    [Token(Token = "0x400326F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;

    [Token(Token = "0x6003EDD")]
    [Address(RVA = "0x2C064F8", Offset = "0x2C064F8", VA = "0x2C064F8")]
    public void EnableSkipButton(Action onClick)
    {
    }

    [Token(Token = "0x6003EDE")]
    [Address(RVA = "0x2C17904", Offset = "0x2C17904", VA = "0x2C17904")]
    public void DisableSkipButton()
    {
    }

    [Token(Token = "0x6003EDF")]
    [Address(RVA = "0x2C1798C", Offset = "0x2C1798C", VA = "0x2C1798C")]
    public LoginBonusSkipView()
    {
    }
  }
}
