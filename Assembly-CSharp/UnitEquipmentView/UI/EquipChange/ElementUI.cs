// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipChange.ElementUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitEquipmentView.UI.EquipChange
{
  [Token(Token = "0x2000485")]
  [Serializable]
  public class ElementUI
  {
    [Token(Token = "0x4001851")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text element1;
    [Token(Token = "0x4001852")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text element2;

    [Token(Token = "0x600194A")]
    [Address(RVA = "0x2494264", Offset = "0x2494264", VA = "0x2494264")]
    public void ApplyAttackType(string element, string colorCode)
    {
    }

    [Token(Token = "0x600194B")]
    [Address(RVA = "0x2494250", Offset = "0x2494250", VA = "0x2494250")]
    public void ApplyNatureType(string element, string colorCode)
    {
    }

    [Token(Token = "0x600194C")]
    [Address(RVA = "0x2494B54", Offset = "0x2494B54", VA = "0x2494B54")]
    private void Apply(Text element, string name)
    {
    }

    [Token(Token = "0x600194D")]
    [Address(RVA = "0x2494B80", Offset = "0x2494B80", VA = "0x2494B80")]
    private void Apply(Text element, string name, string colorCode)
    {
    }

    [Token(Token = "0x600194E")]
    [Address(RVA = "0x2494D28", Offset = "0x2494D28", VA = "0x2494D28")]
    public ElementUI()
    {
    }
  }
}
