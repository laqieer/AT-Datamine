// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.GuildRaidData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CB8")]
  public struct GuildRaidData : IFlatbufferObject
  {
    [Token(Token = "0x4010C16")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F53")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601840C"), Address(RVA = "0x26D7914", Offset = "0x26D7914", VA = "0x26D7914", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601840D")]
    [Address(RVA = "0x26D791C", Offset = "0x26D791C", VA = "0x26D791C")]
    public static GuildRaidData GetRootAsGuildRaidData(ByteBuffer _bb) => new GuildRaidData();

    [Token(Token = "0x601840E")]
    [Address(RVA = "0x26D7928", Offset = "0x26D7928", VA = "0x26D7928")]
    public static GuildRaidData GetRootAsGuildRaidData(ByteBuffer _bb, GuildRaidData obj)
    {
      return new GuildRaidData();
    }

    [Token(Token = "0x601840F")]
    [Address(RVA = "0x26D7984", Offset = "0x26D7984", VA = "0x26D7984", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018410")]
    [Address(RVA = "0x26D796C", Offset = "0x26D796C", VA = "0x26D796C")]
    public GuildRaidData __assign(int _i, ByteBuffer _bb) => new GuildRaidData();

    [Token(Token = "0x17004F54")]
    public int RaidId
    {
      [Token(Token = "0x6018411"), Address(RVA = "0x26D7990", Offset = "0x26D7990", VA = "0x26D7990")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F55")]
    public int ClearLapNum
    {
      [Token(Token = "0x6018412"), Address(RVA = "0x26D79D4", Offset = "0x26D79D4", VA = "0x26D79D4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018413")]
    [Address(RVA = "0x26D7A18", Offset = "0x26D7A18", VA = "0x26D7A18")]
    public static Offset<GuildRaidData> CreateGuildRaidData(
      FlatBufferBuilder builder,
      int raid_id = 0,
      int clear_lap_num = 0)
    {
      return new Offset<GuildRaidData>();
    }

    [Token(Token = "0x6018414")]
    [Address(RVA = "0x26D7B00", Offset = "0x26D7B00", VA = "0x26D7B00")]
    public static void StartGuildRaidData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018415")]
    [Address(RVA = "0x26D7A90", Offset = "0x26D7A90", VA = "0x26D7A90")]
    public static void AddRaidId(FlatBufferBuilder builder, int raidId)
    {
    }

    [Token(Token = "0x6018416")]
    [Address(RVA = "0x26D7A70", Offset = "0x26D7A70", VA = "0x26D7A70")]
    public static void AddClearLapNum(FlatBufferBuilder builder, int clearLapNum)
    {
    }

    [Token(Token = "0x6018417")]
    [Address(RVA = "0x26D7AB0", Offset = "0x26D7AB0", VA = "0x26D7AB0")]
    public static Offset<GuildRaidData> EndGuildRaidData(FlatBufferBuilder builder)
    {
      return new Offset<GuildRaidData>();
    }
  }
}
