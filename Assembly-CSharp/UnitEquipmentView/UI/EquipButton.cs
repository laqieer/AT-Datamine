// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x200044E")]
  [Serializable]
  public class EquipButton
  {
    [Token(Token = "0x40017DA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x40017DB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text text;

    [Token(Token = "0x6001871")]
    [Address(RVA = "0x2490ADC", Offset = "0x2490ADC", VA = "0x2490ADC")]
    public void StateEquip()
    {
    }

    [Token(Token = "0x6001872")]
    [Address(RVA = "0x2490A38", Offset = "0x2490A38", VA = "0x2490A38")]
    public void StateUnEquip()
    {
    }

    [Token(Token = "0x6001873")]
    [Address(RVA = "0x24908AC", Offset = "0x24908AC", VA = "0x24908AC")]
    public void AddListener(UnityAction action)
    {
    }

    [Token(Token = "0x6001874")]
    [Address(RVA = "0x2490F0C", Offset = "0x2490F0C", VA = "0x2490F0C")]
    public EquipButton()
    {
    }
  }
}
