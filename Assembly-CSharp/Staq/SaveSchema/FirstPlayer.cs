// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.FirstPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CAA")]
  public struct FirstPlayer : IFlatbufferObject
  {
    [Token(Token = "0x4010C08")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F26")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018320"), Address(RVA = "0x26D4258", Offset = "0x26D4258", VA = "0x26D4258", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018321")]
    [Address(RVA = "0x26D4260", Offset = "0x26D4260", VA = "0x26D4260")]
    public static FirstPlayer GetRootAsFirstPlayer(ByteBuffer _bb) => new FirstPlayer();

    [Token(Token = "0x6018322")]
    [Address(RVA = "0x26D426C", Offset = "0x26D426C", VA = "0x26D426C")]
    public static FirstPlayer GetRootAsFirstPlayer(ByteBuffer _bb, FirstPlayer obj)
    {
      return new FirstPlayer();
    }

    [Token(Token = "0x6018323")]
    [Address(RVA = "0x26D42C8", Offset = "0x26D42C8", VA = "0x26D42C8")]
    public static bool FirstPlayerBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018324")]
    [Address(RVA = "0x26D4314", Offset = "0x26D4314", VA = "0x26D4314", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018325")]
    [Address(RVA = "0x26D42B0", Offset = "0x26D42B0", VA = "0x26D42B0")]
    public FirstPlayer __assign(int _i, ByteBuffer _bb) => new FirstPlayer();

    [Token(Token = "0x17004F27")]
    public string PlayerId
    {
      [Token(Token = "0x6018326"), Address(RVA = "0x26D4320", Offset = "0x26D4320", VA = "0x26D4320")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018327")]
    [Address(RVA = "0x26D435C", Offset = "0x26D435C", VA = "0x26D435C")]
    public ArraySegment<byte>? GetPlayerIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018328")]
    [Address(RVA = "0x26D4394", Offset = "0x26D4394", VA = "0x26D4394")]
    public byte[] GetPlayerIdArray() => (byte[]) null;

    [Token(Token = "0x6018329")]
    [Address(RVA = "0x26D43E0", Offset = "0x26D43E0", VA = "0x26D43E0")]
    public static Offset<FirstPlayer> CreateFirstPlayer(
      FlatBufferBuilder builder,
      StringOffset player_idOffset = default (StringOffset))
    {
      return new Offset<FirstPlayer>();
    }

    [Token(Token = "0x601832A")]
    [Address(RVA = "0x26D4498", Offset = "0x26D4498", VA = "0x26D4498")]
    public static void StartFirstPlayer(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601832B")]
    [Address(RVA = "0x26D4428", Offset = "0x26D4428", VA = "0x26D4428")]
    public static void AddPlayerId(FlatBufferBuilder builder, StringOffset playerIdOffset)
    {
    }

    [Token(Token = "0x601832C")]
    [Address(RVA = "0x26D4448", Offset = "0x26D4448", VA = "0x26D4448")]
    public static Offset<FirstPlayer> EndFirstPlayer(FlatBufferBuilder builder)
    {
      return new Offset<FirstPlayer>();
    }

    [Token(Token = "0x601832D")]
    [Address(RVA = "0x26D44B0", Offset = "0x26D44B0", VA = "0x26D44B0")]
    public static void FinishFirstPlayerBuffer(
      FlatBufferBuilder builder,
      Offset<FirstPlayer> offset)
    {
    }

    [Token(Token = "0x601832E")]
    [Address(RVA = "0x26D450C", Offset = "0x26D450C", VA = "0x26D450C")]
    public static void FinishSizePrefixedFirstPlayerBuffer(
      FlatBufferBuilder builder,
      Offset<FirstPlayer> offset)
    {
    }
  }
}
