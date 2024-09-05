// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.WeaponData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C6D")]
  public struct WeaponData : IFlatbufferObject
  {
    [Token(Token = "0x4010BCC")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D9E")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017D31"), Address(RVA = "0x37BBD80", Offset = "0x37BBD80", VA = "0x37BBD80", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017D32")]
    [Address(RVA = "0x37BBD88", Offset = "0x37BBD88", VA = "0x37BBD88")]
    public static WeaponData GetRootAsWeaponData(ByteBuffer _bb) => new WeaponData();

    [Token(Token = "0x6017D33")]
    [Address(RVA = "0x37BBD94", Offset = "0x37BBD94", VA = "0x37BBD94")]
    public static WeaponData GetRootAsWeaponData(ByteBuffer _bb, WeaponData obj)
    {
      return new WeaponData();
    }

    [Token(Token = "0x6017D34")]
    [Address(RVA = "0x37BBDD8", Offset = "0x37BBDD8", VA = "0x37BBDD8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017D35")]
    [Address(RVA = "0x37B79A8", Offset = "0x37B79A8", VA = "0x37B79A8")]
    public WeaponData __assign(int _i, ByteBuffer _bb) => new WeaponData();

    [Token(Token = "0x17004D9F")]
    public string Id
    {
      [Token(Token = "0x6017D36"), Address(RVA = "0x37BBDE4", Offset = "0x37BBDE4", VA = "0x37BBDE4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017D37")]
    [Address(RVA = "0x37BBE20", Offset = "0x37BBE20", VA = "0x37BBE20")]
    public ArraySegment<byte>? GetIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017D38")]
    [Address(RVA = "0x37BBE58", Offset = "0x37BBE58", VA = "0x37BBE58")]
    public byte[] GetIdArray() => (byte[]) null;

    [Token(Token = "0x17004DA0")]
    public string UniqueId
    {
      [Token(Token = "0x6017D39"), Address(RVA = "0x37BBEA4", Offset = "0x37BBEA4", VA = "0x37BBEA4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017D3A")]
    [Address(RVA = "0x37BBEE0", Offset = "0x37BBEE0", VA = "0x37BBEE0")]
    public ArraySegment<byte>? GetUniqueIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017D3B")]
    [Address(RVA = "0x37BBF18", Offset = "0x37BBF18", VA = "0x37BBF18")]
    public byte[] GetUniqueIdArray() => (byte[]) null;

    [Token(Token = "0x17004DA1")]
    public int MasterId
    {
      [Token(Token = "0x6017D3C"), Address(RVA = "0x37BBF64", Offset = "0x37BBF64", VA = "0x37BBF64")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DA2")]
    public int StartExp
    {
      [Token(Token = "0x6017D3D"), Address(RVA = "0x37BBFA8", Offset = "0x37BBFA8", VA = "0x37BBFA8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DA3")]
    public int StartDurable
    {
      [Token(Token = "0x6017D3E"), Address(RVA = "0x37BBFEC", Offset = "0x37BBFEC", VA = "0x37BBFEC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DA4")]
    public int LimitBreak
    {
      [Token(Token = "0x6017D3F"), Address(RVA = "0x37BC030", Offset = "0x37BC030", VA = "0x37BC030")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017D40")]
    [Address(RVA = "0x37BC074", Offset = "0x37BC074", VA = "0x37BC074")]
    public int Skills(int j) => new int();

    [Token(Token = "0x17004DA5")]
    public int SkillsLength
    {
      [Token(Token = "0x6017D41"), Address(RVA = "0x37BC0D4", Offset = "0x37BC0D4", VA = "0x37BC0D4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017D42")]
    [Address(RVA = "0x37BC108", Offset = "0x37BC108", VA = "0x37BC108")]
    public ArraySegment<byte>? GetSkillsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017D43")]
    [Address(RVA = "0x37BC140", Offset = "0x37BC140", VA = "0x37BC140")]
    public int[] GetSkillsArray() => (int[]) null;

    [Token(Token = "0x6017D44")]
    [Address(RVA = "0x37BC18C", Offset = "0x37BC18C", VA = "0x37BC18C")]
    public EquipmentOption? Options(int j) => new EquipmentOption?();

    [Token(Token = "0x17004DA6")]
    public int OptionsLength
    {
      [Token(Token = "0x6017D45"), Address(RVA = "0x37BC258", Offset = "0x37BC258", VA = "0x37BC258")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DA7")]
    public BattleParameter? MasterOffset
    {
      [Token(Token = "0x6017D46"), Address(RVA = "0x37BC28C", Offset = "0x37BC28C", VA = "0x37BC28C")] get
      {
        return new BattleParameter?();
      }
    }

    [Token(Token = "0x6017D47")]
    [Address(RVA = "0x37BC324", Offset = "0x37BC324", VA = "0x37BC324")]
    public static Offset<WeaponData> CreateWeaponData(
      FlatBufferBuilder builder,
      StringOffset idOffset = default (StringOffset),
      StringOffset uniqueIdOffset = default (StringOffset),
      int masterId = 0,
      int startExp = 0,
      int startDurable = 0,
      int limitBreak = 0,
      VectorOffset skillsOffset = default (VectorOffset),
      VectorOffset optionsOffset = default (VectorOffset),
      Offset<BattleParameter> masterOffsetOffset = default (Offset<BattleParameter>))
    {
      return new Offset<WeaponData>();
    }

    [Token(Token = "0x6017D48")]
    [Address(RVA = "0x37BC578", Offset = "0x37BC578", VA = "0x37BC578")]
    public static void StartWeaponData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017D49")]
    [Address(RVA = "0x37BC508", Offset = "0x37BC508", VA = "0x37BC508")]
    public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
    {
    }

    [Token(Token = "0x6017D4A")]
    [Address(RVA = "0x37BC4E8", Offset = "0x37BC4E8", VA = "0x37BC4E8")]
    public static void AddUniqueId(FlatBufferBuilder builder, StringOffset uniqueIdOffset)
    {
    }

    [Token(Token = "0x6017D4B")]
    [Address(RVA = "0x37BC4C8", Offset = "0x37BC4C8", VA = "0x37BC4C8")]
    public static void AddMasterId(FlatBufferBuilder builder, int masterId)
    {
    }

    [Token(Token = "0x6017D4C")]
    [Address(RVA = "0x37BC4A8", Offset = "0x37BC4A8", VA = "0x37BC4A8")]
    public static void AddStartExp(FlatBufferBuilder builder, int startExp)
    {
    }

    [Token(Token = "0x6017D4D")]
    [Address(RVA = "0x37BC488", Offset = "0x37BC488", VA = "0x37BC488")]
    public static void AddStartDurable(FlatBufferBuilder builder, int startDurable)
    {
    }

    [Token(Token = "0x6017D4E")]
    [Address(RVA = "0x37BC468", Offset = "0x37BC468", VA = "0x37BC468")]
    public static void AddLimitBreak(FlatBufferBuilder builder, int limitBreak)
    {
    }

    [Token(Token = "0x6017D4F")]
    [Address(RVA = "0x37BC448", Offset = "0x37BC448", VA = "0x37BC448")]
    public static void AddSkills(FlatBufferBuilder builder, VectorOffset skillsOffset)
    {
    }

    [Token(Token = "0x6017D50")]
    [Address(RVA = "0x37BC590", Offset = "0x37BC590", VA = "0x37BC590")]
    public static VectorOffset CreateSkillsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D51")]
    [Address(RVA = "0x37BC638", Offset = "0x37BC638", VA = "0x37BC638")]
    public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D52")]
    [Address(RVA = "0x37BC6C0", Offset = "0x37BC6C0", VA = "0x37BC6C0")]
    public static void StartSkillsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D53")]
    [Address(RVA = "0x37BC428", Offset = "0x37BC428", VA = "0x37BC428")]
    public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
    {
    }

    [Token(Token = "0x6017D54")]
    [Address(RVA = "0x37BC6E0", Offset = "0x37BC6E0", VA = "0x37BC6E0")]
    public static VectorOffset CreateOptionsVector(
      FlatBufferBuilder builder,
      Offset<EquipmentOption>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D55")]
    [Address(RVA = "0x37BC788", Offset = "0x37BC788", VA = "0x37BC788")]
    public static VectorOffset CreateOptionsVectorBlock(
      FlatBufferBuilder builder,
      Offset<EquipmentOption>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D56")]
    [Address(RVA = "0x37BC810", Offset = "0x37BC810", VA = "0x37BC810")]
    public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D57")]
    [Address(RVA = "0x37BC408", Offset = "0x37BC408", VA = "0x37BC408")]
    public static void AddMasterOffset(
      FlatBufferBuilder builder,
      Offset<BattleParameter> masterOffsetOffset)
    {
    }

    [Token(Token = "0x6017D58")]
    [Address(RVA = "0x37BC528", Offset = "0x37BC528", VA = "0x37BC528")]
    public static Offset<WeaponData> EndWeaponData(FlatBufferBuilder builder)
    {
      return new Offset<WeaponData>();
    }
  }
}
