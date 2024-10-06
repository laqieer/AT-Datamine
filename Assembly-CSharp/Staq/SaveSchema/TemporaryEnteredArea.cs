// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.TemporaryEnteredArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CB0")]
  public struct TemporaryEnteredArea : IFlatbufferObject
  {
    [Token(Token = "0x4010C0E")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F39")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018377"), Address(RVA = "0x26D53B4", Offset = "0x26D53B4", VA = "0x26D53B4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018378")]
    [Address(RVA = "0x26D53BC", Offset = "0x26D53BC", VA = "0x26D53BC")]
    public static TemporaryEnteredArea GetRootAsTemporaryEnteredArea(ByteBuffer _bb)
    {
      return new TemporaryEnteredArea();
    }

    [Token(Token = "0x6018379")]
    [Address(RVA = "0x26D53C8", Offset = "0x26D53C8", VA = "0x26D53C8")]
    public static TemporaryEnteredArea GetRootAsTemporaryEnteredArea(
      ByteBuffer _bb,
      TemporaryEnteredArea obj)
    {
      return new TemporaryEnteredArea();
    }

    [Token(Token = "0x601837A")]
    [Address(RVA = "0x26D5424", Offset = "0x26D5424", VA = "0x26D5424", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601837B")]
    [Address(RVA = "0x26D540C", Offset = "0x26D540C", VA = "0x26D540C")]
    public TemporaryEnteredArea __assign(int _i, ByteBuffer _bb) => new TemporaryEnteredArea();

    [Token(Token = "0x17004F3A")]
    public int TableChapterId
    {
      [Token(Token = "0x601837C"), Address(RVA = "0x26D5430", Offset = "0x26D5430", VA = "0x26D5430")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F3B")]
    public int TableAreaId
    {
      [Token(Token = "0x601837D"), Address(RVA = "0x26D5474", Offset = "0x26D5474", VA = "0x26D5474")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601837E")]
    [Address(RVA = "0x26D54B8", Offset = "0x26D54B8", VA = "0x26D54B8")]
    public static Offset<TemporaryEnteredArea> CreateTemporaryEnteredArea(
      FlatBufferBuilder builder,
      int table_chapter_id = 0,
      int table_area_id = 0)
    {
      return new Offset<TemporaryEnteredArea>();
    }

    [Token(Token = "0x601837F")]
    [Address(RVA = "0x26D55A0", Offset = "0x26D55A0", VA = "0x26D55A0")]
    public static void StartTemporaryEnteredArea(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018380")]
    [Address(RVA = "0x26D5530", Offset = "0x26D5530", VA = "0x26D5530")]
    public static void AddTableChapterId(FlatBufferBuilder builder, int tableChapterId)
    {
    }

    [Token(Token = "0x6018381")]
    [Address(RVA = "0x26D5510", Offset = "0x26D5510", VA = "0x26D5510")]
    public static void AddTableAreaId(FlatBufferBuilder builder, int tableAreaId)
    {
    }

    [Token(Token = "0x6018382")]
    [Address(RVA = "0x26D5550", Offset = "0x26D5550", VA = "0x26D5550")]
    public static Offset<TemporaryEnteredArea> EndTemporaryEnteredArea(FlatBufferBuilder builder)
    {
      return new Offset<TemporaryEnteredArea>();
    }
  }
}
