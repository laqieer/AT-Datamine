// Decompiled with JetBrains decompiler
// Type: UnitDetail.EquipInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using TeamOrganization;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x2000492")]
  public class EquipInfo : ItemInfoBase
  {
    [Token(Token = "0x1700031A")]
    public Equipment Data
    {
      [Token(Token = "0x60019B0"), Address(RVA = "0x2C22F04", Offset = "0x2C22F04", VA = "0x2C22F04")] get
      {
        return (Equipment) null;
      }
      [Token(Token = "0x60019B1"), Address(RVA = "0x2C22F0C", Offset = "0x2C22F0C", VA = "0x2C22F0C")] private set
      {
      }
    }

    [Token(Token = "0x60019B2")]
    [Address(RVA = "0x2C22F14", Offset = "0x2C22F14", VA = "0x2C22F14")]
    public EquipInfo(string itemName, string iconName, Equipment equipment)
    {
    }

    [Token(Token = "0x60019B3")]
    [Address(RVA = "0x2C22F58", Offset = "0x2C22F58", VA = "0x2C22F58")]
    public EquipInfo(
      string itemName,
      string iconName,
      Equipment equipment,
      OrganizationEquipmentSlot.EquipmentSlotType equipmentSlotType)
    {
    }
  }
}
