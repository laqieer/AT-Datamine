// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.MatchCountData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C7A")]
  public struct MatchCountData : IFlatbufferObject
  {
    [Token(Token = "0x4010BD9")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DF3")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017E78"), Address(RVA = "0x37C0AEC", Offset = "0x37C0AEC", VA = "0x37C0AEC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017E79")]
    [Address(RVA = "0x37C0AF4", Offset = "0x37C0AF4", VA = "0x37C0AF4")]
    public static MatchCountData GetRootAsMatchCountData(ByteBuffer _bb) => new MatchCountData();

    [Token(Token = "0x6017E7A")]
    [Address(RVA = "0x37C0B00", Offset = "0x37C0B00", VA = "0x37C0B00")]
    public static MatchCountData GetRootAsMatchCountData(ByteBuffer _bb, MatchCountData obj)
    {
      return new MatchCountData();
    }

    [Token(Token = "0x6017E7B")]
    [Address(RVA = "0x37C0B44", Offset = "0x37C0B44", VA = "0x37C0B44", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017E7C")]
    [Address(RVA = "0x37BFB6C", Offset = "0x37BFB6C", VA = "0x37BFB6C")]
    public MatchCountData __assign(int _i, ByteBuffer _bb) => new MatchCountData();

    [Token(Token = "0x17004DF4")]
    public int Id
    {
      [Token(Token = "0x6017E7D"), Address(RVA = "0x37C0B50", Offset = "0x37C0B50", VA = "0x37C0B50")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DF5")]
    public int Count
    {
      [Token(Token = "0x6017E7E"), Address(RVA = "0x37C0B94", Offset = "0x37C0B94", VA = "0x37C0B94")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E7F")]
    [Address(RVA = "0x37C0BD8", Offset = "0x37C0BD8", VA = "0x37C0BD8")]
    public static Offset<MatchCountData> CreateMatchCountData(
      FlatBufferBuilder builder,
      int id = 0,
      int count = 0)
    {
      return new Offset<MatchCountData>();
    }

    [Token(Token = "0x6017E80")]
    [Address(RVA = "0x37C0CC0", Offset = "0x37C0CC0", VA = "0x37C0CC0")]
    public static void StartMatchCountData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017E81")]
    [Address(RVA = "0x37C0C50", Offset = "0x37C0C50", VA = "0x37C0C50")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x6017E82")]
    [Address(RVA = "0x37C0C30", Offset = "0x37C0C30", VA = "0x37C0C30")]
    public static void AddCount(FlatBufferBuilder builder, int count)
    {
    }

    [Token(Token = "0x6017E83")]
    [Address(RVA = "0x37C0C70", Offset = "0x37C0C70", VA = "0x37C0C70")]
    public static Offset<MatchCountData> EndMatchCountData(FlatBufferBuilder builder)
    {
      return new Offset<MatchCountData>();
    }
  }
}
