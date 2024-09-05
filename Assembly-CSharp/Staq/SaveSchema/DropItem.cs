// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.DropItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C8A")]
  public struct DropItem : IFlatbufferObject
  {
    [Token(Token = "0x4010BE9")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E6C")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018047"), Address(RVA = "0x3B1B9E0", Offset = "0x3B1B9E0", VA = "0x3B1B9E0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018048")]
    [Address(RVA = "0x3B1B9E8", Offset = "0x3B1B9E8", VA = "0x3B1B9E8")]
    public static DropItem GetRootAsDropItem(ByteBuffer _bb) => new DropItem();

    [Token(Token = "0x6018049")]
    [Address(RVA = "0x3B1B9F4", Offset = "0x3B1B9F4", VA = "0x3B1B9F4")]
    public static DropItem GetRootAsDropItem(ByteBuffer _bb, DropItem obj) => new DropItem();

    [Token(Token = "0x601804A")]
    [Address(RVA = "0x3B1BA38", Offset = "0x3B1BA38", VA = "0x3B1BA38", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601804B")]
    [Address(RVA = "0x3B1A7FC", Offset = "0x3B1A7FC", VA = "0x3B1A7FC")]
    public DropItem __assign(int _i, ByteBuffer _bb) => new DropItem();

    [Token(Token = "0x17004E6D")]
    public int Rarity
    {
      [Token(Token = "0x601804C"), Address(RVA = "0x3B1BA44", Offset = "0x3B1BA44", VA = "0x3B1BA44")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E6E")]
    public int Count
    {
      [Token(Token = "0x601804D"), Address(RVA = "0x3B1BA88", Offset = "0x3B1BA88", VA = "0x3B1BA88")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601804E")]
    [Address(RVA = "0x3B1BACC", Offset = "0x3B1BACC", VA = "0x3B1BACC")]
    public static Offset<DropItem> CreateDropItem(FlatBufferBuilder builder, int rarity = 0, int count = 0)
    {
      return new Offset<DropItem>();
    }

    [Token(Token = "0x601804F")]
    [Address(RVA = "0x3B1BBB4", Offset = "0x3B1BBB4", VA = "0x3B1BBB4")]
    public static void StartDropItem(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018050")]
    [Address(RVA = "0x3B1BB44", Offset = "0x3B1BB44", VA = "0x3B1BB44")]
    public static void AddRarity(FlatBufferBuilder builder, int rarity)
    {
    }

    [Token(Token = "0x6018051")]
    [Address(RVA = "0x3B1BB24", Offset = "0x3B1BB24", VA = "0x3B1BB24")]
    public static void AddCount(FlatBufferBuilder builder, int count)
    {
    }

    [Token(Token = "0x6018052")]
    [Address(RVA = "0x3B1BB64", Offset = "0x3B1BB64", VA = "0x3B1BB64")]
    public static Offset<DropItem> EndDropItem(FlatBufferBuilder builder) => new Offset<DropItem>();
  }
}
