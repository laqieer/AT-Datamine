// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.HPStockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C8F")]
  public struct HPStockData : IFlatbufferObject
  {
    [Token(Token = "0x4010BEE")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E80")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018097"), Address(RVA = "0x3B1CAA4", Offset = "0x3B1CAA4", VA = "0x3B1CAA4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018098")]
    [Address(RVA = "0x3B1CAAC", Offset = "0x3B1CAAC", VA = "0x3B1CAAC")]
    public static HPStockData GetRootAsHPStockData(ByteBuffer _bb) => new HPStockData();

    [Token(Token = "0x6018099")]
    [Address(RVA = "0x3B1CAB8", Offset = "0x3B1CAB8", VA = "0x3B1CAB8")]
    public static HPStockData GetRootAsHPStockData(ByteBuffer _bb, HPStockData obj)
    {
      return new HPStockData();
    }

    [Token(Token = "0x601809A")]
    [Address(RVA = "0x3B1CB14", Offset = "0x3B1CB14", VA = "0x3B1CB14", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601809B")]
    [Address(RVA = "0x3B1CAFC", Offset = "0x3B1CAFC", VA = "0x3B1CAFC")]
    public HPStockData __assign(int _i, ByteBuffer _bb) => new HPStockData();

    [Token(Token = "0x601809C")]
    [Address(RVA = "0x3B1CB20", Offset = "0x3B1CB20", VA = "0x3B1CB20")]
    public HPData? HpList(int j) => new HPData?();

    [Token(Token = "0x17004E81")]
    public int HpListLength
    {
      [Token(Token = "0x601809D"), Address(RVA = "0x3B1CBD4", Offset = "0x3B1CBD4", VA = "0x3B1CBD4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E82")]
    public int CurrentIndex
    {
      [Token(Token = "0x601809E"), Address(RVA = "0x3B1CC08", Offset = "0x3B1CC08", VA = "0x3B1CC08")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E83")]
    public bool CalculatedFromParam
    {
      [Token(Token = "0x601809F"), Address(RVA = "0x3B1CC4C", Offset = "0x3B1CC4C", VA = "0x3B1CC4C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60180A0")]
    [Address(RVA = "0x3B1CC94", Offset = "0x3B1CC94", VA = "0x3B1CC94")]
    public static Offset<HPStockData> CreateHPStockData(
      FlatBufferBuilder builder,
      VectorOffset hpListOffset = default (VectorOffset),
      int currentIndex = 0,
      bool calculatedFromParam = false)
    {
      return new Offset<HPStockData>();
    }

    [Token(Token = "0x60180A1")]
    [Address(RVA = "0x3B1CDB4", Offset = "0x3B1CDB4", VA = "0x3B1CDB4")]
    public static void StartHPStockData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60180A2")]
    [Address(RVA = "0x3B1CD24", Offset = "0x3B1CD24", VA = "0x3B1CD24")]
    public static void AddHpList(FlatBufferBuilder builder, VectorOffset hpListOffset)
    {
    }

    [Token(Token = "0x60180A3")]
    [Address(RVA = "0x3B1CDCC", Offset = "0x3B1CDCC", VA = "0x3B1CDCC")]
    public static VectorOffset CreateHpListVector(FlatBufferBuilder builder, Offset<HPData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60180A4")]
    [Address(RVA = "0x3B1CE74", Offset = "0x3B1CE74", VA = "0x3B1CE74")]
    public static VectorOffset CreateHpListVectorBlock(
      FlatBufferBuilder builder,
      Offset<HPData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60180A5")]
    [Address(RVA = "0x3B1CEFC", Offset = "0x3B1CEFC", VA = "0x3B1CEFC")]
    public static void StartHpListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60180A6")]
    [Address(RVA = "0x3B1CD04", Offset = "0x3B1CD04", VA = "0x3B1CD04")]
    public static void AddCurrentIndex(FlatBufferBuilder builder, int currentIndex)
    {
    }

    [Token(Token = "0x60180A7")]
    [Address(RVA = "0x3B1CD44", Offset = "0x3B1CD44", VA = "0x3B1CD44")]
    public static void AddCalculatedFromParam(FlatBufferBuilder builder, bool calculatedFromParam)
    {
    }

    [Token(Token = "0x60180A8")]
    [Address(RVA = "0x3B1CD64", Offset = "0x3B1CD64", VA = "0x3B1CD64")]
    public static Offset<HPStockData> EndHPStockData(FlatBufferBuilder builder)
    {
      return new Offset<HPStockData>();
    }
  }
}
