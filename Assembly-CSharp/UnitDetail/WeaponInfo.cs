// Decompiled with JetBrains decompiler
// Type: UnitDetail.WeaponInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using TeamOrganization;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x2000498")]
  public class WeaponInfo : ItemInfoBase
  {
    [Token(Token = "0x1700031D")]
    public int MaxDurability
    {
      [Token(Token = "0x60019C4"), Address(RVA = "0x2C232D8", Offset = "0x2C232D8", VA = "0x2C232D8")] get
      {
        return new int();
      }
      [Token(Token = "0x60019C5"), Address(RVA = "0x2C232E0", Offset = "0x2C232E0", VA = "0x2C232E0")] set
      {
      }
    }

    [Token(Token = "0x1700031E")]
    public Weapon Data
    {
      [Token(Token = "0x60019C6"), Address(RVA = "0x2C232E8", Offset = "0x2C232E8", VA = "0x2C232E8")] get
      {
        return (Weapon) null;
      }
      [Token(Token = "0x60019C7"), Address(RVA = "0x2C232F0", Offset = "0x2C232F0", VA = "0x2C232F0")] private set
      {
      }
    }

    [Token(Token = "0x60019C8")]
    [Address(RVA = "0x2C232F8", Offset = "0x2C232F8", VA = "0x2C232F8")]
    public WeaponInfo(
      string itemName,
      string iconName,
      Weapon weapon,
      OrganizationEquipmentSlot.EquipmentSlotType equipmentSlotType)
    {
    }
  }
}
