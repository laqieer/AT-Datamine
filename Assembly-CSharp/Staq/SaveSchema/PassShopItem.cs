// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.PassShopItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CC8")]
  public struct PassShopItem : IFlatbufferObject
  {
    [Token(Token = "0x4010C26")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F8C")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018553"), Address(RVA = "0x26DC9A0", Offset = "0x26DC9A0", VA = "0x26DC9A0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018554")]
    [Address(RVA = "0x26DC9A8", Offset = "0x26DC9A8", VA = "0x26DC9A8")]
    public static PassShopItem GetRootAsPassShopItem(ByteBuffer _bb) => new PassShopItem();

    [Token(Token = "0x6018555")]
    [Address(RVA = "0x26DC9B4", Offset = "0x26DC9B4", VA = "0x26DC9B4")]
    public static PassShopItem GetRootAsPassShopItem(ByteBuffer _bb, PassShopItem obj)
    {
      return new PassShopItem();
    }

    [Token(Token = "0x6018556")]
    [Address(RVA = "0x26DCA10", Offset = "0x26DCA10", VA = "0x26DCA10", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018557")]
    [Address(RVA = "0x26DC9F8", Offset = "0x26DC9F8", VA = "0x26DC9F8")]
    public PassShopItem __assign(int _i, ByteBuffer _bb) => new PassShopItem();

    [Token(Token = "0x17004F8D")]
    public int PassShopId
    {
      [Token(Token = "0x6018558"), Address(RVA = "0x26DCA1C", Offset = "0x26DCA1C", VA = "0x26DCA1C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F8E")]
    public string EndAt
    {
      [Token(Token = "0x6018559"), Address(RVA = "0x26DCA60", Offset = "0x26DCA60", VA = "0x26DCA60")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601855A")]
    [Address(RVA = "0x26DCA9C", Offset = "0x26DCA9C", VA = "0x26DCA9C")]
    public ArraySegment<byte>? GetEndAtBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x601855B")]
    [Address(RVA = "0x26DCAD4", Offset = "0x26DCAD4", VA = "0x26DCAD4")]
    public byte[] GetEndAtArray() => (byte[]) null;

    [Token(Token = "0x17004F8F")]
    public string LastAt
    {
      [Token(Token = "0x601855C"), Address(RVA = "0x26DCB20", Offset = "0x26DCB20", VA = "0x26DCB20")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601855D")]
    [Address(RVA = "0x26DCB5C", Offset = "0x26DCB5C", VA = "0x26DCB5C")]
    public ArraySegment<byte>? GetLastAtBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x601855E")]
    [Address(RVA = "0x26DCB94", Offset = "0x26DCB94", VA = "0x26DCB94")]
    public byte[] GetLastAtArray() => (byte[]) null;

    [Token(Token = "0x17004F90")]
    public bool OutPeriod
    {
      [Token(Token = "0x601855F"), Address(RVA = "0x26DCBE0", Offset = "0x26DCBE0", VA = "0x26DCBE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6018560")]
    [Address(RVA = "0x26DCC28", Offset = "0x26DCC28", VA = "0x26DCC28")]
    public static Offset<PassShopItem> CreatePassShopItem(
      FlatBufferBuilder builder,
      int pass_shop_id = 0,
      StringOffset end_atOffset = default (StringOffset),
      StringOffset last_atOffset = default (StringOffset),
      bool out_period = false)
    {
      return new Offset<PassShopItem>();
    }

    [Token(Token = "0x6018561")]
    [Address(RVA = "0x26DCD78", Offset = "0x26DCD78", VA = "0x26DCD78")]
    public static void StartPassShopItem(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018562")]
    [Address(RVA = "0x26DCCE8", Offset = "0x26DCCE8", VA = "0x26DCCE8")]
    public static void AddPassShopId(FlatBufferBuilder builder, int passShopId)
    {
    }

    [Token(Token = "0x6018563")]
    [Address(RVA = "0x26DCCC8", Offset = "0x26DCCC8", VA = "0x26DCCC8")]
    public static void AddEndAt(FlatBufferBuilder builder, StringOffset endAtOffset)
    {
    }

    [Token(Token = "0x6018564")]
    [Address(RVA = "0x26DCCA8", Offset = "0x26DCCA8", VA = "0x26DCCA8")]
    public static void AddLastAt(FlatBufferBuilder builder, StringOffset lastAtOffset)
    {
    }

    [Token(Token = "0x6018565")]
    [Address(RVA = "0x26DCD08", Offset = "0x26DCD08", VA = "0x26DCD08")]
    public static void AddOutPeriod(FlatBufferBuilder builder, bool outPeriod)
    {
    }

    [Token(Token = "0x6018566")]
    [Address(RVA = "0x26DCD28", Offset = "0x26DCD28", VA = "0x26DCD28")]
    public static Offset<PassShopItem> EndPassShopItem(FlatBufferBuilder builder)
    {
      return new Offset<PassShopItem>();
    }
  }
}
