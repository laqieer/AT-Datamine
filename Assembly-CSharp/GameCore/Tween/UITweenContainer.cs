// Decompiled with JetBrains decompiler
// Type: GameCore.Tween.UITweenContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.Tween
{
  [Token(Token = "0x2000C2A")]
  [Serializable]
  public class UITweenContainer
  {
    [Token(Token = "0x4003728")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string groupID;
    [Token(Token = "0x4003729")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweener[] tweeners;

    [Token(Token = "0x17000A10")]
    public string GroupID
    {
      [Token(Token = "0x60045C5"), Address(RVA = "0x3513D34", Offset = "0x3513D34", VA = "0x3513D34")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60045C6"), Address(RVA = "0x3513D3C", Offset = "0x3513D3C", VA = "0x3513D3C")] set
      {
      }
    }

    [Token(Token = "0x17000A11")]
    public UITweener[] Tweeners
    {
      [Token(Token = "0x60045C7"), Address(RVA = "0x3513D44", Offset = "0x3513D44", VA = "0x3513D44")] get
      {
        return (UITweener[]) null;
      }
      [Token(Token = "0x60045C8"), Address(RVA = "0x3513D4C", Offset = "0x3513D4C", VA = "0x3513D4C")] set
      {
      }
    }

    [Token(Token = "0x60045C9")]
    [Address(RVA = "0x3513D54", Offset = "0x3513D54", VA = "0x3513D54")]
    public UITweenContainer()
    {
    }
  }
}
