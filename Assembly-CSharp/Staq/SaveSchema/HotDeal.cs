// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.HotDeal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CBC")]
  public struct HotDeal : IFlatbufferObject
  {
    [Token(Token = "0x4010C1A")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F5C")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018443"), Address(RVA = "0x26D8544", Offset = "0x26D8544", VA = "0x26D8544", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018444")]
    [Address(RVA = "0x26D854C", Offset = "0x26D854C", VA = "0x26D854C")]
    public static HotDeal GetRootAsHotDeal(ByteBuffer _bb) => new HotDeal();

    [Token(Token = "0x6018445")]
    [Address(RVA = "0x26D8558", Offset = "0x26D8558", VA = "0x26D8558")]
    public static HotDeal GetRootAsHotDeal(ByteBuffer _bb, HotDeal obj) => new HotDeal();

    [Token(Token = "0x6018446")]
    [Address(RVA = "0x26D85B4", Offset = "0x26D85B4", VA = "0x26D85B4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018447")]
    [Address(RVA = "0x26D859C", Offset = "0x26D859C", VA = "0x26D859C")]
    public HotDeal __assign(int _i, ByteBuffer _bb) => new HotDeal();

    [Token(Token = "0x17004F5D")]
    public string HotDealId
    {
      [Token(Token = "0x6018448"), Address(RVA = "0x26D85C0", Offset = "0x26D85C0", VA = "0x26D85C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018449")]
    [Address(RVA = "0x26D85FC", Offset = "0x26D85FC", VA = "0x26D85FC")]
    public ArraySegment<byte>? GetHotDealIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x601844A")]
    [Address(RVA = "0x26D8634", Offset = "0x26D8634", VA = "0x26D8634")]
    public byte[] GetHotDealIdArray() => (byte[]) null;

    [Token(Token = "0x17004F5E")]
    public bool AlreadyRead
    {
      [Token(Token = "0x601844B"), Address(RVA = "0x26D8680", Offset = "0x26D8680", VA = "0x26D8680")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601844C")]
    [Address(RVA = "0x26D86C8", Offset = "0x26D86C8", VA = "0x26D86C8")]
    public static Offset<HotDeal> CreateHotDeal(
      FlatBufferBuilder builder,
      StringOffset hot_deal_idOffset = default (StringOffset),
      bool already_read = false)
    {
      return new Offset<HotDeal>();
    }

    [Token(Token = "0x601844D")]
    [Address(RVA = "0x26D87B0", Offset = "0x26D87B0", VA = "0x26D87B0")]
    public static void StartHotDeal(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601844E")]
    [Address(RVA = "0x26D8720", Offset = "0x26D8720", VA = "0x26D8720")]
    public static void AddHotDealId(FlatBufferBuilder builder, StringOffset hotDealIdOffset)
    {
    }

    [Token(Token = "0x601844F")]
    [Address(RVA = "0x26D8740", Offset = "0x26D8740", VA = "0x26D8740")]
    public static void AddAlreadyRead(FlatBufferBuilder builder, bool alreadyRead)
    {
    }

    [Token(Token = "0x6018450")]
    [Address(RVA = "0x26D8760", Offset = "0x26D8760", VA = "0x26D8760")]
    public static Offset<HotDeal> EndHotDeal(FlatBufferBuilder builder) => new Offset<HotDeal>();
  }
}
