// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.PassShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CC9")]
  public struct PassShop : IFlatbufferObject
  {
    [Token(Token = "0x4010C27")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F91")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018567"), Address(RVA = "0x26DCD90", Offset = "0x26DCD90", VA = "0x26DCD90", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018568")]
    [Address(RVA = "0x26DCD98", Offset = "0x26DCD98", VA = "0x26DCD98")]
    public static PassShop GetRootAsPassShop(ByteBuffer _bb) => new PassShop();

    [Token(Token = "0x6018569")]
    [Address(RVA = "0x26DCDA4", Offset = "0x26DCDA4", VA = "0x26DCDA4")]
    public static PassShop GetRootAsPassShop(ByteBuffer _bb, PassShop obj) => new PassShop();

    [Token(Token = "0x601856A")]
    [Address(RVA = "0x26DCE00", Offset = "0x26DCE00", VA = "0x26DCE00")]
    public static bool PassShopBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601856B")]
    [Address(RVA = "0x26DCE4C", Offset = "0x26DCE4C", VA = "0x26DCE4C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601856C")]
    [Address(RVA = "0x26DCDE8", Offset = "0x26DCDE8", VA = "0x26DCDE8")]
    public PassShop __assign(int _i, ByteBuffer _bb) => new PassShop();

    [Token(Token = "0x601856D")]
    [Address(RVA = "0x26DCE58", Offset = "0x26DCE58", VA = "0x26DCE58")]
    public PassShopItem? PassShops(int j) => new PassShopItem?();

    [Token(Token = "0x17004F92")]
    public int PassShopsLength
    {
      [Token(Token = "0x601856E"), Address(RVA = "0x26DCF0C", Offset = "0x26DCF0C", VA = "0x26DCF0C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601856F")]
    [Address(RVA = "0x26DCF40", Offset = "0x26DCF40", VA = "0x26DCF40")]
    public static Offset<PassShop> CreatePassShop(
      FlatBufferBuilder builder,
      VectorOffset pass_shopsOffset = default (VectorOffset))
    {
      return new Offset<PassShop>();
    }

    [Token(Token = "0x6018570")]
    [Address(RVA = "0x26DCFF8", Offset = "0x26DCFF8", VA = "0x26DCFF8")]
    public static void StartPassShop(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018571")]
    [Address(RVA = "0x26DCF88", Offset = "0x26DCF88", VA = "0x26DCF88")]
    public static void AddPassShops(FlatBufferBuilder builder, VectorOffset passShopsOffset)
    {
    }

    [Token(Token = "0x6018572")]
    [Address(RVA = "0x26DD010", Offset = "0x26DD010", VA = "0x26DD010")]
    public static VectorOffset CreatePassShopsVector(
      FlatBufferBuilder builder,
      Offset<PassShopItem>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018573")]
    [Address(RVA = "0x26DD0B8", Offset = "0x26DD0B8", VA = "0x26DD0B8")]
    public static VectorOffset CreatePassShopsVectorBlock(
      FlatBufferBuilder builder,
      Offset<PassShopItem>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018574")]
    [Address(RVA = "0x26DD140", Offset = "0x26DD140", VA = "0x26DD140")]
    public static void StartPassShopsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018575")]
    [Address(RVA = "0x26DCFA8", Offset = "0x26DCFA8", VA = "0x26DCFA8")]
    public static Offset<PassShop> EndPassShop(FlatBufferBuilder builder) => new Offset<PassShop>();

    [Token(Token = "0x6018576")]
    [Address(RVA = "0x26DD160", Offset = "0x26DD160", VA = "0x26DD160")]
    public static void FinishPassShopBuffer(FlatBufferBuilder builder, Offset<PassShop> offset)
    {
    }

    [Token(Token = "0x6018577")]
    [Address(RVA = "0x26DD1BC", Offset = "0x26DD1BC", VA = "0x26DD1BC")]
    public static void FinishSizePrefixedPassShopBuffer(
      FlatBufferBuilder builder,
      Offset<PassShop> offset)
    {
    }
  }
}
