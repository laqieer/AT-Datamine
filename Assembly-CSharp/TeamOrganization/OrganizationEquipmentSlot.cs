// Decompiled with JetBrains decompiler
// Type: TeamOrganization.OrganizationEquipmentSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007E0")]
  public class OrganizationEquipmentSlot
  {
    [Token(Token = "0x17000694")]
    public OrganizationEquipmentSlot.EquipmentSlotType SlotType
    {
      [Token(Token = "0x6002C87"), Address(RVA = "0x387EEF0", Offset = "0x387EEF0", VA = "0x387EEF0")] get
      {
        return new OrganizationEquipmentSlot.EquipmentSlotType();
      }
      [Token(Token = "0x6002C88"), Address(RVA = "0x387EEF8", Offset = "0x387EEF8", VA = "0x387EEF8")] private set
      {
      }
    }

    [Token(Token = "0x17000695")]
    public Equipment Equipment
    {
      [Token(Token = "0x6002C89"), Address(RVA = "0x387EF00", Offset = "0x387EF00", VA = "0x387EF00")] get
      {
        return (Equipment) null;
      }
      [Token(Token = "0x6002C8A"), Address(RVA = "0x387EF08", Offset = "0x387EF08", VA = "0x387EF08")] private set
      {
      }
    }

    [Token(Token = "0x17000696")]
    public bool IsForExpendition
    {
      [Token(Token = "0x6002C8B"), Address(RVA = "0x387EF10", Offset = "0x387EF10", VA = "0x387EF10")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002C8C"), Address(RVA = "0x387EF18", Offset = "0x387EF18", VA = "0x387EF18")] private set
      {
      }
    }

    [Token(Token = "0x6002C8D")]
    [Address(RVA = "0x387EF24", Offset = "0x387EF24", VA = "0x387EF24")]
    public OrganizationEquipmentSlot(
      Equipment equipment,
      OrganizationEquipmentSlot.EquipmentSlotType slotType,
      bool isForExpendition = false)
    {
    }

    [Token(Token = "0x6002C8E")]
    [Address(RVA = "0x387EF68", Offset = "0x387EF68", VA = "0x387EF68")]
    public void UnEquipment()
    {
    }

    [Token(Token = "0x6002C8F")]
    [Address(RVA = "0x387EF9C", Offset = "0x387EF9C", VA = "0x387EF9C")]
    public void SetEquipment(Equipment equipment, UniqueID uniqueID)
    {
    }

    [Token(Token = "0x17000697")]
    public bool IsEmpty
    {
      [Token(Token = "0x6002C90"), Address(RVA = "0x387EF8C", Offset = "0x387EF8C", VA = "0x387EF8C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6002C91")]
    [Address(RVA = "0x387EFE4", Offset = "0x387EFE4", VA = "0x387EFE4")]
    public bool CheckAttention(OrganizationEquipmentSlot checkSlot) => new bool();

    [Token(Token = "0x20007E1")]
    public enum EquipmentSlotType
    {
      [Token(Token = "0x40024DF")] MainWeapon,
      [Token(Token = "0x40024E0")] SubWeapon1,
      [Token(Token = "0x40024E1")] SubWeapon2,
      [Token(Token = "0x40024E2")] Accessories,
      [Token(Token = "0x40024E3")] UnitTrust,
      [Token(Token = "0x40024E4")] Vision,
      [Token(Token = "0x40024E5")] SlotMax,
    }
  }
}
