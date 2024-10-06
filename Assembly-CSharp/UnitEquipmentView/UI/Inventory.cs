// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.Inventory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000437")]
  [Serializable]
  public class Inventory
  {
    [Token(Token = "0x40017A0")]
    [FieldOffset(Offset = "0x10")]
    private bool opened;
    [Token(Token = "0x40017A1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;

    [Token(Token = "0x60017E1")]
    [Address(RVA = "0x248F108", Offset = "0x248F108", VA = "0x248F108")]
    public Inventory(UITweenGroup tweenGroup)
    {
    }

    [Token(Token = "0x60017E2")]
    [Address(RVA = "0x248F130", Offset = "0x248F130", VA = "0x248F130")]
    public void Open()
    {
    }

    [Token(Token = "0x60017E3")]
    [Address(RVA = "0x248CA40", Offset = "0x248CA40", VA = "0x248CA40")]
    public void Close()
    {
    }
  }
}
