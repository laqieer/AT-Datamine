// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.URLSchemeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CE9")]
  public struct URLSchemeData : IFlatbufferObject
  {
    [Token(Token = "0x4010C4A")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FFA")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018799"), Address(RVA = "0x2937154", Offset = "0x2937154", VA = "0x2937154", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601879A")]
    [Address(RVA = "0x293715C", Offset = "0x293715C", VA = "0x293715C")]
    public static URLSchemeData GetRootAsURLSchemeData(ByteBuffer _bb) => new URLSchemeData();

    [Token(Token = "0x601879B")]
    [Address(RVA = "0x2937168", Offset = "0x2937168", VA = "0x2937168")]
    public static URLSchemeData GetRootAsURLSchemeData(ByteBuffer _bb, URLSchemeData obj)
    {
      return new URLSchemeData();
    }

    [Token(Token = "0x601879C")]
    [Address(RVA = "0x29371C4", Offset = "0x29371C4", VA = "0x29371C4")]
    public static bool URLSchemeDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601879D")]
    [Address(RVA = "0x2937210", Offset = "0x2937210", VA = "0x2937210", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601879E")]
    [Address(RVA = "0x29371AC", Offset = "0x29371AC", VA = "0x29371AC")]
    public URLSchemeData __assign(int _i, ByteBuffer _bb) => new URLSchemeData();

    [Token(Token = "0x601879F")]
    [Address(RVA = "0x293721C", Offset = "0x293721C", VA = "0x293721C")]
    public URLSchemeParameterDetail? Parameters(int j) => new URLSchemeParameterDetail?();

    [Token(Token = "0x17004FFB")]
    public int ParametersLength
    {
      [Token(Token = "0x60187A0"), Address(RVA = "0x29372D0", Offset = "0x29372D0", VA = "0x29372D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60187A1")]
    [Address(RVA = "0x2937304", Offset = "0x2937304", VA = "0x2937304")]
    public static Offset<URLSchemeData> CreateURLSchemeData(
      FlatBufferBuilder builder,
      VectorOffset parametersOffset = default (VectorOffset))
    {
      return new Offset<URLSchemeData>();
    }

    [Token(Token = "0x60187A2")]
    [Address(RVA = "0x29373BC", Offset = "0x29373BC", VA = "0x29373BC")]
    public static void StartURLSchemeData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60187A3")]
    [Address(RVA = "0x293734C", Offset = "0x293734C", VA = "0x293734C")]
    public static void AddParameters(FlatBufferBuilder builder, VectorOffset parametersOffset)
    {
    }

    [Token(Token = "0x60187A4")]
    [Address(RVA = "0x29373D4", Offset = "0x29373D4", VA = "0x29373D4")]
    public static VectorOffset CreateParametersVector(
      FlatBufferBuilder builder,
      Offset<URLSchemeParameterDetail>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60187A5")]
    [Address(RVA = "0x293747C", Offset = "0x293747C", VA = "0x293747C")]
    public static VectorOffset CreateParametersVectorBlock(
      FlatBufferBuilder builder,
      Offset<URLSchemeParameterDetail>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60187A6")]
    [Address(RVA = "0x2937504", Offset = "0x2937504", VA = "0x2937504")]
    public static void StartParametersVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60187A7")]
    [Address(RVA = "0x293736C", Offset = "0x293736C", VA = "0x293736C")]
    public static Offset<URLSchemeData> EndURLSchemeData(FlatBufferBuilder builder)
    {
      return new Offset<URLSchemeData>();
    }

    [Token(Token = "0x60187A8")]
    [Address(RVA = "0x2937524", Offset = "0x2937524", VA = "0x2937524")]
    public static void FinishURLSchemeDataBuffer(
      FlatBufferBuilder builder,
      Offset<URLSchemeData> offset)
    {
    }

    [Token(Token = "0x60187A9")]
    [Address(RVA = "0x2937580", Offset = "0x2937580", VA = "0x2937580")]
    public static void FinishSizePrefixedURLSchemeDataBuffer(
      FlatBufferBuilder builder,
      Offset<URLSchemeData> offset)
    {
    }
  }
}
