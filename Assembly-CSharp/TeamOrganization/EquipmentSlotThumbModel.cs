// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipmentSlotThumbModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007BE")]
  public class EquipmentSlotThumbModel
  {
    [Token(Token = "0x4002424")]
    [FieldOffset(Offset = "0x10")]
    public OrganizationEquipmentSlot.EquipmentSlotType SlotType;
    [Token(Token = "0x4002425")]
    [FieldOffset(Offset = "0x18")]
    public StaqData.UniqueID? UniqueID;
    [Token(Token = "0x4002426")]
    [FieldOffset(Offset = "0x28")]
    public int EquipmentID;
    [Token(Token = "0x4002427")]
    [FieldOffset(Offset = "0x2C")]
    public RarityTypeEnum RarityType;
    [Token(Token = "0x4002428")]
    [FieldOffset(Offset = "0x30")]
    public bool IsUnknown;
    [Token(Token = "0x4002429")]
    [FieldOffset(Offset = "0x31")]
    public bool IsFavorite;

    [Token(Token = "0x17000686")]
    public bool IsEmpty
    {
      [Token(Token = "0x6002BD5"), Address(RVA = "0x38739B4", Offset = "0x38739B4", VA = "0x38739B4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6002BD6")]
    [Address(RVA = "0x3874768", Offset = "0x3874768", VA = "0x3874768")]
    public void Set(OrganizationEquipmentSlot slot)
    {
    }

    [Token(Token = "0x6002BD7")]
    [Address(RVA = "0x3874840", Offset = "0x3874840", VA = "0x3874840")]
    public EquipmentSlotThumbModel()
    {
    }
  }
}
