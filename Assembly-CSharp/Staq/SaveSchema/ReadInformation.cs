// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ReadInformation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CD3")]
  public struct ReadInformation : IFlatbufferObject
  {
    [Token(Token = "0x4010C31")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FB0")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601861D"), Address(RVA = "0x26DF79C", Offset = "0x26DF79C", VA = "0x26DF79C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601861E")]
    [Address(RVA = "0x26DF7A4", Offset = "0x26DF7A4", VA = "0x26DF7A4")]
    public static ReadInformation GetRootAsReadInformation(ByteBuffer _bb) => new ReadInformation();

    [Token(Token = "0x601861F")]
    [Address(RVA = "0x26DF7B0", Offset = "0x26DF7B0", VA = "0x26DF7B0")]
    public static ReadInformation GetRootAsReadInformation(ByteBuffer _bb, ReadInformation obj)
    {
      return new ReadInformation();
    }

    [Token(Token = "0x6018620")]
    [Address(RVA = "0x26DF80C", Offset = "0x26DF80C", VA = "0x26DF80C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018621")]
    [Address(RVA = "0x26DF7F4", Offset = "0x26DF7F4", VA = "0x26DF7F4")]
    public ReadInformation __assign(int _i, ByteBuffer _bb) => new ReadInformation();

    [Token(Token = "0x17004FB1")]
    public int Id
    {
      [Token(Token = "0x6018622"), Address(RVA = "0x26DF818", Offset = "0x26DF818", VA = "0x26DF818")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004FB2")]
    public bool IsRead
    {
      [Token(Token = "0x6018623"), Address(RVA = "0x26DF85C", Offset = "0x26DF85C", VA = "0x26DF85C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6018624")]
    [Address(RVA = "0x26DF8A4", Offset = "0x26DF8A4", VA = "0x26DF8A4")]
    public static Offset<ReadInformation> CreateReadInformation(
      FlatBufferBuilder builder,
      int id = 0,
      bool is_read = false)
    {
      return new Offset<ReadInformation>();
    }

    [Token(Token = "0x6018625")]
    [Address(RVA = "0x26DF98C", Offset = "0x26DF98C", VA = "0x26DF98C")]
    public static void StartReadInformation(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018626")]
    [Address(RVA = "0x26DF8FC", Offset = "0x26DF8FC", VA = "0x26DF8FC")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x6018627")]
    [Address(RVA = "0x26DF91C", Offset = "0x26DF91C", VA = "0x26DF91C")]
    public static void AddIsRead(FlatBufferBuilder builder, bool isRead)
    {
    }

    [Token(Token = "0x6018628")]
    [Address(RVA = "0x26DF93C", Offset = "0x26DF93C", VA = "0x26DF93C")]
    public static Offset<ReadInformation> EndReadInformation(FlatBufferBuilder builder)
    {
      return new Offset<ReadInformation>();
    }
  }
}
