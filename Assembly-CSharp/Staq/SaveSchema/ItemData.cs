// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C88")]
  public struct ItemData : IFlatbufferObject
  {
    [Token(Token = "0x4010BE7")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E65")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601802D"), Address(RVA = "0x3B1B520", Offset = "0x3B1B520", VA = "0x3B1B520", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601802E")]
    [Address(RVA = "0x3B1B528", Offset = "0x3B1B528", VA = "0x3B1B528")]
    public static ItemData GetRootAsItemData(ByteBuffer _bb) => new ItemData();

    [Token(Token = "0x601802F")]
    [Address(RVA = "0x3B1B534", Offset = "0x3B1B534", VA = "0x3B1B534")]
    public static ItemData GetRootAsItemData(ByteBuffer _bb, ItemData obj) => new ItemData();

    [Token(Token = "0x6018030")]
    [Address(RVA = "0x3B1B590", Offset = "0x3B1B590", VA = "0x3B1B590", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018031")]
    [Address(RVA = "0x3B1B578", Offset = "0x3B1B578", VA = "0x3B1B578")]
    public ItemData __assign(int _i, ByteBuffer _bb) => new ItemData();

    [Token(Token = "0x17004E66")]
    public int Item
    {
      [Token(Token = "0x6018032"), Address(RVA = "0x3B1B59C", Offset = "0x3B1B59C", VA = "0x3B1B59C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018033")]
    [Address(RVA = "0x3B1B5E0", Offset = "0x3B1B5E0", VA = "0x3B1B5E0")]
    public static Offset<ItemData> CreateItemData(FlatBufferBuilder builder, int item = 0)
    {
      return new Offset<ItemData>();
    }

    [Token(Token = "0x6018034")]
    [Address(RVA = "0x3B1B698", Offset = "0x3B1B698", VA = "0x3B1B698")]
    public static void StartItemData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018035")]
    [Address(RVA = "0x3B1B628", Offset = "0x3B1B628", VA = "0x3B1B628")]
    public static void AddItem(FlatBufferBuilder builder, int item)
    {
    }

    [Token(Token = "0x6018036")]
    [Address(RVA = "0x3B1B648", Offset = "0x3B1B648", VA = "0x3B1B648")]
    public static Offset<ItemData> EndItemData(FlatBufferBuilder builder) => new Offset<ItemData>();
  }
}
