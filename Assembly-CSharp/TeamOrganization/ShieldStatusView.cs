// Decompiled with JetBrains decompiler
// Type: TeamOrganization.ShieldStatusView
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
  [Token(Token = "0x2000801")]
  public class ShieldStatusView : AccessoryStatusViewBase
  {
    [Token(Token = "0x40025AE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI accessoryLv;
    [Token(Token = "0x40025AF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI accessoryBattlePower;
    [Token(Token = "0x40025B0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI accessoryDef;
    [Token(Token = "0x40025B1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI accessoryMagDef;
    [Token(Token = "0x40025B2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI accessorySpecialAvoid;
    [Token(Token = "0x40025B3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI accessoryWeight;

    [Token(Token = "0x6002DD8")]
    [Address(RVA = "0x3A8B6BC", Offset = "0x3A8B6BC", VA = "0x3A8B6BC", Slot = "4")]
    public override void ResetEquipParameter()
    {
    }

    [Token(Token = "0x6002DD9")]
    [Address(RVA = "0x3A8B8C4", Offset = "0x3A8B8C4", VA = "0x3A8B8C4", Slot = "5")]
    public override void UpdateEquipParameter(Accessory accessory, Style selectStyle)
    {
    }

    [Token(Token = "0x6002DDA")]
    [Address(RVA = "0x3A8BA3C", Offset = "0x3A8BA3C", VA = "0x3A8BA3C", Slot = "6")]
    public override void UpdateEquipParameter(
      Accessory baseAccessory,
      Accessory selectAccessory,
      Style selectStyle)
    {
    }

    [Token(Token = "0x6002DDB")]
    [Address(RVA = "0x3A8BD38", Offset = "0x3A8BD38", VA = "0x3A8BD38")]
    public ShieldStatusView()
    {
    }
  }
}
