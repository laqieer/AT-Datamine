// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.GuildRaidDataTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CB9")]
  public struct GuildRaidDataTable : IFlatbufferObject
  {
    [Token(Token = "0x4010C17")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F56")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018418"), Address(RVA = "0x26D7B18", Offset = "0x26D7B18", VA = "0x26D7B18", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018419")]
    [Address(RVA = "0x26D7B20", Offset = "0x26D7B20", VA = "0x26D7B20")]
    public static GuildRaidDataTable GetRootAsGuildRaidDataTable(ByteBuffer _bb)
    {
      return new GuildRaidDataTable();
    }

    [Token(Token = "0x601841A")]
    [Address(RVA = "0x26D7B2C", Offset = "0x26D7B2C", VA = "0x26D7B2C")]
    public static GuildRaidDataTable GetRootAsGuildRaidDataTable(
      ByteBuffer _bb,
      GuildRaidDataTable obj)
    {
      return new GuildRaidDataTable();
    }

    [Token(Token = "0x601841B")]
    [Address(RVA = "0x26D7B88", Offset = "0x26D7B88", VA = "0x26D7B88")]
    public static bool GuildRaidDataTableBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601841C")]
    [Address(RVA = "0x26D7BD4", Offset = "0x26D7BD4", VA = "0x26D7BD4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601841D")]
    [Address(RVA = "0x26D7B70", Offset = "0x26D7B70", VA = "0x26D7B70")]
    public GuildRaidDataTable __assign(int _i, ByteBuffer _bb) => new GuildRaidDataTable();

    [Token(Token = "0x601841E")]
    [Address(RVA = "0x26D7BE0", Offset = "0x26D7BE0", VA = "0x26D7BE0")]
    public GuildRaidData? DataList(int j) => new GuildRaidData?();

    [Token(Token = "0x17004F57")]
    public int DataListLength
    {
      [Token(Token = "0x601841F"), Address(RVA = "0x26D7C94", Offset = "0x26D7C94", VA = "0x26D7C94")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018420")]
    [Address(RVA = "0x26D7CC8", Offset = "0x26D7CC8", VA = "0x26D7CC8")]
    public static Offset<GuildRaidDataTable> CreateGuildRaidDataTable(
      FlatBufferBuilder builder,
      VectorOffset data_listOffset = default (VectorOffset))
    {
      return new Offset<GuildRaidDataTable>();
    }

    [Token(Token = "0x6018421")]
    [Address(RVA = "0x26D7D80", Offset = "0x26D7D80", VA = "0x26D7D80")]
    public static void StartGuildRaidDataTable(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018422")]
    [Address(RVA = "0x26D7D10", Offset = "0x26D7D10", VA = "0x26D7D10")]
    public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset)
    {
    }

    [Token(Token = "0x6018423")]
    [Address(RVA = "0x26D7D98", Offset = "0x26D7D98", VA = "0x26D7D98")]
    public static VectorOffset CreateDataListVector(
      FlatBufferBuilder builder,
      Offset<GuildRaidData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018424")]
    [Address(RVA = "0x26D7E40", Offset = "0x26D7E40", VA = "0x26D7E40")]
    public static VectorOffset CreateDataListVectorBlock(
      FlatBufferBuilder builder,
      Offset<GuildRaidData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018425")]
    [Address(RVA = "0x26D7EC8", Offset = "0x26D7EC8", VA = "0x26D7EC8")]
    public static void StartDataListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018426")]
    [Address(RVA = "0x26D7D30", Offset = "0x26D7D30", VA = "0x26D7D30")]
    public static Offset<GuildRaidDataTable> EndGuildRaidDataTable(FlatBufferBuilder builder)
    {
      return new Offset<GuildRaidDataTable>();
    }

    [Token(Token = "0x6018427")]
    [Address(RVA = "0x26D7EE8", Offset = "0x26D7EE8", VA = "0x26D7EE8")]
    public static void FinishGuildRaidDataTableBuffer(
      FlatBufferBuilder builder,
      Offset<GuildRaidDataTable> offset)
    {
    }

    [Token(Token = "0x6018428")]
    [Address(RVA = "0x26D7F44", Offset = "0x26D7F44", VA = "0x26D7F44")]
    public static void FinishSizePrefixedGuildRaidDataTableBuffer(
      FlatBufferBuilder builder,
      Offset<GuildRaidDataTable> offset)
    {
    }
  }
}
