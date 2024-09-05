// Decompiled with JetBrains decompiler
// Type: TeamOrganization.WeaponParameterView
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
  [Token(Token = "0x200080D")]
  public class WeaponParameterView : EquipParameterViewBase
  {
    [Token(Token = "0x400261C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI weaponName;
    [Token(Token = "0x400261D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI weaponLv;
    [Token(Token = "0x400261E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI weaponBattlePower;
    [Token(Token = "0x400261F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI weaponPower;
    [Token(Token = "0x4002620")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI weaponHit;
    [Token(Token = "0x4002621")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI weaponAvoid;
    [Token(Token = "0x4002622")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI weaponDurability;
    [Token(Token = "0x4002623")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI weaponCritical;
    [Token(Token = "0x4002624")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI weaponWeight;
    [Token(Token = "0x4002625")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI weaponRange;
    [Token(Token = "0x4002626")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject weaponCoeffcicent;

    [Token(Token = "0x6002E31")]
    [Address(RVA = "0x3A911FC", Offset = "0x3A911FC", VA = "0x3A911FC", Slot = "4")]
    public override void ResetEquipParameter()
    {
    }

    [Token(Token = "0x6002E32")]
    [Address(RVA = "0x3A91534", Offset = "0x3A91534", VA = "0x3A91534", Slot = "5")]
    protected override void UpdateEquipParameter(Equipment equipment, Style selectStyle)
    {
    }

    [Token(Token = "0x6002E33")]
    [Address(RVA = "0x3A91870", Offset = "0x3A91870", VA = "0x3A91870", Slot = "6")]
    protected override void UpdateEquipParameter(
      Equipment baseEquipment,
      Equipment selectEquipment,
      Style selectStyle)
    {
    }

    [Token(Token = "0x6002E34")]
    [Address(RVA = "0x3A91DCC", Offset = "0x3A91DCC", VA = "0x3A91DCC")]
    public WeaponParameterView()
    {
    }
  }
}
