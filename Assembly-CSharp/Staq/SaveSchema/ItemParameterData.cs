// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ItemParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C89")]
  public struct ItemParameterData : IFlatbufferObject
  {
    [Token(Token = "0x4010BE8")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E67")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018037"), Address(RVA = "0x3B1B6B0", Offset = "0x3B1B6B0", VA = "0x3B1B6B0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018038")]
    [Address(RVA = "0x3B1B6B8", Offset = "0x3B1B6B8", VA = "0x3B1B6B8")]
    public static ItemParameterData GetRootAsItemParameterData(ByteBuffer _bb)
    {
      return new ItemParameterData();
    }

    [Token(Token = "0x6018039")]
    [Address(RVA = "0x3B1B6C4", Offset = "0x3B1B6C4", VA = "0x3B1B6C4")]
    public static ItemParameterData GetRootAsItemParameterData(
      ByteBuffer _bb,
      ItemParameterData obj)
    {
      return new ItemParameterData();
    }

    [Token(Token = "0x601803A")]
    [Address(RVA = "0x3B1B708", Offset = "0x3B1B708", VA = "0x3B1B708", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601803B")]
    [Address(RVA = "0x3B1A608", Offset = "0x3B1A608", VA = "0x3B1A608")]
    public ItemParameterData __assign(int _i, ByteBuffer _bb) => new ItemParameterData();

    [Token(Token = "0x17004E68")]
    public ItemData? Item
    {
      [Token(Token = "0x601803C"), Address(RVA = "0x3B1B714", Offset = "0x3B1B714", VA = "0x3B1B714")] get
      {
        return new ItemData?();
      }
    }

    [Token(Token = "0x17004E69")]
    public int InitialAmount
    {
      [Token(Token = "0x601803D"), Address(RVA = "0x3B1B7AC", Offset = "0x3B1B7AC", VA = "0x3B1B7AC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E6A")]
    public int Amount
    {
      [Token(Token = "0x601803E"), Address(RVA = "0x3B1B7F0", Offset = "0x3B1B7F0", VA = "0x3B1B7F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E6B")]
    public int ItemSkillParam
    {
      [Token(Token = "0x601803F"), Address(RVA = "0x3B1B834", Offset = "0x3B1B834", VA = "0x3B1B834")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018040")]
    [Address(RVA = "0x3B1B878", Offset = "0x3B1B878", VA = "0x3B1B878")]
    public static Offset<ItemParameterData> CreateItemParameterData(
      FlatBufferBuilder builder,
      Offset<ItemData> itemOffset = default (Offset<ItemData>),
      int initialAmount = 0,
      int amount = 0,
      int itemSkillParam = 0)
    {
      return new Offset<ItemParameterData>();
    }

    [Token(Token = "0x6018041")]
    [Address(RVA = "0x3B1B9C8", Offset = "0x3B1B9C8", VA = "0x3B1B9C8")]
    public static void StartItemParameterData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018042")]
    [Address(RVA = "0x3B1B958", Offset = "0x3B1B958", VA = "0x3B1B958")]
    public static void AddItem(FlatBufferBuilder builder, Offset<ItemData> itemOffset)
    {
    }

    [Token(Token = "0x6018043")]
    [Address(RVA = "0x3B1B938", Offset = "0x3B1B938", VA = "0x3B1B938")]
    public static void AddInitialAmount(FlatBufferBuilder builder, int initialAmount)
    {
    }

    [Token(Token = "0x6018044")]
    [Address(RVA = "0x3B1B918", Offset = "0x3B1B918", VA = "0x3B1B918")]
    public static void AddAmount(FlatBufferBuilder builder, int amount)
    {
    }

    [Token(Token = "0x6018045")]
    [Address(RVA = "0x3B1B8F8", Offset = "0x3B1B8F8", VA = "0x3B1B8F8")]
    public static void AddItemSkillParam(FlatBufferBuilder builder, int itemSkillParam)
    {
    }

    [Token(Token = "0x6018046")]
    [Address(RVA = "0x3B1B978", Offset = "0x3B1B978", VA = "0x3B1B978")]
    public static Offset<ItemParameterData> EndItemParameterData(FlatBufferBuilder builder)
    {
      return new Offset<ItemParameterData>();
    }
  }
}
