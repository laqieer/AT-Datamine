// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ShopData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CDA")]
  public struct ShopData : IFlatbufferObject
  {
    [Token(Token = "0x4010C3B")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FC3")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601867D"), Address(RVA = "0x26E0D20", Offset = "0x26E0D20", VA = "0x26E0D20", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601867E")]
    [Address(RVA = "0x26E0D28", Offset = "0x26E0D28", VA = "0x26E0D28")]
    public static ShopData GetRootAsShopData(ByteBuffer _bb) => new ShopData();

    [Token(Token = "0x601867F")]
    [Address(RVA = "0x26E0D34", Offset = "0x26E0D34", VA = "0x26E0D34")]
    public static ShopData GetRootAsShopData(ByteBuffer _bb, ShopData obj) => new ShopData();

    [Token(Token = "0x6018680")]
    [Address(RVA = "0x26E0D90", Offset = "0x26E0D90", VA = "0x26E0D90")]
    public static bool ShopDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018681")]
    [Address(RVA = "0x26E0DDC", Offset = "0x26E0DDC", VA = "0x26E0DDC", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018682")]
    [Address(RVA = "0x26E0D78", Offset = "0x26E0D78", VA = "0x26E0D78")]
    public ShopData __assign(int _i, ByteBuffer _bb) => new ShopData();

    [Token(Token = "0x6018683")]
    [Address(RVA = "0x26E0DE8", Offset = "0x26E0DE8", VA = "0x26E0DE8")]
    public BannerData? Shops(int j) => new BannerData?();

    [Token(Token = "0x17004FC4")]
    public int ShopsLength
    {
      [Token(Token = "0x6018684"), Address(RVA = "0x26E0E9C", Offset = "0x26E0E9C", VA = "0x26E0E9C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018685")]
    [Address(RVA = "0x26E0ED0", Offset = "0x26E0ED0", VA = "0x26E0ED0")]
    public static Offset<ShopData> CreateShopData(
      FlatBufferBuilder builder,
      VectorOffset shopsOffset = default (VectorOffset))
    {
      return new Offset<ShopData>();
    }

    [Token(Token = "0x6018686")]
    [Address(RVA = "0x26E0F88", Offset = "0x26E0F88", VA = "0x26E0F88")]
    public static void StartShopData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018687")]
    [Address(RVA = "0x26E0F18", Offset = "0x26E0F18", VA = "0x26E0F18")]
    public static void AddShops(FlatBufferBuilder builder, VectorOffset shopsOffset)
    {
    }

    [Token(Token = "0x6018688")]
    [Address(RVA = "0x26E0FA0", Offset = "0x26E0FA0", VA = "0x26E0FA0")]
    public static VectorOffset CreateShopsVector(
      FlatBufferBuilder builder,
      Offset<BannerData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018689")]
    [Address(RVA = "0x26E1048", Offset = "0x26E1048", VA = "0x26E1048")]
    public static VectorOffset CreateShopsVectorBlock(
      FlatBufferBuilder builder,
      Offset<BannerData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601868A")]
    [Address(RVA = "0x26E10D0", Offset = "0x26E10D0", VA = "0x26E10D0")]
    public static void StartShopsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601868B")]
    [Address(RVA = "0x26E0F38", Offset = "0x26E0F38", VA = "0x26E0F38")]
    public static Offset<ShopData> EndShopData(FlatBufferBuilder builder) => new Offset<ShopData>();

    [Token(Token = "0x601868C")]
    [Address(RVA = "0x26E10F0", Offset = "0x26E10F0", VA = "0x26E10F0")]
    public static void FinishShopDataBuffer(FlatBufferBuilder builder, Offset<ShopData> offset)
    {
    }

    [Token(Token = "0x601868D")]
    [Address(RVA = "0x26E114C", Offset = "0x26E114C", VA = "0x26E114C")]
    public static void FinishSizePrefixedShopDataBuffer(
      FlatBufferBuilder builder,
      Offset<ShopData> offset)
    {
    }
  }
}
