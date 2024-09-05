// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.AreaIntroduction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CAE")]
  public struct AreaIntroduction : IFlatbufferObject
  {
    [Token(Token = "0x4010C0C")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F35")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018363"), Address(RVA = "0x26D5094", Offset = "0x26D5094", VA = "0x26D5094", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018364")]
    [Address(RVA = "0x26D509C", Offset = "0x26D509C", VA = "0x26D509C")]
    public static AreaIntroduction GetRootAsAreaIntroduction(ByteBuffer _bb)
    {
      return new AreaIntroduction();
    }

    [Token(Token = "0x6018365")]
    [Address(RVA = "0x26D50A8", Offset = "0x26D50A8", VA = "0x26D50A8")]
    public static AreaIntroduction GetRootAsAreaIntroduction(ByteBuffer _bb, AreaIntroduction obj)
    {
      return new AreaIntroduction();
    }

    [Token(Token = "0x6018366")]
    [Address(RVA = "0x26D5104", Offset = "0x26D5104", VA = "0x26D5104", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018367")]
    [Address(RVA = "0x26D50EC", Offset = "0x26D50EC", VA = "0x26D50EC")]
    public AreaIntroduction __assign(int _i, ByteBuffer _bb) => new AreaIntroduction();

    [Token(Token = "0x17004F36")]
    public int TableId
    {
      [Token(Token = "0x6018368"), Address(RVA = "0x26D5110", Offset = "0x26D5110", VA = "0x26D5110")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018369")]
    [Address(RVA = "0x26D5154", Offset = "0x26D5154", VA = "0x26D5154")]
    public static Offset<AreaIntroduction> CreateAreaIntroduction(
      FlatBufferBuilder builder,
      int table_id = 0)
    {
      return new Offset<AreaIntroduction>();
    }

    [Token(Token = "0x601836A")]
    [Address(RVA = "0x26D520C", Offset = "0x26D520C", VA = "0x26D520C")]
    public static void StartAreaIntroduction(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601836B")]
    [Address(RVA = "0x26D519C", Offset = "0x26D519C", VA = "0x26D519C")]
    public static void AddTableId(FlatBufferBuilder builder, int tableId)
    {
    }

    [Token(Token = "0x601836C")]
    [Address(RVA = "0x26D51BC", Offset = "0x26D51BC", VA = "0x26D51BC")]
    public static Offset<AreaIntroduction> EndAreaIntroduction(FlatBufferBuilder builder)
    {
      return new Offset<AreaIntroduction>();
    }
  }
}
