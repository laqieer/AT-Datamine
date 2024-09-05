// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipChange.WeaponsEquipChangeStatusUI
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
  [Token(Token = "0x200047F")]
  [Serializable]
  public class WeaponsEquipChangeStatusUI : MonoBehaviour
  {
    [Token(Token = "0x4001840")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text nameUI;
    [Token(Token = "0x4001841")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text beforeUI;
    [Token(Token = "0x4001842")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text afterUI;

    [Token(Token = "0x6001934")]
    [Address(RVA = "0x2494290", Offset = "0x2494290", VA = "0x2494290")]
    public void Apply(string name)
    {
    }

    [Token(Token = "0x6001935")]
    [Address(RVA = "0x24942B4", Offset = "0x24942B4", VA = "0x24942B4")]
    public void ApplyBefore(int value)
    {
    }

    [Token(Token = "0x6001936")]
    [Address(RVA = "0x24942FC", Offset = "0x24942FC", VA = "0x24942FC")]
    public void ApplyAfter(int value, string colorCode)
    {
    }

    [Token(Token = "0x6001937")]
    [Address(RVA = "0x24943B4", Offset = "0x24943B4", VA = "0x24943B4")]
    public WeaponsEquipChangeStatusUI()
    {
    }
  }
}
