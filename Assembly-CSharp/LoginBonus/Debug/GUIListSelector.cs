// Decompiled with JetBrains decompiler
// Type: LoginBonus.Debug.GUIListSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace LoginBonus.Debug
{
  [Token(Token = "0x2000B15")]
  internal class GUIListSelector
  {
    [Token(Token = "0x4003291")]
    [FieldOffset(Offset = "0x10")]
    private IReadOnlyList<string> listItems;
    [Token(Token = "0x4003292")]
    [FieldOffset(Offset = "0x18")]
    private int defaultSelect;
    [Token(Token = "0x4003293")]
    [FieldOffset(Offset = "0x1C")]
    private Vector2 scrollPos;
    [Token(Token = "0x4003294")]
    [FieldOffset(Offset = "0x28")]
    private Action<int> onSelect;

    [Token(Token = "0x6003F1B")]
    [Address(RVA = "0x2C19E6C", Offset = "0x2C19E6C", VA = "0x2C19E6C")]
    public void Setup(IReadOnlyList<string> listItems, int defaultSelect, Action<int> onSelect)
    {
    }

    [Token(Token = "0x6003F1C")]
    [Address(RVA = "0x2C19E94", Offset = "0x2C19E94", VA = "0x2C19E94")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x6003F1D")]
    [Address(RVA = "0x2C19E64", Offset = "0x2C19E64", VA = "0x2C19E64")]
    public GUIListSelector()
    {
    }
  }
}
