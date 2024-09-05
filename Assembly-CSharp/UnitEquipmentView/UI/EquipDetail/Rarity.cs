// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipDetail.Rarity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI.EquipDetail
{
  [Token(Token = "0x2000467")]
  [Serializable]
  public class Rarity
  {
    [Token(Token = "0x400181B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject root;
    [Token(Token = "0x400181C")]
    [FieldOffset(Offset = "0x18")]
    private List<Transform> imageCount;

    [Token(Token = "0x60018E7")]
    [Address(RVA = "0x2492240", Offset = "0x2492240", VA = "0x2492240")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60018E8")]
    [Address(RVA = "0x2492A10", Offset = "0x2492A10", VA = "0x2492A10")]
    public void Set(int starCount)
    {
    }

    [Token(Token = "0x60018E9")]
    [Address(RVA = "0x24933E4", Offset = "0x24933E4", VA = "0x24933E4")]
    public Rarity()
    {
    }
  }
}
