// Decompiled with JetBrains decompiler
// Type: TeamOrganization.AccessoryParameterView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using TMPro;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200078B")]
  public class AccessoryParameterView : EquipParameterViewBase
  {
    [Token(Token = "0x40022C6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI accessoryName;
    [Token(Token = "0x40022C7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private AccessoryStatusViewBase shieldStatusView;
    [Token(Token = "0x40022C8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private AccessoryStatusViewBase accessoryStatusView;

    [Token(Token = "0x6002A50")]
    [Address(RVA = "0x3500790", Offset = "0x3500790", VA = "0x3500790", Slot = "4")]
    public override void ResetEquipParameter()
    {
    }

    [Token(Token = "0x6002A51")]
    [Address(RVA = "0x3500864", Offset = "0x3500864", VA = "0x3500864", Slot = "5")]
    protected override void UpdateEquipParameter(Equipment equipment, Style selectStyle)
    {
    }

    [Token(Token = "0x6002A52")]
    [Address(RVA = "0x3500990", Offset = "0x3500990", VA = "0x3500990", Slot = "6")]
    protected override void UpdateEquipParameter(
      Equipment baseEquipment,
      Equipment selectEquipment,
      Style selectStyle)
    {
    }

    [Token(Token = "0x6002A53")]
    [Address(RVA = "0x3500AE0", Offset = "0x3500AE0", VA = "0x3500AE0")]
    public AccessoryParameterView()
    {
    }
  }
}
