// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipChange.CompareEquipInfoUI
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
  [Token(Token = "0x200047E")]
  [AddComponentMenu("Scripts/Compare EquipInfo UI")]
  [Serializable]
  public class CompareEquipInfoUI : MonoBehaviour
  {
    [Token(Token = "0x400183C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text equipmentName;
    [Token(Token = "0x400183D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text durability;
    [Token(Token = "0x400183E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private IconUI icon;
    [Token(Token = "0x400183F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ElementUI element;

    [Token(Token = "0x6001930")]
    [Address(RVA = "0x2491E58", Offset = "0x2491E58", VA = "0x2491E58")]
    public void Apply(string name, Sprite icon, int itemNum)
    {
    }

    [Token(Token = "0x6001931")]
    [Address(RVA = "0x2491EA4", Offset = "0x2491EA4", VA = "0x2491EA4")]
    public void Apply(DurabilityText durabilityText)
    {
    }

    [Token(Token = "0x6001932")]
    [Address(RVA = "0x2491EE4", Offset = "0x2491EE4", VA = "0x2491EE4")]
    public void Apply(ElementInfo elementInfo)
    {
    }

    [Token(Token = "0x6001933")]
    [Address(RVA = "0x2494288", Offset = "0x2494288", VA = "0x2494288")]
    public CompareEquipInfoUI()
    {
    }
  }
}
