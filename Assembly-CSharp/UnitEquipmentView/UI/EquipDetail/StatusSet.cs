// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipDetail.StatusSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnitEquipmentView.Equipment;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI.EquipDetail
{
  [Token(Token = "0x200046A")]
  [Serializable]
  public class StatusSet
  {
    [Token(Token = "0x4001821")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform instantiateRoot;
    [Token(Token = "0x4001822")]
    [FieldOffset(Offset = "0x18")]
    private Queue<WeaponsEquipDetailStatusUI> uiCaches;
    [Token(Token = "0x4001823")]
    [FieldOffset(Offset = "0x20")]
    private List<WeaponsEquipDetailStatusUI> activeUIs;
    [Token(Token = "0x4001824")]
    [FieldOffset(Offset = "0x28")]
    private GameObject asset;

    [Token(Token = "0x60018F1")]
    [Address(RVA = "0x2492594", Offset = "0x2492594", VA = "0x2492594")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60018F2")]
    [Address(RVA = "0x2492CBC", Offset = "0x2492CBC", VA = "0x2492CBC")]
    public void Set(IEnumerable<Parameter> parameters)
    {
    }

    [Token(Token = "0x60018F3")]
    [Address(RVA = "0x2493478", Offset = "0x2493478", VA = "0x2493478")]
    public void Clear()
    {
    }

    [Token(Token = "0x60018F4")]
    [Address(RVA = "0x2493624", Offset = "0x2493624", VA = "0x2493624")]
    private WeaponsEquipDetailStatusUI GetInstance(Transform parent)
    {
      return (WeaponsEquipDetailStatusUI) null;
    }

    [Token(Token = "0x60018F5")]
    [Address(RVA = "0x2493784", Offset = "0x2493784", VA = "0x2493784")]
    public StatusSet()
    {
    }
  }
}
