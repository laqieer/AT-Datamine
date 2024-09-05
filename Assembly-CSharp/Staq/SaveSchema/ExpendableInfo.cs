// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ExpendableInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C7D")]
  public struct ExpendableInfo : IFlatbufferObject
  {
    [Token(Token = "0x4010BDC")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DFD")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017EB0"), Address(RVA = "0x37C17FC", Offset = "0x37C17FC", VA = "0x37C17FC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017EB1")]
    [Address(RVA = "0x37C1804", Offset = "0x37C1804", VA = "0x37C1804")]
    public static ExpendableInfo GetRootAsExpendableInfo(ByteBuffer _bb) => new ExpendableInfo();

    [Token(Token = "0x6017EB2")]
    [Address(RVA = "0x37C1810", Offset = "0x37C1810", VA = "0x37C1810")]
    public static ExpendableInfo GetRootAsExpendableInfo(ByteBuffer _bb, ExpendableInfo obj)
    {
      return new ExpendableInfo();
    }

    [Token(Token = "0x6017EB3")]
    [Address(RVA = "0x37C186C", Offset = "0x37C186C", VA = "0x37C186C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017EB4")]
    [Address(RVA = "0x37C1854", Offset = "0x37C1854", VA = "0x37C1854")]
    public ExpendableInfo __assign(int _i, ByteBuffer _bb) => new ExpendableInfo();

    [Token(Token = "0x17004DFE")]
    public int ItemId
    {
      [Token(Token = "0x6017EB5"), Address(RVA = "0x37C1878", Offset = "0x37C1878", VA = "0x37C1878")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DFF")]
    public int Amount
    {
      [Token(Token = "0x6017EB6"), Address(RVA = "0x37C18BC", Offset = "0x37C18BC", VA = "0x37C18BC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017EB7")]
    [Address(RVA = "0x37C1900", Offset = "0x37C1900", VA = "0x37C1900")]
    public static Offset<ExpendableInfo> CreateExpendableInfo(
      FlatBufferBuilder builder,
      int itemId = 0,
      int amount = 0)
    {
      return new Offset<ExpendableInfo>();
    }

    [Token(Token = "0x6017EB8")]
    [Address(RVA = "0x37C19E8", Offset = "0x37C19E8", VA = "0x37C19E8")]
    public static void StartExpendableInfo(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017EB9")]
    [Address(RVA = "0x37C1978", Offset = "0x37C1978", VA = "0x37C1978")]
    public static void AddItemId(FlatBufferBuilder builder, int itemId)
    {
    }

    [Token(Token = "0x6017EBA")]
    [Address(RVA = "0x37C1958", Offset = "0x37C1958", VA = "0x37C1958")]
    public static void AddAmount(FlatBufferBuilder builder, int amount)
    {
    }

    [Token(Token = "0x6017EBB")]
    [Address(RVA = "0x37C1998", Offset = "0x37C1998", VA = "0x37C1998")]
    public static Offset<ExpendableInfo> EndExpendableInfo(FlatBufferBuilder builder)
    {
      return new Offset<ExpendableInfo>();
    }
  }
}
