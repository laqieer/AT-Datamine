// Decompiled with JetBrains decompiler
// Type: TeamOrganization.MindEquipmentParameterView
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
  [Token(Token = "0x20007DD")]
  public class MindEquipmentParameterView : EquipParameterViewBase
  {
    [Token(Token = "0x40024CC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI mindEquipName;
    [Token(Token = "0x40024CD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI mindEquipLv;
    [Token(Token = "0x40024CE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI mindEquipBattlePower;
    [Token(Token = "0x40024CF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI mindEquipHp;
    [Token(Token = "0x40024D0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI mindEquipPhysicalAtk;
    [Token(Token = "0x40024D1")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI mindEquipMagicalAtk;
    [Token(Token = "0x40024D2")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI mindEquipDef;
    [Token(Token = "0x40024D3")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI mindEquipMagicalDef;
    [Token(Token = "0x40024D4")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI mindEquipHit;
    [Token(Token = "0x40024D5")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI mindEquipAvoid;
    [Token(Token = "0x40024D6")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI mindEquipCritical;
    [Token(Token = "0x40024D7")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI mindEquipCriticalAvoid;

    [Token(Token = "0x6002C77")]
    [Address(RVA = "0x387DFE4", Offset = "0x387DFE4", VA = "0x387DFE4", Slot = "4")]
    public override void ResetEquipParameter()
    {
    }

    [Token(Token = "0x6002C78")]
    [Address(RVA = "0x387E390", Offset = "0x387E390", VA = "0x387E390", Slot = "5")]
    protected override void UpdateEquipParameter(Equipment equipment, Style selectStyle)
    {
    }

    [Token(Token = "0x6002C79")]
    [Address(RVA = "0x387E68C", Offset = "0x387E68C", VA = "0x387E68C", Slot = "6")]
    protected override void UpdateEquipParameter(
      Equipment baseEquipment,
      Equipment selectEquipment,
      Style selectStyle)
    {
    }

    [Token(Token = "0x6002C7A")]
    [Address(RVA = "0x387EBE0", Offset = "0x387EBE0", VA = "0x387EBE0")]
    public MindEquipmentParameterView()
    {
    }
  }
}
