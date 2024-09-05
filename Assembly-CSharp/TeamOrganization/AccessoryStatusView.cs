// Decompiled with JetBrains decompiler
// Type: TeamOrganization.AccessoryStatusView
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
  [Token(Token = "0x200078C")]
  public class AccessoryStatusView : AccessoryStatusViewBase
  {
    [Token(Token = "0x40022C9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI accessoryLv;
    [Token(Token = "0x40022CA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI accessoryBattlePower;
    [Token(Token = "0x40022CB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI accessoryLife;
    [Token(Token = "0x40022CC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI accessoryStrength;
    [Token(Token = "0x40022CD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI accessoryIntelligence;
    [Token(Token = "0x40022CE")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI accessoryVitality;
    [Token(Token = "0x40022CF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI accessoryMind;
    [Token(Token = "0x40022D0")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI accessoryAgility;
    [Token(Token = "0x40022D1")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI accessoryDexterity;
    [Token(Token = "0x40022D2")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI accessoryLucky;
    [Token(Token = "0x40022D3")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI accessoryWeight;

    [Token(Token = "0x6002A54")]
    [Address(RVA = "0x3500B38", Offset = "0x3500B38", VA = "0x3500B38", Slot = "4")]
    public override void ResetEquipParameter()
    {
    }

    [Token(Token = "0x6002A55")]
    [Address(RVA = "0x3500E94", Offset = "0x3500E94", VA = "0x3500E94", Slot = "5")]
    public override void UpdateEquipParameter(Accessory accessory, Style selectStyle)
    {
    }

    [Token(Token = "0x6002A56")]
    [Address(RVA = "0x3501190", Offset = "0x3501190", VA = "0x3501190", Slot = "6")]
    public override void UpdateEquipParameter(
      Accessory baseAccessory,
      Accessory selectAccessory,
      Style selectStyle)
    {
    }

    [Token(Token = "0x6002A57")]
    [Address(RVA = "0x3501888", Offset = "0x3501888", VA = "0x3501888")]
    public AccessoryStatusView()
    {
    }
  }
}
