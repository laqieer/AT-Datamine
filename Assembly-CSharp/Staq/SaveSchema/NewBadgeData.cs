// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.NewBadgeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CC4")]
  public struct NewBadgeData : IFlatbufferObject
  {
    [Token(Token = "0x4010C22")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F77")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60184D5"), Address(RVA = "0x26DA6F4", Offset = "0x26DA6F4", VA = "0x26DA6F4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60184D6")]
    [Address(RVA = "0x26DA6FC", Offset = "0x26DA6FC", VA = "0x26DA6FC")]
    public static NewBadgeData GetRootAsNewBadgeData(ByteBuffer _bb) => new NewBadgeData();

    [Token(Token = "0x60184D7")]
    [Address(RVA = "0x26DA708", Offset = "0x26DA708", VA = "0x26DA708")]
    public static NewBadgeData GetRootAsNewBadgeData(ByteBuffer _bb, NewBadgeData obj)
    {
      return new NewBadgeData();
    }

    [Token(Token = "0x60184D8")]
    [Address(RVA = "0x26DA764", Offset = "0x26DA764", VA = "0x26DA764")]
    public static bool NewBadgeDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60184D9")]
    [Address(RVA = "0x26DA7B0", Offset = "0x26DA7B0", VA = "0x26DA7B0", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60184DA")]
    [Address(RVA = "0x26DA74C", Offset = "0x26DA74C", VA = "0x26DA74C")]
    public NewBadgeData __assign(int _i, ByteBuffer _bb) => new NewBadgeData();

    [Token(Token = "0x17004F78")]
    public string CreatedAt
    {
      [Token(Token = "0x60184DB"), Address(RVA = "0x26DA7BC", Offset = "0x26DA7BC", VA = "0x26DA7BC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60184DC")]
    [Address(RVA = "0x26DA7F8", Offset = "0x26DA7F8", VA = "0x26DA7F8")]
    public ArraySegment<byte>? GetCreatedAtBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60184DD")]
    [Address(RVA = "0x26DA830", Offset = "0x26DA830", VA = "0x26DA830")]
    public byte[] GetCreatedAtArray() => (byte[]) null;

    [Token(Token = "0x60184DE")]
    [Address(RVA = "0x26DA87C", Offset = "0x26DA87C", VA = "0x26DA87C")]
    public string StyleIds(int j) => (string) null;

    [Token(Token = "0x17004F79")]
    public int StyleIdsLength
    {
      [Token(Token = "0x60184DF"), Address(RVA = "0x26DA8D4", Offset = "0x26DA8D4", VA = "0x26DA8D4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60184E0")]
    [Address(RVA = "0x26DA908", Offset = "0x26DA908", VA = "0x26DA908")]
    public string WeaponIds(int j) => (string) null;

    [Token(Token = "0x17004F7A")]
    public int WeaponIdsLength
    {
      [Token(Token = "0x60184E1"), Address(RVA = "0x26DA960", Offset = "0x26DA960", VA = "0x26DA960")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60184E2")]
    [Address(RVA = "0x26DA994", Offset = "0x26DA994", VA = "0x26DA994")]
    public string AccessoryIds(int j) => (string) null;

    [Token(Token = "0x17004F7B")]
    public int AccessoryIdsLength
    {
      [Token(Token = "0x60184E3"), Address(RVA = "0x26DA9EC", Offset = "0x26DA9EC", VA = "0x26DA9EC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60184E4")]
    [Address(RVA = "0x26DAA20", Offset = "0x26DAA20", VA = "0x26DAA20")]
    public string MindEquipmentIds(int j) => (string) null;

    [Token(Token = "0x17004F7C")]
    public int MindEquipmentIdsLength
    {
      [Token(Token = "0x60184E5"), Address(RVA = "0x26DAA78", Offset = "0x26DAA78", VA = "0x26DAA78")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60184E6")]
    [Address(RVA = "0x26DAAAC", Offset = "0x26DAAAC", VA = "0x26DAAAC")]
    public string UnitTrustIds(int j) => (string) null;

    [Token(Token = "0x17004F7D")]
    public int UnitTrustIdsLength
    {
      [Token(Token = "0x60184E7"), Address(RVA = "0x26DAB04", Offset = "0x26DAB04", VA = "0x26DAB04")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60184E8")]
    [Address(RVA = "0x26DAB38", Offset = "0x26DAB38", VA = "0x26DAB38")]
    public string CustomSkillIds(int j) => (string) null;

    [Token(Token = "0x17004F7E")]
    public int CustomSkillIdsLength
    {
      [Token(Token = "0x60184E9"), Address(RVA = "0x26DAB90", Offset = "0x26DAB90", VA = "0x26DAB90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60184EA")]
    [Address(RVA = "0x26DABC4", Offset = "0x26DABC4", VA = "0x26DABC4")]
    public string ItemIds(int j) => (string) null;

    [Token(Token = "0x17004F7F")]
    public int ItemIdsLength
    {
      [Token(Token = "0x60184EB"), Address(RVA = "0x26DAC1C", Offset = "0x26DAC1C", VA = "0x26DAC1C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60184EC")]
    [Address(RVA = "0x26DAC50", Offset = "0x26DAC50", VA = "0x26DAC50")]
    public int GachaNumbers(int j) => new int();

    [Token(Token = "0x17004F80")]
    public int GachaNumbersLength
    {
      [Token(Token = "0x60184ED"), Address(RVA = "0x26DACB0", Offset = "0x26DACB0", VA = "0x26DACB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60184EE")]
    [Address(RVA = "0x26DACE4", Offset = "0x26DACE4", VA = "0x26DACE4")]
    public ArraySegment<byte>? GetGachaNumbersBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60184EF")]
    [Address(RVA = "0x26DAD1C", Offset = "0x26DAD1C", VA = "0x26DAD1C")]
    public int[] GetGachaNumbersArray() => (int[]) null;

    [Token(Token = "0x60184F0")]
    [Address(RVA = "0x26DAD68", Offset = "0x26DAD68", VA = "0x26DAD68")]
    public int ObliviaeQuestIds(int j) => new int();

    [Token(Token = "0x17004F81")]
    public int ObliviaeQuestIdsLength
    {
      [Token(Token = "0x60184F1"), Address(RVA = "0x26DADC8", Offset = "0x26DADC8", VA = "0x26DADC8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60184F2")]
    [Address(RVA = "0x26DADFC", Offset = "0x26DADFC", VA = "0x26DADFC")]
    public ArraySegment<byte>? GetObliviaeQuestIdsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60184F3")]
    [Address(RVA = "0x26DAE34", Offset = "0x26DAE34", VA = "0x26DAE34")]
    public int[] GetObliviaeQuestIdsArray() => (int[]) null;

    [Token(Token = "0x60184F4")]
    [Address(RVA = "0x26DAE80", Offset = "0x26DAE80", VA = "0x26DAE80")]
    public static Offset<NewBadgeData> CreateNewBadgeData(
      FlatBufferBuilder builder,
      StringOffset createdAtOffset = default (StringOffset),
      VectorOffset styleIdsOffset = default (VectorOffset),
      VectorOffset weaponIdsOffset = default (VectorOffset),
      VectorOffset accessoryIdsOffset = default (VectorOffset),
      VectorOffset mindEquipmentIdsOffset = default (VectorOffset),
      VectorOffset unitTrustIdsOffset = default (VectorOffset),
      VectorOffset customSkillIdsOffset = default (VectorOffset),
      VectorOffset itemIdsOffset = default (VectorOffset),
      VectorOffset gachaNumbersOffset = default (VectorOffset),
      VectorOffset obliviaeQuestIdsOffset = default (VectorOffset))
    {
      return new Offset<NewBadgeData>();
    }

    [Token(Token = "0x60184F5")]
    [Address(RVA = "0x26DB104", Offset = "0x26DB104", VA = "0x26DB104")]
    public static void StartNewBadgeData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60184F6")]
    [Address(RVA = "0x26DB094", Offset = "0x26DB094", VA = "0x26DB094")]
    public static void AddCreatedAt(FlatBufferBuilder builder, StringOffset createdAtOffset)
    {
    }

    [Token(Token = "0x60184F7")]
    [Address(RVA = "0x26DB074", Offset = "0x26DB074", VA = "0x26DB074")]
    public static void AddStyleIds(FlatBufferBuilder builder, VectorOffset styleIdsOffset)
    {
    }

    [Token(Token = "0x60184F8")]
    [Address(RVA = "0x26DB11C", Offset = "0x26DB11C", VA = "0x26DB11C")]
    public static VectorOffset CreateStyleIdsVector(FlatBufferBuilder builder, StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60184F9")]
    [Address(RVA = "0x26DB1C4", Offset = "0x26DB1C4", VA = "0x26DB1C4")]
    public static VectorOffset CreateStyleIdsVectorBlock(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60184FA")]
    [Address(RVA = "0x26DB24C", Offset = "0x26DB24C", VA = "0x26DB24C")]
    public static void StartStyleIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60184FB")]
    [Address(RVA = "0x26DB054", Offset = "0x26DB054", VA = "0x26DB054")]
    public static void AddWeaponIds(FlatBufferBuilder builder, VectorOffset weaponIdsOffset)
    {
    }

    [Token(Token = "0x60184FC")]
    [Address(RVA = "0x26DB26C", Offset = "0x26DB26C", VA = "0x26DB26C")]
    public static VectorOffset CreateWeaponIdsVector(FlatBufferBuilder builder, StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60184FD")]
    [Address(RVA = "0x26DB314", Offset = "0x26DB314", VA = "0x26DB314")]
    public static VectorOffset CreateWeaponIdsVectorBlock(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60184FE")]
    [Address(RVA = "0x26DB39C", Offset = "0x26DB39C", VA = "0x26DB39C")]
    public static void StartWeaponIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60184FF")]
    [Address(RVA = "0x26DB034", Offset = "0x26DB034", VA = "0x26DB034")]
    public static void AddAccessoryIds(FlatBufferBuilder builder, VectorOffset accessoryIdsOffset)
    {
    }

    [Token(Token = "0x6018500")]
    [Address(RVA = "0x26DB3BC", Offset = "0x26DB3BC", VA = "0x26DB3BC")]
    public static VectorOffset CreateAccessoryIdsVector(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018501")]
    [Address(RVA = "0x26DB464", Offset = "0x26DB464", VA = "0x26DB464")]
    public static VectorOffset CreateAccessoryIdsVectorBlock(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018502")]
    [Address(RVA = "0x26DB4EC", Offset = "0x26DB4EC", VA = "0x26DB4EC")]
    public static void StartAccessoryIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018503")]
    [Address(RVA = "0x26DB014", Offset = "0x26DB014", VA = "0x26DB014")]
    public static void AddMindEquipmentIds(
      FlatBufferBuilder builder,
      VectorOffset mindEquipmentIdsOffset)
    {
    }

    [Token(Token = "0x6018504")]
    [Address(RVA = "0x26DB50C", Offset = "0x26DB50C", VA = "0x26DB50C")]
    public static VectorOffset CreateMindEquipmentIdsVector(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018505")]
    [Address(RVA = "0x26DB5B4", Offset = "0x26DB5B4", VA = "0x26DB5B4")]
    public static VectorOffset CreateMindEquipmentIdsVectorBlock(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018506")]
    [Address(RVA = "0x26DB63C", Offset = "0x26DB63C", VA = "0x26DB63C")]
    public static void StartMindEquipmentIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018507")]
    [Address(RVA = "0x26DAFF4", Offset = "0x26DAFF4", VA = "0x26DAFF4")]
    public static void AddUnitTrustIds(FlatBufferBuilder builder, VectorOffset unitTrustIdsOffset)
    {
    }

    [Token(Token = "0x6018508")]
    [Address(RVA = "0x26DB65C", Offset = "0x26DB65C", VA = "0x26DB65C")]
    public static VectorOffset CreateUnitTrustIdsVector(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018509")]
    [Address(RVA = "0x26DB704", Offset = "0x26DB704", VA = "0x26DB704")]
    public static VectorOffset CreateUnitTrustIdsVectorBlock(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601850A")]
    [Address(RVA = "0x26DB78C", Offset = "0x26DB78C", VA = "0x26DB78C")]
    public static void StartUnitTrustIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601850B")]
    [Address(RVA = "0x26DAFD4", Offset = "0x26DAFD4", VA = "0x26DAFD4")]
    public static void AddCustomSkillIds(
      FlatBufferBuilder builder,
      VectorOffset customSkillIdsOffset)
    {
    }

    [Token(Token = "0x601850C")]
    [Address(RVA = "0x26DB7AC", Offset = "0x26DB7AC", VA = "0x26DB7AC")]
    public static VectorOffset CreateCustomSkillIdsVector(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601850D")]
    [Address(RVA = "0x26DB854", Offset = "0x26DB854", VA = "0x26DB854")]
    public static VectorOffset CreateCustomSkillIdsVectorBlock(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601850E")]
    [Address(RVA = "0x26DB8DC", Offset = "0x26DB8DC", VA = "0x26DB8DC")]
    public static void StartCustomSkillIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601850F")]
    [Address(RVA = "0x26DAFB4", Offset = "0x26DAFB4", VA = "0x26DAFB4")]
    public static void AddItemIds(FlatBufferBuilder builder, VectorOffset itemIdsOffset)
    {
    }

    [Token(Token = "0x6018510")]
    [Address(RVA = "0x26DB8FC", Offset = "0x26DB8FC", VA = "0x26DB8FC")]
    public static VectorOffset CreateItemIdsVector(FlatBufferBuilder builder, StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018511")]
    [Address(RVA = "0x26DB9A4", Offset = "0x26DB9A4", VA = "0x26DB9A4")]
    public static VectorOffset CreateItemIdsVectorBlock(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018512")]
    [Address(RVA = "0x26DBA2C", Offset = "0x26DBA2C", VA = "0x26DBA2C")]
    public static void StartItemIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018513")]
    [Address(RVA = "0x26DAF94", Offset = "0x26DAF94", VA = "0x26DAF94")]
    public static void AddGachaNumbers(FlatBufferBuilder builder, VectorOffset gachaNumbersOffset)
    {
    }

    [Token(Token = "0x6018514")]
    [Address(RVA = "0x26DBA4C", Offset = "0x26DBA4C", VA = "0x26DBA4C")]
    public static VectorOffset CreateGachaNumbersVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018515")]
    [Address(RVA = "0x26DBAF4", Offset = "0x26DBAF4", VA = "0x26DBAF4")]
    public static VectorOffset CreateGachaNumbersVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018516")]
    [Address(RVA = "0x26DBB7C", Offset = "0x26DBB7C", VA = "0x26DBB7C")]
    public static void StartGachaNumbersVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018517")]
    [Address(RVA = "0x26DAF74", Offset = "0x26DAF74", VA = "0x26DAF74")]
    public static void AddObliviaeQuestIds(
      FlatBufferBuilder builder,
      VectorOffset obliviaeQuestIdsOffset)
    {
    }

    [Token(Token = "0x6018518")]
    [Address(RVA = "0x26DBB9C", Offset = "0x26DBB9C", VA = "0x26DBB9C")]
    public static VectorOffset CreateObliviaeQuestIdsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018519")]
    [Address(RVA = "0x26DBC44", Offset = "0x26DBC44", VA = "0x26DBC44")]
    public static VectorOffset CreateObliviaeQuestIdsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601851A")]
    [Address(RVA = "0x26DBCCC", Offset = "0x26DBCCC", VA = "0x26DBCCC")]
    public static void StartObliviaeQuestIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601851B")]
    [Address(RVA = "0x26DB0B4", Offset = "0x26DB0B4", VA = "0x26DB0B4")]
    public static Offset<NewBadgeData> EndNewBadgeData(FlatBufferBuilder builder)
    {
      return new Offset<NewBadgeData>();
    }

    [Token(Token = "0x601851C")]
    [Address(RVA = "0x26DBCEC", Offset = "0x26DBCEC", VA = "0x26DBCEC")]
    public static void FinishNewBadgeDataBuffer(
      FlatBufferBuilder builder,
      Offset<NewBadgeData> offset)
    {
    }

    [Token(Token = "0x601851D")]
    [Address(RVA = "0x26DBD48", Offset = "0x26DBD48", VA = "0x26DBD48")]
    public static void FinishSizePrefixedNewBadgeDataBuffer(
      FlatBufferBuilder builder,
      Offset<NewBadgeData> offset)
    {
    }
  }
}
