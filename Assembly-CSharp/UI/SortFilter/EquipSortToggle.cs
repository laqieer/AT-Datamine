// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.EquipSortToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData.Sort;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.SortFilter
{
  [Token(Token = "0x2000933")]
  public class EquipSortToggle : MonoBehaviour
  {
    [Token(Token = "0x4002AC6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle toggle;
    [Token(Token = "0x4002AC7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private EquipmentSortCondition condition;
    [Token(Token = "0x4002AC8")]
    [FieldOffset(Offset = "0x28")]
    private Action<EquipmentSortCondition> OnToggleAction;

    [Token(Token = "0x60033D6")]
    [Address(RVA = "0x362AD34", Offset = "0x362AD34", VA = "0x362AD34")]
    public void Initialized(
      EquipmentSortCondition sortCondition,
      Action<EquipmentSortCondition> action)
    {
    }

    [Token(Token = "0x60033D7")]
    [Address(RVA = "0x362B574", Offset = "0x362B574", VA = "0x362B574")]
    public void OnValueChangedToggle(bool isOn)
    {
    }

    [Token(Token = "0x60033D8")]
    [Address(RVA = "0x362B3B0", Offset = "0x362B3B0", VA = "0x362B3B0")]
    public void UpdateToggleStatus(EquipmentSortCondition sortCondition)
    {
    }

    [Token(Token = "0x60033D9")]
    [Address(RVA = "0x362B598", Offset = "0x362B598", VA = "0x362B598")]
    public EquipSortToggle()
    {
    }
  }
}
