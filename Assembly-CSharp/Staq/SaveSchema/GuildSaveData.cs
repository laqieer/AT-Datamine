// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.GuildSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CB3")]
  public struct GuildSaveData : IFlatbufferObject
  {
    [Token(Token = "0x4010C11")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F45")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60183BD"), Address(RVA = "0x26D6778", Offset = "0x26D6778", VA = "0x26D6778", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60183BE")]
    [Address(RVA = "0x26D6780", Offset = "0x26D6780", VA = "0x26D6780")]
    public static GuildSaveData GetRootAsGuildSaveData(ByteBuffer _bb) => new GuildSaveData();

    [Token(Token = "0x60183BF")]
    [Address(RVA = "0x26D678C", Offset = "0x26D678C", VA = "0x26D678C")]
    public static GuildSaveData GetRootAsGuildSaveData(ByteBuffer _bb, GuildSaveData obj)
    {
      return new GuildSaveData();
    }

    [Token(Token = "0x60183C0")]
    [Address(RVA = "0x26D67E8", Offset = "0x26D67E8", VA = "0x26D67E8")]
    public static bool GuildSaveDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60183C1")]
    [Address(RVA = "0x26D6834", Offset = "0x26D6834", VA = "0x26D6834", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60183C2")]
    [Address(RVA = "0x26D67D0", Offset = "0x26D67D0", VA = "0x26D67D0")]
    public GuildSaveData __assign(int _i, ByteBuffer _bb) => new GuildSaveData();

    [Token(Token = "0x17004F46")]
    public string LastChatMessageId
    {
      [Token(Token = "0x60183C3"), Address(RVA = "0x26D6840", Offset = "0x26D6840", VA = "0x26D6840")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60183C4")]
    [Address(RVA = "0x26D687C", Offset = "0x26D687C", VA = "0x26D687C")]
    public ArraySegment<byte>? GetLastChatMessageIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60183C5")]
    [Address(RVA = "0x26D68B4", Offset = "0x26D68B4", VA = "0x26D68B4")]
    public byte[] GetLastChatMessageIdArray() => (byte[]) null;

    [Token(Token = "0x17004F47")]
    public string LastBulletinBoardId
    {
      [Token(Token = "0x60183C6"), Address(RVA = "0x26D6900", Offset = "0x26D6900", VA = "0x26D6900")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60183C7")]
    [Address(RVA = "0x26D693C", Offset = "0x26D693C", VA = "0x26D693C")]
    public ArraySegment<byte>? GetLastBulletinBoardIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60183C8")]
    [Address(RVA = "0x26D6974", Offset = "0x26D6974", VA = "0x26D6974")]
    public byte[] GetLastBulletinBoardIdArray() => (byte[]) null;

    [Token(Token = "0x60183C9")]
    [Address(RVA = "0x26D69C0", Offset = "0x26D69C0", VA = "0x26D69C0")]
    public static Offset<GuildSaveData> CreateGuildSaveData(
      FlatBufferBuilder builder,
      StringOffset lastChatMessageIdOffset = default (StringOffset),
      StringOffset lastBulletinBoardIdOffset = default (StringOffset))
    {
      return new Offset<GuildSaveData>();
    }

    [Token(Token = "0x60183CA")]
    [Address(RVA = "0x26D6AA8", Offset = "0x26D6AA8", VA = "0x26D6AA8")]
    public static void StartGuildSaveData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60183CB")]
    [Address(RVA = "0x26D6A38", Offset = "0x26D6A38", VA = "0x26D6A38")]
    public static void AddLastChatMessageId(
      FlatBufferBuilder builder,
      StringOffset lastChatMessageIdOffset)
    {
    }

    [Token(Token = "0x60183CC")]
    [Address(RVA = "0x26D6A18", Offset = "0x26D6A18", VA = "0x26D6A18")]
    public static void AddLastBulletinBoardId(
      FlatBufferBuilder builder,
      StringOffset lastBulletinBoardIdOffset)
    {
    }

    [Token(Token = "0x60183CD")]
    [Address(RVA = "0x26D6A58", Offset = "0x26D6A58", VA = "0x26D6A58")]
    public static Offset<GuildSaveData> EndGuildSaveData(FlatBufferBuilder builder)
    {
      return new Offset<GuildSaveData>();
    }

    [Token(Token = "0x60183CE")]
    [Address(RVA = "0x26D6AC0", Offset = "0x26D6AC0", VA = "0x26D6AC0")]
    public static void FinishGuildSaveDataBuffer(
      FlatBufferBuilder builder,
      Offset<GuildSaveData> offset)
    {
    }

    [Token(Token = "0x60183CF")]
    [Address(RVA = "0x26D6B1C", Offset = "0x26D6B1C", VA = "0x26D6B1C")]
    public static void FinishSizePrefixedGuildSaveDataBuffer(
      FlatBufferBuilder builder,
      Offset<GuildSaveData> offset)
    {
    }
  }
}
