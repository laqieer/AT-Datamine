// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipChange.StatusSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnitEquipmentView.Equipment;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI.EquipChange
{
  [Token(Token = "0x2000482")]
  [Serializable]
  public class StatusSet
  {
    [Token(Token = "0x4001849")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform root;
    [Token(Token = "0x400184A")]
    [FieldOffset(Offset = "0x18")]
    private List<WeaponsEquipChangeStatusUI> statuses;
    [Token(Token = "0x400184B")]
    [FieldOffset(Offset = "0x20")]
    private StatusUICache uiCache;
    [Token(Token = "0x400184C")]
    [FieldOffset(Offset = "0x28")]
    private readonly CompareParameter compareParameter;

    [Token(Token = "0x600193E")]
    [Address(RVA = "0x2491D34", Offset = "0x2491D34", VA = "0x2491D34")]
    public void Apply(IEnumerable<Parameter> before, IEnumerable<Parameter> after)
    {
    }

    [Token(Token = "0x600193F")]
    [Address(RVA = "0x2494430", Offset = "0x2494430", VA = "0x2494430")]
    private void Apply(
      IEnumerator<Parameter> beforeEnumerator,
      IEnumerator<Parameter> afterEnumerator)
    {
    }

    [Token(Token = "0x6001940")]
    [Address(RVA = "0x2492118", Offset = "0x2492118", VA = "0x2492118")]
    public void Resize()
    {
    }

    [Token(Token = "0x6001941")]
    [Address(RVA = "0x2491A54", Offset = "0x2491A54", VA = "0x2491A54")]
    public void Clear()
    {
    }

    [Token(Token = "0x6001942")]
    [Address(RVA = "0x2494878", Offset = "0x2494878", VA = "0x2494878")]
    public StatusSet()
    {
    }
  }
}
