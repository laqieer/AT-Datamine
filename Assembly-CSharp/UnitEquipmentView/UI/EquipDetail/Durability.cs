// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipDetail.Durability
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitEquipmentView.UI.EquipDetail
{
  [Token(Token = "0x2000468")]
  [Serializable]
  public class Durability
  {
    [Token(Token = "0x400181D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text textUI;

    [Token(Token = "0x60018EA")]
    [Address(RVA = "0x2492C7C", Offset = "0x2492C7C", VA = "0x2492C7C")]
    public void Set(DurabilityFormatter formatter, int current, int max)
    {
    }

    [Token(Token = "0x60018EB")]
    [Address(RVA = "0x2493460", Offset = "0x2493460", VA = "0x2493460")]
    public Durability()
    {
    }
  }
}
