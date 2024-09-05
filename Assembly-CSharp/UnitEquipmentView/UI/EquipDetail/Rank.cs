// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipDetail.Rank
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
  [Token(Token = "0x2000466")]
  [Serializable]
  public class Rank
  {
    [Token(Token = "0x4001819")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text rankTextUI;
    [Token(Token = "0x400181A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text expTextUI;

    [Token(Token = "0x60018E5")]
    [Address(RVA = "0x2492C04", Offset = "0x2492C04", VA = "0x2492C04")]
    public void Set(int rank, int exp)
    {
    }

    [Token(Token = "0x60018E6")]
    [Address(RVA = "0x24933DC", Offset = "0x24933DC", VA = "0x24933DC")]
    public Rank()
    {
    }
  }
}
