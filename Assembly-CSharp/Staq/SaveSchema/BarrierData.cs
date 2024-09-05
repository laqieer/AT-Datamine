// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BarrierData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C90")]
  public struct BarrierData : IFlatbufferObject
  {
    [Token(Token = "0x4010BEF")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E84")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60180A9"), Address(RVA = "0x3B1CF1C", Offset = "0x3B1CF1C", VA = "0x3B1CF1C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60180AA")]
    [Address(RVA = "0x3B1CF24", Offset = "0x3B1CF24", VA = "0x3B1CF24")]
    public static BarrierData GetRootAsBarrierData(ByteBuffer _bb) => new BarrierData();

    [Token(Token = "0x60180AB")]
    [Address(RVA = "0x3B1CF30", Offset = "0x3B1CF30", VA = "0x3B1CF30")]
    public static BarrierData GetRootAsBarrierData(ByteBuffer _bb, BarrierData obj)
    {
      return new BarrierData();
    }

    [Token(Token = "0x60180AC")]
    [Address(RVA = "0x3B1CF8C", Offset = "0x3B1CF8C", VA = "0x3B1CF8C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60180AD")]
    [Address(RVA = "0x3B1CF74", Offset = "0x3B1CF74", VA = "0x3B1CF74")]
    public BarrierData __assign(int _i, ByteBuffer _bb) => new BarrierData();

    [Token(Token = "0x17004E85")]
    public int X
    {
      [Token(Token = "0x60180AE"), Address(RVA = "0x3B1CF98", Offset = "0x3B1CF98", VA = "0x3B1CF98")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E86")]
    public int Y
    {
      [Token(Token = "0x60180AF"), Address(RVA = "0x3B1CFDC", Offset = "0x3B1CFDC", VA = "0x3B1CFDC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E87")]
    public int Current
    {
      [Token(Token = "0x60180B0"), Address(RVA = "0x3B1D020", Offset = "0x3B1D020", VA = "0x3B1D020")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E88")]
    public int Max
    {
      [Token(Token = "0x60180B1"), Address(RVA = "0x3B1D064", Offset = "0x3B1D064", VA = "0x3B1D064")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180B2")]
    [Address(RVA = "0x3B1D0A8", Offset = "0x3B1D0A8", VA = "0x3B1D0A8")]
    public static Offset<BarrierData> CreateBarrierData(
      FlatBufferBuilder builder,
      int x = 0,
      int y = 0,
      int current = 0,
      int max = 0)
    {
      return new Offset<BarrierData>();
    }

    [Token(Token = "0x60180B3")]
    [Address(RVA = "0x3B1D1F8", Offset = "0x3B1D1F8", VA = "0x3B1D1F8")]
    public static void StartBarrierData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60180B4")]
    [Address(RVA = "0x3B1D188", Offset = "0x3B1D188", VA = "0x3B1D188")]
    public static void AddX(FlatBufferBuilder builder, int x)
    {
    }

    [Token(Token = "0x60180B5")]
    [Address(RVA = "0x3B1D168", Offset = "0x3B1D168", VA = "0x3B1D168")]
    public static void AddY(FlatBufferBuilder builder, int y)
    {
    }

    [Token(Token = "0x60180B6")]
    [Address(RVA = "0x3B1D148", Offset = "0x3B1D148", VA = "0x3B1D148")]
    public static void AddCurrent(FlatBufferBuilder builder, int current)
    {
    }

    [Token(Token = "0x60180B7")]
    [Address(RVA = "0x3B1D128", Offset = "0x3B1D128", VA = "0x3B1D128")]
    public static void AddMax(FlatBufferBuilder builder, int max)
    {
    }

    [Token(Token = "0x60180B8")]
    [Address(RVA = "0x3B1D1A8", Offset = "0x3B1D1A8", VA = "0x3B1D1A8")]
    public static Offset<BarrierData> EndBarrierData(FlatBufferBuilder builder)
    {
      return new Offset<BarrierData>();
    }
  }
}
