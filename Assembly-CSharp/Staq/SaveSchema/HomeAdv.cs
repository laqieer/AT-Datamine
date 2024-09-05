// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.HomeAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CBB")]
  public struct HomeAdv : IFlatbufferObject
  {
    [Token(Token = "0x4010C19")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F5A")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018436"), Address(RVA = "0x26D8234", Offset = "0x26D8234", VA = "0x26D8234", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018437")]
    [Address(RVA = "0x26D823C", Offset = "0x26D823C", VA = "0x26D823C")]
    public static HomeAdv GetRootAsHomeAdv(ByteBuffer _bb) => new HomeAdv();

    [Token(Token = "0x6018438")]
    [Address(RVA = "0x26D8248", Offset = "0x26D8248", VA = "0x26D8248")]
    public static HomeAdv GetRootAsHomeAdv(ByteBuffer _bb, HomeAdv obj) => new HomeAdv();

    [Token(Token = "0x6018439")]
    [Address(RVA = "0x26D82A4", Offset = "0x26D82A4", VA = "0x26D82A4")]
    public static bool HomeAdvBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601843A")]
    [Address(RVA = "0x26D82F0", Offset = "0x26D82F0", VA = "0x26D82F0", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601843B")]
    [Address(RVA = "0x26D828C", Offset = "0x26D828C", VA = "0x26D828C")]
    public HomeAdv __assign(int _i, ByteBuffer _bb) => new HomeAdv();

    [Token(Token = "0x17004F5B")]
    public AdvDataList? AdvList
    {
      [Token(Token = "0x601843C"), Address(RVA = "0x26D82FC", Offset = "0x26D82FC", VA = "0x26D82FC")] get
      {
        return new AdvDataList?();
      }
    }

    [Token(Token = "0x601843D")]
    [Address(RVA = "0x26D83BC", Offset = "0x26D83BC", VA = "0x26D83BC")]
    public static Offset<HomeAdv> CreateHomeAdv(
      FlatBufferBuilder builder,
      Offset<AdvDataList> adv_listOffset = default (Offset<AdvDataList>))
    {
      return new Offset<HomeAdv>();
    }

    [Token(Token = "0x601843E")]
    [Address(RVA = "0x26D8474", Offset = "0x26D8474", VA = "0x26D8474")]
    public static void StartHomeAdv(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601843F")]
    [Address(RVA = "0x26D8404", Offset = "0x26D8404", VA = "0x26D8404")]
    public static void AddAdvList(FlatBufferBuilder builder, Offset<AdvDataList> advListOffset)
    {
    }

    [Token(Token = "0x6018440")]
    [Address(RVA = "0x26D8424", Offset = "0x26D8424", VA = "0x26D8424")]
    public static Offset<HomeAdv> EndHomeAdv(FlatBufferBuilder builder) => new Offset<HomeAdv>();

    [Token(Token = "0x6018441")]
    [Address(RVA = "0x26D848C", Offset = "0x26D848C", VA = "0x26D848C")]
    public static void FinishHomeAdvBuffer(FlatBufferBuilder builder, Offset<HomeAdv> offset)
    {
    }

    [Token(Token = "0x6018442")]
    [Address(RVA = "0x26D84E8", Offset = "0x26D84E8", VA = "0x26D84E8")]
    public static void FinishSizePrefixedHomeAdvBuffer(
      FlatBufferBuilder builder,
      Offset<HomeAdv> offset)
    {
    }
  }
}
