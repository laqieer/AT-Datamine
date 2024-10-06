// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.FilterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CDF")]
  public struct FilterData : IFlatbufferObject
  {
    [Token(Token = "0x4010C40")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FD9")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60186E7"), Address(RVA = "0x26E2A2C", Offset = "0x26E2A2C", VA = "0x26E2A2C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60186E8")]
    [Address(RVA = "0x26E2A34", Offset = "0x26E2A34", VA = "0x26E2A34")]
    public static FilterData GetRootAsFilterData(ByteBuffer _bb) => new FilterData();

    [Token(Token = "0x60186E9")]
    [Address(RVA = "0x26E2A40", Offset = "0x26E2A40", VA = "0x26E2A40")]
    public static FilterData GetRootAsFilterData(ByteBuffer _bb, FilterData obj)
    {
      return new FilterData();
    }

    [Token(Token = "0x60186EA")]
    [Address(RVA = "0x26E2A84", Offset = "0x26E2A84", VA = "0x26E2A84", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60186EB")]
    [Address(RVA = "0x26E2728", Offset = "0x26E2728", VA = "0x26E2728")]
    public FilterData __assign(int _i, ByteBuffer _bb) => new FilterData();

    [Token(Token = "0x17004FDA")]
    public int Id
    {
      [Token(Token = "0x60186EC"), Address(RVA = "0x26E2A90", Offset = "0x26E2A90", VA = "0x26E2A90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60186ED")]
    [Address(RVA = "0x26E2AD4", Offset = "0x26E2AD4", VA = "0x26E2AD4")]
    public bool Flags(int j) => new bool();

    [Token(Token = "0x17004FDB")]
    public int FlagsLength
    {
      [Token(Token = "0x60186EE"), Address(RVA = "0x26E2B34", Offset = "0x26E2B34", VA = "0x26E2B34")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60186EF")]
    [Address(RVA = "0x26E2B68", Offset = "0x26E2B68", VA = "0x26E2B68")]
    public ArraySegment<byte>? GetFlagsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60186F0")]
    [Address(RVA = "0x26E2BA0", Offset = "0x26E2BA0", VA = "0x26E2BA0")]
    public bool[] GetFlagsArray() => (bool[]) null;

    [Token(Token = "0x60186F1")]
    [Address(RVA = "0x26E2BEC", Offset = "0x26E2BEC", VA = "0x26E2BEC")]
    public static Offset<FilterData> CreateFilterData(
      FlatBufferBuilder builder,
      int id = 0,
      VectorOffset flagsOffset = default (VectorOffset))
    {
      return new Offset<FilterData>();
    }

    [Token(Token = "0x60186F2")]
    [Address(RVA = "0x26E2CD4", Offset = "0x26E2CD4", VA = "0x26E2CD4")]
    public static void StartFilterData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60186F3")]
    [Address(RVA = "0x26E2C64", Offset = "0x26E2C64", VA = "0x26E2C64")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x60186F4")]
    [Address(RVA = "0x26E2C44", Offset = "0x26E2C44", VA = "0x26E2C44")]
    public static void AddFlags(FlatBufferBuilder builder, VectorOffset flagsOffset)
    {
    }

    [Token(Token = "0x60186F5")]
    [Address(RVA = "0x26E2CEC", Offset = "0x26E2CEC", VA = "0x26E2CEC")]
    public static VectorOffset CreateFlagsVector(FlatBufferBuilder builder, bool[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60186F6")]
    [Address(RVA = "0x26E2D94", Offset = "0x26E2D94", VA = "0x26E2D94")]
    public static VectorOffset CreateFlagsVectorBlock(FlatBufferBuilder builder, bool[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60186F7")]
    [Address(RVA = "0x26E2E1C", Offset = "0x26E2E1C", VA = "0x26E2E1C")]
    public static void StartFlagsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60186F8")]
    [Address(RVA = "0x26E2C84", Offset = "0x26E2C84", VA = "0x26E2C84")]
    public static Offset<FilterData> EndFilterData(FlatBufferBuilder builder)
    {
      return new Offset<FilterData>();
    }
  }
}
