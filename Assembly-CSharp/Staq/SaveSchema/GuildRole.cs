// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.GuildRole
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CBA")]
  public struct GuildRole : IFlatbufferObject
  {
    [Token(Token = "0x4010C18")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F58")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018429"), Address(RVA = "0x26D7FA0", Offset = "0x26D7FA0", VA = "0x26D7FA0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601842A")]
    [Address(RVA = "0x26D7FA8", Offset = "0x26D7FA8", VA = "0x26D7FA8")]
    public static GuildRole GetRootAsGuildRole(ByteBuffer _bb) => new GuildRole();

    [Token(Token = "0x601842B")]
    [Address(RVA = "0x26D7FB4", Offset = "0x26D7FB4", VA = "0x26D7FB4")]
    public static GuildRole GetRootAsGuildRole(ByteBuffer _bb, GuildRole obj) => new GuildRole();

    [Token(Token = "0x601842C")]
    [Address(RVA = "0x26D8010", Offset = "0x26D8010", VA = "0x26D8010")]
    public static bool GuildRoleBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601842D")]
    [Address(RVA = "0x26D805C", Offset = "0x26D805C", VA = "0x26D805C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601842E")]
    [Address(RVA = "0x26D7FF8", Offset = "0x26D7FF8", VA = "0x26D7FF8")]
    public GuildRole __assign(int _i, ByteBuffer _bb) => new GuildRole();

    [Token(Token = "0x17004F59")]
    public int Id
    {
      [Token(Token = "0x601842F"), Address(RVA = "0x26D8068", Offset = "0x26D8068", VA = "0x26D8068")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018430")]
    [Address(RVA = "0x26D80AC", Offset = "0x26D80AC", VA = "0x26D80AC")]
    public static Offset<GuildRole> CreateGuildRole(FlatBufferBuilder builder, int Id = 0)
    {
      return new Offset<GuildRole>();
    }

    [Token(Token = "0x6018431")]
    [Address(RVA = "0x26D8164", Offset = "0x26D8164", VA = "0x26D8164")]
    public static void StartGuildRole(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018432")]
    [Address(RVA = "0x26D80F4", Offset = "0x26D80F4", VA = "0x26D80F4")]
    public static void AddId(FlatBufferBuilder builder, int Id)
    {
    }

    [Token(Token = "0x6018433")]
    [Address(RVA = "0x26D8114", Offset = "0x26D8114", VA = "0x26D8114")]
    public static Offset<GuildRole> EndGuildRole(FlatBufferBuilder builder)
    {
      return new Offset<GuildRole>();
    }

    [Token(Token = "0x6018434")]
    [Address(RVA = "0x26D817C", Offset = "0x26D817C", VA = "0x26D817C")]
    public static void FinishGuildRoleBuffer(FlatBufferBuilder builder, Offset<GuildRole> offset)
    {
    }

    [Token(Token = "0x6018435")]
    [Address(RVA = "0x26D81D8", Offset = "0x26D81D8", VA = "0x26D81D8")]
    public static void FinishSizePrefixedGuildRoleBuffer(
      FlatBufferBuilder builder,
      Offset<GuildRole> offset)
    {
    }
  }
}
