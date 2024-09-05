// Decompiled with JetBrains decompiler
// Type: UnitDetail.RemoveInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using TeamOrganization;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x2000495")]
  public class RemoveInfo : ItemInfoBase
  {
    [Token(Token = "0x1700031C")]
    public UniqueID TargetStyleUniqueId
    {
      [Token(Token = "0x60019B9"), Address(RVA = "0x2C230A0", Offset = "0x2C230A0", VA = "0x2C230A0")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x60019BA"), Address(RVA = "0x2C230A8", Offset = "0x2C230A8", VA = "0x2C230A8")] private set
      {
      }
    }

    [Token(Token = "0x60019BB")]
    [Address(RVA = "0x2C230B0", Offset = "0x2C230B0", VA = "0x2C230B0")]
    public void SetTargetStyleUniqueID(UniqueID uniqueID)
    {
    }

    [Token(Token = "0x60019BC")]
    [Address(RVA = "0x2C230B8", Offset = "0x2C230B8", VA = "0x2C230B8")]
    public RemoveInfo(
      OrganizationEquipmentSlot.EquipmentSlotType equipmentSlotType)
    {
    }
  }
}
