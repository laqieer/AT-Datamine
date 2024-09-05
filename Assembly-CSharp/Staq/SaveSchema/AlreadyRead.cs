// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.AlreadyRead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CAF")]
  public struct AlreadyRead : IFlatbufferObject
  {
    [Token(Token = "0x4010C0D")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F37")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601836D"), Address(RVA = "0x26D5224", Offset = "0x26D5224", VA = "0x26D5224", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601836E")]
    [Address(RVA = "0x26D522C", Offset = "0x26D522C", VA = "0x26D522C")]
    public static AlreadyRead GetRootAsAlreadyRead(ByteBuffer _bb) => new AlreadyRead();

    [Token(Token = "0x601836F")]
    [Address(RVA = "0x26D5238", Offset = "0x26D5238", VA = "0x26D5238")]
    public static AlreadyRead GetRootAsAlreadyRead(ByteBuffer _bb, AlreadyRead obj)
    {
      return new AlreadyRead();
    }

    [Token(Token = "0x6018370")]
    [Address(RVA = "0x26D5294", Offset = "0x26D5294", VA = "0x26D5294", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018371")]
    [Address(RVA = "0x26D527C", Offset = "0x26D527C", VA = "0x26D527C")]
    public AlreadyRead __assign(int _i, ByteBuffer _bb) => new AlreadyRead();

    [Token(Token = "0x17004F38")]
    public int TableId
    {
      [Token(Token = "0x6018372"), Address(RVA = "0x26D52A0", Offset = "0x26D52A0", VA = "0x26D52A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018373")]
    [Address(RVA = "0x26D52E4", Offset = "0x26D52E4", VA = "0x26D52E4")]
    public static Offset<AlreadyRead> CreateAlreadyRead(FlatBufferBuilder builder, int table_id = 0)
    {
      return new Offset<AlreadyRead>();
    }

    [Token(Token = "0x6018374")]
    [Address(RVA = "0x26D539C", Offset = "0x26D539C", VA = "0x26D539C")]
    public static void StartAlreadyRead(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018375")]
    [Address(RVA = "0x26D532C", Offset = "0x26D532C", VA = "0x26D532C")]
    public static void AddTableId(FlatBufferBuilder builder, int tableId)
    {
    }

    [Token(Token = "0x6018376")]
    [Address(RVA = "0x26D534C", Offset = "0x26D534C", VA = "0x26D534C")]
    public static Offset<AlreadyRead> EndAlreadyRead(FlatBufferBuilder builder)
    {
      return new Offset<AlreadyRead>();
    }
  }
}
