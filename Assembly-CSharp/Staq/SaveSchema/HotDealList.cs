// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.HotDealList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CBD")]
  public struct HotDealList : IFlatbufferObject
  {
    [Token(Token = "0x4010C1B")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F5F")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018451"), Address(RVA = "0x26D87C8", Offset = "0x26D87C8", VA = "0x26D87C8", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018452")]
    [Address(RVA = "0x26D87D0", Offset = "0x26D87D0", VA = "0x26D87D0")]
    public static HotDealList GetRootAsHotDealList(ByteBuffer _bb) => new HotDealList();

    [Token(Token = "0x6018453")]
    [Address(RVA = "0x26D87DC", Offset = "0x26D87DC", VA = "0x26D87DC")]
    public static HotDealList GetRootAsHotDealList(ByteBuffer _bb, HotDealList obj)
    {
      return new HotDealList();
    }

    [Token(Token = "0x6018454")]
    [Address(RVA = "0x26D8838", Offset = "0x26D8838", VA = "0x26D8838")]
    public static bool HotDealListBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018455")]
    [Address(RVA = "0x26D8884", Offset = "0x26D8884", VA = "0x26D8884", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018456")]
    [Address(RVA = "0x26D8820", Offset = "0x26D8820", VA = "0x26D8820")]
    public HotDealList __assign(int _i, ByteBuffer _bb) => new HotDealList();

    [Token(Token = "0x6018457")]
    [Address(RVA = "0x26D8890", Offset = "0x26D8890", VA = "0x26D8890")]
    public HotDeal? HotDeals(int j) => new HotDeal?();

    [Token(Token = "0x17004F60")]
    public int HotDealsLength
    {
      [Token(Token = "0x6018458"), Address(RVA = "0x26D8944", Offset = "0x26D8944", VA = "0x26D8944")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018459")]
    [Address(RVA = "0x26D8978", Offset = "0x26D8978", VA = "0x26D8978")]
    public static Offset<HotDealList> CreateHotDealList(
      FlatBufferBuilder builder,
      VectorOffset hot_dealsOffset = default (VectorOffset))
    {
      return new Offset<HotDealList>();
    }

    [Token(Token = "0x601845A")]
    [Address(RVA = "0x26D8A30", Offset = "0x26D8A30", VA = "0x26D8A30")]
    public static void StartHotDealList(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601845B")]
    [Address(RVA = "0x26D89C0", Offset = "0x26D89C0", VA = "0x26D89C0")]
    public static void AddHotDeals(FlatBufferBuilder builder, VectorOffset hotDealsOffset)
    {
    }

    [Token(Token = "0x601845C")]
    [Address(RVA = "0x26D8A48", Offset = "0x26D8A48", VA = "0x26D8A48")]
    public static VectorOffset CreateHotDealsVector(
      FlatBufferBuilder builder,
      Offset<HotDeal>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601845D")]
    [Address(RVA = "0x26D8AF0", Offset = "0x26D8AF0", VA = "0x26D8AF0")]
    public static VectorOffset CreateHotDealsVectorBlock(
      FlatBufferBuilder builder,
      Offset<HotDeal>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601845E")]
    [Address(RVA = "0x26D8B78", Offset = "0x26D8B78", VA = "0x26D8B78")]
    public static void StartHotDealsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601845F")]
    [Address(RVA = "0x26D89E0", Offset = "0x26D89E0", VA = "0x26D89E0")]
    public static Offset<HotDealList> EndHotDealList(FlatBufferBuilder builder)
    {
      return new Offset<HotDealList>();
    }

    [Token(Token = "0x6018460")]
    [Address(RVA = "0x26D8B98", Offset = "0x26D8B98", VA = "0x26D8B98")]
    public static void FinishHotDealListBuffer(
      FlatBufferBuilder builder,
      Offset<HotDealList> offset)
    {
    }

    [Token(Token = "0x6018461")]
    [Address(RVA = "0x26D8BF4", Offset = "0x26D8BF4", VA = "0x26D8BF4")]
    public static void FinishSizePrefixedHotDealListBuffer(
      FlatBufferBuilder builder,
      Offset<HotDealList> offset)
    {
    }
  }
}
