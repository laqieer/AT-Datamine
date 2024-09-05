// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ShowFullDuelData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CDC")]
  public struct ShowFullDuelData : IFlatbufferObject
  {
    [Token(Token = "0x4010C3D")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FC7")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60186A1"), Address(RVA = "0x26E1660", Offset = "0x26E1660", VA = "0x26E1660", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60186A2")]
    [Address(RVA = "0x26E1668", Offset = "0x26E1668", VA = "0x26E1668")]
    public static ShowFullDuelData GetRootAsShowFullDuelData(ByteBuffer _bb)
    {
      return new ShowFullDuelData();
    }

    [Token(Token = "0x60186A3")]
    [Address(RVA = "0x26E1674", Offset = "0x26E1674", VA = "0x26E1674")]
    public static ShowFullDuelData GetRootAsShowFullDuelData(ByteBuffer _bb, ShowFullDuelData obj)
    {
      return new ShowFullDuelData();
    }

    [Token(Token = "0x60186A4")]
    [Address(RVA = "0x26E16D0", Offset = "0x26E16D0", VA = "0x26E16D0")]
    public static bool ShowFullDuelDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60186A5")]
    [Address(RVA = "0x26E171C", Offset = "0x26E171C", VA = "0x26E171C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60186A6")]
    [Address(RVA = "0x26E16B8", Offset = "0x26E16B8", VA = "0x26E16B8")]
    public ShowFullDuelData __assign(int _i, ByteBuffer _bb) => new ShowFullDuelData();

    [Token(Token = "0x60186A7")]
    [Address(RVA = "0x26E1728", Offset = "0x26E1728", VA = "0x26E1728")]
    public int ShowFullduelId(int j) => new int();

    [Token(Token = "0x17004FC8")]
    public int ShowFullduelIdLength
    {
      [Token(Token = "0x60186A8"), Address(RVA = "0x26E1788", Offset = "0x26E1788", VA = "0x26E1788")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60186A9")]
    [Address(RVA = "0x26E17BC", Offset = "0x26E17BC", VA = "0x26E17BC")]
    public ArraySegment<byte>? GetShowFullduelIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60186AA")]
    [Address(RVA = "0x26E17F4", Offset = "0x26E17F4", VA = "0x26E17F4")]
    public int[] GetShowFullduelIdArray() => (int[]) null;

    [Token(Token = "0x60186AB")]
    [Address(RVA = "0x26E1840", Offset = "0x26E1840", VA = "0x26E1840")]
    public static Offset<ShowFullDuelData> CreateShowFullDuelData(
      FlatBufferBuilder builder,
      VectorOffset show_fullduel_idOffset = default (VectorOffset))
    {
      return new Offset<ShowFullDuelData>();
    }

    [Token(Token = "0x60186AC")]
    [Address(RVA = "0x26E18F8", Offset = "0x26E18F8", VA = "0x26E18F8")]
    public static void StartShowFullDuelData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60186AD")]
    [Address(RVA = "0x26E1888", Offset = "0x26E1888", VA = "0x26E1888")]
    public static void AddShowFullduelId(
      FlatBufferBuilder builder,
      VectorOffset showFullduelIdOffset)
    {
    }

    [Token(Token = "0x60186AE")]
    [Address(RVA = "0x26E1910", Offset = "0x26E1910", VA = "0x26E1910")]
    public static VectorOffset CreateShowFullduelIdVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60186AF")]
    [Address(RVA = "0x26E19B8", Offset = "0x26E19B8", VA = "0x26E19B8")]
    public static VectorOffset CreateShowFullduelIdVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60186B0")]
    [Address(RVA = "0x26E1A40", Offset = "0x26E1A40", VA = "0x26E1A40")]
    public static void StartShowFullduelIdVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60186B1")]
    [Address(RVA = "0x26E18A8", Offset = "0x26E18A8", VA = "0x26E18A8")]
    public static Offset<ShowFullDuelData> EndShowFullDuelData(FlatBufferBuilder builder)
    {
      return new Offset<ShowFullDuelData>();
    }

    [Token(Token = "0x60186B2")]
    [Address(RVA = "0x26E1A60", Offset = "0x26E1A60", VA = "0x26E1A60")]
    public static void FinishShowFullDuelDataBuffer(
      FlatBufferBuilder builder,
      Offset<ShowFullDuelData> offset)
    {
    }

    [Token(Token = "0x60186B3")]
    [Address(RVA = "0x26E1ABC", Offset = "0x26E1ABC", VA = "0x26E1ABC")]
    public static void FinishSizePrefixedShowFullDuelDataBuffer(
      FlatBufferBuilder builder,
      Offset<ShowFullDuelData> offset)
    {
    }
  }
}
