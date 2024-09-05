// Decompiled with JetBrains decompiler
// Type: TeamOrganization.UnitTrustParameterView
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
  [Token(Token = "0x200080C")]
  public class UnitTrustParameterView : EquipParameterViewBase
  {
    [Token(Token = "0x4002610")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI trustName;
    [Token(Token = "0x4002611")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI trustBattlePower;
    [Token(Token = "0x4002612")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI trustHp;
    [Token(Token = "0x4002613")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI trustPhysicalAtk;
    [Token(Token = "0x4002614")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI trustMagicalAtk;
    [Token(Token = "0x4002615")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI trustDef;
    [Token(Token = "0x4002616")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI trustMagDef;
    [Token(Token = "0x4002617")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI trustHit;
    [Token(Token = "0x4002618")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI trustAvoid;
    [Token(Token = "0x4002619")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI trustCritical;
    [Token(Token = "0x400261A")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI trustCriticalAvoid;
    [Token(Token = "0x400261B")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI trustWeight;

    [Token(Token = "0x6002E2D")]
    [Address(RVA = "0x3A9054C", Offset = "0x3A9054C", VA = "0x3A9054C", Slot = "4")]
    public override void ResetEquipParameter()
    {
    }

    [Token(Token = "0x6002E2E")]
    [Address(RVA = "0x3A908F8", Offset = "0x3A908F8", VA = "0x3A908F8", Slot = "5")]
    protected override void UpdateEquipParameter(Equipment equipment, Style selectStyle)
    {
    }

    [Token(Token = "0x6002E2F")]
    [Address(RVA = "0x3A90C08", Offset = "0x3A90C08", VA = "0x3A90C08", Slot = "6")]
    protected override void UpdateEquipParameter(
      Equipment baseEquipment,
      Equipment selectEquipment,
      Style selectStyle)
    {
    }

    [Token(Token = "0x6002E30")]
    [Address(RVA = "0x3A911A4", Offset = "0x3A911A4", VA = "0x3A911A4")]
    public UnitTrustParameterView()
    {
    }
  }
}
