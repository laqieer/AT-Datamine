// Decompiled with JetBrains decompiler
// Type: UnitDetail.ItemInfoBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using TeamOrganization;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x2000491")]
  public class ItemInfoBase
  {
    [Token(Token = "0x4001861")]
    [FieldOffset(Offset = "0x10")]
    public string iconName;
    [Token(Token = "0x4001862")]
    [FieldOffset(Offset = "0x18")]
    public string itemName;
    [Token(Token = "0x4001863")]
    [FieldOffset(Offset = "0x20")]
    public OrganizationEquipmentSlot.EquipmentSlotType EquipmentSlotType;
    [Token(Token = "0x4001864")]
    [FieldOffset(Offset = "0x28")]
    public UniqueID UniqueID;

    [Token(Token = "0x60019AD")]
    [Address(RVA = "0x2C22E74", Offset = "0x2C22E74", VA = "0x2C22E74")]
    public void SetUniqueID(string uniqueId)
    {
    }

    [Token(Token = "0x60019AE")]
    [Address(RVA = "0x2C22EEC", Offset = "0x2C22EEC", VA = "0x2C22EEC")]
    public void SetUniqueID(UniqueID uniqueID)
    {
    }

    [Token(Token = "0x60019AF")]
    [Address(RVA = "0x2C22EF4", Offset = "0x2C22EF4", VA = "0x2C22EF4")]
    public ItemInfoBase()
    {
    }
  }
}
