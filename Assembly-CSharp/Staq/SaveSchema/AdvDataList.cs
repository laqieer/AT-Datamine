// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.AdvDataList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C62")]
  public struct AdvDataList : IFlatbufferObject
  {
    [Token(Token = "0x4010BC1")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D4D")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017BC9"), Address(RVA = "0x37B59CC", Offset = "0x37B59CC", VA = "0x37B59CC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017BCA")]
    [Address(RVA = "0x37B59D4", Offset = "0x37B59D4", VA = "0x37B59D4")]
    public static AdvDataList GetRootAsAdvDataList(ByteBuffer _bb) => new AdvDataList();

    [Token(Token = "0x6017BCB")]
    [Address(RVA = "0x37B59E0", Offset = "0x37B59E0", VA = "0x37B59E0")]
    public static AdvDataList GetRootAsAdvDataList(ByteBuffer _bb, AdvDataList obj)
    {
      return new AdvDataList();
    }

    [Token(Token = "0x6017BCC")]
    [Address(RVA = "0x37B5A3C", Offset = "0x37B5A3C", VA = "0x37B5A3C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017BCD")]
    [Address(RVA = "0x37B5A24", Offset = "0x37B5A24", VA = "0x37B5A24")]
    public AdvDataList __assign(int _i, ByteBuffer _bb) => new AdvDataList();

    [Token(Token = "0x6017BCE")]
    [Address(RVA = "0x37B5A48", Offset = "0x37B5A48", VA = "0x37B5A48")]
    public AdvData? Advs(int j) => new AdvData?();

    [Token(Token = "0x17004D4E")]
    public int AdvsLength
    {
      [Token(Token = "0x6017BCF"), Address(RVA = "0x37B5AFC", Offset = "0x37B5AFC", VA = "0x37B5AFC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017BD0")]
    [Address(RVA = "0x37B5B30", Offset = "0x37B5B30", VA = "0x37B5B30")]
    public static Offset<AdvDataList> CreateAdvDataList(
      FlatBufferBuilder builder,
      VectorOffset advsOffset = default (VectorOffset))
    {
      return new Offset<AdvDataList>();
    }

    [Token(Token = "0x6017BD1")]
    [Address(RVA = "0x37B5BE8", Offset = "0x37B5BE8", VA = "0x37B5BE8")]
    public static void StartAdvDataList(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017BD2")]
    [Address(RVA = "0x37B5B78", Offset = "0x37B5B78", VA = "0x37B5B78")]
    public static void AddAdvs(FlatBufferBuilder builder, VectorOffset advsOffset)
    {
    }

    [Token(Token = "0x6017BD3")]
    [Address(RVA = "0x37B5C00", Offset = "0x37B5C00", VA = "0x37B5C00")]
    public static VectorOffset CreateAdvsVector(FlatBufferBuilder builder, Offset<AdvData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017BD4")]
    [Address(RVA = "0x37B5CA8", Offset = "0x37B5CA8", VA = "0x37B5CA8")]
    public static VectorOffset CreateAdvsVectorBlock(
      FlatBufferBuilder builder,
      Offset<AdvData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017BD5")]
    [Address(RVA = "0x37B5D30", Offset = "0x37B5D30", VA = "0x37B5D30")]
    public static void StartAdvsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017BD6")]
    [Address(RVA = "0x37B5B98", Offset = "0x37B5B98", VA = "0x37B5B98")]
    public static Offset<AdvDataList> EndAdvDataList(FlatBufferBuilder builder)
    {
      return new Offset<AdvDataList>();
    }
  }
}
