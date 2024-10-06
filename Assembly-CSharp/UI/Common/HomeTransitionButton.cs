// Decompiled with JetBrains decompiler
// Type: UI.Common.HomeTransitionButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI.Common
{
  [Token(Token = "0x2000919")]
  public class HomeTransitionButton : MonoBehaviour
  {
    [Token(Token = "0x4002A71")]
    [FieldOffset(Offset = "0x18")]
    public Action ButtonClickAction;

    [Token(Token = "0x6003345")]
    [Address(RVA = "0x36260AC", Offset = "0x36260AC", VA = "0x36260AC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003346")]
    [Address(RVA = "0x3626178", Offset = "0x3626178", VA = "0x3626178")]
    private void OnButtonClicked()
    {
    }

    [Token(Token = "0x6003347")]
    [Address(RVA = "0x362637C", Offset = "0x362637C", VA = "0x362637C")]
    public static void DefaultButtonClickAction()
    {
    }

    [Token(Token = "0x6003348")]
    [Address(RVA = "0x36261AC", Offset = "0x36261AC", VA = "0x36261AC")]
    private bool IsEnable() => new bool();

    [Token(Token = "0x6003349")]
    [Address(RVA = "0x3626384", Offset = "0x3626384", VA = "0x3626384")]
    public HomeTransitionButton()
    {
    }
  }
}
