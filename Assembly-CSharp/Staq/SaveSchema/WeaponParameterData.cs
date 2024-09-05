// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.WeaponParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C94")]
  public struct WeaponParameterData : IFlatbufferObject
  {
    [Token(Token = "0x4010BF3")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EC5")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018176"), Address(RVA = "0x3B20458", Offset = "0x3B20458", VA = "0x3B20458", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018177")]
    [Address(RVA = "0x3B20460", Offset = "0x3B20460", VA = "0x3B20460")]
    public static WeaponParameterData GetRootAsWeaponParameterData(ByteBuffer _bb)
    {
      return new WeaponParameterData();
    }

    [Token(Token = "0x6018178")]
    [Address(RVA = "0x3B2046C", Offset = "0x3B2046C", VA = "0x3B2046C")]
    public static WeaponParameterData GetRootAsWeaponParameterData(
      ByteBuffer _bb,
      WeaponParameterData obj)
    {
      return new WeaponParameterData();
    }

    [Token(Token = "0x6018179")]
    [Address(RVA = "0x3B204B0", Offset = "0x3B204B0", VA = "0x3B204B0", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601817A")]
    [Address(RVA = "0x3B1D848", Offset = "0x3B1D848", VA = "0x3B1D848")]
    public WeaponParameterData __assign(int _i, ByteBuffer _bb) => new WeaponParameterData();

    [Token(Token = "0x17004EC6")]
    public string Weapon
    {
      [Token(Token = "0x601817B"), Address(RVA = "0x3B204BC", Offset = "0x3B204BC", VA = "0x3B204BC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601817C")]
    [Address(RVA = "0x3B204F8", Offset = "0x3B204F8", VA = "0x3B204F8")]
    public ArraySegment<byte>? GetWeaponBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x601817D")]
    [Address(RVA = "0x3B20530", Offset = "0x3B20530", VA = "0x3B20530")]
    public byte[] GetWeaponArray() => (byte[]) null;

    [Token(Token = "0x17004EC7")]
    public int Exp
    {
      [Token(Token = "0x601817E"), Address(RVA = "0x3B2057C", Offset = "0x3B2057C", VA = "0x3B2057C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EC8")]
    public int Durable
    {
      [Token(Token = "0x601817F"), Address(RVA = "0x3B205C0", Offset = "0x3B205C0", VA = "0x3B205C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EC9")]
    public int NormalAttackSkillParam
    {
      [Token(Token = "0x6018180"), Address(RVA = "0x3B20604", Offset = "0x3B20604", VA = "0x3B20604")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018181")]
    [Address(RVA = "0x3B20648", Offset = "0x3B20648", VA = "0x3B20648")]
    public int WeaponSkillParams(int j) => new int();

    [Token(Token = "0x17004ECA")]
    public int WeaponSkillParamsLength
    {
      [Token(Token = "0x6018182"), Address(RVA = "0x3B206A8", Offset = "0x3B206A8", VA = "0x3B206A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018183")]
    [Address(RVA = "0x3B206DC", Offset = "0x3B206DC", VA = "0x3B206DC")]
    public ArraySegment<byte>? GetWeaponSkillParamsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018184")]
    [Address(RVA = "0x3B20714", Offset = "0x3B20714", VA = "0x3B20714")]
    public int[] GetWeaponSkillParamsArray() => (int[]) null;

    [Token(Token = "0x17004ECB")]
    public WeaponParameterData? Substitute
    {
      [Token(Token = "0x6018185"), Address(RVA = "0x3B20760", Offset = "0x3B20760", VA = "0x3B20760")] get
      {
        return new WeaponParameterData?();
      }
    }

    [Token(Token = "0x6018186")]
    [Address(RVA = "0x3B207F8", Offset = "0x3B207F8", VA = "0x3B207F8")]
    public static Offset<WeaponParameterData> CreateWeaponParameterData(
      FlatBufferBuilder builder,
      StringOffset weaponOffset = default (StringOffset),
      int exp = 0,
      int durable = 0,
      int normalAttackSkillParam = 0,
      VectorOffset weaponSkillParamsOffset = default (VectorOffset),
      Offset<WeaponParameterData> substituteOffset = default (Offset<WeaponParameterData>))
    {
      return new Offset<WeaponParameterData>();
    }

    [Token(Token = "0x6018187")]
    [Address(RVA = "0x3B209B0", Offset = "0x3B209B0", VA = "0x3B209B0")]
    public static void StartWeaponParameterData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018188")]
    [Address(RVA = "0x3B20940", Offset = "0x3B20940", VA = "0x3B20940")]
    public static void AddWeapon(FlatBufferBuilder builder, StringOffset weaponOffset)
    {
    }

    [Token(Token = "0x6018189")]
    [Address(RVA = "0x3B20920", Offset = "0x3B20920", VA = "0x3B20920")]
    public static void AddExp(FlatBufferBuilder builder, int exp)
    {
    }

    [Token(Token = "0x601818A")]
    [Address(RVA = "0x3B20900", Offset = "0x3B20900", VA = "0x3B20900")]
    public static void AddDurable(FlatBufferBuilder builder, int durable)
    {
    }

    [Token(Token = "0x601818B")]
    [Address(RVA = "0x3B208E0", Offset = "0x3B208E0", VA = "0x3B208E0")]
    public static void AddNormalAttackSkillParam(
      FlatBufferBuilder builder,
      int normalAttackSkillParam)
    {
    }

    [Token(Token = "0x601818C")]
    [Address(RVA = "0x3B208C0", Offset = "0x3B208C0", VA = "0x3B208C0")]
    public static void AddWeaponSkillParams(
      FlatBufferBuilder builder,
      VectorOffset weaponSkillParamsOffset)
    {
    }

    [Token(Token = "0x601818D")]
    [Address(RVA = "0x3B209C8", Offset = "0x3B209C8", VA = "0x3B209C8")]
    public static VectorOffset CreateWeaponSkillParamsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601818E")]
    [Address(RVA = "0x3B20A70", Offset = "0x3B20A70", VA = "0x3B20A70")]
    public static VectorOffset CreateWeaponSkillParamsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601818F")]
    [Address(RVA = "0x3B20AF8", Offset = "0x3B20AF8", VA = "0x3B20AF8")]
    public static void StartWeaponSkillParamsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018190")]
    [Address(RVA = "0x3B208A0", Offset = "0x3B208A0", VA = "0x3B208A0")]
    public static void AddSubstitute(
      FlatBufferBuilder builder,
      Offset<WeaponParameterData> substituteOffset)
    {
    }

    [Token(Token = "0x6018191")]
    [Address(RVA = "0x3B20960", Offset = "0x3B20960", VA = "0x3B20960")]
    public static Offset<WeaponParameterData> EndWeaponParameterData(FlatBufferBuilder builder)
    {
      return new Offset<WeaponParameterData>();
    }
  }
}
