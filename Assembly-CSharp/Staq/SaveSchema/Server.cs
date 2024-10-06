// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Server
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CD6")]
  public struct Server : IFlatbufferObject
  {
    [Token(Token = "0x4010C37")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FB5")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601863A"), Address(RVA = "0x26DFE2C", Offset = "0x26DFE2C", VA = "0x26DFE2C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601863B")]
    [Address(RVA = "0x26DFE34", Offset = "0x26DFE34", VA = "0x26DFE34")]
    public static Server GetRootAsServer(ByteBuffer _bb) => new Server();

    [Token(Token = "0x601863C")]
    [Address(RVA = "0x26DFE40", Offset = "0x26DFE40", VA = "0x26DFE40")]
    public static Server GetRootAsServer(ByteBuffer _bb, Server obj) => new Server();

    [Token(Token = "0x601863D")]
    [Address(RVA = "0x26DFE9C", Offset = "0x26DFE9C", VA = "0x26DFE9C")]
    public static bool ServerBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601863E")]
    [Address(RVA = "0x26DFEE8", Offset = "0x26DFEE8", VA = "0x26DFEE8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601863F")]
    [Address(RVA = "0x26DFE84", Offset = "0x26DFE84", VA = "0x26DFE84")]
    public Server __assign(int _i, ByteBuffer _bb) => new Server();

    [Token(Token = "0x17004FB6")]
    public string Name
    {
      [Token(Token = "0x6018640"), Address(RVA = "0x26DFEF4", Offset = "0x26DFEF4", VA = "0x26DFEF4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018641")]
    [Address(RVA = "0x26DFF30", Offset = "0x26DFF30", VA = "0x26DFF30")]
    public ArraySegment<byte>? GetNameBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018642")]
    [Address(RVA = "0x26DFF68", Offset = "0x26DFF68", VA = "0x26DFF68")]
    public byte[] GetNameArray() => (byte[]) null;

    [Token(Token = "0x17004FB7")]
    public string Host
    {
      [Token(Token = "0x6018643"), Address(RVA = "0x26DFFB4", Offset = "0x26DFFB4", VA = "0x26DFFB4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018644")]
    [Address(RVA = "0x26DFFF0", Offset = "0x26DFFF0", VA = "0x26DFFF0")]
    public ArraySegment<byte>? GetHostBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018645")]
    [Address(RVA = "0x26E0028", Offset = "0x26E0028", VA = "0x26E0028")]
    public byte[] GetHostArray() => (byte[]) null;

    [Token(Token = "0x17004FB8")]
    public ServerDeclType Type
    {
      [Token(Token = "0x6018646"), Address(RVA = "0x26E0074", Offset = "0x26E0074", VA = "0x26E0074")] get
      {
        return new ServerDeclType();
      }
    }

    [Token(Token = "0x6018647")]
    [Address(RVA = "0x26E00BC", Offset = "0x26E00BC", VA = "0x26E00BC")]
    public static Offset<Server> CreateServer(
      FlatBufferBuilder builder,
      StringOffset nameOffset = default (StringOffset),
      StringOffset hostOffset = default (StringOffset),
      ServerDeclType type = ServerDeclType.Internal)
    {
      return new Offset<Server>();
    }

    [Token(Token = "0x6018648")]
    [Address(RVA = "0x26E01DC", Offset = "0x26E01DC", VA = "0x26E01DC")]
    public static void StartServer(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018649")]
    [Address(RVA = "0x26E014C", Offset = "0x26E014C", VA = "0x26E014C")]
    public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
    {
    }

    [Token(Token = "0x601864A")]
    [Address(RVA = "0x26E012C", Offset = "0x26E012C", VA = "0x26E012C")]
    public static void AddHost(FlatBufferBuilder builder, StringOffset hostOffset)
    {
    }

    [Token(Token = "0x601864B")]
    [Address(RVA = "0x26E016C", Offset = "0x26E016C", VA = "0x26E016C")]
    public static void AddType(FlatBufferBuilder builder, ServerDeclType type)
    {
    }

    [Token(Token = "0x601864C")]
    [Address(RVA = "0x26E018C", Offset = "0x26E018C", VA = "0x26E018C")]
    public static Offset<Server> EndServer(FlatBufferBuilder builder) => new Offset<Server>();

    [Token(Token = "0x601864D")]
    [Address(RVA = "0x26E01F4", Offset = "0x26E01F4", VA = "0x26E01F4")]
    public static void FinishServerBuffer(FlatBufferBuilder builder, Offset<Server> offset)
    {
    }

    [Token(Token = "0x601864E")]
    [Address(RVA = "0x26E0250", Offset = "0x26E0250", VA = "0x26E0250")]
    public static void FinishSizePrefixedServerBuffer(
      FlatBufferBuilder builder,
      Offset<Server> offset)
    {
    }
  }
}
