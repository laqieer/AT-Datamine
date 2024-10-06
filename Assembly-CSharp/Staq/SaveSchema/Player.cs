// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Player
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CCC")]
  public struct Player : IFlatbufferObject
  {
    [Token(Token = "0x4010C2A")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F9B")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60185A2"), Address(RVA = "0x26DDBCC", Offset = "0x26DDBCC", VA = "0x26DDBCC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60185A3")]
    [Address(RVA = "0x26DDBD4", Offset = "0x26DDBD4", VA = "0x26DDBD4")]
    public static Player GetRootAsPlayer(ByteBuffer _bb) => new Player();

    [Token(Token = "0x60185A4")]
    [Address(RVA = "0x26DDBE0", Offset = "0x26DDBE0", VA = "0x26DDBE0")]
    public static Player GetRootAsPlayer(ByteBuffer _bb, Player obj) => new Player();

    [Token(Token = "0x60185A5")]
    [Address(RVA = "0x26DDC3C", Offset = "0x26DDC3C", VA = "0x26DDC3C")]
    public static bool PlayerBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60185A6")]
    [Address(RVA = "0x26DDC88", Offset = "0x26DDC88", VA = "0x26DDC88", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60185A7")]
    [Address(RVA = "0x26DDC24", Offset = "0x26DDC24", VA = "0x26DDC24")]
    public Player __assign(int _i, ByteBuffer _bb) => new Player();

    [Token(Token = "0x17004F9C")]
    public string PlayerId
    {
      [Token(Token = "0x60185A8"), Address(RVA = "0x26DDC94", Offset = "0x26DDC94", VA = "0x26DDC94")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60185A9")]
    [Address(RVA = "0x26DDCD0", Offset = "0x26DDCD0", VA = "0x26DDCD0")]
    public ArraySegment<byte>? GetPlayerIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60185AA")]
    [Address(RVA = "0x26DDD08", Offset = "0x26DDD08", VA = "0x26DDD08")]
    public byte[] GetPlayerIdArray() => (byte[]) null;

    [Token(Token = "0x17004F9D")]
    public string DeviceId
    {
      [Token(Token = "0x60185AB"), Address(RVA = "0x26DDD54", Offset = "0x26DDD54", VA = "0x26DDD54")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60185AC")]
    [Address(RVA = "0x26DDD90", Offset = "0x26DDD90", VA = "0x26DDD90")]
    public ArraySegment<byte>? GetDeviceIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60185AD")]
    [Address(RVA = "0x26DDDC8", Offset = "0x26DDDC8", VA = "0x26DDDC8")]
    public byte[] GetDeviceIdArray() => (byte[]) null;

    [Token(Token = "0x17004F9E")]
    public string SecretKey
    {
      [Token(Token = "0x60185AE"), Address(RVA = "0x26DDE14", Offset = "0x26DDE14", VA = "0x26DDE14")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60185AF")]
    [Address(RVA = "0x26DDE50", Offset = "0x26DDE50", VA = "0x26DDE50")]
    public ArraySegment<byte>? GetSecretKeyBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60185B0")]
    [Address(RVA = "0x26DDE88", Offset = "0x26DDE88", VA = "0x26DDE88")]
    public byte[] GetSecretKeyArray() => (byte[]) null;

    [Token(Token = "0x17004F9F")]
    public string ServerName
    {
      [Token(Token = "0x60185B1"), Address(RVA = "0x26DDED4", Offset = "0x26DDED4", VA = "0x26DDED4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60185B2")]
    [Address(RVA = "0x26DDF10", Offset = "0x26DDF10", VA = "0x26DDF10")]
    public ArraySegment<byte>? GetServerNameBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60185B3")]
    [Address(RVA = "0x26DDF48", Offset = "0x26DDF48", VA = "0x26DDF48")]
    public byte[] GetServerNameArray() => (byte[]) null;

    [Token(Token = "0x17004FA0")]
    public uint ShortId
    {
      [Token(Token = "0x60185B4"), Address(RVA = "0x26DDF94", Offset = "0x26DDF94", VA = "0x26DDF94")] get
      {
        return new uint();
      }
    }

    [Token(Token = "0x17004FA1")]
    public bool IsDecidedPlayerdataAccunt
    {
      [Token(Token = "0x60185B5"), Address(RVA = "0x26DDFD8", Offset = "0x26DDFD8", VA = "0x26DDFD8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60185B6")]
    [Address(RVA = "0x26DE020", Offset = "0x26DE020", VA = "0x26DE020")]
    public static Offset<Player> CreatePlayer(
      FlatBufferBuilder builder,
      StringOffset player_idOffset = default (StringOffset),
      StringOffset device_idOffset = default (StringOffset),
      StringOffset secret_keyOffset = default (StringOffset),
      StringOffset server_nameOffset = default (StringOffset),
      uint short_id = 0,
      bool is_decided_playerdata_accunt = false)
    {
      return new Offset<Player>();
    }

    [Token(Token = "0x60185B7")]
    [Address(RVA = "0x26DE1D8", Offset = "0x26DE1D8", VA = "0x26DE1D8")]
    public static void StartPlayer(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60185B8")]
    [Address(RVA = "0x26DE148", Offset = "0x26DE148", VA = "0x26DE148")]
    public static void AddPlayerId(FlatBufferBuilder builder, StringOffset playerIdOffset)
    {
    }

    [Token(Token = "0x60185B9")]
    [Address(RVA = "0x26DE128", Offset = "0x26DE128", VA = "0x26DE128")]
    public static void AddDeviceId(FlatBufferBuilder builder, StringOffset deviceIdOffset)
    {
    }

    [Token(Token = "0x60185BA")]
    [Address(RVA = "0x26DE108", Offset = "0x26DE108", VA = "0x26DE108")]
    public static void AddSecretKey(FlatBufferBuilder builder, StringOffset secretKeyOffset)
    {
    }

    [Token(Token = "0x60185BB")]
    [Address(RVA = "0x26DE0E8", Offset = "0x26DE0E8", VA = "0x26DE0E8")]
    public static void AddServerName(FlatBufferBuilder builder, StringOffset serverNameOffset)
    {
    }

    [Token(Token = "0x60185BC")]
    [Address(RVA = "0x26DE0C8", Offset = "0x26DE0C8", VA = "0x26DE0C8")]
    public static void AddShortId(FlatBufferBuilder builder, uint shortId)
    {
    }

    [Token(Token = "0x60185BD")]
    [Address(RVA = "0x26DE168", Offset = "0x26DE168", VA = "0x26DE168")]
    public static void AddIsDecidedPlayerdataAccunt(
      FlatBufferBuilder builder,
      bool isDecidedPlayerdataAccunt)
    {
    }

    [Token(Token = "0x60185BE")]
    [Address(RVA = "0x26DE188", Offset = "0x26DE188", VA = "0x26DE188")]
    public static Offset<Player> EndPlayer(FlatBufferBuilder builder) => new Offset<Player>();

    [Token(Token = "0x60185BF")]
    [Address(RVA = "0x26DE1F0", Offset = "0x26DE1F0", VA = "0x26DE1F0")]
    public static void FinishPlayerBuffer(FlatBufferBuilder builder, Offset<Player> offset)
    {
    }

    [Token(Token = "0x60185C0")]
    [Address(RVA = "0x26DE24C", Offset = "0x26DE24C", VA = "0x26DE24C")]
    public static void FinishSizePrefixedPlayerBuffer(
      FlatBufferBuilder builder,
      Offset<Player> offset)
    {
    }
  }
}
