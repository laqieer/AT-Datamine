// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.GuildRaidNewBadgeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CB7")]
  public struct GuildRaidNewBadgeData : IFlatbufferObject
  {
    [Token(Token = "0x4010C15")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F51")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60183FB"), Address(RVA = "0x26D748C", Offset = "0x26D748C", VA = "0x26D748C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60183FC")]
    [Address(RVA = "0x26D7494", Offset = "0x26D7494", VA = "0x26D7494")]
    public static GuildRaidNewBadgeData GetRootAsGuildRaidNewBadgeData(ByteBuffer _bb)
    {
      return new GuildRaidNewBadgeData();
    }

    [Token(Token = "0x60183FD")]
    [Address(RVA = "0x26D74A0", Offset = "0x26D74A0", VA = "0x26D74A0")]
    public static GuildRaidNewBadgeData GetRootAsGuildRaidNewBadgeData(
      ByteBuffer _bb,
      GuildRaidNewBadgeData obj)
    {
      return new GuildRaidNewBadgeData();
    }

    [Token(Token = "0x60183FE")]
    [Address(RVA = "0x26D74FC", Offset = "0x26D74FC", VA = "0x26D74FC")]
    public static bool GuildRaidNewBadgeDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60183FF")]
    [Address(RVA = "0x26D7548", Offset = "0x26D7548", VA = "0x26D7548", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018400")]
    [Address(RVA = "0x26D74E4", Offset = "0x26D74E4", VA = "0x26D74E4")]
    public GuildRaidNewBadgeData __assign(int _i, ByteBuffer _bb) => new GuildRaidNewBadgeData();

    [Token(Token = "0x6018401")]
    [Address(RVA = "0x26D7554", Offset = "0x26D7554", VA = "0x26D7554")]
    public RaidNewBadgeData? NewbadgeDataList(int j) => new RaidNewBadgeData?();

    [Token(Token = "0x17004F52")]
    public int NewbadgeDataListLength
    {
      [Token(Token = "0x6018402"), Address(RVA = "0x26D7608", Offset = "0x26D7608", VA = "0x26D7608")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018403")]
    [Address(RVA = "0x26D763C", Offset = "0x26D763C", VA = "0x26D763C")]
    public static Offset<GuildRaidNewBadgeData> CreateGuildRaidNewBadgeData(
      FlatBufferBuilder builder,
      VectorOffset newbadge_data_listOffset = default (VectorOffset))
    {
      return new Offset<GuildRaidNewBadgeData>();
    }

    [Token(Token = "0x6018404")]
    [Address(RVA = "0x26D76F4", Offset = "0x26D76F4", VA = "0x26D76F4")]
    public static void StartGuildRaidNewBadgeData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018405")]
    [Address(RVA = "0x26D7684", Offset = "0x26D7684", VA = "0x26D7684")]
    public static void AddNewbadgeDataList(
      FlatBufferBuilder builder,
      VectorOffset newbadgeDataListOffset)
    {
    }

    [Token(Token = "0x6018406")]
    [Address(RVA = "0x26D770C", Offset = "0x26D770C", VA = "0x26D770C")]
    public static VectorOffset CreateNewbadgeDataListVector(
      FlatBufferBuilder builder,
      Offset<RaidNewBadgeData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018407")]
    [Address(RVA = "0x26D77B4", Offset = "0x26D77B4", VA = "0x26D77B4")]
    public static VectorOffset CreateNewbadgeDataListVectorBlock(
      FlatBufferBuilder builder,
      Offset<RaidNewBadgeData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018408")]
    [Address(RVA = "0x26D783C", Offset = "0x26D783C", VA = "0x26D783C")]
    public static void StartNewbadgeDataListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018409")]
    [Address(RVA = "0x26D76A4", Offset = "0x26D76A4", VA = "0x26D76A4")]
    public static Offset<GuildRaidNewBadgeData> EndGuildRaidNewBadgeData(FlatBufferBuilder builder)
    {
      return new Offset<GuildRaidNewBadgeData>();
    }

    [Token(Token = "0x601840A")]
    [Address(RVA = "0x26D785C", Offset = "0x26D785C", VA = "0x26D785C")]
    public static void FinishGuildRaidNewBadgeDataBuffer(
      FlatBufferBuilder builder,
      Offset<GuildRaidNewBadgeData> offset)
    {
    }

    [Token(Token = "0x601840B")]
    [Address(RVA = "0x26D78B8", Offset = "0x26D78B8", VA = "0x26D78B8")]
    public static void FinishSizePrefixedGuildRaidNewBadgeDataBuffer(
      FlatBufferBuilder builder,
      Offset<GuildRaidNewBadgeData> offset)
    {
    }
  }
}
