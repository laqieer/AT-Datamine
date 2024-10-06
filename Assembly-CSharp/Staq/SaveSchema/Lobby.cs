// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Lobby
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CC1")]
  public struct Lobby : IFlatbufferObject
  {
    [Token(Token = "0x4010C1F")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F6A")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018498"), Address(RVA = "0x26D98B4", Offset = "0x26D98B4", VA = "0x26D98B4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018499")]
    [Address(RVA = "0x26D98BC", Offset = "0x26D98BC", VA = "0x26D98BC")]
    public static Lobby GetRootAsLobby(ByteBuffer _bb) => new Lobby();

    [Token(Token = "0x601849A")]
    [Address(RVA = "0x26D98C8", Offset = "0x26D98C8", VA = "0x26D98C8")]
    public static Lobby GetRootAsLobby(ByteBuffer _bb, Lobby obj) => new Lobby();

    [Token(Token = "0x601849B")]
    [Address(RVA = "0x26D9924", Offset = "0x26D9924", VA = "0x26D9924")]
    public static bool LobbyBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601849C")]
    [Address(RVA = "0x26D9970", Offset = "0x26D9970", VA = "0x26D9970", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601849D")]
    [Address(RVA = "0x26D990C", Offset = "0x26D990C", VA = "0x26D990C")]
    public Lobby __assign(int _i, ByteBuffer _bb) => new Lobby();

    [Token(Token = "0x601849E")]
    [Address(RVA = "0x26D997C", Offset = "0x26D997C", VA = "0x26D997C")]
    public PlayEvent? Playleaderevent(int j) => new PlayEvent?();

    [Token(Token = "0x17004F6B")]
    public int PlayleadereventLength
    {
      [Token(Token = "0x601849F"), Address(RVA = "0x26D9A30", Offset = "0x26D9A30", VA = "0x26D9A30")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60184A0")]
    [Address(RVA = "0x26D9A64", Offset = "0x26D9A64", VA = "0x26D9A64")]
    public static Offset<Lobby> CreateLobby(
      FlatBufferBuilder builder,
      VectorOffset playleadereventOffset = default (VectorOffset))
    {
      return new Offset<Lobby>();
    }

    [Token(Token = "0x60184A1")]
    [Address(RVA = "0x26D9B1C", Offset = "0x26D9B1C", VA = "0x26D9B1C")]
    public static void StartLobby(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60184A2")]
    [Address(RVA = "0x26D9AAC", Offset = "0x26D9AAC", VA = "0x26D9AAC")]
    public static void AddPlayleaderevent(
      FlatBufferBuilder builder,
      VectorOffset playleadereventOffset)
    {
    }

    [Token(Token = "0x60184A3")]
    [Address(RVA = "0x26D9B34", Offset = "0x26D9B34", VA = "0x26D9B34")]
    public static VectorOffset CreatePlayleadereventVector(
      FlatBufferBuilder builder,
      Offset<PlayEvent>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60184A4")]
    [Address(RVA = "0x26D9BDC", Offset = "0x26D9BDC", VA = "0x26D9BDC")]
    public static VectorOffset CreatePlayleadereventVectorBlock(
      FlatBufferBuilder builder,
      Offset<PlayEvent>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60184A5")]
    [Address(RVA = "0x26D9C64", Offset = "0x26D9C64", VA = "0x26D9C64")]
    public static void StartPlayleadereventVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60184A6")]
    [Address(RVA = "0x26D9ACC", Offset = "0x26D9ACC", VA = "0x26D9ACC")]
    public static Offset<Lobby> EndLobby(FlatBufferBuilder builder) => new Offset<Lobby>();

    [Token(Token = "0x60184A7")]
    [Address(RVA = "0x26D9C84", Offset = "0x26D9C84", VA = "0x26D9C84")]
    public static void FinishLobbyBuffer(FlatBufferBuilder builder, Offset<Lobby> offset)
    {
    }

    [Token(Token = "0x60184A8")]
    [Address(RVA = "0x26D9CE0", Offset = "0x26D9CE0", VA = "0x26D9CE0")]
    public static void FinishSizePrefixedLobbyBuffer(
      FlatBufferBuilder builder,
      Offset<Lobby> offset)
    {
    }
  }
}
